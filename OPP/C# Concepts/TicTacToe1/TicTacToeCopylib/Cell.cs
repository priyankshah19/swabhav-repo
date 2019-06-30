using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
   public class Cell
    {
        private Mark _mark;

        public Cell()
        {
            _mark = Mark.EMPTY;
        }

        public void SetMark(Mark mark)
        {
            if(this._mark == Mark.EMPTY)
            {
                this._mark = mark;
            }
            else throw new Exception ("Already marked"); 

        }

        public Mark GetMark()
        {
            return _mark;
        }
    }
}
