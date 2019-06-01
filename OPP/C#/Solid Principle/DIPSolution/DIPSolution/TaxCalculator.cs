using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution
{
    class TaxCalculator
    {

        private ILogger _log;
        public TaxCalculator(ILogger logtype)
        {
            this._log = logtype;
        }
        public int CalculateTax(int amount, int rate)
        {
            try
            {
                int r = amount / rate;
                return r;
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.Message);
                _log.load(e.Message);

       
               
            } 
            return -1;
        }
    }
}
