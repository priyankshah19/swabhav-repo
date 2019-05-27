using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ManagingServices manager = new ManagingServices();
            ManagingServices.Deserializer();
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
                    ManagingServices.Add();

                    break;
                case 2:
                    ManagingServices.DisplayList();
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

        
    }
}
