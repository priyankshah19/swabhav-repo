using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVViolation
{
    class Program
    {
        static void Main(string[] args)
        {
            ShouldNotChangeWidthIfHeightChange(new Rectangle(50, 5));
           // ShouldNotChangeWidthIfHeightChange(new Square(100));
        }
      public static void  ShouldNotChangeWidthIfHeightChange(Rectangle r)
        {
            int before = r.GetWidth();
            r.SetHeight(100);
            int after = r.GetWidth();
            Console.WriteLine("{0}",before);
            Console.WriteLine("{0}",after);

        }
    }
}
