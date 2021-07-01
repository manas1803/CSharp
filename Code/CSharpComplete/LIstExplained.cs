using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class LIstExplained
    {
        public void Main()
        {
            List<Student1> li = new List<Student1>();
            Student1 st1 = new Student1()
            {
                Id = 101,
                FirstName = "Tom",
                LastName = "Cruise",
                Marks = 98
            };
            Student1 st2 = new Student1()
            {
                Id = 102,
                FirstName = "Bruce",
                LastName = "Wayne",
                Marks = 99
            };
            Student1 st3 = new Student1()
            {
                Id = 103,
                FirstName = "John",
                LastName = "Watson",
                Marks = 96
            };
            Student1 st4 = new Student1()
            {
                Id = 104,
                FirstName = "Clark",
                LastName = "Kent",
                Marks = 96
            };
            li.Add(st1);
            li.Add(st2);
            li.Add(st3);
            li.Add(st4);

            if (li.Contains(st1))
            {
                Console.WriteLine("Yes the student exists");
            }
            else
            {
                Console.WriteLine("No it does not exists");
            }

            if (li.Exists(s => s.FirstName.StartsWith("C")))
            {
                Console.WriteLine("Hello Superman");
            }
            else
            {
                Console.WriteLine("No Justice League member");
            }

            Student1 ss = li.Find(s => s.Marks > 90);
            Console.WriteLine("FirstName of student is {0},LastName of student is {1} and there marks are {2}", ss.FirstName, ss.LastName, ss.Marks);

            Student1 sl = li.FindLast(s => s.Marks > 90);
            Console.WriteLine("FirstName of student is {0},LastName of student is {1} and there marks are {2}", sl.FirstName, sl.LastName, sl.Marks);


            List<Student1> ll = li.FindAll(s => s.Marks > 90);

            foreach(Student1 sss in ll)
            {
                Console.WriteLine("FirstName of student is {0},LastName of student is {1} and there marks are {2}", sss.FirstName, sss.LastName, sss.Marks);
            }

        }
    }
    public class Student1
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Marks { get; set; }
    }
}
