using System;
using System.Collections.Generic;
using System.Text;
namespace InvoiceAppEncap
{
    internal class Invoice
    {
        private int id;
        private string name;
        private string description;
        private double cost, tax;
        private float discount;

        public void SetId(int id1)
        {
            id=id1;
        }
        public int GetId()
        {
            return id;
        }

        public void SetName(string name1)
        {
            name=name1;
        }
        public string GetName()
        {
            return name ;
        }

        public void SetDescription(string desc)
        {
            description=desc;
        }
        public string GetDescription()
        {
            return name;
        }

        public void SetCost(double cost1)
        {
              if (cost1 > 0)
              {
                  cost = cost1;
              }
              else
              {
                  Console.WriteLine("cost cannot be zero");
              }
             
         //   cost = cost1;
        }
        public double GetCost()
        {
            
                return cost;
            
        }
        public void SetTax(double tax1)
        {
            tax = tax1;
        }
        public double GetTax()
        {

            return tax;

        }
        public void SetDiscount(float discount1)
        {
            discount = discount1;
        }
        public double GetDiscount()
        {

            return discount;

        }

        public double CalculateTotalcost()
        {
            double totalcost = ((cost + tax) - ((cost / 100) * (discount)));
            return totalcost;
        }
        


    }


}
