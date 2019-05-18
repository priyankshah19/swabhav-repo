using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();
            // CaseStudy2();
            //  CaseStudy3();
            Casestudy4();
        }
        public static void CaseStudy1()
        {
            Man man;
            man = new Man();
            man.Play();
            man.Eat();

        }

        public static void CaseStudy2()
        {
            Boy boy;
            boy = new Boy();
            boy.Play();
            boy.Walk();
            boy.Eat();
            boy.Run();
        }
        public static void CaseStudy3()
        {
            Man x;
            x = new Boy();
            x.Play();
            x.Eat();
        }
        public static void Casestudy4()
        {
            ThePark(new Man());
            ThePark(new Boy());
            ThePark(new Kid());
            ThePark(new Infant());

        }

        private static void ThePark(Man man)
        {
            Console.WriteLine("At the park");
            man.Play();
        }

        private static void ThePark(Boy boy)
        {
            Console.WriteLine("At the park");
            boy.Play();
        }

        private static void ThePark(Kid kid)
        {
            Console.WriteLine("At the park");
            kid.Play();
        }

        private static void ThePark(Infant infant)
        {
            Console.WriteLine("At the park");
            infant.Play();
        }
    }
}




