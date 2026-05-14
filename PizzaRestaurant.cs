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
    public partial class PizzaRestaurant : Form
    {
        public PizzaRestaurant()
        {
            InitializeComponent();
        }

        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            Form frm1 = new OrderDetails();
            frm1.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PizzaRestaurant_Load(object sender, EventArgs e)
        {

        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            AboutUs aboutForm = new AboutUs();
            aboutForm.ShowDialog();
        }
    }
}
