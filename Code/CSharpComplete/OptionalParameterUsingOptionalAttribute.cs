using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpComplete
{
    class OptionalParameterUsingOptionalAttribute
    {
        public void Print()
        {
            OptionalParameterUsingOptionalAttribute ooa = new OptionalParameterUsingOptionalAttribute();
            ooa.AddNumbers(10, 20);
        }
        public void AddNumbers(int FirstNumber, int SecondNumber, [Optional] int[] RestOfNumbers)
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
