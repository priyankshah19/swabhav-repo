﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client();
            client1.CallAlgorithm();
        }
    }
}
