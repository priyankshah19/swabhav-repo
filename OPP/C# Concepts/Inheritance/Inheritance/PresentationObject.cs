using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public void Copy()
        {
            Console.WriteLine("Object copied");
        }
        public void Dupilicate()
        {
            Console.WriteLine("object duplicate");
        }
    }
}
