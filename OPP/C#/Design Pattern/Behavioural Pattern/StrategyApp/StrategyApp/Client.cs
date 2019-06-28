using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    class Client
    {

        public void CallAlgorithm(IStraegy st)
        {
            st.Algorithm();
        }
    }
}
