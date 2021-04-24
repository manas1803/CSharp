using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class DataTypesConversion
    {
        public void MyMethod()
        {
            int i = 10000;
            float f = i;
            Console.WriteLine(f);

            float f1 = 12000000000.5F;
            int i1 = (int)f1;
            //int i1 = Convert.ToInt32(f1);
            Console.WriteLine(i1);

            string str = "12342";
            int num = 0;
            bool isNum = int.TryParse(str, out num);
            Console.WriteLine(num);
        }
    }

}
