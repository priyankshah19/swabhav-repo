using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ConsoleWinForm
{
    class Program
    {
 
        static void Main(string[] args)
        {
            WelcomeForm form = new WelcomeForm();
            Application.EnableVisualStyles();
            Application.Run(form);
            //form.Show();
           // form.ShowDialog();

        }
        
    }
}
