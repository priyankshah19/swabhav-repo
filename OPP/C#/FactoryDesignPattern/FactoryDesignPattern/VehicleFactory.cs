using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
   public abstract class VehicleFactory
    {
        public abstract IFactory Getvehicles(string Vehicle);
    }
}
