using System;
using System.Collections.Generic;
using System.Text;

namespace FindGuiatrTester
{
    public class Guitar
    {
        private string serialNumber;
        private double price;
        private GuitarSpec spec;
        public Guitar(String serialNumber, double price, Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            this.serialNumber = serialNumber;
            this.price = price;
            spec = new GuitarSpec(builder, model, type, backWood, topWood);

        }

        public string getSerialNumber()
        {
            return serialNumber;
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(float newPrice)
        {
            this.price = newPrice;
        }

        public GuitarSpec getSpec()
        {
            return spec;
        }

    }

}
