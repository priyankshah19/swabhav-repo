using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableOperation
{
    class Program
    {
        static void Main(string[] args)
        {
           
         
            var name = "xyz";
             const double pie=3.14;
         dynamic person = 10;
            name ="HI";
            object a = 10;
              int a1 = (int)a;   //if one used a.we need to convert object in to orginal type.we need to do type casting
            string s1 = "1.3";
            bool result;
            int s2;
            result = int.TryParse(s1, out s2);
            Console.WriteLine(result); //tryparse will tell true or false if it will be able to convert or not
            Console.WriteLine(name);
            Console.WriteLine(pie);
            Console.WriteLine("enter name");
            person = Console.ReadLine();
            Console.WriteLine(person);


        }
    }
}
