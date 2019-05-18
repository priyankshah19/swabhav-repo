using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StudentArrayListUsingSwitchCase
{
    class Student
    {

        ArrayList student = new ArrayList();

        public void Menu()
        {
            Console.WriteLine("enter option");
            Console.WriteLine("1 to Add");
            Console.WriteLine("2 to insert");
            Console.WriteLine("3 to delete");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("you can add student");
                    student.Add(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("You can insert student");
                    student.Insert(1, Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("You can delete student");
                    student.Remove(Console.ReadLine());
                    break;
            }
            
            Console.WriteLine("if you want to continue then press m Or to exit press any key");
            string press = Console.ReadLine();
            if(press=="m")
            {
                Menu();
            }
            else
            {
                Console.WriteLine("Below is the student list:");
                foreach (var student1 in student)
                {
                    Console.WriteLine(student1);
                    
                }
            }
        }

    }
}
