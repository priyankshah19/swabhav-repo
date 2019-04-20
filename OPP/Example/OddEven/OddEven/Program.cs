using System;
using System.Collections.Generic;
using System.Text;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int j = 0;
            int l = 0;
           
           int[] Even = new int[5];
            int[] Odd = new int[5];
            for(i=1;i<=10;i++)

            {
                if(i%2==0)
                {
                    Even[j] = i;
                    
                   Even[j]++;
                }
                else
                {
                    Odd[l] = i;

                    Odd[l]++;
                }
              foreach(int temp in Even)
                {
                    Console.WriteLine(Even);
                }
                foreach (int temp in Odd)
                {
                    Console.WriteLine(Odd);
                }
            }
         
            
        }
    }
}
