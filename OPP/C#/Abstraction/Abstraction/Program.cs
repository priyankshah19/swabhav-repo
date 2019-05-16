using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Printinfo();
           

        }
        public static void Printinfo()
        {
            Test1 test1 = new Test1();
            Test2 test2 = new Test2();
            int addresult1 = test1.add(6, 7);
            int muiltpleresult1 = test1.multiple(3, 6);
            int muiltpleresult2 = test2.multiple(6, 6);

            Console.WriteLine("Addition is: {0}",addresult1);
            Console.WriteLine("Mutiplication of Test1 is: {0}", muiltpleresult1);
            Console.WriteLine("Multiplication of Test2 is: {0}", muiltpleresult2);
        }
    }
}
