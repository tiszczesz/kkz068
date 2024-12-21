namespace TutPictureViewer_cw14
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pan1 = new Panel();
            lbY = new Label();
            lbX = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label4 = new Label();
            label3 = new Label();
            pan2 = new Panel();
            tabPage3 = new TabPage();
            pan3 = new Panel();
            tabPage4 = new TabPage();
            button3 = new Button();
            button2 = new Button();
            nudYk = new NumericUpDown();
            nudXk = new NumericUpDown();
            nudYp = new NumericUpDown();
            nudXp = new NumericUpDown();
            button1 = new Button();
            pan4 = new Panel();
            colorDialog1 = new ColorDialog();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudXk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudYp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudXp).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(255, 255, 192);
            tabPage1.Controls.Add(pan1);
            tabPage1.Controls.Add(lbY);
            tabPage1.Controls.Add(lbX);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // pan1
            // 
            pan1.BorderStyle = BorderStyle.Fixed3D;
            pan1.Dock = DockStyle.Right;
            pan1.Location = new Point(133, 3);
            pan1.Name = "pan1";
            pan1.Size = new Size(656, 416);
            pan1.TabIndex = 4;
            pan1.MouseEnter += pan1_MouseEnter;
            pan1.MouseLeave += pan1_MouseLeave;
            pan1.MouseMove += pan1_MouseMove;
            // 
            // lbY
            // 
            lbY.AutoSize = true;
            lbY.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lbY.Location = new Point(60, 57);
            lbY.Name = "lbY";
            lbY.Size = new Size(29, 30);
            lbY.TabIndex = 3;
            lbY.Text = "--";
            // 
            // lbX
            // 
            lbX.AutoSize = true;
            lbX.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lbX.Location = new Point(60, 21);
            lbX.Name = "lbX";
            lbX.Size = new Size(29, 30);
            lbX.TabIndex = 2;
            lbX.Text = "--";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(24, 57);
            label2.Name = "label2";
            label2.Size = new Size(30, 30);
            label2.TabIndex = 1;
            label2.Text = "Y:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(30, 30);
            label1.TabIndex = 0;
            label1.Text = "X:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(192, 255, 192);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(pan2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "green";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 344);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 2;
            label4.Text = "green";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 156);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 1;
            label3.Text = "red";
            // 
            // pan2
            // 
            pan2.BorderStyle = BorderStyle.FixedSingle;
            pan2.Location = new Point(217, 52);
            pan2.Name = "pan2";
            pan2.Size = new Size(255, 255);
            pan2.TabIndex = 0;
            pan2.MouseMove += panel1_MouseMove;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(pan3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(792, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Trzeci";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // pan3
            // 
            pan3.Location = new Point(28, 25);
            pan3.Name = "pan3";
            pan3.Size = new Size(728, 361);
            pan3.TabIndex = 0;
            pan3.Paint += pan3_Paint;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(button2);
            tabPage4.Controls.Add(nudYk);
            tabPage4.Controls.Add(nudXk);
            tabPage4.Controls.Add(nudYp);
            tabPage4.Controls.Add(nudXp);
            tabPage4.Controls.Add(button1);
            tabPage4.Controls.Add(pan4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(792, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(8, 210);
            button3.Name = "button3";
            button3.Size = new Size(187, 39);
            button3.TabIndex = 7;
            button3.Text = "Wyczyść panel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(8, 109);
            button2.Name = "button2";
            button2.Size = new Size(187, 39);
            button2.TabIndex = 6;
            button2.Text = "Wybierz kolor";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // nudYk
            // 
            nudYk.Location = new Point(116, 60);
            nudYk.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            nudYk.Name = "nudYk";
            nudYk.Size = new Size(79, 23);
            nudYk.TabIndex = 5;
            // 
            // nudXk
            // 
            nudXk.Location = new Point(8, 60);
            nudXk.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            nudXk.Name = "nudXk";
            nudXk.Size = new Size(79, 23);
            nudXk.TabIndex = 4;
            // 
            // nudYp
            // 
            nudYp.Location = new Point(116, 31);
            nudYp.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            nudYp.Name = "nudYp";
            nudYp.Size = new Size(79, 23);
            nudYp.TabIndex = 3;
            // 
            // nudXp
            // 
            nudXp.Location = new Point(8, 31);
            nudXp.Maximum = new decimal(new int[] { 400, 0, 0, 0 });
            nudXp.Name = "nudXp";
            nudXp.Size = new Size(79, 23);
            nudXp.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(8, 154);
            button1.Name = "button1";
            button1.Size = new Size(187, 39);
            button1.TabIndex = 1;
            button1.Text = "Narysuj prostokąt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pan4
            // 
            pan4.BorderStyle = BorderStyle.FixedSingle;
            pan4.Location = new Point(279, 19);
            pan4.Name = "pan4";
            pan4.Size = new Size(381, 363);
            pan4.TabIndex = 0;
            pan4.MouseDown += pan4_MouseDown;
            pan4.MouseMove += pan4_MouseMove;
            pan4.MouseUp += pan4_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Okienko główne";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudYk).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudXk).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudYp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudXp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel pan1;
        private Label lbY;
        private Label lbX;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel pan2;
        private Label label4;
        private TabPage tabPage3;
        private Panel pan3;
        private TabPage tabPage4;
        private NumericUpDown nudYp;
        private NumericUpDown nudXp;
        private Button button1;
        private Panel pan4;
        private NumericUpDown nudYk;
        private NumericUpDown nudXk;
        private Button button2;
        private ColorDialog colorDialog1;
        private Button button3;
    }
}
