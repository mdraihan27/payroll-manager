using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Payroll_Manager.Templates;

namespace Payroll_Manager
{
    internal class HandleSalaryInfoFile
    {
        public SalaryTemplate getSalaryInfoById(string empId)
        {
            string[] lines = System.IO.File.ReadAllLines("salary-info.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');

                if (string.Equals(parts[0], empId))
                {

                    SalaryTemplate salaryTemplate = new SalaryTemplate
                    (
                        parts[0],
                        parts[1],
                        parts[2],
                        parts[3],
                        parts[4],
                        parts[5],
                        parts[6],
                        parts[7],
                        parts[8],
                        parts[9],
                        parts[10]
                    );

                    return salaryTemplate;
                   
                }
            }

            return null;
        }
    }
}
