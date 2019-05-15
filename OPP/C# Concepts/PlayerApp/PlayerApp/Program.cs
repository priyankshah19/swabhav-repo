using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CaseStudy1();

        }

        private static void CaseStudy1()
        {



            Player sachin = new Player("sachin", 101, 102);
            Printinfo(sachin);
            Player sehwag = new Player("Sehwag", 10);
            Printinfo(sehwag);
           Player sg = new Player("Sehwag", 101, 104);
           Printinfo(sg);
            Player elder = sachin.WhoisElder(sehwag);
            Console.WriteLine("Elder player is: {0}", elder.Name);
           int c= Player.GetCount();
            Console.WriteLine(" player is: {0}", c);
 
        }

        public static void Printinfo(Player player)
        {
            Console.WriteLine("Name:{0}", player.Name);
            Console.WriteLine("Age:{0}", player.Age);
            Console.WriteLine("ID:{0}", player.Id);
          //  Console.WriteLine("Count:{0}", p.GetCount);

        }


    }
}
