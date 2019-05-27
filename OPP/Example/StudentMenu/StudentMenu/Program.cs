using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            Students meet = new Students();
            meet.Add();
            Display(meet);
        }

        public static void Display(Students s)
        {
           
                Console.WriteLine("Name:{0}",s.Name);
                Console.WriteLine("Age:{0}",s.Age);
                Console.WriteLine("COllege Name:{0}",Students.CollegeName);
            
        }
    }
}
