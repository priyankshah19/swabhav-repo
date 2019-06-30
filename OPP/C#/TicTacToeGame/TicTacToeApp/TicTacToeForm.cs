using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicTacToeLib;
using System.Drawing;
namespace TicTacToeApp
{
    class TicTacToeForm : Form
    {
        private Board board;
        private ResultAnalyzer result;
        private Player[] players;
        private Game game;
        private Label winnerlabel = new Label();
        Label gameturn_Label_info;
        private List<Button> buttons = new List<Button>();

        public TicTacToeForm()
        {
            this.Text = "tictactoe game";
            this.Height = 786;
            this.Width = 1024;
            AddingButton();
            Intialize();
            Label player_Label1 = new Label();
            player_Label1.Text = "Player 1 : " + players[0].Name + "  " + players[0].MARk;
            player_Label1.Width = 160;
            player_Label1.Location = new Point(800, 15);

            Label player_Label2 = new Label();
            player_Label2.Text = "Player 2 : " + players[1].Name + "  " + players[1].MARk;
            player_Label2.Width = 160;
            player_Label2.Location = new Point(800, 40);

            Label gameStatus_Label; gameStatus_Label = new Label();
            gameStatus_Label.Text = "Game Status : ";
            gameStatus_Label.Width = 80;
            gameStatus_Label.Location = new Point(800, 70);

            winnerlabel = new Label();
            winnerlabel.Text = " ";
            winnerlabel.Width = 80;
            winnerlabel.Location = new Point(900, 70);

            Label gameturn_Label = new Label();
            gameturn_Label.Text = "Player Turn :";
            gameturn_Label.Width = 80;
            gameturn_Label.Location = new Point(800, 100);

            gameturn_Label_info = new Label();
            gameturn_Label_info.Text = "priyank";
            gameturn_Label_info.Width = 80;
            gameturn_Label_info.Location = new Point(900, 100);

            this.Controls.Add(player_Label1);
            this.Controls.Add(player_Label2);
            this.Controls.Add(gameStatus_Label);
            this.Controls.Add(winnerlabel);
            this.Controls.Add(gameturn_Label);

            this.Controls.Add(gameturn_Label_info);
        }

        void backgroundchange(object obj, EventArgs args)
        {
            int Position;
            Button button = (Button)obj;
            Position = Convert.ToInt32(button.Text);
            game.Play(Position);
            gameturn_Label_info.Text = game.PlayerNameWin;
            winnerlabel.Text = " game in progress";
            if (game.Status() == Result.WIN)
            {
                winnerlabel.Text = game.PlayerName + " wins..";
                gameturn_Label_info.Text = "";
                foreach (Button buttondisable in buttons)
                    buttondisable.Enabled = false;
            }
            if (game.Status() == (Result.DRAW))
            {
                winnerlabel.Text = " match is draw";
                gameturn_Label_info.Text = "";
                foreach (Button buttondisable in buttons)
                    buttondisable.Enabled = false;
            }
           
            button.Text = board.Getpositionmark(Position).ToString();
        }

        void Intialize()
        {
            board = new Board();
            result = new ResultAnalyzer(board);
            players = new Player[2];
            players[0] = new Player("priyank", Mark.O);
            players[1] = new Player("meet", Mark.X);
            game = new Game(players, board, result);
        }

        void AddingButton()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button();
                    button.Click += backgroundchange;
                    button.Height = 95;
                    button.Width = 95;
                    button.BackColor = Color.CadetBlue;
                    button.Font = new Font(button.Font.FontFamily,20);
                    button.Text = count.ToString();
                    count++;
                    button.Location = new System.Drawing.Point((j + 3) * 100, (i + 2) * 100);
                    buttons.Add(button);
                    this.Controls.Add(button);
                }
            }
            Button start = new Button();
            start.Click += Restart;
            start.Height = 50;
            start.Width = 100;
            start.Text = "Restart";
            start.Location = new System.Drawing.Point(10, 10);
            this.Controls.Add(start);
        }

        void Restart(object obj, EventArgs args)
        {
            int i = 0;
            foreach (Button button in buttons)
            {
                button.Text = i++.ToString();
                button.Enabled = true;
            }
            winnerlabel.Text = " ";
            Intialize();
            gameturn_Label_info.Text = "priyank";
        }
    }
}
