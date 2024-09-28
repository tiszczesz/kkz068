namespace cw4
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
            btnDelete = new Button();
            cbIsInsert = new CheckBox();
            tbItem = new TextBox();
            btnAdd = new Button();
            lbColors = new ListBox();
            btnLoadFromFile = new Button();
            btnSaveToFile = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(cbIsInsert);
            panel1.Controls.Add(tbItem);
            panel1.Controls.Add(btnAdd);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 450);
            panel1.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(3, 47);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Usuń";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbIsInsert
            // 
            cbIsInsert.AutoSize = true;
            cbIsInsert.Location = new Point(317, 8);
            cbIsInsert.Name = "cbIsInsert";
            cbIsInsert.Size = new Size(72, 24);
            cbIsInsert.TabIndex = 2;
            cbIsInsert.Text = "wstaw";
            cbIsInsert.UseVisualStyleBackColor = true;
            cbIsInsert.CheckedChanged += cbIsInsert_CheckedChanged;
            // 
            // tbItem
            // 
            tbItem.Location = new Point(103, 5);
            tbItem.Name = "tbItem";
            tbItem.Size = new Size(208, 27);
            tbItem.TabIndex = 1;
            tbItem.TextChanged += tbItem_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.Enabled = false;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Dodaj";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lbColors
            // 
            lbColors.Dock = DockStyle.Left;
            lbColors.FormattingEnabled = true;
            lbColors.Items.AddRange(new object[] { "czerwony", "zielony", "żółty", "czarny" });
            lbColors.Location = new Point(440, 0);
            lbColors.Name = "lbColors";
            lbColors.Size = new Size(214, 450);
            lbColors.TabIndex = 1;
            // 
            // btnLoadFromFile
            // 
            btnLoadFromFile.Location = new Point(679, 24);
            btnLoadFromFile.Name = "btnLoadFromFile";
            btnLoadFromFile.Size = new Size(174, 29);
            btnLoadFromFile.TabIndex = 2;
            btnLoadFromFile.Text = "Pobierz z pliku";
            btnLoadFromFile.UseVisualStyleBackColor = true;
            btnLoadFromFile.Click += btnLoadFromFile_Click;
            // 
            // btnSaveToFile
            // 
            btnSaveToFile.Location = new Point(679, 69);
            btnSaveToFile.Name = "btnSaveToFile";
            btnSaveToFile.Size = new Size(174, 29);
            btnSaveToFile.TabIndex = 3;
            btnSaveToFile.Text = "Zapisz do pliku";
            btnSaveToFile.UseVisualStyleBackColor = true;
            btnSaveToFile.Click += btnSaveToFile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(btnSaveToFile);
            Controls.Add(btnLoadFromFile);
            Controls.Add(lbColors);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private ListBox lbColors;
        private TextBox tbItem;
        private CheckBox cbIsInsert;
        private Button btnLoadFromFile;
        private Button btnSaveToFile;
        private Button btnDelete;
    }
}
