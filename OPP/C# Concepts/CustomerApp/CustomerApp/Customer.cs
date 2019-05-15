using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerApp
{
    class Customer
    {
        // private static int _idgenerator=1000;
        private string _name;
        private int _order;
        private int _id;
        private static int _idgenerator;



        static Customer()
        {
            _idgenerator = 1000; ;
        }
        public Customer(string name, int order)
        {

            _name = name;
            _order = order;
            _idgenerator++;
            _id = _idgenerator;

        }



        public String GetName { get { return _name; } }
        public int GetOrder { get { return _order; } }
        public int GetId { get { return _id; } }
    }
}
