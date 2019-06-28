using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(new CardReader());
            computer.Load();
        }
    }
}
