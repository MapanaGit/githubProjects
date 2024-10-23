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
    public partial class employeeReport : Form
    {
        public employeeReport()
        {
            InitializeComponent();
        }

        private void employeeReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeeDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.employeeDataSet.employee);

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //get data from database and print it
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=gns;Initial Catalog=automotive;Integrated Security=True");
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * From employee Where emp_no Like'%" + txtSearch.Text + "%'", con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (SqlException ex) {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
