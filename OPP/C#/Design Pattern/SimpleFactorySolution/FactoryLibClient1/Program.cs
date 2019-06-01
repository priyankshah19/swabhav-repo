using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactorylib;
namespace FactoryLibClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  AutomobileFactory factory = new AutomobileFactory();
            AutomobileFactory factory = AutomobileFactory.Getinstance(); //for singleton
            IAutoMobile auto = factory.Make(AutomobileFactory.AutoType.BMW);
            Console.WriteLine(auto.GetType());
            auto.Start();
            auto.Stop();
        }
    }
}
