using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {


            int argument = Int32.Parse(args[0]);
            in number = Main(args);
            
    /*        while (argument != 0)
            {
                Console.WriteLine("{0}", argument);
                argument--;

            } 
            Main(args); */
           
        }
        public static void Main(int args)
        {
            while(args!=0)
            {
                return args--;
            }
            return 0;
        }
        


    }
}
