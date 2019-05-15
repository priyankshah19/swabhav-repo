
using System;
using System.Collections.Generic;
using System.Text;

namespace Part3
{
    class Program
    {

        static void Main(string[] args)
        {
            Random number = new Random();
            int randomnumber = number.Next(1, 11);
            int secretnumber = 0;
           
            do
            {
                Console.WriteLine("Enter number from 1 to 10: ");
                secretnumber = Convert.ToInt32(Console.ReadLine());
            }
            while (secretnumber != randomnumber);

            double int1, int2;     //exception handling example
           try
            {
                Console.WriteLine("enter value of i & j");
                int1 = Convert.ToDouble(Console.ReadLine());
                int2 = Convert.ToDouble(Console.ReadLine());
                function(int1, int2);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("error occured");
            }
            finally
            {
                Console.WriteLine("thankyou");

            }

        }

        static Double function(double i,double j)
        {
            if(j ==0)
            {
                throw new DivideByZeroException();

            }
            else
            {
                return i / j;
            }
        }
    }
}
