using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager1 = new Manager();
            Robot robot1 = new Robot();
            AtTheCafeteria(manager1);
            AtTheWorkPlace(manager1);
            AtTheWorkPlace(robot1);

        }

        private static void AtTheCafeteria(IWorkEat w)
        {
            Console.WriteLine("At the Cafeteria");

            w.StartEat();
            w.StopEat();
            Console.WriteLine();
        }
        private static void AtTheWorkPlace(IWork w)
        {
            Console.WriteLine("At the Workplace");

            w.StartWork();
            w.StopWork();
            Console.WriteLine();
        }


    }
}
