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
    public partial class product : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=GNS;Initial Catalog=automotive;Integrated Security=True");
        public product()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into product(prod_code,prod_type,prod_name,prod_description,prod_price,supplier_name)values('" + txtProCode.Text + "','" + ProductTypeComboBox.SelectedItem + "','" + txtName.Text + "','" + txtDescription.Text + "','" + txtPrice.Text + "','" + SupplierNameComboBox.SelectedItem + "')", con);
                cmd.ExecuteNonQuery();
                if (txtDescription.Text != "" && txtName.Text != "" && txtPrice.Text != "" && txtProCode.Text != "")
                {
                    MessageBox.Show("1 record affected");
                }
                else
                {
                    MessageBox.Show("no record saved");
                }
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void product_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select supplier_name from supplier", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    SupplierNameComboBox.Items.Add(dr[0].ToString());
                }
                con.Close();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
