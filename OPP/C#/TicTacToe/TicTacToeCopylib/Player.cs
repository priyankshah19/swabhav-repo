using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
   public class Player
    {
        private string _name;
        private Mark _mark;

        public string Name
        {
            get
            {
                return _name;
            }

        }

        public Mark Mark
        {
            get
            {
                return _mark;
            }

        }

        public Mark GetMark()
        {
            return _mark;
        }

        public void SetMark(Mark mark)
        {
            this._mark = mark;
        }

        public Player(string name,Mark mark)
        {
            this._name = name;
            this._mark = mark;
        }


    }
}
