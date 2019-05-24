using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Students: IEquatable<Students>
    {
        private string _name, _stream;
        private int _age;
        public Students(string name, string stream, int age)
        {
            this._name = name;
            this._stream = stream;
            this._age = age;
        }
        public string Name { get { return _name; } }
        public string Stream { get { return _stream; } }
        public int Age { get { return _age; } }
        public override string ToString()
        {
            return ("students" + " " + _name + " " + "Stream" + " " + _stream + " " + "Age" + " " + _age);
        }

        public bool Equals(Students other)
        {
            return this._name.Equals(other._name);
        }
        public override int GetHashCode()
        {
            return this._name.GetHashCode();
        } 
    }

}

