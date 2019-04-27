using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice();
            Invoice invoice2 = new Invoice();
           
            invoice1.id = 12;
            invoice1.name = "priyank";
            invoice1.description = "Laptop";
            invoice1.cost = 12000;
            invoice1.tax = 1200;
            invoice1.discount = 20;
            double finalcost1=invoice1.CalculateTotalcost();
       
            invoice2.id = 12;
            invoice2.name = "priyank";
            invoice2.description = "Laptop";
            invoice2.cost = -12000;
            invoice2.tax = 1200;
            invoice2.discount = 20;
           double finalcost2 = invoice1.CalculateTotalcost();
            Program p = new Program();
           p.PrintDetails(invoice1);
           p.PrintDetails(invoice2);
            Invoice temp = invoice1;
            Console.WriteLine(temp.Get(cost))

        }

        public Invoice PrintDetails(Invoice inv)
        {
            Console.WriteLine("Customer id:{0}", inv.id);
            Console.WriteLine("Name:{0}", inv.name);
            Console.WriteLine("Description:{0}", inv.description);
            Console.WriteLine("Cost:{0}", inv.cost);
            Console.WriteLine("tax:{0}", inv.tax);
            Console.WriteLine("Discount:{0}", inv.discount);
            Console.WriteLine("Total cost of order 1:{0}", inv.CalculateTotalcost());
            return inv;
        }
  
        }

    }

