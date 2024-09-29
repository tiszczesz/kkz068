namespace cwArk1;

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
        groupBox1 = new GroupBox();
        cbOcupation = new ComboBox();
        tbLastname = new TextBox();
        tbFirstname = new TextBox();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        groupBox2 = new GroupBox();
        btnGener = new Button();
        cbIsSpecial = new CheckBox();
        cbIsNumber = new CheckBox();
        cbIsUpper = new CheckBox();
        tbSize = new TextBox();
        label4 = new Label();
        btnAccept = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(cbOcupation);
        groupBox1.Controls.Add(tbLastname);
        groupBox1.Controls.Add(tbFirstname);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(12, 54);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(388, 256);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Dane pracownika";
        // 
        // cbOcupation
        // 
        cbOcupation.DropDownStyle = ComboBoxStyle.DropDownList;
        cbOcupation.FormattingEnabled = true;
        cbOcupation.Items.AddRange(new object[] { "Kierownik", "Starszy programista", "Młodszy programista", "Tester" });
        cbOcupation.Location = new Point(109, 151);
        cbOcupation.Name = "cbOcupation";
        cbOcupation.Size = new Size(210, 28);
        cbOcupation.TabIndex = 5;
        // 
        // tbLastname
        // 
        tbLastname.Location = new Point(109, 93);
        tbLastname.Name = "tbLastname";
        tbLastname.Size = new Size(210, 27);
        tbLastname.TabIndex = 4;
        // 
        // tbFirstname
        // 
        tbFirstname.Location = new Point(109, 35);
        tbFirstname.Name = "tbFirstname";
        tbFirstname.Size = new Size(210, 27);
        tbFirstname.TabIndex = 3;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(18, 154);
        label3.Name = "label3";
        label3.Size = new Size(84, 20);
        label3.TabIndex = 2;
        label3.Text = "Stanowisko";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(18, 96);
        label2.Name = "label2";
        label2.Size = new Size(72, 20);
        label2.TabIndex = 1;
        label2.Text = "Nazwisko";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(18, 38);
        label1.Name = "label1";
        label1.Size = new Size(38, 20);
        label1.TabIndex = 0;
        label1.Text = "Imię";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnGener);
        groupBox2.Controls.Add(cbIsSpecial);
        groupBox2.Controls.Add(cbIsNumber);
        groupBox2.Controls.Add(cbIsUpper);
        groupBox2.Controls.Add(tbSize);
        groupBox2.Controls.Add(label4);
        groupBox2.Location = new Point(438, 54);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(370, 256);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Generowanie hasła";
        // 
        // btnGener
        // 
        btnGener.BackColor = Color.SteelBlue;
        btnGener.Font = new Font("Segoe UI", 10.8F);
        btnGener.ForeColor = Color.White;
        btnGener.Location = new Point(79, 211);
        btnGener.Name = "btnGener";
        btnGener.Size = new Size(208, 33);
        btnGener.TabIndex = 5;
        btnGener.Text = "Generuj hasło";
        btnGener.UseVisualStyleBackColor = false;
        btnGener.Click += btnGener_Click;
        // 
        // cbIsSpecial
        // 
        cbIsSpecial.AutoSize = true;
        cbIsSpecial.Location = new Point(79, 170);
        cbIsSpecial.Name = "cbIsSpecial";
        cbIsSpecial.Size = new Size(133, 24);
        cbIsSpecial.TabIndex = 4;
        cbIsSpecial.Text = "Znaki specjalne";
        cbIsSpecial.UseVisualStyleBackColor = true;
        // 
        // cbIsNumber
        // 
        cbIsNumber.AutoSize = true;
        cbIsNumber.Location = new Point(79, 125);
        cbIsNumber.Name = "cbIsNumber";
        cbIsNumber.Size = new Size(64, 24);
        cbIsNumber.TabIndex = 3;
        cbIsNumber.Text = "Cyfry";
        cbIsNumber.UseVisualStyleBackColor = true;
        // 
        // cbIsUpper
        // 
        cbIsUpper.AutoSize = true;
        cbIsUpper.Location = new Point(79, 81);
        cbIsUpper.Name = "cbIsUpper";
        cbIsUpper.Size = new Size(155, 24);
        cbIsUpper.TabIndex = 2;
        cbIsUpper.Text = "Małe iwielkie litery";
        cbIsUpper.UseVisualStyleBackColor = true;
        // 
        // tbSize
        // 
        tbSize.Location = new Point(214, 38);
        tbSize.Name = "tbSize";
        tbSize.Size = new Size(125, 27);
        tbSize.TabIndex = 1;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(79, 42);
        label4.Name = "label4";
        label4.Size = new Size(86, 20);
        label4.TabIndex = 0;
        label4.Text = "Ile znaków?";
        // 
        // btnAccept
        // 
        btnAccept.BackColor = Color.SteelBlue;
        btnAccept.Font = new Font("Segoe UI", 10.8F);
        btnAccept.ForeColor = Color.White;
        btnAccept.Location = new Point(275, 346);
        btnAccept.Name = "btnAccept";
        btnAccept.Size = new Size(306, 36);
        btnAccept.TabIndex = 6;
        btnAccept.Text = "Zatwiedź";
        btnAccept.UseVisualStyleBackColor = false;
        btnAccept.Click += btnAccept_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.LightSteelBlue;
        ClientSize = new Size(882, 450);
        Controls.Add(btnAccept);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "Form1";
        Text = "Dodaj pracownika";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private ComboBox cbOcupation;
    private TextBox tbLastname;
    private TextBox tbFirstname;
    private Label label3;
    private Label label2;
    private Label label1;
    private Button btnGener;
    private CheckBox cbIsSpecial;
    private CheckBox cbIsNumber;
    private CheckBox cbIsUpper;
    private TextBox tbSize;
    private Label label4;
    private Button btnAccept;
}
