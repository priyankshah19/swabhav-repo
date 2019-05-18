using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
//using System.Collections.Generic;
namespace GuitarTestingApp
{
    class Inventory
    {
        ArrayList guitar = new ArrayList(10);

        public void AddGuitar(string serialnumber, double price, string builder, string type, string model, string blackwood, string topwood)
        {
            Guitar guitar1 = new Guitar(serialnumber,price,builder,type,model,blackwood,topwood);
            guitar.Add(guitar);
        }
        public Guitar GetGuitar(Guitar serialnumber)
        {
          
            return serialnumber;
            }
        }

    public ArrayList Search(Guitar searchguitar)
    {
        ArrayList matchingguitar = new ArrayList();
        foreach (var gui in guitar)
        {
            if(searchguitar.GetBuilder()!=guitar.GetBuilder)
            {

            }
        }
    }

    }
