namespace SalaryLibrary
{
    public class Employee
    {
        public string EmployeeName { get; set; }
        public string EmployeeID { get; set; }
        public double BasicSalary { get; set; }
        public double Allowance { get; set; }
        public double Deduction { get; set; }

        public double CalculateGrossSalary()
        {
            return (BasicSalary + Allowance);
        }

        public double CalculateTax()
        {
            double gross = CalculateGrossSalary();
            double rate;

            if (gross <= 20000)
                rate = 0.05;
            else if (gross <= 40000)
                rate = 0.10;
            else if (gross <= 6000)
                rate = 0.15;
            else
                rate = 0.20;

            return gross * rate;
        }

        public double CalculateNetSalary()
        {
            return (CalculateGrossSalary() - CalculateTax() - Deduction);
        }

        public string GetSalaryGrade()
        {
            if (BasicSalary <= 15000) return "Grade 1";
            else if (BasicSalary <= 25000) return "Grade 2";
            else if (BasicSalary <= 40000) return "Grade 3";
            else return "Grade 4";
        }
    }
}   
