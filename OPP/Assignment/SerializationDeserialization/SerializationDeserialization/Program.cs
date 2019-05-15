using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;


namespace SerializationDeserialization
{
    [Serializable]
    class Tutorial
    {
        public string name;
        public int id;
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.name = "Priyank";
            obj.id = 100;
            IFormatter formatter = new BinaryFormatter();//this will convert in binary process
            Stream stream = new FileStream(@"D:\Swabhav rep\OPP\Assignment\SerializationDeserialization\\TextFile.txt", FileMode.Create, FileAccess.Write); //this is use for writing
            formatter.Serialize(stream, obj);//this will store object in to stream path
            stream.Close();
            stream = new FileStream(@"D:\\Swabhav rep\\OPP\\Assignment\\SerializationDeserialization\\TextFile.txt", FileMode.Open, FileAccess.Read); //this is use for reading
            Tutorial objnew = (Tutorial)formatter.Deserialize(stream);

            Console.WriteLine(objnew.id);
            Console.WriteLine(objnew.name);

            Console.ReadKey();

        }
    }
}
