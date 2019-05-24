using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeNew
{
    class Student:Person
    {
        private int _id;
        private string _address;
        private string _dob;
        private string _branch;

        public void Id(int id)
        {
            _id = id;
        }

        public void Address(string address)
        {
            _address = address;
        }

        public void Dob(string dob)
        {
            _dob = dob;
        }
        public void Branch(string branch)
        {
            _branch = branch;
        }
    }
}
