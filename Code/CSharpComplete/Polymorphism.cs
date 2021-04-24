using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class Polymorphism
    {
        public virtual void Print()
        {
            Console.WriteLine("Animal makes sound");
        }
    }
    class FirstChild : Polymorphism
    {
        public override void Print()
        {
            Console.WriteLine("Pig sound is wee");
        }
    }
    
}
