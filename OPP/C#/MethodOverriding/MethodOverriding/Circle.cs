using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
   class Circle :Shape
    {
        public override void Draw()
        {
            Console.WriteLine("This is Circle");
        }
    }
}
