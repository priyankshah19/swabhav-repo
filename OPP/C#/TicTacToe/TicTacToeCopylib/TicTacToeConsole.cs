using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeLib
{
    public  class TicTacToeConsole
    {
        private static Game game;


        public void Start()
        {
            game = new Game();
           

           game.Play(0);
            DisplayBoard(game.Board);
            DisplayStatus();

            game.Play(5);
            DisplayBoard(game.Board);
            DisplayStatus();

            game.Play(1);
            DisplayBoard(game.Board);
            DisplayStatus();
           
            game.Play(4);
            DisplayBoard(game.Board);
            DisplayStatus();

            game.Play(2);
            DisplayBoard(game.Board);
            DisplayStatus();    

        }

       

        private void DisplayBoard(Board board)
        {
            Cell[] cell = board.GetCells();
            int index = 0;
            for(int i = 0; i<=2; i++)
            {
                for(int j = 0; j<=2; j++)
                {
                    if(cell[index].GetMark().Equals(Mark.EMPTY))
                    {
                        Console.Write("-\t");
                    }
                    else
                    {
                        Console.Write(cell[index].GetMark() + "\t");
                    }
                    index = index + 1;
                }
                Console.WriteLine();
            }

        }

        private void DisplayStatus()
        {
            Result resstatus = game.Status;
            if(resstatus == Result.WIN)
            {
                Console.WriteLine("Player:" + game.Player.Name + "  Wins");
            }
            if(resstatus == Result.DRAW)
            {
                Console.WriteLine("Game is draw");
            }
            if(resstatus == Result.ONGOING)
            {
                Console.WriteLine("Current Player:"+game.Player.Name);
            }
            Console.WriteLine();
        }

    }
}
