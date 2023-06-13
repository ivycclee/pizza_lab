using System;
using System.Collections.Generic;
using System.Text;

namespace L2_Q4
{
    class Customer
    {
        public string name { get; set; }
        public string address { get; set; }

        public Customer()
        {

        }
        public Customer(string name, string addr)
        {
            this.name = name;
            this.address = addr;
        }
    }
}
