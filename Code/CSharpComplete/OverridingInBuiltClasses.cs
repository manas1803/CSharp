using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class OverridingInBuiltClasses
    {
        public void Print()
        {
            Customer c1 = new Customer();
            c1.FirstName = "Manas";
            c1.LastName = "Pant";
            Console.WriteLine(c1.ToString());

            Customer c2 = new Customer();
            c2.FirstName = "Manas";
            c2.LastName = "Pant";
            Console.WriteLine(c2.ToString());

            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.Equals(c2));

        }
    }
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return this.FirstName + " " + this.LastName;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if(!(obj is Customer))
            {
                return false;
            }
            return this.FirstName == ((Customer)obj).FirstName && this.LastName == ((Customer)obj).LastName;
        }
        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode();
        }
    }
}
