using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeMagnet6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ArrayList<String> a = new ArrayList();
            a.Add(0, "zero");
            a.Add(1, "one");
            a.Add(2,"two");
            Console.WriteLine(a);
            if (a.Contains("two"))
            {
                a.Add("four");
            }
            a.Remove(1);
            Console.WriteLine(a);
            if(a.Indexof("four")!=4)
            {
                a.Add(4, "4.2");
            }
            Console.WriteLine(a);

        }
    }
}
