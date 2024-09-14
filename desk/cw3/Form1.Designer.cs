namespace cw3;

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
        tbA = new TextBox();
        tbB = new TextBox();
        comboBox1 = new ComboBox();
        label1 = new Label();
        SuspendLayout();
        // 
        // tbA
        // 
        tbA.Location = new Point(51, 36);
        tbA.Name = "tbA";
        tbA.PlaceholderText = "Podaj a";
        tbA.Size = new Size(125, 27);
        tbA.TabIndex = 0;
        // 
        // tbB
        // 
        tbB.Location = new Point(51, 111);
        tbB.Name = "tbB";
        tbB.PlaceholderText = "Podaj b";
        tbB.Size = new Size(125, 27);
        tbB.TabIndex = 1;
        // 
        // comboBox1
        // 
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "+", "-", "*", "/" });
        comboBox1.Location = new Point(185, 71);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(114, 28);
        comboBox1.TabIndex = 2;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(352, 74);
        label1.Name = "label1";
        label1.Size = new Size(50, 20);
        label1.TabIndex = 3;
        label1.Text = "label1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(486, 615);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Controls.Add(tbB);
        Controls.Add(tbA);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox tbA;
    private TextBox tbB;
    private ComboBox comboBox1;
    private Label label1;
}
