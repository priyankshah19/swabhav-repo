﻿using System;
using System.Collections.Generic;
using System.Text;


namespace DogDoor
{
    class Remote
    {
        private DogDoor _door;

        public Remote(DogDoor door)
        {
            _door = door;
        }

        public void pressButton()
        {
            Console.WriteLine("Pressing the remote control button ...");
            if (_door.isOpen)
            {
                _door.close();
            }
            else
            {
                _door.open();
            }
        }
    }
}
