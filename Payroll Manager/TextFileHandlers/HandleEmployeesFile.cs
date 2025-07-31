using Payroll_Manager.Templates;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll_Manager.TextFileHandlers
{
    internal class HandleEmployeesFile
    {
        public ArrayList getAllEmployees()
        {

            ArrayList employees = new ArrayList();

            string[] lines = File.ReadAllLines("employees.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                EmployeeTemplate employee = new EmployeeTemplate(
                    parts[0],
                    parts[1],
                    parts[2],
                    parts[3],
                    parts[4],
                    parts[5],
                    parts[6],
                    parts[7],
                    parts[8]
                );

                employees.Add(employee);
            }

            return employees;
        }

        public EmployeeTemplate getEmployeeById(string id)
        {

            ArrayList employees = new ArrayList();

            string[] lines = File.ReadAllLines("employees.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');



                if (string.Equals(parts[0], id))
                {
                    EmployeeTemplate employee = new EmployeeTemplate(
                       parts[0],
                       parts[1],
                       parts[2],
                       parts[3],
                       parts[4],
                       parts[5],
                       parts[6],
                       parts[7],
                       parts[8]
                   );

                    return employee;

                }
            }

            return null;

            
        }

        public bool deleteEmployeeById(string id)
        {
            string[] lines = File.ReadAllLines("employees.txt");
            List<string> updatedLines = new List<string>();
            bool employeeFound = false;

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (!string.Equals(parts[0], id))
                {
                    updatedLines.Add(line);
                }
                else
                {
                    employeeFound = true;
                }
            }

            if (employeeFound)
            {
                File.WriteAllLines("employees.txt", updatedLines);
            }

            return employeeFound;
        }
    }
}
