using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
          int number1 = Int32.Parse(args[0]);
            
           int number2 = Int32.Parse(args[1]);
            int result = number1 / number2;
            Console.WriteLine("Result is:{0}",result);
           // Main(new string[] { "hii", "hello" });
             Main(args);
        }

        
    }
}
