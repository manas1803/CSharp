using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class MethodHiding
    {
        public void print()
        {
            Console.WriteLine("Parent class here");
        }
    }
    class childClassForHiding : MethodHiding
    {
        public new void print()
        {
            Console.WriteLine("Child class here");
        }
    }
}
