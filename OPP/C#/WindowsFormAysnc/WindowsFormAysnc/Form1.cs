using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAysnc
{
    public partial class Form1 : Form
    {
        string message = "";
        public Form1()
        {
            InitializeComponent();
        }
        private async Task MethodAsync()
        {
            await Task.Delay(3000);
            message = "finished";
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show("hi");
        }

        private async  void button2_Click(object sender, EventArgs e)
        {
            await MethodAsync();
            textBox1.Text = "hello";
        }
    }
}
