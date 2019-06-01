using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolation
{
    interface IWorker
    {
        void StartWork();
        void StopWork();
        void StartEat();
        void StopEat();
    }
}
