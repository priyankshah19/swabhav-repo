using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancApp
{
    class Boy :Man
    {
       public override void  Play()                      
        {
            Console.WriteLine("Boy is playing");
        }

        public void Walk()
        {
            Console.WriteLine("Boy is Walking");
        }
        public void Run()
        {
            Console.WriteLine("Boy is running");
        }
    }
}
