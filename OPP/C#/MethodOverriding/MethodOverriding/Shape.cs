using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    class Shape
    {
      /*  public int width { get; set; }
        public int height { get; set; }
        public ShapeType type{ get; set; } */
        public  virtual void  Draw()
        {
            Console.WriteLine("Shape is not define");
            
        }
    }
}
