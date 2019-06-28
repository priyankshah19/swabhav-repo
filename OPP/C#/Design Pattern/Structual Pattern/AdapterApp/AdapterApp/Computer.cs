using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    class Computer
    {
        private ICardReader _cardreader;
        public Computer(ICardReader cardreader)
        {
            this._cardreader = cardreader;
        }

        public void Load()
        {
            _cardreader.Read();
        }
    }
}
