using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPVolation
{
    class TaxCalculator
    {
        public enum LogType
        {
            DB, FILE
        }
        private LogType _log;
        public TaxCalculator(LogType logtype)
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
                //Console.WriteLine(e.Message);
                DBLogger db = new DBLogger();
                FileLogger f = new FileLogger();
                if (_log.Equals(LogType.DB))
                {
                    db.Log(e.Message);
                }
                else if (_log.Equals(LogType.FILE))
                {
                    f.Log(e.Message);
                }
            }
            return -1;
        }
    }
}
