using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution
{
    class HoliRate:IFestivalRate
    {
        public float Rate()
        {
            float rate = 0.08f;
            return rate;
        }
    }
}
