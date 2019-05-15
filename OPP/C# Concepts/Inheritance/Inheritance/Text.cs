using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Text : PresentationObject   // : is similar to Extend in java
    {
        public int Fontsize { get; set; }
            public void Add(string name)
        {
            Console.WriteLine("hi your name is  {0}",name);
        }
    }
}
