using System;
using System.Collections.Generic;
using System.Text;

namespace StudentObjectArraylist
{
    [Serializable]
    class Student
    {
        private string _name, _age, _college;
        public Student(string name,string age,string college)
        {
            _name = name;
            _age = age;
            _college = college;
        }
        public override string ToString()
        {
            return
                String.Format("{0} {1} {2}", _name,_age,_college);
        }

   
    }
}
