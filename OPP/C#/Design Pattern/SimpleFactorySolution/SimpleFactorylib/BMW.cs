using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibClient1
{
    class BMW : IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("BMW started");
        }

        public void Stop()
        {
            Console.WriteLine("BMW stop");
        }
    }

}
