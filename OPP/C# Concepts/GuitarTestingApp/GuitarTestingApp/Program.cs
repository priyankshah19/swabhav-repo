using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarTestingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Inventory inventory = new Inventory();
                initializeInvetory(inventory);
                Guitar whatErinLikes = new Guitar("", 0, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.CEDAR);
                List<Guitar> guitars = inventory.search(whatErinLikes);
                if (guitars != null)
                {

                    foreach (Guitar guitar in guitars)  // we can use foreach instead of IEnumerator to loop thorugh the collection
                    {
                        Console.WriteLine("Erin, you might like this " +
                        guitar.GetBuilder() + " " + guitar.GetModel() + " " +
                        guitar.GetType() + " guitar : \n    " +
                        guitar.GetBackwood() + " back and sides, \n    " +
                        guitar.GetTopwood() + " top. \nYou can have it only for $" +
                        guitar.GetPrice() + " ! ");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, Erin, we have nothing for you.");
                }
            }
        }
        private static void initializeInvetory(Inventory inventory)
        {
            inventory.AddGuitar("1", 3000, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.CEDAR);
            inventory.AddGuitar("2", 3500, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.CEDAR);
            inventory.AddGuitar("3", 4000, Builder.OLSON, "Stratocastor", Type.ACOUSTIC, Wood.ALDER, Wood.ALDER);


        }






    }

    public enum Type
    {
        ACOUSTIC, ELECTRIC
    }

    public enum Builder
    {
        FENDER, MARTIN, GIBSON, COLLINGS, OLSON, RYAN, PRS, ANY
    }
    public enum Wood
    {
        INDIAN_ROSEWOOD, BRAZILIAN_ROSEWOOD, MAHOGANY, MAPLE,
        COCOBOLO, CEDAR, ADIRONDACK, ALDER, SITKA
    }

}
