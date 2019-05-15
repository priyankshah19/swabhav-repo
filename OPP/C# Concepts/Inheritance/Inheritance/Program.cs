using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Add("priyank");
            text.Width = 100;
            text.Height = 30;
            Console.WriteLine("height is {0}",text.Height);
        }
    }
}
