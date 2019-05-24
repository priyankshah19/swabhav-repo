using System;
using System.Collections.Generic;
using System.Text;

namespace College
{
    class Professor:Person,SalaryEmployee
    {
        
        private double _salary;

        public Professor(int id, string address, double dob, double salary):base(id,address,dob)
        {

            this._salary = salary;
        }

        public double Calculatesalary()
        {
            { return this._salary = _salary*100; } 

        }


       
        
    }
}
