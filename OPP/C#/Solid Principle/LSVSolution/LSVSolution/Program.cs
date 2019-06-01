using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSVSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            ShouldNotChangeWidthIfHeightChanges(new Rectangle(50, 5));
         //   ShouldNotChangeWidthIfHeightChanges(new Square(5));
        }

        public static void ShouldNotChangeWidthIfHeightChanges(Rectangle r)
        {
            double before = r.GetWidth();
            r.SetHeight(10);
            double after = r.GetWidth();
            Console.WriteLine("{0}",before);
            Console.WriteLine("{0}", after);


        }
    }
}
