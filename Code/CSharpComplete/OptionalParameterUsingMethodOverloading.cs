using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class OptionalParameterUsingMethodOverloading
    {
        public void Print()
        {
            OptionalParameterUsingMethodOverloading oop = new OptionalParameterUsingMethodOverloading();
            oop.AddNumbers(10, 20);
            
        }
        public void AddNumbers(int FirstNumber, int SecondNumber)
        {
            OptionalParameterUsingMethodOverloading o = new OptionalParameterUsingMethodOverloading();
            o.AddNumbers(FirstNumber, SecondNumber, null);
        }
        public void AddNumbers(int FirstNumber, int SecondNumber, int[] RestOfNumbers)
        {
            int sum = FirstNumber + SecondNumber;
            if (RestOfNumbers != null)
            {
                foreach (int i in RestOfNumbers)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum is {0}", sum);
        }
    }
}
