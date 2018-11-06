using NAudio.Lame;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwistedTTS.Desktop
{
    public partial class TextToMp3 : Form
    {
        private int _speechRate = 0;
        private int _speechVolume = 50;
        // Initialize a new instance of the SpeechSynthesizer.  
        SpeechSynthesizer synth = new SpeechSynthesizer();
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        // Configure the audio output.   
        private string LastSavedFile = "";
        public TextToMp3()
        {
            timer.Interval = 10;
            timer.Tick += (o, e) =>
            {
                if (audioFile != null)
                {
                    trackbarPosition.Value = (int)audioFile.Position;
                }
            };
            InitializeComponent();
            AddInstalledVoicesToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            synth.SetOutputToDefaultAudioDevice();
            // Subscribe to the StateChanged event.  
            synth.StateChanged += new EventHandler<StateChangedEventArgs>(synth_StateChanged);
            // Subscribe to the SpeakProgress event.  
            synth.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(synth_SpeakProgress);
            // Subscribe to the SpeakCompleted event.  
            synth.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);


            trackBar1.Scroll += (s, a) => outputDevice.Volume = trackBar1.Value / 100f;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            synth = new SpeechSynthesizer { Volume = _speechVolume, Rate = _speechRate };
            synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
            synth.SpeakAsync(rtfText.Text);
            trackbarPosition.Minimum = 0;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (synth.State == SynthesizerState.Speaking) synth.Pause();
            else synth.Resume();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Cancel the SpeakAsync operation and wait one second.  
            synth.SpeakAsyncCancelAll();
            Thread.Sleep(1000);
            Console.WriteLine("Redirecting output");
            synth.SetOutputToWaveFile(@"d:\test.wav");
            Console.WriteLine("Speaking text...");
            synth.Speak("This is a test.");
            Console.WriteLine("Done speaking text");
            synth.SetOutputToNull();
            Console.WriteLine("Done setting output to null");
        }

        // Write to the console when the SpeakAsync operation has been cancelled.  
        static void synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            Console.WriteLine("The SpeakAsync operation was cancelled!!");  
        }

        // When it changes, write the state of the SpeechSynthesizer to the console.  
        static void synth_StateChanged(object sender, StateChangedEventArgs e)
        {
            Console.WriteLine("Synthesizer State: {0} Previous State: {1}", e.State, e.PreviousState);  
        }

        // Write the text being spoken by the SpeechSynthesizer to the console.  
        static void synth_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            Console.WriteLine(e.Text);
            Console.WriteLine(e.AudioPosition);
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            _speechRate = trackBar2.Value;
            synth.Rate = _speechRate;
        }
        private void AddInstalledVoicesToList()
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                foreach (var voice in synth.GetInstalledVoices())
                {
                    ddlVoices.Items.Add(voice.VoiceInfo.Name);
                }
            }

            ddlVoices.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            synth.SelectVoice(ddlVoices.SelectedItem.ToString());
            if(audioFile != null) audioFile.Close();
            synth.SpeakAsyncCancelAll();
            Thread.Sleep(1000);
            Console.WriteLine("Redirecting output");
            synth.SetOutputToWaveFile("temp.wav");
            Console.WriteLine("Speaking text...");
            synth.Speak(rtfText.Text);
            Console.WriteLine("Done speaking text");
            synth.SetOutputToNull();
            Console.WriteLine("Done setting output to null");
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Filter = "Text files (*.mp3)|*.mp3|All files (*.*)|*.*";
            ofd.ShowDialog();
            using (var reader = new AudioFileReader("temp.wav"))
            using (var writer = new LameMP3FileWriter(ofd.FileName, reader.WaveFormat, LAMEPreset.ABR_128))
                reader.CopyTo(writer);
            LastSavedFile = ofd.FileName;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Playing)
            {
                outputDevice.Pause();
                timer.Stop();
            }
            else if (outputDevice != null && outputDevice.PlaybackState == PlaybackState.Paused)
            {
                outputDevice.Play();
                timer.Start();
            }
            else
            {
                outputDevice = new WaveOutEvent();
                audioFile = new AudioFileReader(LastSavedFile);
                trackbarPosition.Maximum = (int)audioFile.Length;
                trackbarPosition.TickFrequency = (int)(audioFile.Length / 100);
                outputDevice.PlaybackStopped += OnPlaybackStopped;

                outputDevice.Init(audioFile);
                timer.Start();
                outputDevice.Play();
            }

        }
        private void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            timer.Stop();
            //outputDevice.Dispose();
            //outputDevice = null;
            //audioFile.Dispose();
            //audioFile = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (outputDevice != null)
            {
                outputDevice.Dispose();
                outputDevice = null;
            }
            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }

        private void trackbarPosition_Scroll(object sender, EventArgs e)
        {
            audioFile.Position = trackbarPosition.Value;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (outputDevice != null && audioFile != null)
            {
                timer.Stop();
                outputDevice.Stop();
                audioFile.Position = 0;
            }
        }
    }
}
