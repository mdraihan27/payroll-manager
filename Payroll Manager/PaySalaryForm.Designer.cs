namespace Payroll_Manager
{
    partial class PaySalaryForm
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
            label13 = new Label();
            monthInput = new TextBox();
            payButton = new Button();
            label1 = new Label();
            yearInput = new TextBox();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(142, 106);
            label13.Name = "label13";
            label13.Size = new Size(72, 25);
            label13.TabIndex = 42;
            label13.Text = "Month";
            // 
            // monthInput
            // 
            monthInput.BackColor = SystemColors.WindowFrame;
            monthInput.BorderStyle = BorderStyle.FixedSingle;
            monthInput.Font = new Font("Segoe UI", 16F);
            monthInput.Location = new Point(234, 100);
            monthInput.Name = "monthInput";
            monthInput.Size = new Size(309, 36);
            monthInput.TabIndex = 41;
            // 
            // payButton
            // 
            payButton.BackColor = Color.SeaGreen;
            payButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            payButton.ForeColor = Color.Snow;
            payButton.Location = new Point(260, 287);
            payButton.Name = "payButton";
            payButton.Size = new Size(162, 57);
            payButton.TabIndex = 46;
            payButton.Text = "Pay";
            payButton.UseVisualStyleBackColor = false;
            payButton.Click += payButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(142, 173);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 45;
            label1.Text = "Year";
            // 
            // yearInput
            // 
            yearInput.BackColor = SystemColors.WindowFrame;
            yearInput.BorderStyle = BorderStyle.FixedSingle;
            yearInput.Font = new Font("Segoe UI", 16F);
            yearInput.Location = new Point(234, 167);
            yearInput.Name = "yearInput";
            yearInput.Size = new Size(309, 36);
            yearInput.TabIndex = 44;
            // 
            // PaySalaryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(687, 403);
            Controls.Add(payButton);
            Controls.Add(label1);
            Controls.Add(yearInput);
            Controls.Add(label13);
            Controls.Add(monthInput);
            Name = "PaySalaryForm";
            Text = "PaySalaryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private TextBox monthInput;
        private Button payButton;
        private Label label1;
        private TextBox yearInput;
    }
}