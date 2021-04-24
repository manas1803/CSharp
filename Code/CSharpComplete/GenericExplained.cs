using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    public class GenericExplained
    {
        public void Print()
        {
            //Calculate calc = new Calculate();
            //bool value = calc.AreEqual<string>("A","B");
            //if (value)
            //{
            //    Console.WriteLine("Are equal");
            //}
            //else
            //{
            //    Console.WriteLine("Not equal");
            //}

            Calculate<int> calc = new Calculate<int>();
            bool val = calc.AreEqual(20, 20);
            int result = calc.HelloWorld(30, 55);

            if (val)
            {
                Console.WriteLine("The result from hellow world is {0}",result);
            }
            else
            {
                Console.WriteLine("No result");
            }
        }
    }
    public class Calculate<T>
    {
        public bool AreEqual(T Value1,T Value2)
        {
            return Value1.Equals(Value2);
        }
        public T HelloWorld(T value1,T value2)
        {
            if (value1.Equals(value2))
                return value1;
            else
                return value2;
        }

    }
}
