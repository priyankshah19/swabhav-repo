using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismApp
{
   
    class Program
    {
        static void Main(string[] args)
        {
            AccountDetails customer1 = new SavingsAccount("Priyank",1001,1000.2);
            AccountDetails customer2 = new CurrentAccount("Priyank", 1001, 100.2);
            Printinfo(customer2);
            customer2.Deposit(100);
      
            Printinfo(customer2);
             customer2.Withdraw(7000);
            Printinfo(customer2);

        }

        public static void Printinfo(AccountDetails acc)
        {
            Console.WriteLine("Name:{0}",acc.GetName);
            Console.WriteLine("Account Number:{0}", acc.GetAccountNumber);
            Console.WriteLine("Balance:{0}", acc.GetBalance);
        }
    }
}
