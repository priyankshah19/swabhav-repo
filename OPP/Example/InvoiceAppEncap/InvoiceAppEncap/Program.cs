using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceAppEncap
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice[] invoice = new Invoice[3];
            invoice[0] = new Invoice();
            invoice[1] = new Invoice();
            invoice[2] = new Invoice();
            Program p = new Program();
            invoice[0].SetId(12);
            invoice[0].SetName("priyank");
            invoice[0].SetDescription("Laptop");
            invoice[0].SetCost(120);
            invoice[0].SetTax(1200);
            invoice[0].SetDiscount(20);
            double finalcost0 = invoice[0].CalculateTotalcost();

            invoice[1].SetId(12);
            invoice[1].SetName("pr");
            invoice[1].SetDescription("Laptop123");
            invoice[1].SetCost(120000);
            invoice[1].SetTax(13000);
            invoice[1].SetDiscount(30);
            double finalcost1 = invoice[1].CalculateTotalcost();
            invoice[2].SetId(12);
            invoice[2].SetName("met");
            invoice[2].SetDescription("Laptop456");
            invoice[2].SetCost(15000);
            invoice[2].SetTax(1200);
            invoice[2].SetDiscount(10);
            double finalcost2 = invoice[2].CalculateTotalcost();


            PrintDetails(invoice[0]);
            PrintDetails(invoice[1]);
            PrintDetails(invoice[2]);
            double totalcost = invoice[0].GetCost() + invoice[1].GetCost() + invoice[2].GetCost();
            Console.WriteLine("Total cost of 3 items:{0}", totalcost);
            Console.WriteLine("Annonmyos class:"+new Invoice().GetCost());
            PrintDetails(new Invoice());

            /*     Invoice temp = invoice1;
                 Console.WriteLine(temp.GetCost());
                 Console.WriteLine(invoice1.GetCost());

                 temp.SetCost(5000);
                 Console.WriteLine(temp.GetCost());
                 Console.WriteLine(invoice1.GetCost());
       
            Invoice temp = invoice[0];
            temp = null;
            Console.WriteLine(invoice[0].GetCost());
            Console.WriteLine(temp.GetCost());
     */

        }
        public static Invoice PrintDetails(Invoice inv)
        {
            Console.WriteLine("Customer id:{0}", inv.GetId());
            Console.WriteLine("Name:{0}", inv.GetName());
            Console.WriteLine("Description:{0}", inv.GetDescription());
            Console.WriteLine("Cost:{0}", inv.GetCost());
            Console.WriteLine("tax:{0}", inv.GetTax());
            Console.WriteLine("Discount:{0}", inv.GetDiscount());
            Console.WriteLine("Total cost of order :{0}", inv.CalculateTotalcost());
            return inv;
        }
    }
}
