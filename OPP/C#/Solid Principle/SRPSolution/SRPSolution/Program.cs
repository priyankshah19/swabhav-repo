﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice(1,"priyank",1000,0.5f,0.18f);
            InvoiceConsolePrinter consoleprinter = new InvoiceConsolePrinter();
            consoleprinter.Printinfo(invoice1);
        }
    }
}
