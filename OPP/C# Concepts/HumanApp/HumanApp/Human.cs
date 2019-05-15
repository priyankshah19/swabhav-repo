using System;
using System.Collections.Generic;
using System.Text;

namespace HumanApp
{
    class Human
    {
        private string _name;
        private int _age;
        private float _height;
        private float _weight;
        private Genderoption _gender;

        public  Human(string name,int age,float height,float weight,Genderoption gender)
        {
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
            _gender = gender;

        }
        public String Name { get
            { return _name; }
             }

        public int Age
        {
            get
            { return _age; }
        }

        public float Height
        {
            get
            { return _height; }

        }

        public float Weight
        {
            get
            { return _weight; }

        }
        public Genderoption Gender
        {
           get
            { return _gender; }

        }

        public void Eat()
        {
            _weight =  _weight + ((_weight * 5)/100);
        }
    }
}
