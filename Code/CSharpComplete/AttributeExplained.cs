using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class AttributeExplained
    {
        [Obsolete("Use the method Add(List<int> Numbers)")]
        public static int Add(int FirstNumber,int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach(int num in Numbers)
            {
                Sum += num;
            }
            return Sum;
        }
    }
}
