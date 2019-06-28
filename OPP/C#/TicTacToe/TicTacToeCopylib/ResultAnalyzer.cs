using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
   public class ResultAnalyzer
    {
        private Board _board;

        public ResultAnalyzer(Board board)
        {
            this._board = board;
        }

        public Result AnalyzeResult()
        {
          
            if (Diagonally().Equals(Result.WIN) || Horizontally().Equals(Result.WIN) || Vertically().Equals(Result.WIN))   // if win in any case 
            {
                return Result.WIN;
            }
            else if (_board.IsBoardFull())      // checking cell 
            {
                return Result.DRAW;
            }
            return Result.ONGOING ;
        }

        private Result Vertically()
        {
            Cell[] cell = _board.GetCells();
            // will first check whether  each cell is marked or empty
            if(!(cell[0].GetMark().Equals(Mark.EMPTY)) && !(cell[3].GetMark().Equals(Mark.EMPTY)) && !(cell[6].GetMark().Equals(Mark.EMPTY)))
            {
                if(cell[0].GetMark().Equals(cell[3].GetMark()) && cell[3].GetMark().Equals(cell[6].GetMark()))
                {
                    return Result.WIN;
                }

            }
            if(!(cell[1].GetMark().Equals(Mark.EMPTY)) && !(cell[4].GetMark().Equals(Mark.EMPTY)) && !(cell[7].GetMark().Equals(Mark.EMPTY)))
            {
                if (cell[1].GetMark().Equals(cell[4].GetMark()) && cell[4].GetMark().Equals(cell[7].GetMark()))
                {
                    return Result.WIN;
                }
            }

            if(!(cell[2].GetMark().Equals(Mark.EMPTY)) && !(cell[5].GetMark().Equals(Mark.EMPTY)) && !(cell[8].GetMark().Equals(Mark.EMPTY)))
            {
                if (cell[2].GetMark().Equals(cell[5].GetMark()) && cell[5].GetMark().Equals(cell[8].GetMark()))
                {
                    return Result.WIN;
                }
            }

            return Result.ONGOING;

        }

        private Result Horizontally()
        {
            Cell[] cell = _board.GetCells();
            if (!(cell[0].GetMark().Equals(Mark.EMPTY)) && !(cell[1].GetMark().Equals(Mark.EMPTY)) && !(cell[2].GetMark().Equals(Mark.EMPTY)))
            {
                if (cell[0].GetMark().Equals(cell[1].GetMark()) && cell[1].GetMark().Equals(cell[2].GetMark()))
                {
                    return Result.WIN;
                }

            }
            if (!(cell[3].GetMark().Equals(Mark.EMPTY)) && !(cell[4].GetMark().Equals(Mark.EMPTY)) && !(cell[5].GetMark().Equals(Mark.EMPTY)))
            {
                if (cell[3].GetMark().Equals(cell[4].GetMark()) && cell[4].GetMark().Equals(cell[5].GetMark()))
                {
                    return Result.WIN;
                }
            }

            if (!(cell[6].GetMark().Equals(Mark.EMPTY)) && !(cell[7].GetMark().Equals(Mark.EMPTY)) && !(cell[8].GetMark().Equals(Mark.EMPTY)))
            {
                if (cell[6].GetMark().Equals(cell[7].GetMark()) && cell[7].GetMark().Equals(cell[8].GetMark()))
                {
                    return Result.WIN;
                }
            }


            return Result.ONGOING;

        }

        private Result Diagonally()
        {
            Cell[] cell = _board.GetCells();
            if (!(cell[0].GetMark().Equals(Mark.EMPTY)) && !(cell[4].GetMark().Equals(Mark.EMPTY)) && !(cell[8].GetMark().Equals(Mark.EMPTY)))
            {
                if(cell[0].GetMark().Equals(cell[4].GetMark()) && cell[4].GetMark().Equals(cell[8].GetMark()))
                {
                    return Result.WIN;
                }
            }
            else if((!(cell[2].GetMark().Equals(Mark.EMPTY)) && !(cell[4].GetMark().Equals(Mark.EMPTY)) && !(cell[6].GetMark().Equals(Mark.EMPTY))))
            {
                if (cell[2].GetMark().Equals(cell[4].GetMark()) && cell[4].GetMark().Equals(cell[6].GetMark()))
                {
                    return Result.WIN;
                }
            }
           
            return Result.ONGOING;
        }


    }

}
