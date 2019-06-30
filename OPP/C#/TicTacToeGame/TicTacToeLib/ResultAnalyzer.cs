using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
   public class ResultAnalyzer
    {
       private Board _board = new Board();
        public ResultAnalyzer(Board board)
        {
            _board = board;
        }
        public Result resultGenerator()
        {
            if ((_board.Getpositionmark(0) == _board.Getpositionmark(1) && _board.Getpositionmark(1) == _board.Getpositionmark(2) && _board.Getpositionmark(0) != Mark.EMPTY)
                
                
            
               
            || (_board.Getpositionmark(3) == _board.Getpositionmark(4) && _board.Getpositionmark(4) == _board.Getpositionmark(5) && _board.Getpositionmark(3) != Mark.EMPTY)

              || (_board.Getpositionmark(6) == _board.Getpositionmark(7) && _board.Getpositionmark(7) == _board.Getpositionmark(8) && _board.Getpositionmark(6) != Mark.EMPTY)

              || (_board.Getpositionmark(0) == _board.Getpositionmark(3) && _board.Getpositionmark(3) == _board.Getpositionmark(6) && _board.Getpositionmark(0) != Mark.EMPTY)

              || (_board.Getpositionmark(1) == _board.Getpositionmark(4) && _board.Getpositionmark(4) == _board.Getpositionmark(7) && _board.Getpositionmark(1) != Mark.EMPTY)

              || (_board.Getpositionmark(2) == _board.Getpositionmark(5) && _board.Getpositionmark(5) == _board.Getpositionmark(8) && _board.Getpositionmark(2) != Mark.EMPTY)

               || (_board.Getpositionmark(0) == _board.Getpositionmark(4) && _board.Getpositionmark(8) == _board.Getpositionmark(4) && _board.Getpositionmark(0) != Mark.EMPTY)

                || (_board.Getpositionmark(2) == _board.Getpositionmark(4) && _board.Getpositionmark(4) == _board.Getpositionmark(6) && _board.Getpositionmark(2) != Mark.EMPTY))



                return Result.WIN;
            if (_board.IsBoardFull())
                return Result.DRAW;
            return Result.PROGRESS;




        }

    }
}
