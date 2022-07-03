using System;

namespace SalarySlip
{
    class Program
    {
        static void Main(string[] args)
        {
            string designation;
            Console.Write("Enter Your designation (engineer,manager,analyst): ");

            designation = Console.ReadLine();
            Console.WriteLine(designation+" gross salary is: "+GetSalarySlip(designation));

        }
        public static double GetSalarySlip(string designation)
        {
            double Salary=0;
            switch (designation.ToLower())
            {
                case "engineer":
                    Engineer eng = new Engineer();
                    Salary = eng.CalculateSalary();
                    break;

                    case "manager":
                    Manger mng = new Manger();
                    Salary = mng.CalculateSalary();
                    break;

                    case "analyst":
                    Analyst ans = new Analyst();
                    Salary = ans.CalculateSalary();
                    break;

            }
            return Salary;
        }
    }
}
