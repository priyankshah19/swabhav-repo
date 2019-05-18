using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Father father = new Father();

            Mother mother = father;
            mother.Foo();

            Child child = father;
            child.Foo();

        }
    }
}
