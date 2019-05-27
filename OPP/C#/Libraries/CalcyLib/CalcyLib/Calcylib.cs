using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcyLib
{
    public class Calcylib
    {
        public long Add(long number1,long number2)
        {
            if((number1<0) || (number2<0))
            {
                throw ( new NegativeNumberNotSupported("negative number not supported"));
            }
            else
            {
                return number1 + number2;
            }

        }
    }
}
