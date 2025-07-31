using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace viva_finance
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=viva_db;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                //get username and password from textboxes
                string email = txtUserNm.Text.Trim();
                string password = txtPass.Text.Trim();
                //open sql connection
                con.Open();
                //sql query to check login credentials
                string query = "SELECT COUNT(*) FROM Admin WHERE EmailAddress = @email AND Password = @password";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password); // In production, use hashed passwords!

                int results = (int)cmd.ExecuteScalar();

                if(results > 0)
                {
                    adminDashboard admin = new adminDashboard(email);
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Always close the connection
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
    }
}
