using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePloymorphism
{
    class CustomerDB:ICredable
    {
        public void Create()
        {
            Console.WriteLine("Customer  is created");
        }
        public void Read()
        {
            Console.WriteLine("Customer  is priyank");
        }
        public void Update()
        {
            Console.WriteLine("Customer is updated to meet");
        }
        public void Delete()
        {
            Console.WriteLine("Customer meet is deleted");
        }
    }
}
