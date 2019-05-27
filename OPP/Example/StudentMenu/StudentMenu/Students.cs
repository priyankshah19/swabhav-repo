using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMenu
{
    class Students
    {
        private static string _college="a p shah";
        private string _name;
        private int _age;

     /*   public Students(string name,int age)
        {
            this._name = name;
            this._age = age;
        }  */
       public static string CollegeName {  get { return _college; }  }
        public string Name { get { return _name; } }
        public int Age { get { return _age; } }
        public void Add()
        {
            Console.WriteLine("Enter Student Name");
            _name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            _age = Convert.ToInt32(Console.ReadLine());
          
        }
        
    }
}
