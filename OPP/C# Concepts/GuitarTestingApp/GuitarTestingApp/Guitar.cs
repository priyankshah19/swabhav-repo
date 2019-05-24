using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarTestingApp
{
    class Guitar
    {
        private string _serialnumber, _builder, _type, _model, _backwood, _topwood;
        private double _price;

        public Guitar(String serialnumber, double price, Builder builder, string model, Type type, Wood backwood, Wood topwood)
        {
            _serialnumber = serialnumber;
            _price = price;
            _builder = builder.ToString();
            _type = type.ToString();
            _model = model;
            _backwood = backwood.ToString();
            _topwood = topwood.ToString();
        }
        public string GetSerialNumber()
        {
            return _serialnumber;
        }

        public void SetPrice(double newprice)
        {
            _price = newprice;
        }
   
        public double GetPrice()
        {
            return _price;
        }
        public string GetBuilder()
        {
            return _builder;
        }

        public string Gettype()
        {
            return _type;

        }

        public string GetModel()
        {
            return _model;
        }

        public string GetBackwood()
        {
            return _backwood;
        }
        public string GetTopwood()
        {
            return _topwood;

        }
        
        


        }


    }

