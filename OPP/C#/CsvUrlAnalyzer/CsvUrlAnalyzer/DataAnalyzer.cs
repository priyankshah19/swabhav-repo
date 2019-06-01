using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsvUrlAnalyzer
{
    class DataAnalyzer

    {
       
        public DataAnalyzer(ILoader i)
        {
            i.load();
            
           
        }
        public static void Display()
        {
           
        }
        public string MaximumSalary(HashSet<Employee> emplist)
        {
            int maximum = 0;
            string name = " ";
            foreach (var employee in emplist)
            {
                if (employee.Salary > maximum)
                {
                    maximum = employee.Salary;
                    name = employee.Empname;
                }
            }

            return (name + " and Salary:" + maximum.ToString());
        }

        public void EmployeeCountDesgination(HashSet<Employee> emplist)
        {

            List<string> empdesignation = new List<string>();
            foreach (var employee in emplist)
            {
                int count = 0;
                string designation = employee.Empdesignation;
                if (!empdesignation.Contains(designation))
                {
                    foreach (var employees in emplist)
                    {

                        if (designation == employees.Empdesignation)
                        {

                            count = count + 1;
                        }


                    }

                    Console.WriteLine("Designation:" + designation + "Count:" + count);
                }
                empdesignation.Add(designation);
            }
        }


        public void EmpCountDeptno(HashSet<Employee> emplist)
        {
            List<string> empdepno = new List<string>();
            foreach (var employee in emplist)
            {
                int count = 0;
                string depno = employee.Deptno.ToString();
                if (!empdepno.Contains(depno))
                {
                    foreach (var employees in emplist)
                    {

                        if (depno == employees.Deptno.ToString())
                        {

                            count = count + 1;


                        }


                    }

                    Console.WriteLine("Designation:" + depno + "Count:" + count);
                }
                empdepno.Add(depno);
            }
        }

        public void DictionaryDesignation(HashSet<Employee> emplist)
        {
            Dictionary<int,string> dictionary = new Dictionary<int,string>();
            
            foreach (var e in emplist)
            {
                dictionary.Add(e.Empid,e.Empdesignation);
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine(" {0} Designation: {1}", item.Key, item.Value);
            }

            //Create a different dictionary to store the counts.
            Dictionary<string, int> valCount = new Dictionary<string, int>();
            //Iterate through the values, setting count to 1 or incrementing current count.
            foreach (string i in dictionary.Values)
                if (valCount.ContainsKey(i))
                    valCount[i]++;
                else
                    valCount[i] = 1;
            //Finally some code to output this and prove it worked:
            foreach (KeyValuePair<string, int> kvp in valCount)//note - not sorted, that must be added if needed
                Console.WriteLine("{0} - {1}", kvp.Key, kvp.Value);

        }
    }

}
