using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceWithConstructor.Case2
{
    class Child :Parent
    {
        public Child() : base(100)
        {
            Console.WriteLine("ChildofFoo");
        }
        public Child(int foo):base(foo)
        {
            Console.WriteLine("child");
        }
    }
}
