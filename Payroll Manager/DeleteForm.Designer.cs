namespace Payroll_Manager
{
    partial class DeleteForm
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
            employeeIdInput = new TextBox();
            deleteButton = new Button();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ButtonFace;
            label13.Location = new Point(92, 88);
            label13.Name = "label13";
            label13.Size = new Size(121, 25);
            label13.TabIndex = 39;
            label13.Text = "Employee Id";
            // 
            // employeeIdInput
            // 
            employeeIdInput.BackColor = SystemColors.WindowFrame;
            employeeIdInput.BorderStyle = BorderStyle.FixedSingle;
            employeeIdInput.Font = new Font("Segoe UI", 16F);
            employeeIdInput.Location = new Point(234, 79);
            employeeIdInput.Name = "employeeIdInput";
            employeeIdInput.Size = new Size(309, 36);
            employeeIdInput.TabIndex = 38;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.Maroon;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            deleteButton.ForeColor = SystemColors.ButtonFace;
            deleteButton.Location = new Point(247, 225);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(162, 57);
            deleteButton.TabIndex = 40;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // DeleteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(656, 346);
            Controls.Add(deleteButton);
            Controls.Add(label13);
            Controls.Add(employeeIdInput);
            Name = "DeleteForm";
            Text = "DeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label13;
        private TextBox employeeIdInput;
        private Button deleteButton;
    }
}