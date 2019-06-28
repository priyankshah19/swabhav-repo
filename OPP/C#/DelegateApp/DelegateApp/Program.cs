using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateApp
{
    delegate void DPrintMenu(string name);
    class Program
    {
        
        static void Main(string[] args)
        {
          
          //  CaseStudy1();
            Casestudy2();
        }
        private static void CaseStudy1()
        {

            DPrintMenu menu;
            menu = new DPrintMenu(PrintHello);
            menu("meet");
            menu = PrintBye;
            menu("priyank");
            PrintAll(PrintHello);
        }
        private static void Casestudy2()
        {

            DPrintMenu menu;
            menu = new DPrintMenu(PrintHello);
            menu += PrintBye;
            menu("meet");
            menu("priyank");
           
            PrintAll(PrintHello);
        }
        private static void PrintHello(string name)
        {
            Console.WriteLine("Hi Says {0}", name);
        }
        private static void PrintBye(string name)
        {
            Console.WriteLine("Bye Says {0}", name);
        }
        private static void foo()
        {

        }
        private static void PrintAll(DPrintMenu menu)
        {
            Console.WriteLine("Printing starts");
            menu("champ");
        }
    
    
    }
   
}
