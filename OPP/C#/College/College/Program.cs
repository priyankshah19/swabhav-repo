using System;
using System.Collections.Generic;
using System.Text;

namespace College
{
    class Program
    {
        static void Main(string[] args)
        {

            Student p = new Student(1001, "spx", 02312012,Student.Branch1.civil);
            Console.WriteLine("ID:{0}",p.Id);
            Console.WriteLine("DOB:{0}", p.dob);
            Console.WriteLine("ADDRESS:{0}", p.address);
            Console.WriteLine("BRANCH:{0}", p.Branch);
            Professor ps = new Professor(100, "skaad", 120110, 1000);
            Console.WriteLine("ID:{0}",ps.Id);
            Console.WriteLine("DOB:{0}", ps.dob);
            Console.WriteLine("ADDRESS:{0}", ps.address);
            Console.WriteLine("Salary:{0}", ps.Calculatesalary()); 
         
        }
        
    }
}
