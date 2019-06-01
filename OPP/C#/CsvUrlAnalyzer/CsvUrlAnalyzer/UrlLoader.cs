using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CsvUrlAnalyzer
{
    class UrlLoader : ILoader
    {
        public  HashSet<Employee> emplist = new HashSet<Employee>();

        public static string GetCSV(string url)
        {

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();

            StreamReader sr = new StreamReader(resp.GetResponseStream());
            string results = sr.ReadToEnd();
            sr.Close();

            return results;
        }
        public void load()
        {

            string fileList = GetCSV("https://swabhav-tech.firebaseapp.com/emp.txt");
            string[] tempStr;

            tempStr = fileList.Split('\n');
            foreach (string employee in tempStr)
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
