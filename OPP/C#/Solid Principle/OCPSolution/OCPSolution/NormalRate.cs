using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution
{
    class NormalRate : IFestivalRate
    {
        public float Rate()
        {
            float rate = 0.07f;
            return rate;
        }
    }
}
