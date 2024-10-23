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
    public partial class supplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=GNS;Initial Catalog=automotive;Integrated Security=True");
        public supplier()
        {
            InitializeComponent();
        }

        private void supplier_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into supplier values('" + txtName.Text + "','" + txtAddress.Text + "','" + txtContact.Text + "')", con);
                cmd.ExecuteNonQuery();

                if (txtContact.Text != "" && txtAddress.Text != "" && txtName.Text != "")
                {
                    MessageBox.Show("1 record affected");
                }
                else
                {
                    MessageBox.Show("failed saving a record");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally {
                con.Close();
            }
            txtName.Clear();
            txtContact.Clear();
            txtAddress.Clear();
        }
    }
}
