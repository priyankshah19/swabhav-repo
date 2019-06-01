using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixeddeposit = new FixedDeposit("priyank", 100000, 10, FixedDeposit.Festivaltype.Normal);
            PrintSimpleinterest printsimpleinterest = new PrintSimpleinterest();
            printsimpleinterest.Printinfo(fixeddeposit);
        }
    }
}
