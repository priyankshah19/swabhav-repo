using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Phonebook
{
    class Program
    {
        public static List<Contacts> Contactlist = new List<Contacts>();
        static void Main(string[] args)
        {

            List<Contacts> Contactlist1 = null;
            using (FileStream str = File.OpenRead(@"D:\Swabhav rep\OPP\C#\Phonebook\contactlists.txt"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Contactlist1 = (List<Contacts>)bf.Deserialize(str);
                str.Close();

                Contactlist.AddRange(Contactlist1);
            }



            Menu();




        }

        public static void Menu()
        {
            Console.WriteLine("enter option");
            Console.WriteLine("1 to Add");
            Console.WriteLine("2 to Display");
            Console.WriteLine("3 to Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Add();

                    break;
                case 2:
                    DisplayList();
                    break;
                case 3:
                    Console.WriteLine("Press 3 to exit");
                    int press = Convert.ToInt32(Console.ReadLine());
                    if (press == 3)
                    {
                        break;
                    }
                    break;
            }

            if (option != 3)
            {
                Menu();
            }

        }
        private static void Add()
        {
            Contacts singlecontacts = new Contacts();
            Console.WriteLine("Add First Name");
            singlecontacts.FirstName = Console.ReadLine();
            Console.WriteLine("Add Last Name");
            singlecontacts.LastName = Console.ReadLine();
            Console.WriteLine("Add Email");
            singlecontacts.Email = Console.ReadLine();
            Console.WriteLine("Add Number");

            singlecontacts.PhoneNumber = Convert.ToDouble(Console.ReadLine());
            Contactlist.Add(singlecontacts);
            // DisplaySerialize(Contactlist);
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\Swabhav rep\OPP\C#\Phonebook\contactlists.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, Contactlist);
            stream.Close();

        }
        private static void Printinfo(Contacts Printcontact)
        {
            Console.WriteLine("Firstname:{0}", Printcontact.FirstName);
            Console.WriteLine("Lastname:{0}", Printcontact.LastName);
            Console.WriteLine("Email:{0}", Printcontact.Email);
            Console.WriteLine("Phoneno:{0}", Printcontact.PhoneNumber);
        }

        private static void DisplayList()
        {
            if (Contactlist.Count == 0)
            {
                Console.WriteLine("contactlist is empty");
                Console.ReadKey(); //this will force to enter return key and once return key is press it will go out of method
            }
            Console.WriteLine("here is the contactlist");
            foreach (var person in Contactlist)
            {
                Printinfo(person);
            }


        }

        
    }
}