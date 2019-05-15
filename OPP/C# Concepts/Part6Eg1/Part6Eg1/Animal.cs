using System;
using System.Collections.Generic;
using System.Text;

namespace Part6Eg1
{
    class Animal
    {
        private string name;   //if used protected that it can be change & access by that class and subclass
        private string sound; //can only be change by that class
        public const string Shelter = "priyanks home"; //we can also define constant ..the value will be same throughout and it can't be changed
        public readonly int idNum; //by using readonly the value can be readed it cannot be changed

        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);

        }
        public Animal()   //this is default constructor if no paramter are passed this will be used
            : this("No name", "no sound") { }
        public Animal(string name)   //this is constructor with one parameter

            : this(name, "no sound") { }

        public Animal(string name, string sound) //with two parameter
        {
            SetName(name);  //method 1
            Sound = sound;  //method 2
            NumofAnimals = 1;
            Random rnd = new Random();  //this will generate random number 
            idNum = rnd.Next(1, 10);  // we are setting readonly value using random number

        }

        public void SetName(string name)    // one way of using for getter & setter
        {


            this.name = name;
            

        }

        public string GetName()
        {
            return name;
        }

        public string Sound   //another way of using getter & setter using properties
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)  //it will check if length of sound is greater thAN 10
                {
                    Sound = "NO SOUND";
                    Console.WriteLine("sound is to long");
                }
                sound = value;   //value is default variable store what is passed in setter function
            }
        }


        public string Owner { get; set; } = "no owner";

        public static int numofanimals= 0;
            public static int NumofAnimals
        {
            get { return numofanimals; }
            set
            {
                numofanimals += value;
            }
        }
    }
}
