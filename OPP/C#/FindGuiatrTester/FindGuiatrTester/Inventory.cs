using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FindGuiatrTester
{
    public class Inventory
    {
        private List<Guitar> guitars;
        public Inventory()
        {
            guitars = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price, Builder builder, string model, Type type,
        Wood backWood, Wood topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder,
                                       model, type, backWood, topWood);
            guitars.Add(guitar);
        }

        public Guitar getGuitar(string serialNumber)
        {
            for (IEnumerator i = guitars.GetEnumerator(); i.MoveNext();)
            {
                Guitar guitar = (Guitar)i.Current;
                if (guitar.getSerialNumber().Equals(serialNumber))
                {
                    return guitar;
                }

            }
            return null;
        }

        public List<Guitar> search(GuitarSpec searchSpec)
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            for (IEnumerator i = guitars.GetEnumerator(); i.MoveNext();)
            {
                Guitar guitar = (Guitar)i.Current;
                GuitarSpec guitarSpec = guitar.getSpec();
                // Ignore serial number since that's uniquer
                // Ignore price since that's unique                    
                string builder = searchSpec.getBuilder();
                if (searchSpec.getBuilder() != searchSpec.getBuilder())
                    continue;
                String model = searchSpec.getModel().ToLower();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitarSpec.getModel().ToLower())))
                    continue;
                if (searchSpec.getType() != guitarSpec.getType())
                    continue;
                if (searchSpec.getBackWood() != guitarSpec.getBackWood())
                    continue;
                if (searchSpec.getTopWood() != guitarSpec.getTopWood())
                    continue;

                matchingGuitars.Add(guitar);

            }
            return matchingGuitars;
        }


    }

}
