using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class Board
    {
       private Cell[] _cell = new Cell[9];
        public Board()
        {
            for (int i = 0; i < 9; i++)
            {
                _cell[i] = new Cell();
            }
        }
        public Cell[] Getcells
        {
            get
            {
                return _cell;
            }
            
        }
        public void SetPosition(int position, Mark mark)
        {
           
            
                if (_cell[position].IsAlreadymarked())
                {
                    throw new Exception("cell is already filled");

                }
                else
                {
                    _cell[position].MARK = mark;
                }
            }
           

        
        public Mark Getpositionmark(int position)
        {
            return _cell[position].MARK;
        }
        public bool IsBoardFull()
        {
            for (int i = 0; i < 9; i++)
            {
                if (!(_cell[i].IsAlreadymarked()))
                {
                    return false;
                }

            }
            return true;
        }
        public bool IsBoardEmpty()
        {
            for (int i = 0; i < 9; i++)
            {
                if (_cell[i].IsAlreadymarked())
                {
                    return false;
                }

            }
            return true;

        }
    }
}
