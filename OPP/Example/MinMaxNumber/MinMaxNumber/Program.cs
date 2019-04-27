using System;
using System.Collections.Generic;
using System.Text;



public class Program
{
    public static void Main()
    {
        MinMax1 obj = new MinMax1();

        obj.MinMax();
    }
}
class MinMax1
{

    int max1 = 0;
    int max2 = 0;
    int i;
    public void MinMax()
    {
        int n;
        int[] array = new int[26];
        Console.Write("Enter number of cases : ");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
            
        }
        for (int i = 0; i < n; i++)
        {
            Console.Write(array[i]);
           

        }
        

        for (i = 0; i < n; i++)
        {
            if (array[i] > max1)
            {
                max2 = max1;
                max1 = array[i];
            }
            else if (array[i] > max2)
            {
                max2 = array[i];
            }

        }

        Console.WriteLine("First max:" +max1);
        Console.WriteLine("Second max:"+max2);
       
    }


}