using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp.ManBoy
{
    class Man : IManerable
    {
        public void DepartingGoodBye()
        {
            Console.WriteLine("Man is saying GoodBye");
        }

        public void Wish()
        {
            Console.WriteLine("Man is wishing GoodMorning");
        }
    }
}
