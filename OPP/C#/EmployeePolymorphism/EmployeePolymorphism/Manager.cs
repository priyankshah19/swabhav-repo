using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism
{
    class Manager : Employee
    {
        public Manager(string name, int id, double basicsalary) : base(name, id, basicsalary)
        {

        }

        public override double TotalSalary()
        {
            double hra = 0.50 * _basicsalary;
            double performance = 0.40 * _basicsalary;
            double overttime = 0.30 * _basicsalary;
            double salary = hra + performance + overttime;
            return salary;
        }

        public override string SalaryDetails()

        {
            double hra = 0.50 * _basicsalary;
            double performance = 0.40 * _basicsalary;
            double overttime = 0.30 * _basicsalary;
            double salary = hra + performance + overttime;
            return ("SalaryDetails: "+" " + "hra: " + hra+" " +"performance: " + performance + " " + "Overtime: " + overttime);
        }

        public override string Role
        {
            get
            {
                return "manager";
            }
        }
    }
}
