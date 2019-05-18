using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StudentArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ArrayList student = new ArrayList();
            student.Add("priyank");
            student.Add("meet");
            student.Add("kartik");
            foreach(var student1 in student)
            {
                Console.WriteLine("Student name is: {0}",student1);
            }

            student.Insert(2, "aakash");

            Console.WriteLine("After adding new student.updated list is");
            foreach(var student1 in student)
            {
                Console.WriteLine("student name is:{0}",student1);
            }

            student.Remove("aakash");
            student.RemoveAt(2);
            Console.WriteLine("After removing two student the updated list is");
            foreach (var student1 in student)
            {
                Console.WriteLine("student name is:{0}", student1);
            }

        }
    }
}
