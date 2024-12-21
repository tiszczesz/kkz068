namespace zadanie
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
            listBox1 = new ListBox();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(22, 70);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(405, 319);
            listBox1.TabIndex = 0;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 28);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 1;
            label1.Text = "Nowe zadanie:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 23);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(296, 25);
            button1.Name = "button1";
            button1.Size = new Size(131, 23);
            button1.TabIndex = 3;
            button1.Text = "Dodaj zadanie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 407);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 4;
            label2.Text = "Ilość zadań: 0";
            // 
            // button2
            // 
            button2.Location = new Point(444, 28);
            button2.Name = "button2";
            button2.Size = new Size(131, 23);
            button2.TabIndex = 5;
            button2.Text = "Usuń zadanie";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.DialogResult = DialogResult.OK;
            button3.Location = new Point(473, 139);
            button3.Name = "button3";
            button3.Size = new Size(131, 23);
            button3.TabIndex = 6;
            button3.Text = "ok";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.DialogResult = DialogResult.Cancel;
            button4.Location = new Point(473, 196);
            button4.Name = "button4";
            button4.Size = new Size(131, 23);
            button4.TabIndex = 7;
            button4.Text = "anuluj";
            button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            DoubleClick += Form1_DoubleClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
