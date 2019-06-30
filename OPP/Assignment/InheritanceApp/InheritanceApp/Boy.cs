using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Boy:Man
    {
        public override void Play()
        {
            Console.WriteLine("Boy is playing");
        }
        public void Run()
        {
            Console.WriteLine("boy is running");
        }
    }
}
