using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation
{
    class Robot : IWorker
    {
        public void StartEat()
        {
            throw new NotImplementedException("LSP Violation");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot started working");
        }

        public void StopEat()
        {
            throw new NotImplementedException("LSP Violation");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stopped working");
        }
    }
}
