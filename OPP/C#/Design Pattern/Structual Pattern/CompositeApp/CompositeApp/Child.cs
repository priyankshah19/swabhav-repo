using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeApp
{
    class Child : IEatable
    {
        public void Eat()
        {
            Console.WriteLine("Childis eating");
        }
    }
}
