using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace viva_finance
{
    public partial class adminDashboard : Form
    {

        public adminDashboard(string email)
        {
            InitializeComponent();
        }

        public adminDashboard()
        {
            // TODO: Complete member initialization
        }

        private void time_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt"); // e.g., 09:45:23 AM
        }

        private void btnCust_Click(object sender, EventArgs e)
        {
            customer cust = new customer();
            cust.Show();
            this.Hide();
        }

        private void btnTrans_Click(object sender, EventArgs e)
        {
            transaction trans = new transaction();
            trans.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Confirm logout
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Open Login Form
                Form1 login = new Form1(); // Replace with your actual login form class name
                login.Show();

                // Close or hide the current form
                this.Hide(); // Use this.Close() if you want to fully exit this form
            }
        }
    }
}
