namespace cw2
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
            btnDesc = new Button();
            btnAsc = new Button();
            lbCount = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            lbHint = new Label();
            lbTakes = new Label();
            btnCheck = new Button();
            btnStart = new Button();
            tbNumber = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnDesc
            // 
            btnDesc.Font = new Font("Segoe UI", 13.8F);
            btnDesc.Location = new Point(25, 46);
            btnDesc.Name = "btnDesc";
            btnDesc.Size = new Size(94, 55);
            btnDesc.TabIndex = 0;
            btnDesc.Text = "<<";
            btnDesc.UseVisualStyleBackColor = true;
            btnDesc.Click += btnDesc_Click;
            // 
            // btnAsc
            // 
            btnAsc.Font = new Font("Segoe UI", 13.8F);
            btnAsc.Location = new Point(307, 46);
            btnAsc.Name = "btnAsc";
            btnAsc.Size = new Size(94, 55);
            btnAsc.TabIndex = 1;
            btnAsc.Text = ">>";
            btnAsc.UseVisualStyleBackColor = true;
            btnAsc.Click += btnAsc_Click;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lbCount.Location = new Point(187, 27);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(70, 81);
            lbCount.TabIndex = 2;
            lbCount.Text = "0";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(btnAsc);
            panel1.Controls.Add(btnDesc);
            panel1.Controls.Add(lbCount);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 167);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(lbHint);
            panel2.Controls.Add(lbTakes);
            panel2.Controls.Add(btnCheck);
            panel2.Controls.Add(btnStart);
            panel2.Controls.Add(tbNumber);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(483, 204);
            panel2.TabIndex = 4;
            // 
            // lbHint
            // 
            lbHint.AutoSize = true;
            lbHint.Location = new Point(238, 85);
            lbHint.Name = "lbHint";
            lbHint.Size = new Size(0, 20);
            lbHint.TabIndex = 4;
            // 
            // lbTakes
            // 
            lbTakes.AutoSize = true;
            lbTakes.Location = new Point(219, 28);
            lbTakes.Name = "lbTakes";
            lbTakes.Size = new Size(82, 20);
            lbTakes.TabIndex = 3;
            lbTakes.Text = "Ilość prób: ";
            // 
            // btnCheck
            // 
            btnCheck.Enabled = false;
            btnCheck.Location = new Point(12, 111);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(125, 29);
            btnCheck.TabIndex = 2;
            btnCheck.Text = "SPRAWDŹ";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(12, 21);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(125, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "START";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(12, 67);
            tbNumber.Name = "tbNumber";
            tbNumber.PlaceholderText = "podaj liczbę";
            tbNumber.Size = new Size(125, 27);
            tbNumber.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 371);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Okno Główne";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDesc;
        private Button btnAsc;
        private Label lbCount;
        private Panel panel1;
        private Panel panel2;
        private TextBox tbNumber;
        private Button btnCheck;
        private Button btnStart;
        private Label lbHint;
        private Label lbTakes;
    }
}
