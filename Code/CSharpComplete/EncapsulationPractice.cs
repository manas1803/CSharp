using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpComplete
{
    class EncapsulationPractice
    {
        private int _marks = 30;
        private string _name;
        private string _address;
        public int EmployeeId { get; set; }
        public string EmployeeName
        {
            get
            {
                return this._name;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Name is required");
                }
                this._name = value;
            }
        }
        public string EmployeeAddress {
            get
            {
                return this._address;
            }
            set
            {
                if (value.Length < 1)
                {
                    throw new Exception("Address required");
                }
                this._address = value;
            }
        }
    }
}
