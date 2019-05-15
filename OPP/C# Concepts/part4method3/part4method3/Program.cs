using System;
using System.Collections.Generic;
using System.Text;

namespace part4method3
{
    class Program
    {
        static void Main(string[] args)
        {
            printinfo(zipcode: 1234, name: "ps"); //name parameter
        }
        static void printinfo(string name,int zipcode) 
        {
            Console.WriteLine("name:{0}  zipcode:{1}",name, zipcode);
            
        }
    }
}
