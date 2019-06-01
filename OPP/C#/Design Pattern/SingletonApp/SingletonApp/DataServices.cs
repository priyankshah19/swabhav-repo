using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonApp
{
    class DataServices
    {
        private static DataServices _container;

        private DataServices()
        {
            Console.WriteLine("Services created");
        }
        public void DoSomething()
        {
            Console.WriteLine("Doing something by {0}", this.GetHashCode());
        }
        public static DataServices Getinstance()
        {
            if (_container == null)
                _container = new DataServices();
            return _container;
        }
    }
}
