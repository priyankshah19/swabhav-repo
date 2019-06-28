using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleWinForm
{
    class WelcomeForm:Form
    {
        Button button1;
        public WelcomeForm()
        {
            this.Text = "priyank";
              this.Height = 1024;
              this.Width = 268;
        //    this.StartPosition = FormStartPosition.CenterScreen; //form will appear in center of screen
        //    this.ClientSize = new Size(400, 200);//will set height and width of form
            button1 = new Button();
            button1.Size = new Size(40, 40);
            button1.Location = new Point(30, 30);
            button1.Text = "Click me";
            this.Controls.Add(button1); //adding button to control class
            button1.Click += new EventHandler(button1_Click);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
