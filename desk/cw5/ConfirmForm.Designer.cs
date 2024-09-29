namespace cw5
{
    partial class ConfirmForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbQuestion = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbQuestion
            // 
            lbQuestion.AutoSize = true;
            lbQuestion.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lbQuestion.Location = new Point(39, 23);
            lbQuestion.Name = "lbQuestion";
            lbQuestion.Size = new Size(91, 38);
            lbQuestion.TabIndex = 0;
            lbQuestion.Text = "label1";
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(39, 94);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(194, 70);
            btnOK.TabIndex = 1;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(380, 94);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(194, 70);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Anuluj";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // ConfirmForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(603, 197);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(lbQuestion);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "ConfirmForm";
            Text = "Potwierdź";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbQuestion;
        private Button btnOK;
        private Button btnCancel;
    }
}