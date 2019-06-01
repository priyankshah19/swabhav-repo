using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            using (account)
            {
               
                account.show();
            }
        }
    }
}
