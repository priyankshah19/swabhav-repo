using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixeddeposit = new FixedDeposit("priyank", 100000, 10, new NormalRate());
            PrintSimpleinterest printsimpleinterest = new PrintSimpleinterest();
            printsimpleinterest.Printinfo(fixeddeposit);
        }
    }
}
