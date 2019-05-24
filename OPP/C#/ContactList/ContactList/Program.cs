using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace ContactList
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList contact = new ArrayList();
          

            Menu();



        }
        public static void Menu()
        {

            var contactlist = new ArrayList();
            Console.WriteLine("enter option");
            Console.WriteLine("1 to Add");
            Console.WriteLine("2 to Display");
            Console.WriteLine("3 to Exit");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    var contactlist1 = new ArrayList();
                    Console.WriteLine("Add Contacts");


                    Console.WriteLine("Enter Your First Name");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Enter Your last Name");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("Enter Your email");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter Your Phone no");
                    double phoneno = Convert.ToDouble(Console.ReadLine());
                    Contacts addcontact = new Contacts(firstname, lastname, email, phoneno);
                    contactlist1.Add(addcontact);
                   
                   

                    /* 
                        foreach (var contact1 in contactlist)
                        {
                            Console.WriteLine(contact1);
                        } */
                      SerializableData(contactlist);

                 
                  // SerializableData(contactlist);


                    break;
                case 2:

                   
                    /*   Console.WriteLine("Displaying contacts");
                       string text = File.ReadAllText(@"D:\Swabhav rep\OPP\C#\ContactList\contactlist.txt");
                       Console.WriteLine(text); */
                    ArrayList contactxx = BinaryDeserialize();

                   
                    foreach (var contact1 in contactxx)
                    {
                        Console.WriteLine(contact1);

                        /* TextWriter tsw = new StreamWriter(@"D:\Swabhav rep\OPP\C#\ContactList\contactlist.txt", true);
                         tsw.WriteLine(contact1);
                         tsw.Close(); */

                    }


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




        private static void SerializableData(ArrayList contactserializer)
        {


             using (FileStream str = File.Create(@"D:\Swabhav rep\OPP\C#\ContactList\contact.txt"))
              {
                  BinaryFormatter bf = new BinaryFormatter();
                
                  bf.Serialize(str, contactserializer);

              } 


            /*   using (FileStream str = File.Create(@"D:\Swabhav rep\OPP\C#\ContactList\contact.txt"))
               {
                   BinaryFormatter bf = new BinaryFormatter();
                   bf.Serialize(str, contactx);
               }  
             */

        }
        private static ArrayList BinaryDeserialize()
        {


            ArrayList contactdeserializer = null;


            using (FileStream str = File.OpenRead(@"D:\Swabhav rep\OPP\C#\ContactList\contact.txt"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                contactdeserializer = (ArrayList)bf.Deserialize(str);


            }

            return contactdeserializer;
        }

        private static void Write()

        {


        }


    }
}
