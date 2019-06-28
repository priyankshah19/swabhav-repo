using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorUnitTesting
{
  public  class Calculator
    {
        public long Add(long number1,long number2)
        {
            if((number1<0) || (number2<0))
                {
                throw new Exception("error");
            }
            else
            {
                return number1 + number2;
            }
        }
    }
}
