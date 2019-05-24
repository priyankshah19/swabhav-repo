using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceApp.ManBoy
{
    class Boy : IEmotionable, IManerable
    {
        public void Cry()
        {
            Console.WriteLine("Boy is Crying");
        }

        public void DepartingGoodBye()
        {
            Console.WriteLine("Boy is saying Goodbye");
        }

        public void Laugh()
        {
            Console.WriteLine("Boy is Laughing");
        }

        public void Wish()
        {
            Console.WriteLine("Boy is wishing GoodMorning");
        }
    }
}
