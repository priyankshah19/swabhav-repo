using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
   public class Cell
    {
        private Mark mark;
        public Cell()
        {
            mark = Mark.EMPTY;
        }
       public Mark MARK
        {
            set
            {
                mark = value;
            }
            get
            {
                return mark;
            }
        }
       public bool IsAlreadymarked()
        {
            if (!(mark == Mark.EMPTY))
            {
                return true;
            }
            else
                return false;
        }

    }
}
