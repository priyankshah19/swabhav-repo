using System;
using System.Collections.Generic;
using System.Text;

namespace Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 145;
            object o = i;
            int j = (int) o;
            i = 240;
            Console.WriteLine(i);
            Console.WriteLine(o);
            Console.WriteLine(j);
        }
    }
}
