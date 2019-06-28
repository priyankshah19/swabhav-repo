using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncAndAsync
{
    class Test
    {
        public async Task sayHelloAsync()
        {
            await Task.Delay(3000);
            string strdata = "Hello world async method";
            Console.WriteLine(strdata);
        }

        public void sayHelloSync()
        {
          //  System.Threading.Thread.Sleep(1000);
            string strdata = "Hello world synchronous method";
            Console.WriteLine(strdata);
        }

    }
}

