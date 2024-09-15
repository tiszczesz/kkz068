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
        cbOparation = new ComboBox();
        lbResult = new Label();
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
        // cbOparation
        // 
        cbOparation.DropDownStyle = ComboBoxStyle.DropDownList;
        cbOparation.FormattingEnabled = true;
        cbOparation.Items.AddRange(new object[] { "+", "-", "*", "/" });
        cbOparation.Location = new Point(185, 71);
        cbOparation.Name = "cbOparation";
        cbOparation.Size = new Size(114, 28);
        cbOparation.TabIndex = 2;
        cbOparation.SelectedIndexChanged += cbOparation_SelectedIndexChanged;
        // 
        // lbResult
        // 
        lbResult.AutoSize = true;
        lbResult.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
        lbResult.Location = new Point(352, 68);
        lbResult.Name = "lbResult";
        lbResult.Size = new Size(76, 31);
        lbResult.TabIndex = 3;
        lbResult.Text = "Wynik";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(733, 213);
        Controls.Add(lbResult);
        Controls.Add(cbOparation);
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
    private ComboBox cbOparation;
    private Label lbResult;
}
