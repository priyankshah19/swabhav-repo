using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvUrlAnalyzer
{
    class CsvLoader : ILoader
    {
        public  HashSet<Employee> emplist = new HashSet<Employee>();



        public  void load()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Swabhav rep\OPP\C#\CsvToList\dataFile.txt");
            foreach (string employee in lines)
            {
                var values = employee.Split(',');

                emplist.Add(new Employee()
                {

                    Empid = int.Parse(values[0]),
                    Empname = values[1],
                    Empdesignation = values[2],
                    Managerid = values[3],
                    Doj = values[4],
                    Salary = int.Parse(values[5]),
                    Commission = values[6],
                    Deptno = int.Parse(values[7])


                });



            }
            foreach (var e in emplist)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7}", e.Empid.ToString(), e.Empname, e.Empdesignation, e.Managerid, e.Doj, e.Salary.ToString(), e.Commission, e.Deptno.ToString());
            }
        }

   

      
    }
}
