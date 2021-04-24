using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    public interface Area
    {
        public void Print();
    }
    public interface Perimeter
    {
        public void Print();
    }
    class InterfaceExplained : Area,Perimeter
    {
         void Area.Print()
        {
            Console.WriteLine("Area of Rectangle is 180");
        }
         void Perimeter.Print()
        {
            Console.WriteLine("Permieter of rectangle is 126");
        }
    }

}
