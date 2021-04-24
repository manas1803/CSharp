using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpComplete
{
    class DictionaryTryGet
    {
        public void Print()
        {
            Dictionary<int, Employees> employeeDictionary = new Dictionary<int, Employees>();

            Employees e1 = new Employees()
            {
                EmpId = 101,
                EmpName = "Manas",
                Salary = 30000
            };

            Employees e2 = new Employees()
            {
                EmpId = 102,
                EmpName = "Arjun",
                Salary = 40000
            };

            Employees e3 = new Employees()
            {
                EmpId = 103,
                EmpName = "Atul",
                Salary = 50000
            };

            employeeDictionary.Add(e1.EmpId, e1);
            employeeDictionary.Add(e2.EmpId, e2);
            employeeDictionary.Add(e3.EmpId, e3);

            Employees e4 = new Employees();
            Console.WriteLine("Please enter the key for which to search for data in dictionary");
            int key = Convert.ToInt32(Console.ReadLine());
            if(!employeeDictionary.TryGetValue(key,out e4))
            {
                Console.WriteLine("Enter the employee name and employee salary");
                employeeDictionary.Add(key, new Employees() { EmpId = key, EmpName = Console.ReadLine(), Salary = Convert.ToInt32(Console.ReadLine()) });
            }
            else
            {
                Console.WriteLine("The Employee exists and the details are");
            }

            int counter = employeeDictionary.Count;
            int linqCounter = employeeDictionary.Count(kvp=>kvp.Value.Salary>35000);

            Console.WriteLine(counter);
            Console.WriteLine(linqCounter);

            foreach (KeyValuePair<int, Employees> empData in employeeDictionary)
            {
                Console.WriteLine("The employee id is {0}", empData.Key);

                Console.WriteLine("The employee name is " + employeeDictionary[empData.Key].EmpName + " and the salary of employee is " + employeeDictionary[empData.Key].Salary);
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            }
        }
        class Employees
        {
            public int EmpId { get; set; }
            public string EmpName { get; set; }
            public int Salary { get; set; }
        }
    }
}
