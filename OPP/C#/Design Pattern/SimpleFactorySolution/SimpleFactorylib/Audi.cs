﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibClient1
{
    class Audi:IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Audi started");
        }

        public void Stop()
        {
            Console.WriteLine("Audi stop");
        }
    }
}
