using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BinaryReaderWriter //it is use to read & write datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath3 = @"D:\Swabhav rep\OPP\Assignment\textpad3.dat";
            FileInfo datfile = new FileInfo(textFilePath3);
            BinaryWriter bw = new BinaryWriter(datfile.OpenWrite());
            string randtext = "random text";
            int age = 12;
            double height = 6.25;
            bw.Write(randtext);
            bw.Write(age);
            bw.Write(height);
            bw.Close();
            BinaryReader br = new BinaryReader(datfile.OpenRead());
            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            Console.ReadLine();
        }
    }
}
