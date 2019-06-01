using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib;
namespace FactoryMethodClient
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutomobileFactory fact = BMWFactory.GetInstance();
            IAutoMobile auto = fact.Make();
            auto.Start();
            auto.Stop();

            
        }
    }
}
