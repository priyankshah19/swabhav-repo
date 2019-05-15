using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarTestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory iventory = new Inventory();
            initializeInventory(inventory);
            Guitar priyank = new GuitarTestingApp.Guitar("serial01", 1000, "wood","Electric", "y1", "Black", "top");
            if (priyank != null)
            {
                Console.WriteLine("You might like :{0} {1} {2} {3} {4} {5} ", priyank.GetBuilder(), priyank.GetBlackwood(), priyank.GetModel(), priyank.GetPrice(), priyank.GetTopwood(), priyank.Gettype());
            }
            else
            {
                Console.WriteLine("no match found ");
            }


        }
        private static void initializeInventory(Inventory inventory)
        {

        }

        public Guitar search(Guitar searchGuitar)
        {
            for(Iterator i=Guitar.iterator();i.hasNext();)
            {
                Guitar guitar = (Guitar)i.Next();
                if(search.GetBuilder()!)
            }

        }
    }
}
