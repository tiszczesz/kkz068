namespace cw9_sqlite;

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
        dataGridView1 = new DataGridView();
        panelAdd = new Panel();
        btnSave = new Button();
        tbPrice = new TextBox();
        dataYear = new DateTimePicker();
        tbDirector = new TextBox();
        tbTitle = new TextBox();
        btnShow = new Button();
        sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
        btnDeletMovie = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        panelAdd.SuspendLayout();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 12);
        dataGridView1.MultiSelect = false;
        dataGridView1.Name = "dataGridView1";
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dataGridView1.Size = new Size(571, 414);
        dataGridView1.TabIndex = 0;
        dataGridView1.DoubleClick += dataGridView1_DoubleClick;
        // 
        // panelAdd
        // 
        panelAdd.BackColor = Color.FromArgb(255, 255, 192);
        panelAdd.Controls.Add(btnSave);
        panelAdd.Controls.Add(tbPrice);
        panelAdd.Controls.Add(dataYear);
        panelAdd.Controls.Add(tbDirector);
        panelAdd.Controls.Add(tbTitle);
        panelAdd.Location = new Point(620, 12);
        panelAdd.Name = "panelAdd";
        panelAdd.Size = new Size(262, 245);
        panelAdd.TabIndex = 1;
        panelAdd.Visible = false;
        // 
        // btnSave
        // 
        btnSave.BackColor = Color.FromArgb(255, 224, 192);
        btnSave.Location = new Point(28, 202);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(211, 29);
        btnSave.TabIndex = 4;
        btnSave.Text = "Zapisz";
        btnSave.UseVisualStyleBackColor = false;
        btnSave.Click += btnSave_Click;
        // 
        // tbPrice
        // 
        tbPrice.Location = new Point(28, 163);
        tbPrice.Name = "tbPrice";
        tbPrice.PlaceholderText = "podaj cenę";
        tbPrice.Size = new Size(211, 23);
        tbPrice.TabIndex = 3;
        tbPrice.KeyPress += tbPrice_KeyPress;
        // 
        // dataYear
        // 
        dataYear.CustomFormat = "yyyy";
        dataYear.Format = DateTimePickerFormat.Custom;
        dataYear.Location = new Point(28, 116);
        dataYear.Name = "dataYear";
        dataYear.Size = new Size(211, 23);
        dataYear.TabIndex = 2;
        // 
        // tbDirector
        // 
        tbDirector.Location = new Point(28, 69);
        tbDirector.Name = "tbDirector";
        tbDirector.PlaceholderText = "podaj imię i nazwisko reżysera";
        tbDirector.Size = new Size(211, 23);
        tbDirector.TabIndex = 1;
        // 
        // tbTitle
        // 
        tbTitle.Location = new Point(28, 22);
        tbTitle.Name = "tbTitle";
        tbTitle.PlaceholderText = "podaj tytuł filmu";
        tbTitle.Size = new Size(211, 23);
        tbTitle.TabIndex = 0;
        // 
        // btnShow
        // 
        btnShow.Location = new Point(620, 273);
        btnShow.Name = "btnShow";
        btnShow.Size = new Size(262, 47);
        btnShow.TabIndex = 2;
        btnShow.Text = "Pokaż formularz";
        btnShow.UseVisualStyleBackColor = true;
        btnShow.Click += btnShow_Click;
        // 
        // sqliteCommand1
        // 
        sqliteCommand1.CommandTimeout = 30;
        sqliteCommand1.Connection = null;
        sqliteCommand1.Transaction = null;
        sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
        // 
        // btnDeletMovie
        // 
        btnDeletMovie.Location = new Point(620, 337);
        btnDeletMovie.Name = "btnDeletMovie";
        btnDeletMovie.Size = new Size(262, 47);
        btnDeletMovie.TabIndex = 3;
        btnDeletMovie.Text = "Usuń film";
        btnDeletMovie.UseVisualStyleBackColor = true;
        btnDeletMovie.Click += btnDeletMovie_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1270, 450);
        Controls.Add(btnDeletMovie);
        Controls.Add(btnShow);
        Controls.Add(panelAdd);
        Controls.Add(dataGridView1);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        panelAdd.ResumeLayout(false);
        panelAdd.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private DataGridView dataGridView1;
    private Panel panelAdd;
    private Button btnShow;
    private DateTimePicker dataYear;
    private TextBox tbDirector;
    private TextBox tbTitle;
    private TextBox tbPrice;
    private Button btnSave;
    private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
    private Button btnDeletMovie;
}
