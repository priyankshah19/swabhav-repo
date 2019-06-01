using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution
{
 public   class DBLogger:ILogger
    {
        public void load(string errormsg)
        {
           
            Console.WriteLine("in the DB");
        }
    }
}
