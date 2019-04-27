using System;
using System.Collections.Generic;
using System.Text;

namespace StudentApp
{
    public  class Student
    {
        private int rollno, age;
        private string name;
        private float cgpa;


        public Student(int rollno1,int age1,string name1,float cgpa1)
        {
            rollno = rollno1;
            age = age1;
            name = name1;
            cgpa = cgpa1;

        }
        public Student(int rollno2, string name2, float cgpa2)
        {
            rollno = rollno2;
            name = name2;
            cgpa = cgpa2;
           
        }
        public int GetRollno()
        {
            return rollno;
        }

        public int GetAge()
        {
            return age;
        }
        public string GetName()
        {
            return name;
        }

        public float Getcgpa()
        {
            return cgpa;
        }

     public float ConvertToCgpa()
        {
            float percentage;
            return percentage = cgpa * 9.5f;
        }
      

    }

}
