namespace cw13
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
            label1 = new Label();
            tbOwner = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            dateTimePicker1 = new DateTimePicker();
            tracBarAge = new TrackBar();
            lbAge = new Label();
            tbVisit = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)tracBarAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.SeaGreen;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(352, 61);
            label1.TabIndex = 1;
            label1.Text = "Wizyta u weterynarza";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbOwner
            // 
            tbOwner.BackColor = Color.LightGreen;
            tbOwner.BorderStyle = BorderStyle.FixedSingle;
            tbOwner.Dock = DockStyle.Top;
            tbOwner.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tbOwner.Location = new Point(0, 61);
            tbOwner.Name = "tbOwner";
            tbOwner.PlaceholderText = "Imię i nazwisko właściciela";
            tbOwner.Size = new Size(352, 33);
            tbOwner.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(0, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Gatunek";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.LightGreen;
            listBox1.BorderStyle = BorderStyle.FixedSingle;
            listBox1.Dock = DockStyle.Top;
            listBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(0, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(352, 107);
            listBox1.TabIndex = 4;
            listBox1.Click += listBox1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = Color.LightGreen;
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(12, 341);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(328, 23);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.Value = new DateTime(2024, 12, 21, 16, 0, 0, 0);
            // 
            // tracBarAge
            // 
            tracBarAge.Location = new Point(98, 251);
            tracBarAge.Name = "tracBarAge";
            tracBarAge.Size = new Size(254, 45);
            tracBarAge.TabIndex = 6;
            tracBarAge.ValueChanged += trackBar1_ValueChanged;
            // 
            // lbAge
            // 
            lbAge.AutoSize = true;
            lbAge.Location = new Point(12, 251);
            lbAge.Name = "lbAge";
            lbAge.Size = new Size(67, 15);
            lbAge.TabIndex = 7;
            lbAge.Text = "ile ma lat: 0";
            // 
            // tbVisit
            // 
            tbVisit.BackColor = Color.LightGreen;
            tbVisit.BorderStyle = BorderStyle.FixedSingle;
            tbVisit.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            tbVisit.Location = new Point(0, 302);
            tbVisit.Name = "tbVisit";
            tbVisit.PlaceholderText = "Cel wizyty";
            tbVisit.Size = new Size(352, 33);
            tbVisit.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(12, 380);
            button1.Name = "button1";
            button1.Size = new Size(328, 34);
            button1.TabIndex = 9;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(352, 663);
            Controls.Add(button1);
            Controls.Add(tbVisit);
            Controls.Add(lbAge);
            Controls.Add(tracBarAge);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(tbOwner);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)tracBarAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox tbOwner;
        private Label label2;
        private ListBox listBox1;
        private DateTimePicker dateTimePicker1;
        private TrackBar tracBarAge;
        private Label lbAge;
        private TextBox tbVisit;
        private Button button1;
    }
}
