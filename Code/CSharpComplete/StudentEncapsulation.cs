using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class StudentEncapsulation
    {
        private int _id;
        private string _name;
        private int _passmarks = 35;
        public string Email { get; set; }

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Id cannot be negative");
                }
                else
                {
                    this._id=value;
                }
            }
        }
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                if (value.Length <= 0)
                    throw new Exception("Name should be present ");
                this._name = value;
            }
        }
        public int Passmarks { get { return this._passmarks; } }
    }
}
