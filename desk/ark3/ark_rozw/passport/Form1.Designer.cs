namespace passport;

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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        tbNumber = new TextBox();
        tbFirstname = new TextBox();
        tbLastname = new TextBox();
        groupBox1 = new GroupBox();
        radioButton3 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton1 = new RadioButton();
        pb1 = new PictureBox();
        pb2 = new PictureBox();
        button1 = new Button();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pb1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pb2).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(90, 47);
        label1.Name = "label1";
        label1.Size = new Size(51, 20);
        label1.TabIndex = 0;
        label1.Text = "numer";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(90, 99);
        label2.Name = "label2";
        label2.Size = new Size(38, 20);
        label2.TabIndex = 1;
        label2.Text = "imię";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(90, 159);
        label3.Name = "label3";
        label3.Size = new Size(69, 20);
        label3.TabIndex = 2;
        label3.Text = "nazwisko";
        // 
        // tbNumber
        // 
        tbNumber.Location = new Point(170, 40);
        tbNumber.Name = "tbNumber";
        tbNumber.Size = new Size(127, 27);
        tbNumber.TabIndex = 3;
        tbNumber.Leave += tbNumber_Leave;
        // 
        // tbFirstname
        // 
        tbFirstname.Location = new Point(170, 96);
        tbFirstname.Name = "tbFirstname";
        tbFirstname.Size = new Size(123, 27);
        tbFirstname.TabIndex = 4;
        // 
        // tbLastname
        // 
        tbLastname.Location = new Point(172, 156);
        tbLastname.Name = "tbLastname";
        tbLastname.Size = new Size(125, 27);
        tbLastname.TabIndex = 5;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(radioButton3);
        groupBox1.Controls.Add(radioButton2);
        groupBox1.Controls.Add(radioButton1);
        groupBox1.Location = new Point(61, 224);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(250, 177);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "Kolor oczu";
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(29, 132);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(70, 24);
        radioButton3.TabIndex = 2;
        radioButton3.TabStop = true;
        radioButton3.Text = "piwne";
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(29, 91);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(78, 24);
        radioButton2.TabIndex = 1;
        radioButton2.TabStop = true;
        radioButton2.Text = "zielone";
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(29, 47);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(99, 24);
        radioButton1.TabIndex = 0;
        radioButton1.TabStop = true;
        radioButton1.Text = "niebiedkie";
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // pb1
        // 
        pb1.Image = Properties.Resources._000_zdjecie;
        pb1.Location = new Point(365, 53);
        pb1.Name = "pb1";
        pb1.Size = new Size(199, 242);
        pb1.SizeMode = PictureBoxSizeMode.StretchImage;
        pb1.TabIndex = 7;
        pb1.TabStop = false;
        // 
        // pb2
        // 
        pb2.Image = Properties.Resources._000_odcisk;
        pb2.Location = new Point(570, 56);
        pb2.Name = "pb2";
        pb2.Size = new Size(186, 239);
        pb2.SizeMode = PictureBoxSizeMode.StretchImage;
        pb2.TabIndex = 8;
        pb2.TabStop = false;
        // 
        // button1
        // 
        button1.Location = new Point(365, 315);
        button1.Name = "button1";
        button1.Size = new Size(391, 49);
        button1.TabIndex = 9;
        button1.Text = "OK";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button1);
        Controls.Add(pb2);
        Controls.Add(pb1);
        Controls.Add(groupBox1);
        Controls.Add(tbLastname);
        Controls.Add(tbFirstname);
        Controls.Add(tbNumber);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pb1).EndInit();
        ((System.ComponentModel.ISupportInitialize)pb2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox tbNumber;
    private TextBox tbFirstname;
    private TextBox tbLastname;
    private GroupBox groupBox1;
    private RadioButton radioButton3;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private PictureBox pb1;
    private PictureBox pb2;
    private Button button1;
}
