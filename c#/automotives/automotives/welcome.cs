using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace automotives
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            customer cust = new customer();
            cust.Show();
            this.Hide();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //logout
            if (MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo) != DialogResult.No) {
                Application.Exit();
            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            supplier s = new supplier();
            s.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            product p = new product();
            p.Show();
            this.Hide();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //display local date and time
            String time = DateTime.Now.ToLongTimeString();
            lblTime.Text = time;
        }
    }
}
