using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib;
namespace FactoryMethodLib
{
    class Tesla:IAutoMobile
    {
        public void Start()
        {
            Console.WriteLine("tesla started");
        }

        public void Stop()
        {
            Console.WriteLine("tesla stop");
        }
    }
}
