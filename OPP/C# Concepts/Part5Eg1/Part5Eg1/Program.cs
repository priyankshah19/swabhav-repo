using System;
using System.Collections.Generic;
using System.Text;

namespace Part5Eg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1; //struct is user define type which allows you to have mutiple fields
            rect1.height = 100;
            rect1.width = 100;
            Console.WriteLine("area of rectangle is:{0}",rect1.Area());

            Rectangle rect2 = new Rectangle(10, 400); //creating rectangle 2
            rect1 = rect2; //if we store rect1 value in rect2 and then if we change value of rect1 then we when we print we will get inital value of rect1
            rect1.height = 600;
            Console.WriteLine("area of rectangle is:{0}", rect2.height);
            Console.ReadLine();
        }
        struct Rectangle // struct eg
        {
           public double height;
           public double width;
            public Rectangle(double h,double w) //constructor of struct
            {
                height = h;
                width = w; 
            }
            public double Area() //area method
            {
                double area = height * width;
                return area;
            }

        }
    }
}
