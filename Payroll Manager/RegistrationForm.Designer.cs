namespace Payroll_Manager
{
    partial class RegistrationForm
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
            submitButton = new Button();
            idInput = new TextBox();
            empTypeInput = new TextBox();
            nameInput = new TextBox();
            designationInput = new TextBox();
            basicSalaryInput = new TextBox();
            presentAddressInput = new TextBox();
            permanentAddressInput = new TextBox();
            genderComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            phoneInput = new TextBox();
            SuspendLayout();
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.DarkSlateBlue;
            submitButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            submitButton.ForeColor = Color.Snow;
            submitButton.Location = new Point(252, 587);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(162, 57);
            submitButton.TabIndex = 0;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // idInput
            // 
            idInput.BackColor = SystemColors.WindowFrame;
            idInput.BorderStyle = BorderStyle.FixedSingle;
            idInput.Font = new Font("Segoe UI", 16F);
            idInput.Location = new Point(261, 62);
            idInput.Name = "idInput";
            idInput.Size = new Size(309, 36);
            idInput.TabIndex = 1;
            // 
            // empTypeInput
            // 
            empTypeInput.BackColor = SystemColors.WindowFrame;
            empTypeInput.BorderStyle = BorderStyle.FixedSingle;
            empTypeInput.Font = new Font("Segoe UI", 16F);
            empTypeInput.Location = new Point(261, 165);
            empTypeInput.Name = "empTypeInput";
            empTypeInput.Size = new Size(309, 36);
            empTypeInput.TabIndex = 2;
            // 
            // nameInput
            // 
            nameInput.BackColor = SystemColors.WindowFrame;
            nameInput.BorderStyle = BorderStyle.FixedSingle;
            nameInput.Font = new Font("Segoe UI", 16F);
            nameInput.Location = new Point(261, 112);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(309, 36);
            nameInput.TabIndex = 3;
            // 
            // designationInput
            // 
            designationInput.BackColor = SystemColors.WindowFrame;
            designationInput.BorderStyle = BorderStyle.FixedSingle;
            designationInput.Font = new Font("Segoe UI", 16F);
            designationInput.Location = new Point(261, 220);
            designationInput.Name = "designationInput";
            designationInput.Size = new Size(309, 36);
            designationInput.TabIndex = 4;
            // 
            // basicSalaryInput
            // 
            basicSalaryInput.BackColor = SystemColors.WindowFrame;
            basicSalaryInput.BorderStyle = BorderStyle.FixedSingle;
            basicSalaryInput.Font = new Font("Segoe UI", 16F);
            basicSalaryInput.Location = new Point(261, 275);
            basicSalaryInput.Name = "basicSalaryInput";
            basicSalaryInput.Size = new Size(309, 36);
            basicSalaryInput.TabIndex = 5;
            // 
            // presentAddressInput
            // 
            presentAddressInput.BackColor = SystemColors.WindowFrame;
            presentAddressInput.BorderStyle = BorderStyle.FixedSingle;
            presentAddressInput.Font = new Font("Segoe UI", 16F);
            presentAddressInput.Location = new Point(261, 334);
            presentAddressInput.Name = "presentAddressInput";
            presentAddressInput.Size = new Size(309, 36);
            presentAddressInput.TabIndex = 6;
            // 
            // permanentAddressInput
            // 
            permanentAddressInput.BackColor = SystemColors.WindowFrame;
            permanentAddressInput.BorderStyle = BorderStyle.FixedSingle;
            permanentAddressInput.Font = new Font("Segoe UI", 16F);
            permanentAddressInput.Location = new Point(261, 396);
            permanentAddressInput.Name = "permanentAddressInput";
            permanentAddressInput.Size = new Size(309, 36);
            permanentAddressInput.TabIndex = 7;
            // 
            // genderComboBox
            // 
            genderComboBox.BackColor = SystemColors.WindowFrame;
            genderComboBox.Font = new Font("Segoe UI", 16F);
            genderComboBox.FormattingEnabled = true;
            genderComboBox.Location = new Point(261, 521);
            genderComboBox.Name = "genderComboBox";
            genderComboBox.Size = new Size(309, 38);
            genderComboBox.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(71, 67);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 9;
            label1.Text = "Employee ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(71, 113);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 10;
            label2.Text = "Employee Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(69, 168);
            label3.Name = "label3";
            label3.Size = new Size(145, 25);
            label3.TabIndex = 11;
            label3.Text = "Employee Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(71, 224);
            label4.Name = "label4";
            label4.Size = new Size(119, 25);
            label4.TabIndex = 12;
            label4.Text = "Designation";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(71, 279);
            label5.Name = "label5";
            label5.Size = new Size(116, 25);
            label5.TabIndex = 13;
            label5.Text = "Basic Salary";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(69, 339);
            label6.Name = "label6";
            label6.Size = new Size(155, 25);
            label6.TabIndex = 14;
            label6.Text = "Present Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(69, 399);
            label7.Name = "label7";
            label7.Size = new Size(185, 25);
            label7.TabIndex = 15;
            label7.Text = "Permanent Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(69, 464);
            label8.Name = "label8";
            label8.Size = new Size(148, 25);
            label8.TabIndex = 16;
            label8.Text = "Phone Number";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(70, 525);
            label9.Name = "label9";
            label9.Size = new Size(78, 25);
            label9.TabIndex = 17;
            label9.Text = "Gender";
            // 
            // phoneInput
            // 
            phoneInput.BackColor = SystemColors.WindowFrame;
            phoneInput.BorderStyle = BorderStyle.FixedSingle;
            phoneInput.Font = new Font("Segoe UI", 16F);
            phoneInput.Location = new Point(261, 461);
            phoneInput.Name = "phoneInput";
            phoneInput.Size = new Size(309, 36);
            phoneInput.TabIndex = 18;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(654, 693);
            Controls.Add(phoneInput);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(genderComboBox);
            Controls.Add(permanentAddressInput);
            Controls.Add(presentAddressInput);
            Controls.Add(basicSalaryInput);
            Controls.Add(designationInput);
            Controls.Add(nameInput);
            Controls.Add(empTypeInput);
            Controls.Add(idInput);
            Controls.Add(submitButton);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitButton;
        private TextBox idInput;
        private TextBox empTypeInput;
        private TextBox nameInput;
        private TextBox designationInput;
        private TextBox basicSalaryInput;
        private TextBox presentAddressInput;
        private TextBox permanentAddressInput;
        private ComboBox genderComboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox phoneInput;
    }
}