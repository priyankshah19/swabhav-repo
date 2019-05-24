using System;
using System.Collections.Generic;
using System.Text;

namespace FindGuiatrTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            initializeInvetory(inventory);

            GuitarSpec whatErinLikes = new GuitarSpec(Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.CEDAR);
            List<Guitar> matchingGuitars = inventory.search(whatErinLikes);
            if (matchingGuitars != null)
            {

                Console.WriteLine("Erin, you might like these guitars :");

                foreach (Guitar guitar in matchingGuitars)  // we can use foreach instead of IEnumerator to loop thorugh the collection
                {

                    GuitarSpec spec = guitar.getSpec();
                    Console.WriteLine(" We have a " +
                    spec.getBuilder() + " " + spec.getModel() + " " +
                    spec.getType() + " guitar : \n    " +
                    spec.getBackWood() + " back and sides, \n    " +
                    spec.getTopWood() + " top. \nYou can have it only for $" +
                    guitar.getPrice() + " ! ");
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void initializeInvetory(Inventory inventory)
        {
            inventory.addGuitar("1", 3000, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.CEDAR);
            inventory.addGuitar("2", 3500, Builder.FENDER, "Stratocastor", Type.ELECTRIC, Wood.ALDER, Wood.CEDAR);
            inventory.addGuitar("3", 4000, Builder.OLSON, "Stratocastor", Type.ACOUSTIC, Wood.ALDER, Wood.ALDER);

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

