using System;
using System.Collections.Generic;
using System.Text;

namespace L2_Q4
{
    class Order
    {
        public Customer cust { get; set; }
        public List<Pizza> pizzas = new List<Pizza>();
        public List<string> side = new List<string>();


        public Order()
        {

        }
        public Order(Customer c, List<Pizza> p, List<string> s)
        {
            this.cust = c;
            this.pizzas = p;
            this.side = s;
        }
            
    }
}
