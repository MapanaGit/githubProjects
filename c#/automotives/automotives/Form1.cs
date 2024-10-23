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
using System.Data.OleDb;

namespace automotives
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=GNS;Initial Catalog=automotive;Integrated Security=True");
        //OleDbConnection con = new OleDbConnection(@"");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try{
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from admin where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", con);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                int count = 0;

                while (dr.Read()) {
                    count++;
                }
                if (count == 1)
                {
                    welcome w = new welcome();
                    w.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Incorrect Username / Password entered");
                }
                con.Close();
            }catch(SqlException ex){
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
