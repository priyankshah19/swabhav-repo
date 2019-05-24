using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism
{
    class Accountant : Employee
    {
        public Accountant(string name, int id, double basicsalary) : base(name, id, basicsalary)
        {

        }

        public override double TotalSalary()
        {

            double bonus = 0.20 * _basicsalary;
            double salary = bonus;
            return salary;
        }

        public override string SalaryDetails()

        {
            double bonus = 0.20 * _basicsalary;
            return ("SalaryDetails " + " " + "bonus: " + bonus);
        }

        public override string Role
        {
            get
            {
                return "Accountant";
            }
        }
    }
}
