using System;
using System.Collections;
using System.Collections.Generic;

namespace CodeMagnet6
{
    class Program
    {
        static void Main(string[] args)
        {
           
            ArrayList a = new ArrayList();
            a.Insert(0, "zero");
            a.Insert(1, "one");
            a.Insert(2,"two");
      
            if (a.Contains("two"))
            {
                a.Insert(3,"four");
            }
            a.Remove(1);
           
            if(a.Contains("four"))
            {
                a.Insert(4, "4.2");
            }
        
            foreach(string number in a)
            {
                Console.WriteLine(number);
            }

        }
    }
}
