using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine("carname:{0}", car1.Carname("TATA"));
            Console.WriteLine("vehicle type:{0}", car1.VehicleDetails("car"));
        }
    }
}
