using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    abstract class Test
    {
        public int add(int a,int b)
        {
            return a + b;
        }
        abstract public int multiple(int x, int y);
    }
}
