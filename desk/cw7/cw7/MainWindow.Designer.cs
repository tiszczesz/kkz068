namespace cw7
{
    partial class MainWindow
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
            btnAddPerson = new Button();
            btnLoad = new Button();
            dgvPeople = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeople).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnAddPerson);
            panel1.Controls.Add(btnLoad);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 568);
            panel1.TabIndex = 0;
            // 
            // btnAddPerson
            // 
            btnAddPerson.Location = new Point(12, 73);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.Size = new Size(133, 46);
            btnAddPerson.TabIndex = 1;
            btnAddPerson.Text = "Dodaj kontakt";
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 21);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(133, 46);
            btnLoad.TabIndex = 0;
            btnLoad.Text = "Pobierz z pliu";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // dgvPeople
            // 
            dgvPeople.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPeople.Dock = DockStyle.Fill;
            dgvPeople.Location = new Point(168, 0);
            dgvPeople.Name = "dgvPeople";
            dgvPeople.ReadOnly = true;
            dgvPeople.RowHeadersWidth = 51;
            dgvPeople.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeople.Size = new Size(838, 568);
            dgvPeople.TabIndex = 1;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 568);
            Controls.Add(dgvPeople);
            Controls.Add(panel1);
            Name = "MainWindow";
            Text = "Zarządzanie kontaktami";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPeople).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvPeople;
        private Button btnLoad;
        private Button btnAddPerson;
    }
}
