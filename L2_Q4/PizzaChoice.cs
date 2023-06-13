using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace L2_Q4
{
    public partial class PizzaChoice : Form
    {
        public PizzaChoice()
        {
            InitializeComponent();
        }

        public Pizza addPizza()
        {
            string size, pizzaBase;
            string toppings = "";

            if (rbSmall.Checked)
                size = "Small";

            else if (rbMedium.Checked)
                size = "Medium";

            else
                size = "Large";

            if (rbThick.Checked)
                pizzaBase = "Thick";

            else if (rbThin.Checked)
                pizzaBase = "Thin";

            else
                pizzaBase = "Cheese-Stuffed";

            //foreach (String tp in clbToppings.Items)
            //{
            //    if (tp.Checked)
            //        toppings.Add(tp.Text);
            //}        

            //String s = "";
            for (int x = 0; x < clbToppings.CheckedItems.Count; x++) 
            
            { 
                toppings = toppings + (x + 1).ToString() + ". " + clbToppings.CheckedItems[x].ToString() + " "; 
            } 

            Pizza p = new Pizza(pizzaBase, size, toppings);
            return p;

        }

        public void btnAddPizza_Click(object sender, EventArgs e)
        {

            this.Close();

        }
    }
}
