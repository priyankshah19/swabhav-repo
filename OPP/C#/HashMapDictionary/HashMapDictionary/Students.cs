using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapDictionary
{
    class Students:IEqualityComparer<KeyValuePair<Students,Students>>
    {
        private string _name;
        private int _standard, _rollno;

        public Students(string name,int standard,int rollno)
        {
            this._name = name;
            this._standard = standard;
            this._rollno = rollno;
        }

        public string Name { get { return _name; } }
        public int Standard {  get { return _standard; } }
        public int Rollno { get { return _rollno; } }

        public override string ToString()
        {
            return ("Name" + " " + _name + " " + "standard" + " " + _standard + " " + "Rollno" + " " + _rollno);
        }

        public bool Equals(KeyValuePair<Students, Students> x, KeyValuePair<Students, Students> y)
        {
            if(x.Key==y.Key && (x.Value._name==y.Value._name) && (x.Value._standard==y.Value._standard) && (x.Value._standard==y.Value._rollno)) 
            return true;
            return false;
        }

        public int GetHashCode(KeyValuePair<Students, Students> obj)
        {
            return obj.Key.GetHashCode();
        }
    }
}
