namespace cw7
{
    partial class FormAddNew
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbFirstname = new TextBox();
            tbLastname = new TextBox();
            tbEmail = new TextBox();
            mcDate = new MonthCalendar();
            btnSave = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(120, 41);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 0;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 102);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 161);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 222);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 3;
            label4.Text = "Data urodzenia";
            // 
            // tbFirstname
            // 
            tbFirstname.Location = new Point(195, 38);
            tbFirstname.Name = "tbFirstname";
            tbFirstname.Size = new Size(314, 27);
            tbFirstname.TabIndex = 4;
            tbFirstname.KeyPress += tbFirstname_KeyPress;
            // 
            // tbLastname
            // 
            tbLastname.Location = new Point(195, 99);
            tbLastname.Name = "tbLastname";
            tbLastname.Size = new Size(314, 27);
            tbLastname.TabIndex = 5;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(195, 158);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(314, 27);
            tbEmail.TabIndex = 6;
            // 
            // mcDate
            // 
            mcDate.Location = new Point(184, 222);
            mcDate.Name = "mcDate";
            mcDate.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(70, 469);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(209, 43);
            btnSave.TabIndex = 8;
            btnSave.Text = "Zapisz";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(300, 469);
            button2.Name = "button2";
            button2.Size = new Size(209, 43);
            button2.TabIndex = 9;
            button2.Text = "Anuluj";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormAddNew
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 555);
            Controls.Add(button2);
            Controls.Add(btnSave);
            Controls.Add(mcDate);
            Controls.Add(tbEmail);
            Controls.Add(tbLastname);
            Controls.Add(tbFirstname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAddNew";
            Text = "Dodaj nowy kontakt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbFirstname;
        private TextBox tbLastname;
        private TextBox tbEmail;
        private MonthCalendar mcDate;
        private Button btnSave;
        private Button button2;
    }
}