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
    public partial class OrderDetails : Form
    {
        int BasePrice = 0;
        public OrderDetails()
        {
            InitializeComponent();
            
        }
        private void UpdatePrice()
        {
            int Total = BasePrice;

            //Crust adds to the price
            if (rdbThin.Checked) Total += 5;
            if (rdbThick.Checked) Total += 10;

            //Size Price
            if (rdbSmall.Checked) Total += 5;
            if (rdbMedium.Checked) Total += 8;
            if (rdbLarge.Checked) Total += 11;

            //Toppings +5 Each
            if (chkBoxExtraCheese.Checked) Total += 5;
            if (chkBoxMushrooms.Checked) Total += 5;
            if (chkBoxTomatoes.Checked) Total += 5;
            if (chkBoxOlives.Checked) Total += 5;
            if (chkBoxOnion.Checked) Total += 5;
            if (chkBoxGreenPepper.Checked) Total += 5;

            lblPrice.Text = $"${Total:F2}";
        }
        private void UpdateToppingsLabel()
        {
            List<string> Toppings = new List<string>();

            //Add Each topping that is checked
            if (chkBoxExtraCheese.Checked) Toppings.Add("Extra Cheese");
            if (chkBoxMushrooms.Checked) Toppings.Add("Mushrooms");
            if (chkBoxTomatoes.Checked) Toppings.Add("Toamtoes");
            if (chkBoxOlives.Checked) Toppings.Add("Olives");
            if (chkBoxOnion.Checked) Toppings.Add("Onion");
            if (chkBoxGreenPepper.Checked) Toppings.Add("Green Pepper");

            //If Nothing is chekcked show none
            lblToppingsChosen.Text = Toppings.Count > 0 ? string.Join("\n, ", Toppings) : "None";
        }
        private void UpdateSizeLabel()
        {
            if (rdbSmall.Checked) lblSizeChosen.Text = "Small";
            if (rdbMedium.Checked) lblSizeChosen.Text = "Medium";
            if (rdbLarge.Checked) lblSizeChosen.Text = "Large";
        }
        private void UpdateCrustLabel()
        {
            if (rdbThin.Checked) lblCrustTypeChosen.Text = "Thin";
            if (rdbThick.Checked) lblCrustTypeChosen.Text = "Thick";
        }
        private void UpdatePlaceLabel()
        {
            if (rdbTakeAway.Checked) lblPlaceChosen.Text = "Take Away";
            if (rdbEatIn.Checked) lblPlaceChosen.Text = "Eat In";

        }
        private void rdbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlaceLabel();
        }

        private void rdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeLabel();
            UpdatePrice();
        }

        private void rdbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustLabel();
            UpdatePrice();
        }

        private void rdbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustLabel();
            UpdatePrice();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grpOrderSummary_Enter(object sender, EventArgs e)
        {

        }

        private void lblSizeChosen_Click(object sender, EventArgs e)
        {
           
        }

        private void grpSize_Enter(object sender, EventArgs e)
        {

        }

        private void rdbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeLabel();
            UpdatePrice();
        }

        private void rdbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSizeLabel();
            UpdatePrice();
        }

        private void chkBoxExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            UpdatePrice();
        }

        private void chkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            UpdatePrice();
        }

        private void chkBoxTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            UpdatePrice();
        }

        private void chkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            UpdatePrice();
        }

        private void chkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            UpdatePrice();
        }

        private void chkBoxGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingsLabel();
            UpdatePrice();
        }

      

        private void lblDollarSign_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {
            
        }

        private void rdbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePlaceLabel();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Uncheck all radio buttons
            rdbThin.Checked = false;
            rdbThick.Checked = false;
            rdbSmall.Checked = false;
            rdbMedium.Checked = false;
            rdbLarge.Checked = false;
            rdbEatIn.Checked = false;
            rdbTakeAway.Checked = false;

            // Uncheck all toppings
            chkBoxExtraCheese.Checked = false;
            chkBoxMushrooms.Checked = false;
            chkBoxTomatoes.Checked = false;
            chkBoxOlives.Checked = false;
            chkBoxOnion.Checked = false;
            chkBoxGreenPepper.Checked = false;

            // Reset all labels
            lblSizeChosen.Text = ".....";
            lblCrustTypeChosen.Text = ".....";
            lblToppingsChosen.Text = ".....";
            lblPlaceChosen.Text = ".....";
            lblPrice.Text = "$0.00";

            // Re-enable everything
            grpCrust.Enabled = true;
            grpSize.Enabled = true;
            grpToppings.Enabled = true;
            grpPlace.Enabled = true;
            btnOrder.Enabled = true;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Validate that all options are selected
            if (!rdbThin.Checked && !rdbThick.Checked)
            {
                MessageBox.Show("Please select a crust type!", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!rdbSmall.Checked && !rdbMedium.Checked && !rdbLarge.Checked)
            {
                MessageBox.Show("Please select a size!", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!rdbEatIn.Checked && !rdbTakeAway.Checked)
            {
                MessageBox.Show("Please select a place!", "Missing Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            // Show order Confirmation
            OrderConfirm Confirm = new OrderConfirm(
                lblSizeChosen.Text,
                lblCrustTypeChosen.Text,
                lblToppingsChosen.Text,
              lblPlaceChosen.Text,
                lblPrice.Text,
                this
                );
            Confirm.ShowDialog();


        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {

        }

        private void grpCrust_Enter(object sender, EventArgs e)
        {

        }

        private void grpToppings_Enter(object sender, EventArgs e)
        {

        }

        private void lblCrustTypeChosen_Click(object sender, EventArgs e)
        {

        }

        private void lblPlaceChosen_Click(object sender, EventArgs e)
        {

        }

        private void lblCrustType_Click(object sender, EventArgs e)
        {

        }

        private void lblToppingsChosen_Click(object sender, EventArgs e)
        {

        }

        private void lblToppings_Click(object sender, EventArgs e)
        {

        }

        private void btnClosePage_Click(object sender, EventArgs e)
        {

        }

        private void btnClosePage_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
