using System;
using System.Collections.Generic;
using System.Text;

namespace College
{
    class Student:Person
    {

        
        private Branch1 _branch;
        

        public Student (int id,string address,double dob,Branch1 branch):base(id,address,dob)
        {

            this._branch = branch;
        }

        

       public Branch1 Branch
        {
            get { return _branch;  }
        }
       
       public  enum Branch1
        {
            civil,mech
        }
    }

    

}
