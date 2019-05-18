using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceWithConstructor.Case1
{
    class Child : Parent
    {
        public Child():base()
        {
            Console.WriteLine("Child");
        }
    }
}
