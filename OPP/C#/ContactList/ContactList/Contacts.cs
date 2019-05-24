using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ContactList
{
    [Serializable]
    class Contacts
    {
       
        private string _name, _lastname, _email;
        private double _phoneno;
        public Contacts(string name, string lastname, string email,double phoneno)
        {
            _name = name;
            _lastname = lastname;
            _email = email;
            _phoneno = phoneno;
        }
       public override string ToString()
        {
            return
                String.Format("{0} {1} {2} {3} ", _name, _lastname, _email,_phoneno);
        } 
        public string FirstName { get { return _name; } set { _name = value; }  }
        public string LastName { get { return _lastname; } set { _lastname = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public double Phoneno { get { return _phoneno; } set { _phoneno = value; } }
    }
}
