using System;
using System.Collections.Generic;
using System.Text;

namespace Part6Eg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Animal();
            cat.SetName("Caspher");
            cat.Sound = "meow";
            Console.WriteLine("Name {0}  and says {1}", cat.GetName(), cat.Sound);
            cat.Owner = "priyank";
            Console.WriteLine(" {0}  owner is {1}", cat.GetName(), cat.Owner);
            Console.WriteLine(" {0}  shleter id is {1}", cat.GetName(), cat.idNum);
            Animal fox = new Animal("fox", "geesd");
            Console.WriteLine(" number of animals is {0}", Animal.NumofAnimals); //here we write animal class first because numofanimal is static then we can call numofanimal
        }
    }
}
