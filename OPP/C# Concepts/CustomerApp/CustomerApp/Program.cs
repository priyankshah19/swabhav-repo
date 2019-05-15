using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("meet", 500);
            
            Customer customer2 = new Customer("sachin", 20);
           

            Printinfo(customer2);
            Printinfo(customer1);
       //     Console.WriteLine("customer1 id:{0}",);
        }

        public static void Printinfo(Customer c)
        {
            Console.WriteLine("Customer name is: {0}",c.GetName);
            Console.WriteLine("Total orders: {0}", c.GetOrder);
            Console.WriteLine("Customer id is: {0}", c.GetId);
        }
    }
}
