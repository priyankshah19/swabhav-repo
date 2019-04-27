using System;
using System.Collections.Generic;
using System.Text;
namespace InvoiceApp
{
    internal class Invoice
    {
        public int id;
        public string name, description;
        public double cost, tax;
        public float discount;
       
        public double CalculateTotalcost()
        {
            double totalcost=((cost+tax)-((cost/100)*(discount)));
            return totalcost;
        }
        

    }
}