using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace StudentObjectArraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList student = new ArrayList();
            Student student1 = new Student("priyank", "18", "Ap shah");
            Student student2 = new Student("MS", "19", "A p shah");
            student.Add(student1);
            student.Add(student2);
            Student student3 = new Student("XYZ", "18", "Mithibai");
            student.Insert(2, student3);
         
            Console.WriteLine("{0}",student1.Name);

            foreach (var students in student)
            {
                Console.WriteLine(students);
            }
            student.RemoveAt(1);
            foreach (var students in student)
            {
                Console.WriteLine(students);
            }

            SerializableData(student);

            ArrayList studentxx = BinaryDeserialize();
                foreach(Student stud1 in studentxx)
            {
                Console.WriteLine(stud1.Name);
            }

        }
      
            private static void  SerializableData(ArrayList studentx)
        {
            
            using (FileStream str = File.Create(@"D:\Swabhav rep\OPP\C#\StudentObjectArraylist\studentname.txt"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(str, studentx);
            }
          

        }

        private static ArrayList BinaryDeserialize()
        {
            ArrayList studentx = null;

            using (FileStream str = File.OpenRead(@"D:\Swabhav rep\OPP\C#\StudentObjectArraylist\studentname.txt"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                studentx = (ArrayList)bf.Deserialize(str);
            }
            return studentx;
        }
    }
}

