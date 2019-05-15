using System;
using System.Collections.Generic;
using System.Text;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 120;
            object o = i;
            i = 146;
            Console.WriteLine(o);
            Console.WriteLine(i);
        }
    }
}
