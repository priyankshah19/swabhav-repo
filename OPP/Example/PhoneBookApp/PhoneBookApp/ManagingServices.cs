using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
   
    class ManagingServices
    {
        public static List<Contact> Contactlist = new List<Contact>();
        public static void Deserializer()
        {
            List<Contact> Contactlist1 = null;
            using (FileStream str = File.OpenRead(@"D:\Swabhav rep\OPP\Example\PhoneBookApp\Contactlist.txt"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Contactlist1 = (List<Contact>)bf.Deserialize(str);
                str.Close();

                Contactlist.AddRange(Contactlist1);
            }
        }
        
        public static void Add()
        {
            Contact SingleContact = new Contact();
            Console.WriteLine("Enter Name");
            SingleContact.Name = Console.ReadLine();
            Console.WriteLine("Enter Email");
            SingleContact.Email = Console.ReadLine();
            Console.WriteLine("Enter Phoneno");
            SingleContact.PhoneNo = Convert.ToInt32(Console.ReadLine());
            Contactlist.Add(SingleContact);
            Serialize(Contactlist);
        }
        public static void Serialize(List<Contact> c)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"D:\Swabhav rep\OPP\Example\PhoneBookApp\Contactlist.txt", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, c);
            stream.Close();
        }

        public static void Printinfo(Contact Printcontact)
        {
            Console.WriteLine("Firstname:{0}", Printcontact.Name);

            Console.WriteLine("Email:{0}", Printcontact.Email);
            Console.WriteLine("Phoneno:{0}", Printcontact.PhoneNo);
        }

        public static void DisplayList()
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
