using System;
using System.Collections.Generic;
using System.Text;

namespace FindGuiatrTester
{
  public   class GuitarSpec
    {
        private string builder, model, type, backWood, topWood;
        public GuitarSpec(Builder builder, string model, Type type, Wood backWood, Wood topWood)
        {
            this.builder = builder.ToString();
            this.model = model;
            this.type = type.ToString();
            this.backWood = backWood.ToString();
            this.topWood = topWood.ToString();
        }
        public string getBuilder()
        {
            return builder;
        }

        public string getModel()
        {
            return model;
        }

        public string getType()
        {
            return type;
        }

        public string getBackWood()
        {
            return backWood;
        }

        public string getTopWood()
        {
            return topWood;
        }

    }
}
