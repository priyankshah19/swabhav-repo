using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcyLib;
namespace CalculatorUsingLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcylib calculate = new Calcylib();
            long result = calculate.Add(-23, 12);
            Console.WriteLine(result);
        }
    }
}
