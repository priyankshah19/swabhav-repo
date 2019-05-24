using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp.Vehicles
{
    class Truck : IMovable
    {
        private string _name;
        private string _model;
        public Truck(string name, string model)
        {
            _name = name;
            _model = model;
        }

        public string Name { get { return _name; } }
        public string Model { get { return _model; } }
        public void Move()
        {
            Console.WriteLine("{0} Truck is moving",_name);
        }
    }
}
