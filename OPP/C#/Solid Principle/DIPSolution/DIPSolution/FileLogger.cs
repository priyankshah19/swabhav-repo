using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution
{
   public class FileLogger : ILogger

    {
        public void load(string errormsg)
        {
            errormsg="in the file";
            Console.WriteLine("in the File");
        }
    }
}
