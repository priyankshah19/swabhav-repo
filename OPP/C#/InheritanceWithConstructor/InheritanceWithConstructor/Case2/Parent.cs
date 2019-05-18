using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceWithConstructor.Case2
{
    class Parent
    {
        public int foo;
        public Parent(int foo)
        {
            this.foo = foo;
            Console.WriteLine("ParentofFoo");
        }
        public int GetFoo()
        {
            return foo;
        }
    }
}
