namespace egz2025_react
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            checkBoxCars = new CheckBox();
            checkBoxAnimals = new CheckBox();
            checkBoxFlower = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1064, 735);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(checkBoxCars);
            panel1.Controls.Add(checkBoxAnimals);
            panel1.Controls.Add(checkBoxFlower);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1064, 38);
            panel1.TabIndex = 1;
            // 
            // checkBoxCars
            // 
            checkBoxCars.AutoSize = true;
            checkBoxCars.Checked = true;
            checkBoxCars.CheckState = CheckState.Checked;
            checkBoxCars.Location = new Point(217, 12);
            checkBoxCars.Name = "checkBoxCars";
            checkBoxCars.Size = new Size(89, 19);
            checkBoxCars.TabIndex = 2;
            checkBoxCars.Text = "Samochody";
            checkBoxCars.UseVisualStyleBackColor = true;
            checkBoxCars.CheckedChanged += checkBoxCars_CheckedChanged;
            // 
            // checkBoxAnimals
            // 
            checkBoxAnimals.AutoSize = true;
            checkBoxAnimals.Checked = true;
            checkBoxAnimals.CheckState = CheckState.Checked;
            checkBoxAnimals.Location = new Point(115, 12);
            checkBoxAnimals.Name = "checkBoxAnimals";
            checkBoxAnimals.Size = new Size(76, 19);
            checkBoxAnimals.TabIndex = 1;
            checkBoxAnimals.Text = "Zwierzęta";
            checkBoxAnimals.UseVisualStyleBackColor = true;
            checkBoxAnimals.CheckedChanged += checkBoxAnimals_CheckedChanged;
            // 
            // checkBoxFlower
            // 
            checkBoxFlower.AutoSize = true;
            checkBoxFlower.Checked = true;
            checkBoxFlower.CheckState = CheckState.Checked;
            checkBoxFlower.Location = new Point(12, 12);
            checkBoxFlower.Name = "checkBoxFlower";
            checkBoxFlower.Size = new Size(61, 19);
            checkBoxFlower.TabIndex = 0;
            checkBoxFlower.Text = "Kwiaty";
            checkBoxFlower.UseVisualStyleBackColor = true;
            checkBoxFlower.CheckedChanged += checkBoxFlower_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1064, 773);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private CheckBox checkBoxCars;
        private CheckBox checkBoxAnimals;
        private CheckBox checkBoxFlower;
    }
}
