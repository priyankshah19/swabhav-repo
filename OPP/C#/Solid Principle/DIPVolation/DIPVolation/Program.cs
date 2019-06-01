using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPVolation
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator(TaxCalculator.LogType.FILE);
            Console.WriteLine("{0}", calc.CalculateTax(20,0)); 
        }
    }
}
