﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolation
{
    class Invoice
    {
        private int _invoiceno;
        private string _name;
        private double _cost;
        private float _gst, _discount;

        public Invoice(int invoice,string name,double cost,float gst,float discount)
        {
            this._invoiceno = invoice;
            this._name = name;
            this._cost = cost;
            this._gst = gst;
            this._discount = discount;
        }
        public string Name { get { return _name; } }
        public int InvoiceNo { get { return _invoiceno; } }
        public double Cost { get { return _cost; } }
        public float CalculateDiscount()
        {
             double disc = _cost -(_cost * _discount);
            return (float)disc;
        }
        public float CalculateGst()
        {
            double tax =_cost+(_cost * _gst);
            return (float)tax;
        }
        public float TotalCost()
        {
            double totalcost = CalculateDiscount() + CalculateGst();
            return (float)totalcost;
        }
        public void Printinfo()
        {
            Console.WriteLine("Name:{0}",Name);
            Console.WriteLine("Invoice Id:{0}",InvoiceNo);
            Console.WriteLine("Cost:{0}", Cost);
            Console.WriteLine("Discount:{0}",CalculateDiscount());
            Console.WriteLine("GSt:{0}",CalculateGst());
            Console.WriteLine("Total Cost:{0}",TotalCost());
        }

    }
}
