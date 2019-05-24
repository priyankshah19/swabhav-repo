using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Students> studentslist = new HashSet<Students>();
            studentslist.Add(new Students("priyank", "comps", 22));
            studentslist.Add(new Students("priyank", "comps", 22));
            studentslist.Add(new Students("p", "extc", 21));
            studentslist.Add(new Students("meet", "civil", 22));
            foreach(Students student in studentslist)
            {
                Console.WriteLine(student.GetHashCode());
                Console.WriteLine(student);
               
            }
            Console.WriteLine("{0}",studentslist.Count);
        }
    }
}
