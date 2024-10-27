namespace cw8_menu
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
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            nowyToolStripMenuItem = new ToolStripMenuItem();
            otwórzToolStripMenuItem = new ToolStripMenuItem();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            inneToolStripMenuItem = new ToolStripMenuItem();
            edycjaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            oProgramieToolStripMenuItem = new ToolStripMenuItem();
            dodatkoweInformacjeToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            btnSearch = new Button();
            tbSearch = new TextBox();
            lbConsonants = new Label();
            lbVowels = new Label();
            lbLetters = new Label();
            lbChars = new Label();
            lbLines = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbEdit = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, edycjaToolStripMenuItem, toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nowyToolStripMenuItem, otwórzToolStripMenuItem, zapiszToolStripMenuItem, toolStripSeparator1, inneToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "&Plik";
            // 
            // nowyToolStripMenuItem
            // 
            nowyToolStripMenuItem.Name = "nowyToolStripMenuItem";
            nowyToolStripMenuItem.Size = new Size(112, 22);
            nowyToolStripMenuItem.Text = "Nowy";
            nowyToolStripMenuItem.Click += nowyToolStripMenuItem_Click;
            // 
            // otwórzToolStripMenuItem
            // 
            otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            otwórzToolStripMenuItem.Size = new Size(112, 22);
            otwórzToolStripMenuItem.Text = "Otwórz";
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.Size = new Size(112, 22);
            zapiszToolStripMenuItem.Text = "Zapisz";
            zapiszToolStripMenuItem.Click += zapiszToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(109, 6);
            // 
            // inneToolStripMenuItem
            // 
            inneToolStripMenuItem.Name = "inneToolStripMenuItem";
            inneToolStripMenuItem.Size = new Size(112, 22);
            inneToolStripMenuItem.Text = "Inne";
            // 
            // edycjaToolStripMenuItem
            // 
            edycjaToolStripMenuItem.Name = "edycjaToolStripMenuItem";
            edycjaToolStripMenuItem.Size = new Size(53, 20);
            edycjaToolStripMenuItem.Text = "&Edycja";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { oProgramieToolStripMenuItem, dodatkoweInformacjeToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(57, 20);
            toolStripMenuItem1.Text = "P&omoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            oProgramieToolStripMenuItem.Size = new Size(194, 22);
            oProgramieToolStripMenuItem.Text = "O programie";
            // 
            // dodatkoweInformacjeToolStripMenuItem
            // 
            dodatkoweInformacjeToolStripMenuItem.Name = "dodatkoweInformacjeToolStripMenuItem";
            dodatkoweInformacjeToolStripMenuItem.Size = new Size(194, 22);
            dodatkoweInformacjeToolStripMenuItem.Text = "Dodatkowe informacje";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(lbConsonants);
            panel1.Controls.Add(lbVowels);
            panel1.Controls.Add(lbLetters);
            panel1.Controls.Add(lbChars);
            panel1.Controls.Add(lbLines);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(600, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 404);
            panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(29, 239);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(121, 23);
            btnSearch.TabIndex = 11;
            btnSearch.Text = "Szukaj";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(30, 197);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "szukane słowo";
            tbSearch.Size = new Size(120, 23);
            tbSearch.TabIndex = 10;
            // 
            // lbConsonants
            // 
            lbConsonants.AutoSize = true;
            lbConsonants.Location = new Point(106, 162);
            lbConsonants.Name = "lbConsonants";
            lbConsonants.Size = new Size(0, 15);
            lbConsonants.TabIndex = 9;
            // 
            // lbVowels
            // 
            lbVowels.AutoSize = true;
            lbVowels.Location = new Point(106, 128);
            lbVowels.Name = "lbVowels";
            lbVowels.Size = new Size(0, 15);
            lbVowels.TabIndex = 8;
            // 
            // lbLetters
            // 
            lbLetters.AutoSize = true;
            lbLetters.Location = new Point(106, 94);
            lbLetters.Name = "lbLetters";
            lbLetters.Size = new Size(0, 15);
            lbLetters.TabIndex = 7;
            // 
            // lbChars
            // 
            lbChars.AutoSize = true;
            lbChars.Location = new Point(106, 60);
            lbChars.Name = "lbChars";
            lbChars.Size = new Size(0, 15);
            lbChars.TabIndex = 6;
            // 
            // lbLines
            // 
            lbLines.AutoSize = true;
            lbLines.Location = new Point(106, 26);
            lbLines.Name = "lbLines";
            lbLines.Size = new Size(0, 15);
            lbLines.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 162);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 4;
            label5.Text = "spółgłoski:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 128);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 3;
            label4.Text = "samogłoski:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 94);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "ilość liter:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 60);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "ilość znaków:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 26);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 0;
            label1.Text = "ilość lini:";
            // 
            // tbEdit
            // 
            tbEdit.Dock = DockStyle.Fill;
            tbEdit.Location = new Point(0, 24);
            tbEdit.Multiline = true;
            tbEdit.Name = "tbEdit";
            tbEdit.Size = new Size(600, 404);
            tbEdit.TabIndex = 2;
            tbEdit.TextChanged += tbEdit_TextChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "pliki tekstowe|*.txt|Wszystkie pliki|*.*";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "txt";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(69, 17);
            toolStripStatusLabel1.Text = "niezapisano";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbEdit);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel panel1;
        private TextBox tbEdit;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem edycjaToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem nowyToolStripMenuItem;
        private ToolStripMenuItem otwórzToolStripMenuItem;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem inneToolStripMenuItem;
        private ToolStripMenuItem oProgramieToolStripMenuItem;
        private ToolStripMenuItem dodatkoweInformacjeToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private Label lbConsonants;
        private Label lbVowels;
        private Label lbLetters;
        private Label lbChars;
        private Label lbLines;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tbSearch;
        private Button btnSearch;
        private SaveFileDialog saveFileDialog1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
