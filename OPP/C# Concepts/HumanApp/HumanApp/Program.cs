using System;
using System.Collections.Generic;
using System.Text;

namespace HumanApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Human priyank = new Human("priyank", 22, 5.3f, 48, Genderoption.MALE);
            Human meet = new Human("meet", 23, 5.6f, 48, Genderoption.MALE);
           
            Printinfo(priyank);
            Printinfo(meet);
            priyank.Eat();
            Printinfo(priyank);
        }
        private static void  Printinfo(Human human)
        {
            Console.WriteLine("Name: {0}",human.Name);
            Console.WriteLine("Age: {0}",human.Age);
            Console.WriteLine("Height: {0}",human.Height);
            Console.WriteLine("Weight: {0}",human.Weight);
            Console.WriteLine("Gender: {0}",human.Gender);
            Console.ReadLine();
        }
       
    }
}
