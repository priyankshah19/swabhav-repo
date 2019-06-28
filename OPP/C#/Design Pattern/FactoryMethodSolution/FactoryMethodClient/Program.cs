using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib;
using System.Configuration;
using System.Reflection;

namespace FactoryMethodClient
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Console.WriteLine(typeof(BMWFactory).FullName);
           // Console.WriteLine(typeof(BMWFactory).AssemblyQualifiedName);
            // IAutomobileFactory fact = BMWFactory.GetInstance();
            var f = ConfigurationSettings.AppSettings["Factory"];
           
              MethodInfo method = Type.GetType(f).GetMethod("GetInstance");
              IAutomobileFactory fact = null;
             fact = (IAutomobileFactory)method.Invoke("GetInstance",null);
            IAutoMobile auto = fact.Make();
            auto.Start();
            auto.Stop();
            //  Type type = Type.GetType(f);

            //   IAutomobileFactory fact = type.GetMethod("GetInstance");
            //   var method = type.GetMethod("GetInstance");
            //    IAutomobileFactory fact = (IAutomobileFactory)method;
            //   Class1 c = new Class1();


            //  IAutomobileFactory fact = (IAutomobileFactory)Type.GetType(f).GetMethod("GetInstance");

            /* IAutomobileFactory fact = BMWFactory.GetInstance();
             IAutoMobile auto = fact.Make();
             auto.Start();
             auto.Stop();  */
        }
    
       
    }
}
