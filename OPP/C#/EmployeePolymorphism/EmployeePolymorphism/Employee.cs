using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism
{
    public abstract class Employee
    {
        protected string _employeename;
        protected int _employeeno;
        protected double _basicsalary;

        public Employee(string employeename, int employeeno, double basicsalary)
        {
            this._employeename = employeename;
            this._employeeno = employeeno;
            this._basicsalary = basicsalary;
        }

        public string Name { get { return _employeename; } }
        public int Id { get { return _employeeno; } }
        public double Basicsalary { get { return _basicsalary; } }

        public abstract double TotalSalary();
        public abstract string SalaryDetails();
        public abstract string Role { get;  }

    }
}
