using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution
{
    class DiwaliRate:IFestivalRate
    {
        public float Rate()
        {
            float rate = 0.09f;
            return rate;
        }
    }
}
