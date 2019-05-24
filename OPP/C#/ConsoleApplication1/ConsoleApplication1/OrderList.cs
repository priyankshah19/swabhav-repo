using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class OrderList
    {
        private string _name;
        private double _cost;
        private int _quantity;
        public OrderList(string name,double cost,int quantity)
        {
            this._name = name;
            this._cost = cost;
            this._quantity = quantity;
        }
        public string Name { get { return _name; } }
        public int Quantity { get { return _quantity; } }
        public double Cost { get { return _cost; } }
        public override string ToString()
        {
            return ("Name" +""+ _name +"Quanity"+"" +_quantity + "cost"+"" +_cost);
        }
        public double CalculateTotalCost()
        {
            double total = _cost * _quantity;
            return total;
        }

    }
}
