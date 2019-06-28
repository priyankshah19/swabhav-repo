using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeLib
{
    public class TicTacToeWinsConsoleApp:Form
    {
        TextBox currentplayertextbox;
        TextBox currentstatus;
        public TicTacToeWinsConsoleApp()
        {
            this.Height = 750;
            this.Width = 1024;
            this.BackColor = Color.LightBlue;

            currentplayertextbox = new TextBox();
            this.Controls.Add(currentplayertextbox);
            currentplayertextbox.Height = 50;
            currentplayertextbox.Width = 100;
            currentplayertextbox.Location = new Point(181, 25);
            Label currentplayerlabel = new Label();
            currentplayerlabel.Height = 50;
            currentplayerlabel.Width = 100;
            currentplayerlabel.Text = "Current Player";
            currentplayerlabel.Location = new Point(90, 25);
            this.Controls.Add(currentplayerlabel);

            currentstatus = new TextBox();
            this.Controls.Add(currentstatus);
            currentstatus.Height = 50;
            currentstatus.Width = 100;
            currentstatus.Location = new Point(462, 25);
            Label status = new Label();
            status.Height = 50;
            status.Width = 100;
            status.Text = "Current Status";
            status.Location = new Point(371, 25);
            this.Controls.Add(status);

            TextBox winner = new TextBox();
            this.Controls.Add(winner);
            winner.Height = 50;
            winner.Width = 100;
            winner.Text = "NO ONE";
            winner.Location = new Point(743, 25);
            Label winningplayer = new Label();
            winningplayer.Height = 50;
            winningplayer.Width = 100;
            winningplayer.Text = "Winning Player";
            winningplayer.Location = new Point(652, 25);
            this.Controls.Add(winningplayer);

            for (int index = 0; index < 3; index++)
            {

                Button button = new Button();
                button.Height = 100;
                button.Width = 100;
                button.Text = (index).ToString();
                button.Location = new Point((281 * index) + 181, 75);
                button.BackColor = Color.LightGoldenrodYellow;
                button.Click += new EventHandler(ButtonClickOneEvent);
                button.Tag = index;
                this.Controls.Add(button);
            }
            for (int index = 0; index < 3; index++)
            {

                Button button = new Button();
                button.Height = 100;
                button.Width = 100;
                button.Text = (index + 3).ToString();
                button.Location = new Point((281 * index) + 181, 250);
                button.BackColor = Color.LightGoldenrodYellow;
                button.Click += new EventHandler(ButtonClickOneEvent);
                button.Tag = index;
                this.Controls.Add(button);
            }
            for (int index = 0; index < 3; index++)
            {

                Button button = new Button();
                button.Height = 100;
                button.Width = 100;
                button.Text = (index + 6).ToString();
                button.Location = new Point((281 * index) + 181, 425);
                button.BackColor = Color.LightGoldenrodYellow;
                button.Click += new EventHandler(ButtonClickOneEvent);
                this.Controls.Add(button);
            }
            //startbutton
            Button startbutton = new Button();
            startbutton.Height = 50;
            startbutton.Width = 100;
            startbutton.Text = "Start Game";
            startbutton.Location = new Point(461, 600);
            startbutton.BackColor = Color.ForestGreen;
            startbutton.Click += new EventHandler(StartButtonClickEvent);
            this.Controls.Add(startbutton);
        }
        private void StartButtonClickEvent(Object sender, EventArgs e)
        {
           
           
        }
        private void Currentplayer(object sender, EventArgs e)
        {
            Game game = new TicTacToeLib.Game();
            TextBox textbox = sender as TextBox;
      
        }

        private void  ButtonClickOneEvent(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            Game game = new TicTacToeLib.Game();
            int index = int.Parse(btn.Text);
            game.Play(index);
            currentplayertextbox.Text = game.Player.Name;
            btn.Text = game.Player.Mark.ToString();
           
            currentstatus.Text = game.Status.ToString();
          
           
            
        }


    }
}
