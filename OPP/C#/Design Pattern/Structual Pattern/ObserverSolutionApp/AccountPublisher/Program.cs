using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPublisherLib;
namespace AccountPublisher
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Priyank", 1001, "ps@gmail.com", 9876543211, 12000);
            account1.RegisterNotifer(new EmailNotifer());
            account1.RegisterNotifer(new SmsNotifer());
            Console.WriteLine("Updated balance after Deposit:{0}",account1.Deposit(100));
            Console.WriteLine("Updated balance after WithDrawal:{0}", account1.WithDraw(100));
        }
    }
}
