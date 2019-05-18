using System;
using System.Collections.Generic;
using System.Text;

namespace InheritancApp
{
    class Infant: Man
    {
        public override void Play()
        {
            Console.WriteLine("Infant is playing");
        }
    }
}
