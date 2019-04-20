using System;
using System.Collections.Generic;
using System.Text;

namespace Chp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            String[] islands = new String[4];
            islands[0] = "Andheri";
            islands[1] = "Bandra";
            islands[2] = "Dadar";
            islands[3] = "Churchgate";
            int[] index = new int[4];
            index[0] = 3;
            index[1] = 2;
            index[2] = 0;
            index[3] = 1;
            int y = 0;
           
            while(y<4)
            {
                r = index[y];
                Console.WriteLine(islands[r]);
                y = y + 1;
            }


        }
    }
}
