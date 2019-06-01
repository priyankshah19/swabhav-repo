using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib;
namespace FactoryMethodLib
{
  public  class BMWFactory : IAutomobileFactory
    {
        private static BMWFactory _container;
        public BMWFactory()
        {

        }
        public  IAutoMobile Make()
        {

            return new BMW();

        }
        public static BMWFactory GetInstance()
        {
            if (_container == null)
                _container = new BMWFactory();
            return _container;
        }
    }
}
