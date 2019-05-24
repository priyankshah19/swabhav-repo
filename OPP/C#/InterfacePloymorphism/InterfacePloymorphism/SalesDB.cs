using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePloymorphism
{
    class SalesDB:ICredable
    {
        public void Create()
        {
            Console.WriteLine("sales person is created");
        }
        public void Read()
        {
            Console.WriteLine("sales person is priyank");
        }
        public void Update()
        {
            Console.WriteLine("sales person is updated to meet");
        }
        public void Delete()
        {
            Console.WriteLine("sales person meet is deleted");
        }
    }
}
