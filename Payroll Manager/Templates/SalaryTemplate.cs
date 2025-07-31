namespace Payroll_Manager.Templates
{
    public class SalaryTemplate
    {

        public string EmployeeId { get; set; }
        public string RentAllowance { get; set; }
        public string MedicalAllowance { get; set; }
        public string EducationalAllowance { get; set; }
        public string FestivalBonus { get; set; }
        public string TelephoneAllowance { get; set; }

        public string BenevolentFund { get; set; }
        public string InsurancePremium { get; set; }
        public string ElectricityBill { get; set; }
        public string PensionFund { get; set; }
        public string IncomeTax { get; set; }

        public SalaryTemplate(string employeeId, string rentAllowance, string medicalAllowance, string educationalAllowance, 
                     string festivalBonus, string telephoneAllowance, string benevolentFund, 
                     string insurancePremium, string electricityBill, string pensionFund, string incomeTax)
        {
            EmployeeId = employeeId;
            RentAllowance = rentAllowance;
            MedicalAllowance = medicalAllowance;
            EducationalAllowance = educationalAllowance;
            FestivalBonus = festivalBonus;
            TelephoneAllowance = telephoneAllowance;
            BenevolentFund = benevolentFund;
            InsurancePremium = insurancePremium;
            ElectricityBill = electricityBill;
            PensionFund = pensionFund;
            IncomeTax = incomeTax;
        }
    }
}
