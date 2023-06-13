using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L2_Q4
{
    public partial class OrderSummary : Form
    {
        public OrderSummary()
        {
            InitializeComponent();

        }

        List<Pizza> plist = new List<Pizza>();
        List<string> sides = new List<string>();
        Order o = new Order();
        string nl = Environment.NewLine;

        Customer cust = new Customer();

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PizzaChoice form = new PizzaChoice();

            if (txtName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please enter your name and address first :) ", "Enter name and address!");
            }

            else
            {

                cust.name = txtName.Text;
                cust.address = txtAddress.Text;

                o.cust = cust;

                form.ShowDialog();

                Pizza p = form.addPizza();
                plist.Add(p);

                txtSummary.Text += nl + nl + "Pizza added";
            }


            //if (plist != null)
            //{
            //    foreach (Pizza pz in plist)
            //    {
            //        txtSummary.Text = "Size: " + pz.size + nl + "Base: " + pz.pizzaBase + nl + "Toppings: " + pz.toppings;

            //    }
            //}

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtAddress.Text = "";
            txtSummary.Text = "";

            
            plist.Clear();
            sides.Clear();

        }

        private void btnAddSide_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please enter your name and address first :) ", "Enter details", MessageBoxButtons.OK);
            }

            else
            {
                switch (cbSides.SelectedIndex)
                {
                    case 0:
                        sides.Add("Chicken Nuggets");
                        txtSummary.Text += nl + nl + "Chicken Nuggets added";
                        break;

                    case 1:
                        sides.Add("Garlic Bread");
                        txtSummary.Text += nl + nl + "Garlic Bread added";
                        break;

                    case 2:
                        sides.Add("Potato Wedges");
                        txtSummary.Text += nl + nl + "Potato Wedges added";
                        break;

                    case 3:
                        sides.Add("Dough Balls");
                        txtSummary.Text += nl + nl + "Dough Balls added";
                        break;

                    case 4:
                        sides.Add("Chicken Strippers");
                        txtSummary.Text += nl + nl + "Chicken Strippers added";
                        break;

                    case 5:
                        sides.Add("BBQ Wings");
                        txtSummary.Text += nl + nl + "BBQ Wings added";
                        break;
                }
            }

            //txtSummary.Text += nl + nl + "Sides: ";

            //if (sides != null)
            //{

            //    foreach (string s in sides)
            //        txtSummary.Text += s + " ";

            //}
        }

        private void btnReview_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "" || txtAddress.Text == "")
            {
                MessageBox.Show("Please enter your name and address first :) ", "Enter name and address!");
            }
            else
            {
                
                cust.name = txtName.Text;
                cust.address = txtAddress.Text;

                o.cust = cust;

                int x = 0;
                o.pizzas = plist;
                o.side = sides;

                if (o.cust.name != "" && o.cust.address != "")
                {
                    if (o.pizzas.Count != 0 || o.side.Count != 0)
                    {
                        txtSummary.Text = "Name: " + o.cust.name + " Address: " + o.cust.address;

                        foreach (Pizza p in o.pizzas)
                        {
                            txtSummary.Text += nl + nl + "Pizza " + (x + 1) + ": " + " Size: " + p.size +  ", Base: " + p.pizzaBase
                                + nl + "Toppings: " + p.toppings;
                            x++;
                        }

                        txtSummary.Text += nl + nl + "Sides: ";

                        foreach (string s in o.side)
                        {
                            txtSummary.Text += nl + s;
                        }

                        MessageBox.Show("Please review the order and click Place Order when you're ready!", "Review Order", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("No pizza or sides added", "");

                }
                else
                    MessageBox.Show("No details entered", "No order details");
            }

            

            
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            if (txtName.Text != "" && txtAddress.Text != "")
            {
                if (o.pizzas.Count != 0 || o.side.Count != 0)
                    MessageBox.Show("Order placed!", "Pizza on the way");
                else
                    MessageBox.Show("No pizza or sides added", "");
            }
            else
                MessageBox.Show("Nothing entered", "Invalid entry");
                
        }
    }
}
