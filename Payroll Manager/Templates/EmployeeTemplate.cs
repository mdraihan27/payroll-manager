namespace Payroll_Manager.Templates
{
    public class EmployeeTemplate
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string EmpType { get; set; }
        public string Designation { get; set; }
        public string BasicSalary { get; set; }
        public string PresentAddress { get; set; }
        public string PermanentAddress { get; set; }
        public string Phone { get; set; }

        public string Gender { get; set; }

        public EmployeeTemplate(string id, string name, string empType, string designation, string basicSalary, string phone, string presentAddress, string permanentAddress, string gender)
        {
            Id = id;
            EmpType = empType;
            Name = name;
            Designation = designation;
            BasicSalary = basicSalary;
            PresentAddress = presentAddress;
            PermanentAddress = permanentAddress;
            Gender = gender;
            Phone = phone;
        }
    }
}
