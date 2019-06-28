using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            try
            {
               long result = cal.Add(-9, 10);


                Console.WriteLine("Addition is:{0}",result );
            }
            catch(NegativeNumberNotSupported e)
            {
                Console.WriteLine("Exception: {0}",e.Message);
            }
            
        }
    }
}
