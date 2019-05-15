using System;
using System.Collections.Generic;
using System.Text;

namespace part4method2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;double y = 20;
            Console.WriteLine("before swap: x={0} & y={1}", x, y);
            Getsum(ref x, ref y);
            Console.WriteLine("Aftr swap: x={0} & y={1}",x,y);


            Console.WriteLine("1+2+3:{0}", Getmoresum(1, 2, 3));

        }

        static double Getsum(ref double x, ref double y)// passby reference here we will get value outside method also
        { 

            double temp = x;
            x = y;
            y = temp;
            return x + y;

        }

        static double Getmoresum(params double[] nums)// here we are passing value instead of variable
        {

            double sum = 0;
            foreach(int i in nums)
            {
                sum += i;
                return sum;
            }

        }
    }
}
