using System;
using System.Collections.Generic;
using System.Text;

namespace Part2String  //string builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder name = new StringBuilder ( "hi how are you " ); //default intial string builder has capacity of 16
            StringBuilder name1 = new StringBuilder("dwwlwh dhw dwjdwdw2hdn", 256); //here we are defining capacity of stringbuilder as 256
            Console.WriteLine("capacity:{0}",name.Capacity);
            Console.WriteLine("capacity:{0}", name1.Capacity);
            Console.WriteLine("length:{0}", name1.Length);

        }
    }
}
