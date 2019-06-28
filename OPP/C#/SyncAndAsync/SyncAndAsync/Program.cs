using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncAndAsync
{
    class Program
    {
        static void Main(string[] args)
        {

          // Console.WriteLine("Line before callTestCls async call");
            callTestCls();
           Console.WriteLine("Line after callTestCls async call");

            Console.WriteLine("Line before MakeSyncMethodAsynchronous call");
            MakeSyncMethodAsynchronous();
            Console.WriteLine("Line after MakeSyncMethodAsynchronous call");
            Console.ReadLine();
        }

        static private void callTestCls()
        {
            Test tclass = new Test();
            tclass.sayHelloAsync().ConfigureAwait(false);
        }

        static void MakeSyncMethodAsynchronous()
        {
            
                Test tclass = new Test();
                tclass.sayHelloSync();

            

        }
    }
}
