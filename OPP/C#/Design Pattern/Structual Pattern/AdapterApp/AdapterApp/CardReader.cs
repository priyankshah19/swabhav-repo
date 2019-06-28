using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterApp
{
    class CardReader : MemoryCard,ICardReader
    {
        public void Read()
        {
            LoadMemory();
        }
    }
}
