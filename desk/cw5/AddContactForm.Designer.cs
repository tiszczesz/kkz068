namespace cw5
{
    partial class AddContactForm
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
            tbFirstName = new TextBox();
            tbLastName = new TextBox();
            tbPhone = new TextBox();
            tbAge = new NumericUpDown();
            cbIsFamily = new CheckBox();
            btnAddContact = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)tbAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(74, 37);
            label1.Name = "label1";
            label1.Size = new Size(107, 28);
            label1.TabIndex = 0;
            label1.Text = "Podaj imię:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(32, 113);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 1;
            label2.Text = "Podaj nazwisko:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(66, 189);
            label3.Name = "label3";
            label3.Size = new Size(115, 28);
            label3.TabIndex = 2;
            label3.Text = "Nr telefonu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(121, 265);
            label4.Name = "label4";
            label4.Size = new Size(60, 28);
            label4.TabIndex = 3;
            label4.Text = "Wiek:";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(199, 41);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(190, 27);
            tbFirstName.TabIndex = 5;
            tbFirstName.TextChanged += tbFirstName_TextChanged;
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(199, 117);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(190, 27);
            tbLastName.TabIndex = 6;
            tbLastName.TextChanged += tbFirstName_TextChanged;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(199, 193);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(190, 27);
            tbPhone.TabIndex = 7;
            tbPhone.TextChanged += tbFirstName_TextChanged;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(199, 266);
            tbAge.Maximum = new decimal(new int[] { 130, 0, 0, 0 });
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(190, 27);
            tbAge.TabIndex = 8;
            // 
            // cbIsFamily
            // 
            cbIsFamily.AutoSize = true;
            cbIsFamily.Location = new Point(199, 335);
            cbIsFamily.Name = "cbIsFamily";
            cbIsFamily.Size = new Size(108, 24);
            cbIsFamily.TabIndex = 9;
            cbIsFamily.Text = "Czy rodzina";
            cbIsFamily.UseVisualStyleBackColor = true;
            // 
            // btnAddContact
            // 
            btnAddContact.Enabled = false;
            btnAddContact.Location = new Point(29, 412);
            btnAddContact.Name = "btnAddContact";
            btnAddContact.Size = new Size(175, 44);
            btnAddContact.TabIndex = 10;
            btnAddContact.Text = "Dodaj kontakt";
            btnAddContact.UseVisualStyleBackColor = true;
            btnAddContact.Click += btnAddContact_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(214, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(175, 44);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 498);
            Controls.Add(btnCancel);
            Controls.Add(btnAddContact);
            Controls.Add(cbIsFamily);
            Controls.Add(tbAge);
            Controls.Add(tbPhone);
            Controls.Add(tbLastName);
            Controls.Add(tbFirstName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "AddContactForm";
            Text = "Dodaj nowy kontakt";
            ((System.ComponentModel.ISupportInitialize)tbAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbFirstName;
        private TextBox tbLastName;
        private TextBox tbPhone;
        private NumericUpDown tbAge;
        private CheckBox cbIsFamily;
        private Button btnAddContact;
        private Button btnCancel;
    }
}