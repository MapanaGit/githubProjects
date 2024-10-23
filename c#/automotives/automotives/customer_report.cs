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
    public partial class customer_report : Form
    {
        public customer_report()
        {
            InitializeComponent();
        }

        private void customer_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerReportDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.customerReportDataSet.customer);

            try {
                SqlConnection con = new SqlConnection(@"Data Source=GNS;Initial Catalog=automotive;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from customer where cust_name='" + txtSearch.Text + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=GNS;Initial Catalog=automotive;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from customer Where cust_name Like'%" + txtSearch.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            welcome w = new welcome();
            w.Show();
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
