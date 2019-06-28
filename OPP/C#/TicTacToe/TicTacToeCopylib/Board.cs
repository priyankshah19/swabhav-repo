using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
   public class Board
    {
        private Cell[] cells = new Cell[9];
        private static int maxindex = 8;

        public Board()
        {
            InitializeCells();
        }

        public void InitializeCells()
        {
            for(int index=0;index<=maxindex;index++)
            {
                cells[index] = new Cell();
            }
        }

        public Cell[] GetCells()
        {
            return cells;
        }

        public bool IsBoardEmpty()
        {
            for (int index = 0; index <= maxindex; index++)
            {
                if(!cells[index].GetMark().Equals(Mark.EMPTY))
                {
                    return false;
                }
            }
            return true;

        }
        public bool IsBoardFull()
        {
            for (int index = 0; index <= maxindex; index++)
            {
                if (cells[index].GetMark().Equals(Mark.EMPTY))
                {
                    return false;
                }
            }
            return true;

        }

        public void SetLocation(Mark mark , int index)
        {
            cells[index].SetMark(mark);
        }

    }
}
