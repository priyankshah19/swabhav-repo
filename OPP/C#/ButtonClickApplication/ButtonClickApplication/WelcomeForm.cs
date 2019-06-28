using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ButtonClickApplication
{
    class WelcomeForm:Form
    {
        public Button button1;
        public Button button2;
        public WelcomeForm()
        {
            this.Height = 768;
            this.Width = 1000;
            button1 = new Button();
            button1.Height = 100;
            button1.Width = 100;
            button1.Text = "Submit1";
            button1.Location = new Point(181, 142);
            this.Controls.Add(button1);
            button2 = new Button();
            button2.Height = 100;
            button2.Width = 100;
            button2.Text = "Submit2";
          //  button2.Location = new Point(181, 142);
        //    this.Controls.Add(button2);

           // Casestudy1();
            CaseStudy2();
        }

        private void Casestudy1()
        {
            button1.Click += new EventHandler(button1_click);
            button1.Click += button2_click;
        }
        private void CaseStudy2()
        {
            button1.Click += new EventHandler(button1_click);
            button2.Click += button1_click;
        }
        private void button1_click(object sender,EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("Hi You have Clicked on"+btn.Text);
        }
        private void button2_click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
    }
}
