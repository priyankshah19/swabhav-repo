using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
            Casestudy2();
        }

        private static void Casestudy2()
        {
            List<OrderList> cart = new List<OrderList>();
            cart.Add(new OrderList("priyank", 1000, 1));
            cart.Add(new OrderList("priya", 3000, 3));
            cart.Add(new OrderList("ps", 3000, 2));
            foreach (OrderList items in cart)
            {
                Console.WriteLine(items);
                double finalcost = items.CalculateTotalCost();
                Console.WriteLine("Final Cost:{0}", finalcost);
            }
        }

        private static void CaseStudy1()
        {
            ArrayList cart = new ArrayList();
            cart.Add(new OrderList("priyank", 1000, 1));
            cart.Add(new OrderList("priya", 3000, 3));
            cart.Add(new OrderList("ps", 3000, 2));
            cart.Add("hi");
            foreach (Object items in cart)
            {
                Console.WriteLine((OrderList)items);
            }
        }
    }
}
