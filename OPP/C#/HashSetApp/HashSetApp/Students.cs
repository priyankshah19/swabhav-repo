using System;
using System.Collections.Generic;
using System.Text;

namespace HashSetApp
{
    class Students
    {
        private string _name, _stream;
        private int _age;
        public Students(string name,string stream,int age)
        {
            this._name = name;
            this._stream = stream;
            this._age = age;
        }
        public string Name { get { return _name; } }
        public string Stream { get { return _stream; } }
        public int Age { get { return _age; } }
    }
}
