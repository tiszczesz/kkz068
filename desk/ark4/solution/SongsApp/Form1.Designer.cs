namespace SongsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbArtist = new Label();
            lbTitle = new Label();
            lbSongsNumber = new Label();
            lbdownloadsNumber = new Label();
            lbYear = new Label();
            btnDownload = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 70);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1289, 175);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 70);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(128, 84);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(199, 201);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lbArtist
            // 
            lbArtist.AutoSize = true;
            lbArtist.Font = new Font("Segoe UI", 50.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbArtist.ForeColor = Color.White;
            lbArtist.Location = new Point(400, 48);
            lbArtist.Name = "lbArtist";
            lbArtist.Size = new Size(194, 89);
            lbArtist.TabIndex = 3;
            lbArtist.Text = "Artist";
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 30F, FontStyle.Italic, GraphicsUnit.Point, 238);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(400, 150);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(96, 54);
            lbTitle.TabIndex = 4;
            lbTitle.Text = "Title";
            // 
            // lbSongsNumber
            // 
            lbSongsNumber.AutoSize = true;
            lbSongsNumber.Font = new Font("Segoe UI", 20.25F);
            lbSongsNumber.ForeColor = Color.FromArgb(97, 217, 24);
            lbSongsNumber.Location = new Point(400, 222);
            lbSongsNumber.Name = "lbSongsNumber";
            lbSongsNumber.Size = new Size(182, 37);
            lbSongsNumber.TabIndex = 5;
            lbSongsNumber.Text = "Ilość utworów";
            // 
            // lbdownloadsNumber
            // 
            lbdownloadsNumber.AutoSize = true;
            lbdownloadsNumber.Font = new Font("Segoe UI", 20.25F);
            lbdownloadsNumber.ForeColor = Color.FromArgb(97, 217, 24);
            lbdownloadsNumber.Location = new Point(138, 329);
            lbdownloadsNumber.Name = "lbdownloadsNumber";
            lbdownloadsNumber.Size = new Size(163, 37);
            lbdownloadsNumber.TabIndex = 6;
            lbdownloadsNumber.Text = "Ilość pobrań";
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Font = new Font("Segoe UI", 20.25F);
            lbYear.ForeColor = Color.FromArgb(97, 217, 24);
            lbYear.Location = new Point(659, 222);
            lbYear.Name = "lbYear";
            lbYear.Size = new Size(61, 37);
            lbYear.TabIndex = 7;
            lbYear.Text = "Rok";
            // 
            // btnDownload
            // 
            btnDownload.BackColor = Color.FromArgb(97, 217, 24);
            btnDownload.FlatAppearance.BorderColor = Color.FromArgb(97, 217, 24);
            btnDownload.FlatAppearance.BorderSize = 0;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            btnDownload.ForeColor = Color.Black;
            btnDownload.Location = new Point(400, 321);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(156, 53);
            btnDownload.TabIndex = 8;
            btnDownload.Text = "Pobierz";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1389, 479);
            Controls.Add(btnDownload);
            Controls.Add(lbYear);
            Controls.Add(lbdownloadsNumber);
            Controls.Add(lbSongsNumber);
            Controls.Add(lbTitle);
            Controls.Add(lbArtist);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.White;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "MojeDźwięki, Wykonał: XXXXXXXX";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lbArtist;
        private Label lbTitle;
        private Label lbSongsNumber;
        private Label lbdownloadsNumber;
        private Label lbYear;
        private Button btnDownload;
    }
}
