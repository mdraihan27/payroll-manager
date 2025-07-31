using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll_Manager.Templates;

namespace Payroll_Manager
{
    internal class HandleSalaryFile
    {
        public void writeEmployeeSalary(string employeeId, string employeeName, string basicSalary)
        {

            HandleSalaryInfoFile handleSalaryInfoFile = new HandleSalaryInfoFile();
            SalaryTemplate salary = handleSalaryInfoFile.getSalaryInfoById(employeeId);
            
            int basic = int.Parse(basicSalary);
            int totalAllowances = int.Parse(salary.RentAllowance) + int.Parse(salary.MedicalAllowance) + 
                                 int.Parse(salary.EducationalAllowance) + int.Parse(salary.FestivalBonus) + 
                                 int.Parse(salary.TelephoneAllowance);
            
            int totalDeductions = int.Parse(salary.BenevolentFund) + int.Parse(salary.InsurancePremium) + 
                                 int.Parse(salary.ElectricityBill) + int.Parse(salary.PensionFund) + 
                                 int.Parse(salary.IncomeTax);
            
            int finalSalary = basic + totalAllowances - totalDeductions;
            
            StringBuilder salaryData = new StringBuilder();
            salaryData.AppendLine("");
            salaryData.AppendLine($"Name: {employeeName} ID: {employeeId}");
            salaryData.AppendLine($"Basic Salary: {basicSalary}");
            salaryData.AppendLine("");
            salaryData.AppendLine("Allowances:");
            salaryData.AppendLine($"Rent Allowance: {salary.RentAllowance}");
            salaryData.AppendLine($"Medical Allowance: {salary.MedicalAllowance}");
            salaryData.AppendLine($"Educational Allowance: {salary.EducationalAllowance}");
            salaryData.AppendLine($"Festival Bonus: {salary.FestivalBonus}");
            salaryData.AppendLine($"Telephone Allowance: {salary.TelephoneAllowance}");
            salaryData.AppendLine($"Total Allowances: {totalAllowances}");
            salaryData.AppendLine("");
            salaryData.AppendLine("Deductions:");
            salaryData.AppendLine($"Benevolent Fund: {salary.BenevolentFund}");
            salaryData.AppendLine($"Insurance Premium: {salary.InsurancePremium}");
            salaryData.AppendLine($"Electricity Bill: {salary.ElectricityBill}");
            salaryData.AppendLine($"Pension Fund: {salary.PensionFund}");
            salaryData.AppendLine($"Income Tax: {salary.IncomeTax}");
            salaryData.AppendLine($"Total Deductions: {totalDeductions}");
            salaryData.AppendLine("");
            salaryData.AppendLine($"Final Salary: {finalSalary}");
            salaryData.AppendLine("");
            salaryData.AppendLine("-------------------");
            
            System.IO.File.AppendAllText("salary.txt", salaryData.ToString());
        }
    }
}
