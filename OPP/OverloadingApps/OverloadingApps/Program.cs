using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingApps
{
    class Program
    {

        static void Main(string[] args)
        {
            PrintThis(4);
            PrintThis('e');
            PrintThis(true);
            PrintThis(3.5);
            PrintThis("hello");
        }
        public static void PrintThis(int j)
        {
            Console.WriteLine("overload1" + j);

        }
        public static void PrintThis(char i)
        {
            Console.WriteLine("overload2" + i);


        }

        public static void PrintThis(Boolean x)
        {
            Console.WriteLine("overload3" + x);


        }

        public static void PrintThis(double y)
        {
            Console.WriteLine("overload4" + y);


        }
        public static void PrintThis(string s)
        {
            Console.WriteLine("overload6" + s);


        }


    }
}

    
