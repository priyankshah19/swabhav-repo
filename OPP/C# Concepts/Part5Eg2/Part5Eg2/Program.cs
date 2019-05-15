using System;
using System.Collections.Generic;
using System.Text;

namespace Part5Eg2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal fox = new Animal();
            {
                fox.name = "fox";
                fox.sound = "sssss";

            }
            Console.WriteLine("numof animal:{0}",Animal.getnumofanimal());
            fox.GetAnimal();
            Console.ReadLine();
        }
    }
}
