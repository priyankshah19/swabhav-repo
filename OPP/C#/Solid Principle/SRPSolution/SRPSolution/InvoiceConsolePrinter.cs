using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolution
{
    class InvoiceConsolePrinter
    {
        public void Printinfo(Invoice invoice)
        {
            Console.WriteLine("Name:{0}",invoice.Name);
            Console.WriteLine("Invoice Id:{0}",invoice.InvoiceNo);
            Console.WriteLine("Cost:{0}",invoice.Cost);
            Console.WriteLine("Discount:{0}",invoice.CalculateDiscount());
            Console.WriteLine("GSt:{0}", invoice.CalculateGst());
            Console.WriteLine("Total Cost:{0}", invoice.TotalCost());
        }
    }
}
