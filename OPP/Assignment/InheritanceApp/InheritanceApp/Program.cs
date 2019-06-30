using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy4();
            Console.ReadLine();
        }

        private static void CaseStudy1()
        {
            Man x = new Man();
            x.Play();
            x.Eat();
        }
        private static void Casestudy2()
        {
            Boy y = new Boy();
            y.Play();
            y.Run();
        }
        private static void Casestudy3()
        {
            Man x = new Boy();
            x.Play();
            x.Eat();
        }
        private static void CaseStudy4()
        {
            AtthePark(new Man());
            AtthePark(new Boy());
            AtthePark(new Kid());
        }
        private static void AtthePark( Man x)
        {
            Console.WriteLine(" at the park");
            x.Play();
        }
    }
}
