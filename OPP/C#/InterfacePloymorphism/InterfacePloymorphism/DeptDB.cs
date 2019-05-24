using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePloymorphism
{
    class DepartmentDB:ICredable
    {
        public void Create()
        {
            Console.WriteLine("Department  is created");
        }
        public void Read()
        {
            Console.WriteLine("Department  is priyank");
        }
        public void Update()
        {
            Console.WriteLine("Department is updated to meet");
        }
        public void Delete()
        {
            Console.WriteLine("Department meet is deleted");
        }
    }
}
