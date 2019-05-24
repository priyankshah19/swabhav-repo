using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashMapDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Students, Students> studentlist = new Dictionary<Students, Students>();
            Students s1 = new Students("priyank", 10, 1);
            Students s2 = new Students("meet", 10, 2);
            Students s3 = new Students("kartik", 1, 5);
        
            studentlist.Add(s1,s1);
            studentlist.Add(s2, s2);
            studentlist.Add(s3, s3);
           // studentlist.Add(s3, s3);

            foreach (KeyValuePair<Students,Students> list in studentlist)
            {
                Console.WriteLine(list);
            }
            Console.WriteLine(studentlist.ContainsKey(s1)); 
        }
    }
}
