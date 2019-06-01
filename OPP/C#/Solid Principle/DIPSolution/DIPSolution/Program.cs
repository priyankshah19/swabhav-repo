using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator calc = new TaxCalculator(new DBLogger());
            Console.WriteLine("{0}",calc.CalculateTax(10, 0));
        }
    }
}
