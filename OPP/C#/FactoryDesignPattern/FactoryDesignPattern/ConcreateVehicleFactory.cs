using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
  public   class ConcreateVehicleFactory : VehicleFactory
    {
        public override IFactory Getvehicles(string Vehicle)
        {
           switch(Vehicle)
            {
                case "Scooter":
                    return new Scooter();
                case "Bike":
                    return new BIke();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }
    }
}
