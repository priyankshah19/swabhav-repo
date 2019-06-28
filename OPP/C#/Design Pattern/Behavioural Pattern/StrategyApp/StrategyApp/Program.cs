using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            IStraegy i = new Algorithm1();
            client.CallAlgorithm(i); 
        }
    }
}
