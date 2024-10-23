using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace automotives
{
    public partial class customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=GNS;Initial Catalog=automotive;Integrated Security=True");
        public customer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //insert data
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into customer(customer_id,cust_name,cust_phone,address,email)values('" + txtCustomerId.Text.ToString() + "','" + txtName.Text + "','" + txtPhone.Text + "','" + txtAddress.Text + "','" + txtEmail.Text + "')", con);
                cmd.ExecuteNonQuery();
                if (txtCustomerId.Text != "" && txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && txtEmail.Text != "")
                {
                    MessageBox.Show("1 record saved");
                }
                else
                {
                    MessageBox.Show("record not saved");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally {
                con.Close();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                //insert data
                con.Open();
                SqlCommand cmd = new SqlCommand("update customer set cust_name='"+txtName.Text+"',cust_phone='"+txtPhone.Text+"',address='"+txtAddress.Text+"',email='"+txtEmail.Text+"' where customer_id='"+txtCustomerId.Text+"'", con);
                cmd.ExecuteNonQuery();
                if (txtCustomerId.Text != "" && txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && txtEmail.Text != "")
                {
                    MessageBox.Show("Update successful");
                }
                else
                {
                    MessageBox.Show("record not updated");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //update
            try
            {
                //insert data
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from customer where customer_id='"+txtCustomerId.Text+"'", con);
                cmd.ExecuteNonQuery();
                if (txtCustomerId.Text != "" && txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && txtEmail.Text != "")
                {
                    MessageBox.Show("Delete successful");
                }
                else
                {
                    MessageBox.Show("record not deleted");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //redirect to welcome page
            welcome w = new welcome();
            w.Show();
            this.Hide();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            customer_report cr = new customer_report();
            cr.Show();
            this.Hide();
        }
    }
}
