using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryLibClient1
{
   
    public   class AutomobileFactory
    {
       private static AutomobileFactory _container;
          private AutomobileFactory()
        {

        }
        public static AutomobileFactory Getinstance()
        {
            if (_container == null)
                _container = new AutomobileFactory();
            return _container;
        }
        public IAutoMobile Make(AutoType type)
        {
            if(type==AutoType.Audi)
            {
                return new Audi();
            }
            else if (type == AutoType.BMW)
            {
                return new BMW();
            }
            else if (type == AutoType.Tesla)
            {
                return new Tesla();
            }
            return null;
        }
        public enum AutoType
        {
            BMW, Audi, Tesla
        }
    }
}
