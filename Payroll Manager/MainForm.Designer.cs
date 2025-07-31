namespace Payroll_Manager
{
    partial class MainForm
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
            employeeListView = new ListView();
            addButton = new Button();
            refreshButton = new Button();
            deleteButton = new Button();
            paySalaryButton = new Button();
            addSalaryInformationButton = new Button();
            SuspendLayout();
            // 
            // employeeListView
            // 
            employeeListView.BackColor = SystemColors.InactiveCaption;
            employeeListView.Location = new Point(242, 21);
            employeeListView.Margin = new Padding(4);
            employeeListView.Name = "employeeListView";
            employeeListView.Size = new Size(1063, 841);
            employeeListView.TabIndex = 0;
            employeeListView.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.DimGray;
            addButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            addButton.ForeColor = SystemColors.Control;
            addButton.Location = new Point(20, 43);
            addButton.Margin = new Padding(4);
            addButton.Name = "addButton";
            addButton.Size = new Size(204, 74);
            addButton.TabIndex = 1;
            addButton.Text = "Add New Employee";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.SlateGray;
            refreshButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            refreshButton.ForeColor = SystemColors.ControlLightLight;
            refreshButton.Location = new Point(20, 268);
            refreshButton.Margin = new Padding(4);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(204, 74);
            refreshButton.TabIndex = 2;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.DarkRed;
            deleteButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            deleteButton.ForeColor = SystemColors.ControlLight;
            deleteButton.Location = new Point(20, 381);
            deleteButton.Margin = new Padding(4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(204, 74);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete Employee";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // paySalaryButton
            // 
            paySalaryButton.BackColor = Color.DarkSlateGray;
            paySalaryButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            paySalaryButton.ForeColor = SystemColors.ControlLightLight;
            paySalaryButton.Location = new Point(20, 494);
            paySalaryButton.Margin = new Padding(4);
            paySalaryButton.Name = "paySalaryButton";
            paySalaryButton.Size = new Size(204, 74);
            paySalaryButton.TabIndex = 4;
            paySalaryButton.Text = "Pay Salary";
            paySalaryButton.UseVisualStyleBackColor = false;
            paySalaryButton.Click += paySalaryButton_Click;
            // 
            // addSalaryInformationButton
            // 
            addSalaryInformationButton.BackColor = Color.Gray;
            addSalaryInformationButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            addSalaryInformationButton.ForeColor = SystemColors.ControlLightLight;
            addSalaryInformationButton.Location = new Point(20, 154);
            addSalaryInformationButton.Margin = new Padding(4);
            addSalaryInformationButton.Name = "addSalaryInformationButton";
            addSalaryInformationButton.Size = new Size(204, 74);
            addSalaryInformationButton.TabIndex = 5;
            addSalaryInformationButton.Text = "Add Salary Information";
            addSalaryInformationButton.UseVisualStyleBackColor = false;
            addSalaryInformationButton.Click += addSalaryInformationButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 28, 28);
            ClientSize = new Size(1331, 886);
            Controls.Add(addSalaryInformationButton);
            Controls.Add(paySalaryButton);
            Controls.Add(deleteButton);
            Controls.Add(refreshButton);
            Controls.Add(addButton);
            Controls.Add(employeeListView);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListView employeeListView;
        private Button addButton;
        private Button refreshButton;
        private Button deleteButton;
        private Button paySalaryButton;
        private ColumnHeader ID;
        private Button addSalaryInformationButton;
    }
}
