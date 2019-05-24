using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism
{
    class Programmer :Employee
    {
        public Programmer(string name, int id, double basicsalary) :base(name,id,basicsalary)
        {

        }

        public override double TotalSalary()
        {

            double performance = 0.40 * _basicsalary;
            double salary = performance;
            return salary;
        }

        public override string SalaryDetails()

        {
            double performance = 0.40 * _basicsalary;
            return ("SalaryDetails " + " " + "performance: " + performance);
        }

        public override string Role
        {
            get
            {
                return "programmer";
            }
        }
    }
}
