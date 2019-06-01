using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    class Product
    {
        private int _id;
        private string _name;
        private double _cost, _discount;

        public Product(int id,string name,double cost,double discount)
        {
            this._id = id;
            this._name = name;
            this._cost = cost;
            this._discount = discount;
        }
        public int ID { get { return _id; } }
        public string Name { get { return _name; } }
        public double Cost { get { return _cost; } }
        public double Discount { get { return _discount; } }

        public double FindCost()
        {
             double cost = _cost - _discount;
            return cost;
        }
    }
}
