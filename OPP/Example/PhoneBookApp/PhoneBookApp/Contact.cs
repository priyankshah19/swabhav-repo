using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    [Serializable]
    class Contact
    {
        private string _name;
        private string _email;
        private int _phoneno;


        public string Name { get { return _name; } set { _name = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public int PhoneNo { get { return _phoneno; } set { _phoneno = value; } }
    }
}
