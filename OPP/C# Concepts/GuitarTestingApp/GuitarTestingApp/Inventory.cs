using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
//using System.Collections.Generic;
namespace GuitarTestingApp
{
    class Inventory
    {
        ArrayList guitars = new ArrayList();

        public void AddGuitar(String serialNumber, double price, Builder builder, string model, Type type,
Wood backwood, Wood topwood)

        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backwood, topwood);
            guitars.Add(guitar);
        }
        public Guitar GetGuitar(Guitar serialnumber)
        {
            for (IEnumerator i = guitars.GetEnumerator(); i.MoveNext();)
            {
                Guitar guitar = (Guitar)i.Current;
                if (guitar.GetSerialNumber().Equals(serialnumber))
                {
                    return guitar;
                }

            }
            return null;

        }

        public List<Guitar> search(Guitar searchGuitar)
        {
            List<Guitar> matchingguitars = new List<Guitar>();
            for (IEnumerator i = guitars.GetEnumerator(); i.MoveNext();)
            {
                Guitar guitar = (Guitar)i.Current;
                // Ignore serial number since that's uniquer
                // Ignore price since that's unique                    
                string builder = searchGuitar.GetBuilder();
                if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(guitar.GetBuilder())))
                    continue;
                String model = searchGuitar.GetModel();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.GetModel())))
                    continue;
                String type = searchGuitar.Gettype();
                if ((type != null) && (!type.Equals("")) && (!type.Equals(guitar.GetType())))
                    continue;
                String backWood = searchGuitar.GetBackwood();
                if ((backWood != null) && (!backWood.Equals("")) &&
                    (!backWood.Equals(guitar.GetBackwood())))
                    continue;
                String topWood = searchGuitar.GetTopwood();
                if ((topWood != null) && (!topWood.Equals("")) &&
                    (!topWood.Equals(guitar.GetTopwood())))
                    continue;

                matchingguitars.Add(guitar);

            }
            return matchingguitars;

        }

    }
}

