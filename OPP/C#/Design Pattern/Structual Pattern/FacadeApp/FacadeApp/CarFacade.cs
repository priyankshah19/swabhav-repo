using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeApp
{
    class CarFacade
    {
        private CarBody _body;
        private CarEngine _engine;
        private CarModel _model;
        public CarFacade()
        {
            _body = new CarBody();
            _engine = new CarEngine();
            _model = new CarModel();
        }
        public void CreateCar()
        {
            Console.WriteLine("Creating new car");
            _body.Body();
            _engine.Engine();
            _model.Model();
        }
    }
}
