using System.Collections;
using Payroll_Manager.TextFileHandlers;
using Payroll_Manager.Templates;

namespace Payroll_Manager
{
    public partial class MainForm : Form
    {
        private ArrayList employees;
        private HandleEmployeesFile handleEmployeesFile;

        public MainForm()
        {
            InitializeComponent();
            employees = new ArrayList();
            handleEmployeesFile = new HandleEmployeesFile();


            employeeListView.View = View.Details;
            employeeListView.Columns.Add("ID", 80);
            employeeListView.Columns.Add("Name", 120);
            employeeListView.Columns.Add("Employee Type", 150);
            employeeListView.Columns.Add("Designation", 120);
            employeeListView.Columns.Add("Basic Salary", 100);
            employeeListView.Columns.Add("Phone", 100);
            employeeListView.Columns.Add("Present Address", 150);
            employeeListView.Columns.Add("Permanent Address", 150);
            employeeListView.Columns.Add("Gender", 80);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            employees.Clear();

            employees = handleEmployeesFile.getAllEmployees();

            employeeListView.Items.Clear();

            foreach (EmployeeTemplate emp in employees)
            {
                ListViewItem item = new ListViewItem(emp.Id);
                item.SubItems.Add(emp.Name);
                item.SubItems.Add(emp.EmpType);
                item.SubItems.Add(emp.Designation);
                item.SubItems.Add(emp.BasicSalary);
                item.SubItems.Add(emp.Phone);
                item.SubItems.Add(emp.PresentAddress);
                item.SubItems.Add(emp.PermanentAddress);
                item.SubItems.Add(emp.Gender);

                employeeListView.Items.Add(item);
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DeleteForm deleteForm = new DeleteForm();
            deleteForm.Show();
        }

        private void addSalaryInformationButton_Click(object sender, EventArgs e)
        {
            SalaryInfoForm salaryInfoForm = new SalaryInfoForm();
            salaryInfoForm.Show();
        }

        private void paySalaryButton_Click(object sender, EventArgs e)
        {
            ArrayList employees = handleEmployeesFile.getAllEmployees();
            if (employees.Count == 0)
            {
                MessageBox.Show("No employees found to pay salary.");
                return;
            }

            PaySalaryForm paySalaryForm = new PaySalaryForm();
            paySalaryForm.Show();
        }
    }
}
