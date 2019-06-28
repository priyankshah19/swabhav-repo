using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToeLib;
namespace TicTacToeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
               TicTacToeConsole tictactoe = new TicTacToeConsole();
      
               tictactoe.Start(); 
            TicTacToeWinsConsoleApp console = new TicTacToeWinsConsoleApp();
            Application.Run(console); 
        }
    }
}
