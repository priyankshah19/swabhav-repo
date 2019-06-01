using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolution
{
    class Robot : IWork
    {
        public void StartWork()
        {
            Console.WriteLine("Robot started working");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot stopped working");
        }

        
    }
}
