using System;
using System.Collections.Generic;
using System.Text;

namespace College
{
    abstract class Person
    {

        private int _id;
        private string _address;
        private double _dob;



        public Person(int id, string address, double dob)
        {
            this._id = id;
            this._address = address;
            this._dob = dob;

        }

        public int Id { get { return _id; } }
        public string address { get { return _address; } }
        public double dob { get { return _dob; } }
    }
}
