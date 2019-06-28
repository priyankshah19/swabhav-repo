using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenicsViolation
{
    class Array
    {
        public int[,] array2Da = new int[3, 3] { { 1, 2, 9 }, { 3, 4, 8 }, { 5, 6, 7 } };
       
        public void Display()
        {
            int rowcount = array2Da.GetLength(0);
            int Colcount = array2Da.GetLength(1);
            for (int i = 0; i < rowcount; i++)
            {
                for(int j=0;j<Colcount;j++)
                {
                    Console.WriteLine("{0}",array2Da[i,j]);
                }
            }
        }

      /*  public void Row()
        {
            int rowcount = array2Da.GetLength(0);
            int Colcount = array2Da.GetLength(1);
            for (int i = 0; i < rowcount; i++)
            {
                Column(i);
            }
        }

        public void Column(int row)
        {
            int Colcount = array2Da.GetLength(1);
            for (int j = 0; j < Colcount; j++)
            {
                Console.WriteLine("{0}", array2Da[row, j]);
            }
        }
        */
    }
}
