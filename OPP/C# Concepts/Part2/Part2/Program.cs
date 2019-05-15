using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading.Tasks;
using System.Globalization;


namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "priyank"; // by using var C# will understand that the name is string
            Console.WriteLine("myname:{0}", name.GetType()); // this will give type of name

            int[] student = new int[3];

            string[] customers = { "hi", "hello", "bye" }; //string array
            var employes = new[] { "shs", "ddkk", "dhj" };  // we create array using var
            object[] people = { "hi", 45, 1.23 };
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("people:{0} value {1}", i, people[i]); //it will give index and values

            }

            string[,] employee = new string[2, 2] { { "priyank", "shah" }, { "meet", "shah" } }; //for 2d array
            Console.WriteLine("employeename:   {0}",employee.GetValue(1,1)); 
            for(int i=0;i<employee.GetLength(0);i++)
            {
                for (int j = 0; j < employee.GetLength(1); j++)
                {
                    Console.Write("employeename:  {0}", employee[i,j]);
                }
                Console.WriteLine();
            }


            int[] nums = new int[] { 1, 2, 3, 4 };
            PrintArray(nums, "Numbers");  ///passing function with array and message
            Console.ReadLine();

        }

        private static void  PrintArray(int[] number,string msg)
        {
            foreach(int k in number)             
            {
                Console.WriteLine("{0} :{1}", msg,k);  //we can sort,reverse ,search an element ,kcopy one array in to another using function for that check on web
            }
        }
    }
}
