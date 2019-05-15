using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace HtmlFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter swrite = new StreamWriter("D:\\Swabhav rep\\OPP\\Assignment\\htmlfile.html");
            swrite.WriteLine("<html>");
            swrite.WriteLine("<body>");
            swrite.WriteLine("<p>This is web page</p>");
            swrite.WriteLine("</body>");
            swrite.WriteLine("</html>");
            swrite.Close();

        }
    }
}
