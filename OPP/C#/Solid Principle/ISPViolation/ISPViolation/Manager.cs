using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation
{
    class Manager : IWorker
    {
        public void StartEat()
        {
            Console.WriteLine("Manager Started Eating");
        }

        public void StartWork()
        {
            Console.WriteLine("Manager Started Working");
        }

        public void StopEat()
        {
            Console.WriteLine("Manager stopped Eating");
        }

        public void StopWork()
        {
            Console.WriteLine("Manager stopped Working");
        }
    }
}
