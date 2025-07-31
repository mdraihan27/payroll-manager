using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Payroll_Manager.Templates;
using Payroll_Manager.TextFileHandlers;

namespace Payroll_Manager
{
    public partial class PaySalaryForm : Form
    {
        public PaySalaryForm()
        {
            InitializeComponent();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            string month = monthInput.Text;
            string year = yearInput.Text;

            HandleEmployeesFile handleEmployeesFile = new HandleEmployeesFile();
            ArrayList employees = handleEmployeesFile.getAllEmployees();

            if (employees.Count == 0)
            {
                MessageBox.Show("No employees found.");
                return;
            }

            HandleSalaryFile handleSalaryFile = new HandleSalaryFile();

            StringBuilder text = new StringBuilder();
            text.AppendLine("");
            text.AppendLine("---------------");
            text.AppendLine($"Salary Payment for {month}, {year}");
            text.AppendLine("---------------");
            System.IO.File.AppendAllText("salary.txt", text.ToString());
            foreach (EmployeeTemplate employee in employees)
            {
                handleSalaryFile.writeEmployeeSalary(employee.Id, employee.Name, employee.BasicSalary);
            }

            Close();

            
        }
    }
}
