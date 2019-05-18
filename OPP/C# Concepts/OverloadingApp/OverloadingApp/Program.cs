using System;
using System.Collections.Generic;
using System.Text;

namespace OverridingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account customer1 = new Account("meet", 1000, 1001);
            Account customer2 = new Account("meet", 1000, 1001);
           // Console.WriteLine(customer1);
            Console.WriteLine(customer1.ToString());

         //   Console.WriteLine(base.customer1.ToString());
          //  Console.WriteLine(customer1.GetHashCode());
          //  Console.WriteLine(customer2.GetHashCode());
           // Console.WriteLine(customer1==customer1);
       //     Console.WriteLine(customer2 == customer1);
          //  Console.WriteLine(customer1.Equals(customer2));


            Console.WriteLine();
        }
    }
}
