using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarShopGUI
{
    public partial class Form1 : Form
    {

        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource shoppingCartBindingSource = new BindingSource();
        Store myStore = new Store();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Car c = new Car(txt_make.Text, txt_model.Text,decimal.Parse(txt_price.Text)) ;

            myStore.CarList.Add(c);
            carInventoryBindingSource.ResetBindings(false);

             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            carInventoryBindingSource.DataSource = myStore.CarList;
            shoppingCartBindingSource.DataSource = myStore.ShoppingList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString();

            lst_cart.DataSource = shoppingCartBindingSource;
            lst_cart.DisplayMember = ToString();
        }

        private void btn_add_a_car_Click(object sender, EventArgs e)
        {
            //get the selected item from inventory
            Car selected = (Car) lst_inventory.SelectedItem;

            // add that item to the cart
            myStore.ShoppingList.Add(selected);

            //update the list box control
            shoppingCartBindingSource.ResetBindings(false);

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            decimal total = myStore.Checkout();
            lbl_total.Text = "$"+ total.ToString();

            shoppingCartBindingSource.ResetBindings(false);
        }
    }
}
