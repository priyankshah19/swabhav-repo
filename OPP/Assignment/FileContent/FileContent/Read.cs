using System;
using System.Collections.Generic;
using System.Text;
using System.IO;




namespace FileContent
{
    class Read
    {
        public void ReadContent()
        {
            string text = File.ReadAllText(@"D:\Swabhav rep\OPP\Assignment\FileContent\Hello.txt");

            // Display the file contents to the console. Variable text is a string.
            Console.WriteLine("Contents of WriteText.txt = {0}", text);

        }
    }
}
