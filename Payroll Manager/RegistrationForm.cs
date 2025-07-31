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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
            
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string id = idInput.Text;
            string empType = empTypeInput.Text;
            string name = nameInput.Text;
            string designation = designationInput.Text;
            string basicSalary = basicSalaryInput.Text;
            string presentAddress = presentAddressInput.Text;
            string permanentAddress = permanentAddressInput.Text;
            string phone = phoneInput.Text;
            string gender = genderComboBox.Text;

            HandleEmployeesFile handleEmployeesFile = new HandleEmployeesFile();
            if (handleEmployeesFile.getEmployeeById(id) != null)
            {
                MessageBox.Show("Employee ID already exists.");
                
            }

            string employeeData = $"{id},{name},{empType},{designation},{basicSalary},{phone},{presentAddress},{permanentAddress},{gender}";

            System.IO.File.AppendAllText("employees.txt", employeeData + Environment.NewLine);

            MessageBox.Show("Employee registered successfully!");

            Close();
        }
    }
}
