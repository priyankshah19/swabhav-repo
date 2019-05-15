using System;
using System.Collections.Generic;
using System.Text;

namespace GuitarTestingApp
{
    class GuitarBuilder
    {
        public enum builder
        {
            WOOD ,IRON
        }
        public void paintColor(builder option)
        {
            switch (option)
            
                case builder.WOOD:
                    this. = Color.Red;
                    break;
                case backColors.BLUE:
                    this.BackColor = Color.Blue;
                    break;
                case backColors.GREEN:
                    this.BackColor = Color.Green;
                    break;
                case backColors.YELLOW:
                    this.BackColor = Color.Yellow;
                    break;
                default:
                    this.BackColor = Color.Gray;
                    break;
            }
        }
    }
}
