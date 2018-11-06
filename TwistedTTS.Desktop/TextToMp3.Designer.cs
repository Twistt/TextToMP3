namespace TwistedTTS.Desktop
{
    partial class TextToMp3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextToMp3));
            this.rtfText = new System.Windows.Forms.RichTextBox();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackbarPosition = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlVoices = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtfText
            // 
            this.rtfText.Location = new System.Drawing.Point(12, 12);
            this.rtfText.Name = "rtfText";
            this.rtfText.Size = new System.Drawing.Size(572, 249);
            this.rtfText.TabIndex = 0;
            this.rtfText.Text = resources.GetString("rtfText.Text");
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(139, 288);
            this.trackBar2.Minimum = -10;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(196, 45);
            this.trackBar2.TabIndex = 5;
            this.trackBar2.Scroll += new System.EventHandler(this.trackBar2_ValueChanged);
            this.trackBar2.ValueChanged += new System.EventHandler(this.trackBar2_ValueChanged);
            // 
            // trackbarPosition
            // 
            this.trackbarPosition.Location = new System.Drawing.Point(12, 413);
            this.trackbarPosition.Maximum = 100;
            this.trackbarPosition.Name = "trackbarPosition";
            this.trackbarPosition.Size = new System.Drawing.Size(374, 45);
            this.trackbarPosition.TabIndex = 5;
            this.trackbarPosition.TickFrequency = 5;
            this.trackbarPosition.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackbarPosition.Scroll += new System.EventHandler(this.trackbarPosition_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Speed of Speech";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 398);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Volume";
            // 
            // ddlVoices
            // 
            this.ddlVoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlVoices.FormattingEnabled = true;
            this.ddlVoices.Location = new System.Drawing.Point(12, 292);
            this.ddlVoices.Name = "ddlVoices";
            this.ddlVoices.Size = new System.Drawing.Size(121, 21);
            this.ddlVoices.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(341, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(242, 26);
            this.button4.TabIndex = 8;
            this.button4.Text = "Save TTS to MP3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(392, 414);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(192, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.TickFrequency = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(139, 384);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Play/Pause";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Voice";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Stop";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TextToMp3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 463);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ddlVoices);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackbarPosition);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.rtfText);
            this.Name = "TextToMp3";
            this.Text = "TTS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfText;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackbarPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlVoices;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

