using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib;

namespace FactoryMethodLib
{
  public  class TeslaFactory : IAutomobileFactory
    {
        private static TeslaFactory _container;
        public TeslaFactory()
        {

        }
        public IAutoMobile Make()
        {
            return new  Tesla();
        }
        public static TeslaFactory GetInstance()
        {
            if (_container == null)
                _container = new TeslaFactory();
            return _container;
        }
    }
}
