using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibClient1
{
    class Tesla:IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("Tesla started");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla stop");
        }
    }
}
