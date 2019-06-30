using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacePloymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            DoDBOperation(new SalesDB());
                    Console.WriteLine("");
            DoDBOperation(new DepartmentDB());
                         Console.WriteLine("");
            DoDBOperation(new CustomerDB());
            Console.ReadLine();

        }
        public static void DoDBOperation(ICredable cread)
        {

            cread.Create();
            cread.Read();
            cread.Update();
            cread.Delete();
        }
    }
}
