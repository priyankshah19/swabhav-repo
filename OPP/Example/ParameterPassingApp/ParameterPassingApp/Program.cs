using System;
using System.Collections.Generic;
using System.Text;

namespace ParameterPassingApp
{
    class Program
    {
     public static void Main(string[] args)
        {
            Program p = new Program();
            int mark = 100;
            p.ChangeMarksToZero(ref mark);
            Console.WriteLine(mark);

            int[] Marks = { 10, 20, 30 };
            p.ChangeMarksToZero(Marks);
            foreach (int temp in Marks)
            {
                Console.WriteLine(temp);
            }

          


        }
        public void ChangeMarksToZero(ref int pmark)
        {
            pmark = 0;
        

        }
       public void ChangeMarksToZero(int[] Marks1)
        {
            int i;
            for(i=0;i<Marks1.Length;i++)
            {
                Marks1[i] = 0;
              
            }
   
        }
    
    }

}
