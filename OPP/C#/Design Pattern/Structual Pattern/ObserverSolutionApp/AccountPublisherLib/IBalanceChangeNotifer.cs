using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPublisherLib
{
   public interface IBalanceChangeNotifer
    {
        void Notify(Account account);
    }
}
