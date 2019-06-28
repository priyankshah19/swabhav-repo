using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IEatable eat = new Child();
            IEatable eat1 = new Parent();
            IWorkable work = new Parent();
            eat.Eat();
            eat1.Eat();
            work.Work();
        }
    }
}
