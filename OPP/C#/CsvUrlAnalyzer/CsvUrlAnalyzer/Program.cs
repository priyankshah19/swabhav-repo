using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvUrlAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            DataAnalyzer d = new DataAnalyzer(new UrlLoader());
            d.EmpCountDeptno(u.emplist);
       //     d.EmpCountDeptno();
         //   CsvLoader c = new CsvLoader();
         //   UrlLoader u = new UrlLoader();
           // c.load();
          //  d.DictionaryDesignation(c.emplist);
            //d.EmpCountDeptno(c.emplist);
          //  u.load();
          //  Console.Write("Maximum Salaried Employee");
         //   Console.WriteLine(d.MaximumSalary(u.emplist));
         //   Console.WriteLine("Designation Wise Count");
         //   d.EmployeeCountDesgination(u.emplist);
        //    Console.WriteLine("DepartmentNo Wise Count");
         //   d.EmpCountDeptno(u.emplist);
           
       
          //  DisplayUrlData(d, url);
           // DisplayCsvData(d, csv);
        }

        private static void DisplayCsvData(DataAnalyzer d, CsvLoader csv)
        {
            csv.load();
            Console.Write("Maximum Salaried Employee");
            Console.WriteLine(d.MaximumSalary(csv.emplist));
            Console.WriteLine("Designation Wise Count");
            d.EmployeeCountDesgination(csv.emplist);
            Console.WriteLine("DepartmentNo Wise Count");
            d.EmployeeCountDesgination(csv.emplist);
        }

        private static void DisplayUrlData(DataAnalyzer d, UrlLoader url)
        {
            url.load();


            Console.Write("Maximum Salaried Employee");
            Console.WriteLine(d.MaximumSalary(url.emplist));

            Console.WriteLine("Designation Wise Count");
            d.EmployeeCountDesgination(url.emplist);
            Console.WriteLine("DepartmentNo Wise Count");
            d.EmployeeCountDesgination(url.emplist);
        }

    }
}
