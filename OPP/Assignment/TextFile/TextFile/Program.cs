    using System;
using System.Collections.Generic;
using System.IO;
using System.Text;    

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo CurrentDirectory = new DirectoryInfo("."); // . is use for current directory information
            DirectoryInfo ParticularDirectory = new DirectoryInfo(@"D:\Swabhav rep\OPP\Assignment"); // @ is use so that we can use back slash and give particular path
            Console.WriteLine(ParticularDirectory.FullName); // it returns full name 
            Console.WriteLine(ParticularDirectory.Name); // it returns name
            Console.WriteLine(ParticularDirectory.Parent); // it returns parent name
            Console.WriteLine(ParticularDirectory.Attributes); //it returns attribute
            Console.WriteLine(ParticularDirectory.CreationTime); //it returns creation time

            DirectoryInfo NewPath = new DirectoryInfo(@"D:\Swabhav rep\OPP\Data"); //this will create new directory data .you can also delete directory
            string[] Customers = {
                "Priyank shah","kartik shaaah","aakash desai"
        };
            string textFilePath = @"D:\Swabhav rep\OPP\Assignment\textpad.txt"; // this file create a file
            File.WriteAllLines(textFilePath, Customers); //this will copy customers in to textfilepath
            foreach(string name in File.ReadAllLines(textFilePath))
            {
                Console.WriteLine($"Customers: {name}"); //$ is used when we have to write like this
            }

            string textFile = @"D:\Swabhav rep\OPP\Assignment\Text1.txt";  //this is use to read file which is already present
            foreach(string name1 in File.ReadAllLines(textFile))
            {
                Console.WriteLine(name1);
            }
            Console.ReadLine(); 



        }

        
    }
}
