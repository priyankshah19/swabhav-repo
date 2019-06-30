using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new SavingAccount(1,"priyank",300);
            Console.WriteLine("inital Balance: {0}",a.GetBalance);
            a.Deposit(300);
            Console.WriteLine(a.GetBalance);
            a.WithDraw(50);
            Console.WriteLine(a.GetBalance);
            Console.ReadLine();
        }
    }
}
