using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDesignPattern
{
    class Client
    {

        public IStraegy Straegy { get; set; }
        public void CallAlgorithm(IStraegy S)
        {
            Console.WriteLine("Name:{0}",Straegy.Algorithm());
        }
    }
}
