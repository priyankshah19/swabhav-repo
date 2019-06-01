using FactoryMethodLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodLib
{
   public interface IAutomobileFactory
    {
        IAutoMobile Make();
    }
}
