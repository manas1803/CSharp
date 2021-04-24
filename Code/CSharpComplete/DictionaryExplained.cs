using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class DictionaryExplained
    {
        public void Print()
        {
            Dictionary<int, Employee> employeeDictionary = new Dictionary<int, Employee>();
            
            Employee e1 = new Employee()
            {
                EmpId = 101,
                EmpName = "Manas",
                Salary = 30000
            };

            Employee e2 = new Employee()
            {
                EmpId = 102,
                EmpName = "Arjun",
                Salary = 40000
            };

            Employee e3 = new Employee()
            {
                EmpId = 103,
                EmpName = "Atul",
                Salary = 50000
            };
            
            employeeDictionary.Add(e1.EmpId,e1);
            employeeDictionary.Add(e2.EmpId,e2);
            employeeDictionary.Add(e3.EmpId,e3);


            foreach(KeyValuePair<int,Employee> empData in employeeDictionary)
            {
                Console.WriteLine("The employee id is {0}",empData.Key);
                
                Console.WriteLine("The employee name is " + employeeDictionary[empData.Key].EmpName + " and the salary of employee is " + employeeDictionary[empData.Key].Salary);
                Console.WriteLine("--------------------------------------------------------------------------------------------------------");
            }
        }
    }
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Salary { get; set; }
    }
}
