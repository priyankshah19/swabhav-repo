using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee manager = new Manager("priyank", 1001,10000);
            PrintSalarySlip(manager);
            
            Employee programmer = new Programmer("meet", 1002, 10000);
            PrintSalarySlip(programmer);
            
            Employee accountant = new Accountant("aakash", 1003, 10000);
            PrintSalarySlip(accountant);
         
        }

        public static void PrintSalarySlip(Employee employee)
        {
            Console.WriteLine("Name:{0}",employee.Name);
            Console.WriteLine("Employee Id:{0}",employee.Id);
        //    Console.WriteLine("Role of Employee:{0}",employee.GetType().Name);
            Console.WriteLine("Total Salary:{0}",employee.TotalSalary());
            Console.WriteLine(employee.SalaryDetails());
            Console.WriteLine("Role of Employee:{0}", employee.Role);
        }
    }
}
