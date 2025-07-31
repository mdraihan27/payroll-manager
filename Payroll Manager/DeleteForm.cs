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
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string employeeID = employeeIdInput.Text;

            HandleEmployeesFile handleEmployeesFile = new HandleEmployeesFile();

            bool isDeleted = handleEmployeesFile.deleteEmployeeById(employeeID);

            if (isDeleted)
            {
                MessageBox.Show("Employee Deleted");
                Close();
            }
            else
            {
                MessageBox.Show("Employee Does Not Exist");

            }


        }
    }
}
