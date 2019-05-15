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

namespace ResumeApplication
{
    public partial class Form1 : Form
    {
        private object server;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamWriter swrite = new StreamWriter("D:\\Swabhav rep\\OPP\\Assignment\\Resume.html");
            swrite.WriteLine("    < td > Password </ td > ");
            swrite.WriteLine(" <td> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td> ");
            swrite.WriteLine("<html>");
            swrite.WriteLine("<html>");

        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter swrite = new StreamWriter("D:\\Swabhav rep\\OPP\\Assignment\\Resume.html");
            swrite.WriteLine("<!DOCTYPE html>");
            swrite.WriteLine("<html>");
            swrite.WriteLine("<head>");
            swrite.WriteLine("<title></title> ");
            swrite.WriteLine("</head>  ");
            swrite.WriteLine(" <form> ");
            swrite.WriteLine("<div> ");
            swrite.WriteLine("  <table class> ");
            swrite.WriteLine("<tr> ");
            swrite.WriteLine(" <td>Name :</td>");
            swrite.WriteLine(" <td>  ");
            swrite.WriteLine("<asp:TextBox></asp:TextBox>  ");
            swrite.WriteLine(" </td> ");
            swrite.WriteLine(" </tr> ");
            swrite.WriteLine("</html>");
          
            swrite.Close();
            StreamReader sread = new StreamReader("D:\\Swabhav rep\\OPP\\Assignment\\Resume.html");

            sread.Close();
        }
    }
}
