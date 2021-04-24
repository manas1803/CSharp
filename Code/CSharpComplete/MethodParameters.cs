using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class MethodParameters
    {
        public void MyMethod()
        {
            // Value Parameters
            int j = 0;
            ValueTypeParam(j);
            Console.WriteLine(j);

            // Reference Parameters
            int i = 0;
            ReferenceType(ref i);
            Console.WriteLine(i);

            // Out Parameters
            int Sum = 0;
            int Product = 0;
            int a = 0, b = 0;
            OutParameterType(a,b,out Sum,out Product);
            Console.WriteLine(Sum);
            Console.WriteLine(Product);
        }
        public void ValueTypeParam(int j)
        {
            j = 11231;
        }
        public void ReferenceType(ref int i)
        {
            i = 11231;
        }
        public void OutParameterType(int a,int b,out int Sum,out int Product)
        {
            a = 12;
            b = 13;
            Sum = a + b;
            Product = a * b;
        }
    }
}
