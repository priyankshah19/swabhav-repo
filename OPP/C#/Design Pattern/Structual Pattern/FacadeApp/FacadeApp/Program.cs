using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarFacade carfacade = new CarFacade();
            carfacade.CreateCar();
        }
    }
}
