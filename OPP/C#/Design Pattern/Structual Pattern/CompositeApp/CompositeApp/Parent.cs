using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeApp
{
    class Parent : IEatable, IWorkable
    {
        public void Eat()
        {
            Console.WriteLine("Parent is Eating");
        }

        public void Work()
        {
            Console.WriteLine("Parent is working");
        }
    }
}
