using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpComplete
{
    public class Enums
    {
        public void PrintEnums()
        {
            string[] enumList = Enum.GetNames(typeof(MyEnums));
            int[] valueEnums = (int[])Enum.GetValues(typeof(MyEnums));

            foreach(string s in enumList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();
            foreach(int i in valueEnums)
            {
                Console.WriteLine(i);
            }
        }
    }
    public enum MyEnums
    {
        Batman,
        Superman,
        WonderWoman
    }
}