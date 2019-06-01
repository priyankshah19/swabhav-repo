using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingKeyword
{
    class Account:IDisposable
    {
        public void Dispose()
        {
           
        }
        public void show()
        {
            Console.WriteLine("dispose");
        }
  
    }
}
