using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            float percentage;
            float highestcgpa = 0;
            string name="";
          
            Student[] students = new Student[3];
            students[0] = new Student(1, 18, "ps", 8.2f);
             students[1]  = new Student(2, 18, "dsds", 9.2f);
             students[2] = new Student(3,  "priyank", 10);
     
            foreach(Student student in students)
            {
                Console.WriteLine("Rollno:{0}",student.GetRollno());
                Console.WriteLine("Age:{0}",student.GetAge());
                Console.WriteLine("Name:{0}",student.GetName());
                Console.WriteLine("cgpa:{0}", student.Getcgpa());
                Console.WriteLine("Percentage:{0}",student.ConvertToCgpa());
               
        
            
                if (student.Getcgpa()>highestcgpa)
                {
                    highestcgpa = student.Getcgpa();
                    name = student.GetName();
                }

            }
            Console.WriteLine("Topper:{0}",name);
            Console.WriteLine("Highest Cgpa:{0}",highestcgpa);
        }
    }
}
