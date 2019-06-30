using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicTacToeLib;
using System.Windows.Forms;
namespace TicTacToeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               Application.EnableVisualStyles();
               Application.Run(new TicTacToeForm());
              //  Case1();


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
                


        }

        private static void Case1()
        {
            Board board = new Board();
            ResultAnalyzer result = new ResultAnalyzer(board);
            Player[] players = new Player[2];
            players[0] = new Player("meet", Mark.O);
            players[1] = new Player("priyank", Mark.X);
            Game game = new Game(players, board, result);

            while (!board.IsBoardFull())
            {
                int Position;

                Console.WriteLine(game.PlayerName + " : enter the position");
                Position = Convert.ToInt32(Console.ReadLine());
                try
                {


                    game.Play(Position);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    continue;
                }
                Display(board);
                if (game.Status() == Result.WIN)
                {
                    Console.WriteLine("Player " + game.PlayerNameWin + " wins..");
                    break;
                }
                if (game.Status() == (Result.DRAW))
                {
                    Console.WriteLine("The match is draw");
                    break;
                }



            }
        }

        static void Display(Board board)
        {
            int count = 0;
            Console.WriteLine("");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board.Getpositionmark(count) == Mark.EMPTY)
                        Console.Write(" N ");
                    else
                        Console.Write(" " + board.Getpositionmark(count) + " ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}
