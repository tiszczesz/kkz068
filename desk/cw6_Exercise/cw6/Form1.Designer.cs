namespace cw6;

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
        lbNumbers = new ListBox();
        button1 = new Button();
        numSize = new NumericUpDown();
        button2 = new Button();
        lbMax = new Label();
        ((System.ComponentModel.ISupportInitialize)numSize).BeginInit();
        SuspendLayout();
        // 
        // lbNumbers
        // 
        lbNumbers.Dock = DockStyle.Left;
        lbNumbers.FormattingEnabled = true;
        lbNumbers.Location = new Point(0, 0);
        lbNumbers.Name = "lbNumbers";
        lbNumbers.Size = new Size(194, 450);
        lbNumbers.TabIndex = 0;
        // 
        // button1
        // 
        button1.Location = new Point(223, 28);
        button1.Name = "button1";
        button1.Size = new Size(94, 29);
        button1.TabIndex = 1;
        button1.Text = "Generuj liczby";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // numSize
        // 
        numSize.Location = new Point(362, 30);
        numSize.Name = "numSize";
        numSize.Size = new Size(150, 27);
        numSize.TabIndex = 2;
        // 
        // button2
        // 
        button2.Location = new Point(223, 106);
        button2.Name = "button2";
        button2.Size = new Size(94, 29);
        button2.TabIndex = 3;
        button2.Text = "Max";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // lbMax
        // 
        lbMax.AutoSize = true;
        lbMax.Location = new Point(371, 110);
        lbMax.Name = "lbMax";
        lbMax.Size = new Size(50, 20);
        lbMax.TabIndex = 4;
        lbMax.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(lbMax);
        Controls.Add(button2);
        Controls.Add(numSize);
        Controls.Add(button1);
        Controls.Add(lbNumbers);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)numSize).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox lbNumbers;
    private Button button1;
    private NumericUpDown numSize;
    private Button button2;
    private Label lbMax;
}
