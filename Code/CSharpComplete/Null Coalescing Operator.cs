using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    public class Null_Coalescing_Operator
    {
        //int score = null; This throws compile error
        public void MyMethod1()
        {
            int? score = null;
            int target = 0;
            if (score == null)
                target = 0;
            else
                target = (int)score;
            Console.WriteLine(target);
        }
        public void MyMethod2()
        {
            int? score = null;
            int target = 0;
            target = score ?? 0;
            Console.WriteLine(target);
        }
    }
}
