namespace SalarySlip
{
    class Employee
    {
        public double BaseSalary { get; set; }
        public double MedicalAllowance { get; set; }
        public double FuelAdjustment { get; set; }
        public Employee()
        {
            BaseSalary = 1500;
        }
        public virtual double CalculateSalary()
        {
            return BaseSalary+MedicalAllowance+FuelAdjustment;
        }

    }
}
