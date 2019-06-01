using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class BIke:IFactory
    {
        public void Drive(int miles)
        {
            Console.WriteLine("Miles:{0}", miles.ToString());
        }
    }
}
