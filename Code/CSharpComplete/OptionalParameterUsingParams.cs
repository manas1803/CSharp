using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class OptionalParameterUsingParams
    {
        public void Print()
        {
            OptionalParameterUsingParams op = new OptionalParameterUsingParams();
            op.AddNumbers(10, 20,30,60);
        }
        public void AddNumbers(int FirstNumber,int SecondNumber,params object[] RestOfNumbers)
        {
            int sum = FirstNumber + SecondNumber;
            if (RestOfNumbers != null)
            {
                foreach(int i in RestOfNumbers)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum is {0}",sum);
        }
    }
}
