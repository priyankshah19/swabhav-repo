using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib;

namespace FactoryMethodLib
{
    
  public  class AudiFactory : IAutomobileFactory
    {
        private static AudiFactory _container;
        public AudiFactory()
        {

        }
        public IAutoMobile Make()
        {
            return new Audi();
        }
        public static AudiFactory GetInstance()
        {
            if (_container == null)
                _container = new AudiFactory();
            return _container;
        }
    }
}
