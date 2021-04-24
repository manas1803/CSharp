using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    abstract class HTML
    {
        public abstract void Print();
        public void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

    }
    class AbstractClassExplained : HTML
    {
        public override void Print()
        {
            Console.WriteLine("I have inherited the abstract class here");
        }
    }
}
