using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
   public class NegativeNumberNotSupported:Exception
    {

       private string _message;
        public  NegativeNumberNotSupported(string message)
        {
            _message = message;
        }
        public override string Message
        {
            get
            {
                return _message;
            }
        }


    }
}
