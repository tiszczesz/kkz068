namespace cw5
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
            panel1 = new Panel();
            btnLoad = new Button();
            lbContacts = new ListBox();
            openFileDialog1 = new OpenFileDialog();
            panelInfo = new Panel();
            tbPersonPhone = new TextBox();
            tbPersonAge = new TextBox();
            tbPersonLastName = new TextBox();
            tbPersonFirstName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 643);
            panel1.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 27);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(209, 29);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Wczytaj kontakty";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lbContacts
            // 
            lbContacts.Dock = DockStyle.Left;
            lbContacts.FormattingEnabled = true;
            lbContacts.Location = new Point(250, 0);
            lbContacts.Name = "lbContacts";
            lbContacts.Size = new Size(248, 643);
            lbContacts.TabIndex = 1;
            lbContacts.SelectedIndexChanged += lbContacts_SelectedIndexChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Csv|*.csv|wszystkie|*.*";
            // 
            // panelInfo
            // 
            panelInfo.BorderStyle = BorderStyle.FixedSingle;
            panelInfo.Controls.Add(pictureBox1);
            panelInfo.Controls.Add(tbPersonPhone);
            panelInfo.Controls.Add(tbPersonAge);
            panelInfo.Controls.Add(tbPersonLastName);
            panelInfo.Controls.Add(tbPersonFirstName);
            panelInfo.Controls.Add(label5);
            panelInfo.Controls.Add(label4);
            panelInfo.Controls.Add(label3);
            panelInfo.Controls.Add(label2);
            panelInfo.Controls.Add(label1);
            panelInfo.Location = new Point(526, 12);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(424, 574);
            panelInfo.TabIndex = 2;
            // 
            // tbPersonPhone
            // 
            tbPersonPhone.Location = new Point(113, 206);
            tbPersonPhone.Name = "tbPersonPhone";
            tbPersonPhone.Size = new Size(242, 27);
            tbPersonPhone.TabIndex = 8;
            // 
            // tbPersonAge
            // 
            tbPersonAge.Location = new Point(113, 158);
            tbPersonAge.Name = "tbPersonAge";
            tbPersonAge.Size = new Size(242, 27);
            tbPersonAge.TabIndex = 7;
            // 
            // tbPersonLastName
            // 
            tbPersonLastName.Location = new Point(113, 110);
            tbPersonLastName.Name = "tbPersonLastName";
            tbPersonLastName.Size = new Size(242, 27);
            tbPersonLastName.TabIndex = 6;
            // 
            // tbPersonFirstName
            // 
            tbPersonFirstName.Location = new Point(113, 62);
            tbPersonFirstName.Name = "tbPersonFirstName";
            tbPersonFirstName.Size = new Size(242, 27);
            tbPersonFirstName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 209);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 4;
            label5.Text = "Telefon:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 161);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 3;
            label4.Text = "Wiek:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 113);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Nazwisko:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 65);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Imię:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(85, 5);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 0;
            label1.Text = "Szczegóły kontaktu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.smile;
            pictureBox1.Location = new Point(66, 273);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 232);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 643);
            Controls.Add(panelInfo);
            Controls.Add(lbContacts);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Kontakty";
            panel1.ResumeLayout(false);
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnLoad;
        private ListBox lbContacts;
        private OpenFileDialog openFileDialog1;
        private Panel panelInfo;
        private TextBox tbPersonPhone;
        private TextBox tbPersonAge;
        private TextBox tbPersonLastName;
        private TextBox tbPersonFirstName;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}
