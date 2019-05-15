using System;
using System.Collections.Generic;
using System.Text;

namespace part4Method
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 4;
            double y = 5;
            Console.Write("sum:{0}", Getsum(x, y));//passby value -by default value are going to passed  in to function/method and not a refrence to variable.changes made to those values inside a method are not going to affect outside the method
            int solution;
            passbyvalue(15, out solution);
            Console.WriteLine("solution:{0}",solution);

            Console.ReadLine();
        }
        static double Getsum(double x=1,double y=2)// passby value here we will get sum as 9 changing the value in method will not affect value outside method 
        {
            
            
            double temp = x;
            x = y;
            y = temp;
            return x + y;

        }
        static void passbyvalue(int x,out int solution)
        {
            solution = x * 2;
        }
    }
}
