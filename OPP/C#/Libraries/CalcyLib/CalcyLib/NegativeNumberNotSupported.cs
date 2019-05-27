using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcyLib
{
    class NegativeNumberNotSupported:Exception
    {
        private string _message;
        public NegativeNumberNotSupported(string message):base(message)
        {
            _message = message;
        }
        public override string Message { get { return _message; } }
    }
}
