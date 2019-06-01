using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DataServices services1 = DataServices.Getinstance();
            DataServices services2 = DataServices.Getinstance();
            services1.DoSomething();
            services2.DoSomething();
            Console.WriteLine("{0}", services1.GetHashCode());
            Console.WriteLine("{0}", services2.GetHashCode());
        }
    }
}
