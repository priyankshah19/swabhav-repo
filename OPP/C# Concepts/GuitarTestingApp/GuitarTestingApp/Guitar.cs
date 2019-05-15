using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarTestingApp
{
    class Guitar
    {
        private string _serialnumber, _builder, _type, _model, _blackwood, _topwood;
        private double _price;

        public Guitar(string serialnumber,double price,string builder,string type,string model,string blackwood,string topwood)
        {
            _serialnumber = serialnumber;
            _price = price;
            _builder = builder;
            _type = type;
            _model = model;
            _blackwood = blackwood;
            _topwood = topwood;
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

        public string GetBlackwood()
        {
            return _blackwood;
        }
        public string GetTopwood()
        {
            return _topwood;

        }
        public enum Type
        {
            ACCOUSTIC,ELECTRIC
                
                
       
        }
        public enum WOOD
        {
            BLACK,TOP


        }
        


        }


    }
}
