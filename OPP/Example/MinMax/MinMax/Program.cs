using System;
using System.Collections.Generic;
using System.Text;



public class Program
{
    public static void Main()
    {
        MinMaxNumber mm = new MinMaxNumber();

        mm.MinMax();
    }
}
class MinMaxNumber
{

    int max1 = 0;
    int max2 = 0;
    int n, i;
    int[] input = new int[26];
    public void MinMax()
    {

        Console.WriteLine("Enter number of values");
        n = Console.Read();
       
        for (i = 0; i < input.Length; i++)
        {

            Console.WriteLine("Enter number");
            input[i] = Console.Read();
        }
       
   /*     for (i = 0; i < n; i++)
        {

            Console.WriteLine(input[i]);

        }
        Console.Read();
        */
        for (i = 0; i < n; i++)
        {
            if (input[i] > max1)
            {
                max2 = max1;
                max1 = input[i];
            }
            else if (input[i] > max2)
            {
                max2 = input[i];
            }

        }

        Console.WriteLine(max1);
        Console.WriteLine(max2);
    }


}