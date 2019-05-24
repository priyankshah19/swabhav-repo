using System;
using System.Collections.Generic;
using System.Text;

namespace Phonebook 
{
    [Serializable]
    class Contacts
    {
        private string _firstname, _lastname, _email;
        private double _phonenumber;

    /*    public Contacts(string firstname,string lastname,string email,double phonenumber)
        {
            this._firstname = firstname;
            this._firstname = lastname;
            this._email = email;
            this._phonenumber = phonenumber;
        } */
        public string FirstName {  get { return _firstname; } set { _firstname = value; } }
        public string LastName { get { return _lastname; } set { _lastname = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public double PhoneNumber { get { return _phonenumber; } set { _phonenumber = value; } }
    }
}
