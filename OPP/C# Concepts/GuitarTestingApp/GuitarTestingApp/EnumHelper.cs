using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace GuitarTestingApp
{
    class EnumHelper
    {

        public enum Wood
        {
            WOOD, WOOD1, WOOD2
        }
        public string WoodInfo(Wood woodinfo)
        {
            switch (woodinfo)
            {
                case Wood.WOOD1:return "Wood";
                    
                    break;
                case Wood.WOOD2:
                    Console.WriteLine("this is wood2");
                    break;
            }
        }
        public enum Type
        {
            Electric, Iron
        }
        public void TypeInfo(Type typeinfo)
        {

            switch (typeinfo)
            {
                case Type.Electric:
                    Console.WriteLine("electric");
                    break;
                case Type.Iron:
                    Console.WriteLine("iron");
                    break;
            }
        }

        public enum Builder
        {
            WOOD, Stick
        }
        public void BuilderInfo(Builder builderinfo)
        {

            switch (builderinfo)
            {
                case Builder.WOOD:
                    Console.WriteLine("wood");
                    break;
                case Builder.Stick:
                    Console.WriteLine("stick");
                    break;
            }
        }
    }
}

