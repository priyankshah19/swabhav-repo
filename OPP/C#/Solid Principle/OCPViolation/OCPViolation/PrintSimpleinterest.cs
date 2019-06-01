using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolation
{
    class PrintSimpleinterest
    {
        public void Printinfo(FixedDeposit f)
        {
            Console.WriteLine("Name:{0}", f.Name);
            Console.WriteLine("Principal Amount:{0}", f.PrincipalAmount);
            Console.WriteLine("Simple Interest:{0}",f.CalculateSimpleInterest());
        }
    }
}
