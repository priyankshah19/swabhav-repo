using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
 public   class Game
    {
        private Board _board;
        private Player _player;
        private ResultAnalyzer _resultanalyzer;
        private static int _turn = 0;
        private Result _status;

        public ResultAnalyzer resultanalyzer
        {
            get
            {
                return _resultanalyzer;
            }
        }

        public Board Board
        {
            get
            {
                return _board;
            }
        }

        public Player Player
        {
            get
            {
                return _player;
            }
        }

        public Result Status
        {
            get
            {
                return _status;
            }
        }


        public Game()
        {
            _board = new Board();
            _resultanalyzer = new ResultAnalyzer(_board);
            _status = Result.ONGOING;

        }

        public void Play(int index)
        {
            if(_status.Equals(Result.ONGOING))
            {
                _player= PlayerTurn();
                _board.SetLocation(_player.GetMark(), index);
                _status = _resultanalyzer.AnalyzeResult();
            }
           

        }


        public Player PlayerTurn()
        {
            _turn = _turn + 1;
            if (_turn % 2 == 0)
            {
                return new Player("meet", Mark.X);
                
            }
           
            else  return new Player("priyank", Mark.O);
            
        }


    }
}
