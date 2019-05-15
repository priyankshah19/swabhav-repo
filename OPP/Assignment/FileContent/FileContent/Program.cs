
using System;
using System.Collections.Generic;
using System.IO;

using System.Text;


namespace FileContent
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter tsw = new StreamWriter(@"D:\Swabhav rep\OPP\Assignment\FileContent\Hello.txt", true);
            //Writing text to the file.
            tsw.WriteLine("How");
            tsw.WriteLine("are you?");

            //Close the file.
            tsw.Close();

            // Read the file as one string.
           // string text = System.IO.File.ReadAllText(@"E:\Swabhav rep\OOP\FileContent\Hello.txt");
            Read r = new Read();
            r.ReadContent();
            // Display the file contents to the console. Variable text is a string.
            // System.Console.WriteLine("Contents of WriteText.txt = {0}", text);

            // 

        }
    }
}
