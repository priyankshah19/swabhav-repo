using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Phonebook
{
   
    class ManagingService
    {
        public static List<Contacts> Contactlist = new List<Contacts>();
        public static void Add()
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

    }

}
