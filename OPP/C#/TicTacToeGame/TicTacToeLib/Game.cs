using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicTacToeLib
{
    public class Game
    {
        private Player[] _players;
        private Board _board;
        private ResultAnalyzer _resultanalyzer;
        private int switching;
        private Result _status;

        public Game(Player[] players, Board board, ResultAnalyzer analyzer)
        {
            _board = board;
            _resultanalyzer = analyzer;
            _players = players;
            switching = 0;
        }
        public Result Status()
        {
            return _status;
        }
        public string PlayerName
        {
            get
            {
                if (switching == 1)
                    return _players[0].Name;
                return _players[1].Name;
            }

        }
        public string PlayerNameWin
        {
            get
            {
                if (switching == 0)
                    return _players[0].Name;
                return _players[1].Name;
            }

        }
        public void Play(int position)
        {
            



            if (switching == 0)
            {

                Console.WriteLine(_players[switching].Name);
                Console.WriteLine(_players[switching].MARk);

                _board.SetPosition(position, _players[switching].MARk);
                switching = 1;
                _status = _resultanalyzer.resultGenerator();
                return;
            }
            _board.SetPosition(position, _players[switching].MARk);
            switching = 0;
            _status = _resultanalyzer.resultGenerator();
        }
        public int Switch
        {
            get
            {
                return switching;
            }
        }


    }

}

