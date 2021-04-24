using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    public class InheritanceExplained
    {
        public InheritanceExplained()
        {
            Console.WriteLine("Base class");
        }
        public InheritanceExplained(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class ChildClass : InheritanceExplained
    {
        ChildClass():base("My message is ")
        {

        }
    }
}
