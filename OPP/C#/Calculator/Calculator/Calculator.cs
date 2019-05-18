using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculators
    {
       
        
        public long Add(long number1, long number2)
        {
            if ((number1 < 0) || (number2 < 0))
            {
                throw (new NegativeNumberNotSupported("cannot pass negative number"));
            }
            else
            {
                return number1 + number2;
            }
           // return 0;
        
    }
    }
}
