using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountPublisherLib;
namespace AccountPublisher
{
    class EmailNotifer : IBalanceChangeNotifer
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Hello" + " " + account.Name + " " + "Updated balance is sent on your mail");
        }
    }
}
