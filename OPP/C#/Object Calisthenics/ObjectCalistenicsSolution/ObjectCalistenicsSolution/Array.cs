using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalistenicsSolution
{
    class Array
    {
        public int[,] array2Da = new int[3, 3] { { 1, 2, 9 }, { 3, 4, 8 }, { 5, 6, 7 } };
        public void Row()
        {
            int rowcount = array2Da.GetLength(0);
            int Colcount = array2Da.GetLength(1);
            for (int rowindex = 0; rowindex < rowcount; rowindex++)
            {
                Column(rowindex);
            }
        }

        public void Column(int rowindex)
        {
            int Colcount = array2Da.GetLength(1);
            for (int columnindex = 0; columnindex < Colcount; columnindex++)
            {
                Console.WriteLine("{0}", array2Da[rowindex, columnindex]);
            }
        }
               
    }
}
