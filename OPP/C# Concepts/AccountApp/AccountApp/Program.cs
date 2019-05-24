using System;
using System.Collections.Generic;
using System.Text;
using AccountApp.Business;
namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account priyank = new Account(1001, "priyank");
            Account meet = new Account(1002, "meet", 1000.0);
            InsufficientException excep = new InsufficientException(meet);

            //  Printinfo(priyank);
            Printinfo(meet);
            //   priyank.Deposit(700);
            // priyank.WithDraw(300);
            meet.Deposit(300);
            try
            {

                meet.WithDraw(1000);
            }

            catch (InsufficientException e)
            {

                Console.WriteLine("Exception: {0}", e.Message);
                Console.WriteLine("Your Current Balance is {0} ", e.Account1.Balance);
            }

            //Printinfo(priyank);
            // Printinfo(meet);

        }
        private static void Printinfo(Account account)
        {
            Console.WriteLine("Account number:{0}", account.Accountnumber);
            Console.WriteLine("Name:{0}", account.Name);
            Console.WriteLine("Current Balance:{0}", account.Balance);
            Console.WriteLine("\n");
        }
    }
}
