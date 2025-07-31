using Payroll_Manager.TextFileHandlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_Manager
{
    public partial class SalaryInfoForm : Form
    {
        public SalaryInfoForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string employeeId = employeeIdInput.Text;
            string rentAllowance = rentAllowanceInput.Text;
            string medicalAllowance = medicalAllowanceInput.Text;
            string educationalAllowance = educationalAllowanceInput.Text;
            string festivalBonus = festivalBonusInput.Text;
            string telephoneAllowance = telephoneAllowanceInput.Text;
            string benevolentFund = benevolentFundInput.Text;
            string insurancePremium = insurancePremiumInput.Text;
            string electricityBill = electricityBillInput.Text;
            string pensionFund = pensionFundInput.Text;
            string incomeTax = incomeTaxInput.Text;

            
            HandleEmployeesFile handleEmployeesFile = new HandleEmployeesFile();
            if(handleEmployeesFile.getEmployeeById(employeeId) == null)
            {
                MessageBox.Show("Employee ID does not exist.");
                Close();
                return;
            }

            string salaryData = $"{employeeId},{rentAllowance},{medicalAllowance},{educationalAllowance},{festivalBonus},{telephoneAllowance},{benevolentFund},{insurancePremium},{electricityBill},{pensionFund},{incomeTax}";

            System.IO.File.AppendAllText("salary-info.txt", salaryData + Environment.NewLine);

            MessageBox.Show("Salary information saved successfully!");

            Close();
        }
    }
}
