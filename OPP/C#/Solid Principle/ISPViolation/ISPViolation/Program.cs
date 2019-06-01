using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation
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
            AtTheCafeteria(robot1);
        }

        public static void AtTheCafeteria(IWorker w)
        {
            Console.WriteLine("At the Cafeteria");
            Console.WriteLine();
            w.StartEat();
            w.StopEat();
        }
        public static void AtTheWorkPlace(IWorker w)
        {
            Console.WriteLine("At the Workplace");
            Console.WriteLine();
            w.StartWork();
            w.StopWork();
        }
    }
}
