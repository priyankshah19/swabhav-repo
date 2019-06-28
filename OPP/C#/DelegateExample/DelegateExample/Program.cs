using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    class Program
    {
       
        public delegate int Addoperation(int number1, int number2);
        static void Main(string[] args)
        {
            Addoperation add = new Addoperation(Operation.Add);
            add += Operation.Multipy;
            Console.WriteLine("{0}", add(1, 3));
            Console.WriteLine("{0}", add(2, 3));


        }
    }
}
