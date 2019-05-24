using System;
using System.Collections.Generic;
using System.Text;

namespace DogDoor
{
    class DogDoor
    {
        public bool isOpen { get; private set; }


        public DogDoor()
        {
            isOpen = false;
        }

        public void open()
        {
            isOpen = true;
            Console.WriteLine("The dog doog opens.");
        }

        public void close()
        {
            isOpen = false;
            Console.WriteLine("The dog doog closes.");
        }
    }
}