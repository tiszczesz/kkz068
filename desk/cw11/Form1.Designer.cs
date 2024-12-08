namespace cw11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            panel1 = new Panel();
            trackBar4 = new TrackBar();
            lbRed = new Label();
            lbGreen = new Label();
            lbBlue = new Label();
            lbOpacity = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(28, 12);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(266, 45);
            trackBar1.TabIndex = 0;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(28, 77);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(266, 45);
            trackBar2.TabIndex = 1;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(28, 142);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(266, 45);
            trackBar3.TabIndex = 2;
            trackBar3.ValueChanged += trackBar3_ValueChanged;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Location = new Point(404, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(383, 304);
            panel1.TabIndex = 3;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(28, 207);
            trackBar4.Maximum = 255;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(266, 45);
            trackBar4.TabIndex = 4;
            trackBar4.Value = 255;
            trackBar4.ValueChanged += trackBar4_ValueChanged;
            // 
            // lbRed
            // 
            lbRed.AutoSize = true;
            lbRed.Location = new Point(309, 12);
            lbRed.Name = "lbRed";
            lbRed.Size = new Size(33, 15);
            lbRed.TabIndex = 5;
            lbRed.Text = "Red: ";
            // 
            // lbGreen
            // 
            lbGreen.AutoSize = true;
            lbGreen.Location = new Point(309, 77);
            lbGreen.Name = "lbGreen";
            lbGreen.Size = new Size(41, 15);
            lbGreen.TabIndex = 6;
            lbGreen.Text = "Green:";
            // 
            // lbBlue
            // 
            lbBlue.AutoSize = true;
            lbBlue.Location = new Point(317, 142);
            lbBlue.Name = "lbBlue";
            lbBlue.Size = new Size(33, 15);
            lbBlue.TabIndex = 7;
            lbBlue.Text = "Blue:";
            // 
            // lbOpacity
            // 
            lbOpacity.AutoSize = true;
            lbOpacity.Location = new Point(309, 207);
            lbOpacity.Name = "lbOpacity";
            lbOpacity.Size = new Size(51, 15);
            lbOpacity.TabIndex = 8;
            lbOpacity.Text = "Opacity:";
            // 
            // button1
            // 
            button1.Location = new Point(66, 358);
            button1.Name = "button1";
            button1.Size = new Size(259, 85);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 625);
            Controls.Add(button1);
            Controls.Add(lbOpacity);
            Controls.Add(lbBlue);
            Controls.Add(lbGreen);
            Controls.Add(lbRed);
            Controls.Add(trackBar4);
            Controls.Add(panel1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private Panel panel1;
        private TrackBar trackBar4;
        private Label lbRed;
        private Label lbGreen;
        private Label lbBlue;
        private Label lbOpacity;
        private Button button1;
    }
}
