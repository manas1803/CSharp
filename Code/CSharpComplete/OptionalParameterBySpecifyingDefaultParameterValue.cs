using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class OptionalParameterBySpecifyingDefaultParameterValue
    {
        public void Print()
        {
            OptionalParameterBySpecifyingDefaultParameterValue od = new OptionalParameterBySpecifyingDefaultParameterValue();
            od.AddNumbers(10, 20,new int []{ 30,40});
        }
        public void AddNumbers(int FirstNumber, int SecondNumber, int [] RestOfNumbers=null)
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
