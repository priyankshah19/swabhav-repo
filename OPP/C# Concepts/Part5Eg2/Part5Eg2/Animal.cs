using System;
using System.Collections.Generic;
using System.Text;

namespace Part5Eg2
{
    class Animal
    {
        public string name;
        public string sound;
        public Animal()
        {
            name = "no name";
            sound = "no sound";
            numofanimal++;
        }
        public Animal(string name1)
        {
            this.name = name1;
            numofanimal++;
        }
        public Animal(string name2, string sound2)
        {
            this.name = name2;
            this.sound = sound2;
            numofanimal++;
        }
        public void GetAnimal()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        static int numofanimal = 0; //when we make static that value will be same for all and if we change that value then it will change for all objects.
        public static int getnumofanimal()
        {
            return numofanimal;
        }
    }
}
