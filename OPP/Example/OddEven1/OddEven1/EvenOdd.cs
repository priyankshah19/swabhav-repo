using System;
using System.Collections.Generic;
using System.Text;

namespace OddEven1
{
    class EvenOdd
    {
        private int value = 1;
        private int constantNumber = 100;
        private int print;
     
        public void PrintEven()
        {
            for (value = 1; value <= constantNumber; value++)

            {
                if (value % 2 == 0)
                {
                    Console.WriteLine(value);

                    value++;
                }
            }
           

        }
        public void PrintOdd()
        {
            for (value = 1; value <= constantNumber; value++)
            {
                if (value % 2 != 0)
                {
                    Console.WriteLine(value);

                    value++;
                }
            }
            
        }
    }

}
