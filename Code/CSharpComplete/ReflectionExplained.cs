using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
namespace CSharpComplete
{
    public class MainClass
    {
        public void Printing()
        {
            Type T = Type.GetType("CSharpComplete.ReflectionExplained");
            PropertyInfo[] properties = T.GetProperties();
            Console.WriteLine();
            Console.WriteLine("Properties list for ReflectionExplained class is ");

            foreach(PropertyInfo property in properties)
            {
                Console.WriteLine("Name of property is "+ property.Name + " and property type is " + property.PropertyType);
            }

            MethodInfo[] methods = T.GetMethods();
            Console.WriteLine();
            Console.WriteLine("Methods list for ReflectionExplained class is ");

            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("Name of method is " + method.Name + " and method type is " + method.ReturnType);
            }

            ConstructorInfo[] constructors = T.GetConstructors();
            Console.WriteLine();
            Console.WriteLine("Constructors list for ReflectionExplained class is ");

            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine("Name of constructor is " + constructor.ToString());
            }
        }
    }
    public class ReflectionExplained
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private int _marks;

        ReflectionExplained()
        {

        }
        ReflectionExplained(int marks)
        {
            this._marks = marks;
        }

        public void Print()
        {
            Console.WriteLine("Hello World");
        }
        public void Run()
        {
            Console.WriteLine("Lets run");
        }
    }
}
