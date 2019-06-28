using Subscriber.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(1001, "Priyank", 1000);
            account.BalanceChangeEvent += SendEmail;
            account.BalanceChangeEvent += SendSMS;
            account.Deposit(100);
        }
        private static void SendEmail(Account account)
        {
            Console.WriteLine("Hi {0} Email has been sent", account.GetName);
        }
        private static void SendSMS(Account account)
        {
            Console.WriteLine("Hi {0} SMS has been sent", account.GetName);
        }
    }
}
