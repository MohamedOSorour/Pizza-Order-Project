using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Order_Project
{
    public partial class OrderConfirm : Form
    {
        private OrderDetails _orderDetails;
        public OrderConfirm(string size, string crust, string toppings, string place, string price,OrderDetails orderDetails)
        {
            InitializeComponent();

            lblSizeChosen.Text = size;
            lblCrustTypeChosen.Text = crust;
            lblToppingsChosen.Text = toppings;
            lblPlaceChosen.Text = place;
            lblPrice.Text = price;
            _orderDetails = orderDetails;
        }

        private void grpOrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void lblSizeChosen_Click(object sender, EventArgs e)
        {
            
        }

        private void lblToppings_Click(object sender, EventArgs e)
        {

        }

        private void lblToppingsChosen_Click(object sender, EventArgs e)
        {

        }

        private void lblCrustType_Click(object sender, EventArgs e)
        {

        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            _orderDetails.grpCrust.Enabled = false;
            _orderDetails.grpSize.Enabled = false;
            _orderDetails.grpToppings.Enabled = false;
            _orderDetails.grpPlace.Enabled = false;
            _orderDetails.btnOrder.Enabled = false;
            MessageBox.Show("Your order has been placed successfully!\nThank you for choosing us!",
                "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OrderConfirm_Load(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }

        private void lblPlace_Click(object sender, EventArgs e)
        {

        }

        private void lblCrustTypeChosen_Click(object sender, EventArgs e)
        {

        }
    }
}
