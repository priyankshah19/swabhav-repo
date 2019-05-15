using System;
using System.Collections.Generic;
using System.Text;
using System.IO;  //this is use for file
using System.Text;   //this is use for file
namespace TextRead
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo currentdirectory = new DirectoryInfo("."); //this for curent directory
            DirectoryInfo directory = new DirectoryInfo(@"D:\Swabhav rep\OPP\Assignment\Text1.txt"); //this is use to get in to specific directory
            Console.WriteLine(currentdirectory.FullName); //it will provide name
            Console.WriteLine(directory.Name); //it will provide name
            string[] customers = { "ps", "sbi" };
            string textFilePath = @"D:\Swabhav rep\OPP\Assignment\Text1.txt"; //this will create file
            File.WriteAllLines(textFilePath, customers); //this will write into file.here customers data will be inserted into  textfilepath
            foreach(string cust in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customers: {cust}");
            }
            Console.ReadLine(); // to hold output
        }
    }
}
