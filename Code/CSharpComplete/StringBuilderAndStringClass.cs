using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class StringBuilderAndStringClass
    {
        public void Print()
        {
            string str = string.Empty;
            for(int i = 1; i < 10000; i++)
            {
                str += Convert.ToString(i);
            }
            Console.WriteLine(str);

            StringBuilder str1 = new StringBuilder();
            for (int i = 1; i < 10000; i++)
            {
                str1.Append(Convert.ToString(i));
            }
            Console.WriteLine(str1);
        }
    }
}
