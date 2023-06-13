using System;
using System.Collections.Generic;
using System.Text;

namespace L2_Q4
{
    public class Pizza
    {
        public string pizzaBase { get; set; }
        public string size { get; set; }

        public string toppings { get; set; }

        public Pizza()
        {

        }


        public Pizza(string pBase, string size, string tops)
        {
            this.pizzaBase = pBase;
            this.size = size;
            this.toppings = tops;
        }
    }
}
