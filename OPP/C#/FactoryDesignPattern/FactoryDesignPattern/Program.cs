using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreateVehicleFactory();

            IFactory scooter = factory.Getvehicles("Scooter");
            scooter.Drive(10);

            IFactory bike = factory.Getvehicles("Bike");
            bike.Drive(20);
        }
    }
}
