using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//sql
using System.Data.SqlClient;
//validation
using System.Text.RegularExpressions;

namespace automotives
{
    public partial class employee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=GNS;Initial Catalog=automotive;Integrated Security=True");
        public employee()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open(); ;
                SqlCommand cmd = new SqlCommand("insert into employee(emp_no,emp_name,emp_id,phone,email_address,address,password)values('" + txtEmpNo.Text + "','" + txtEmpName.Text + "','" + txtEmpId.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + txtAddress.Text + "','" + txtPassword.Text + "')", con);
                cmd.ExecuteNonQuery();
                if (txtAddress.Text != "" && txtEmail.Text != "" && txtEmpId.Text != "" && txtEmpName.Text != "" && txtEmpNo.Text != "" && txtPassword.Text != "" && txtPhone.Text != "")
                {
                    MessageBox.Show("1 record affected");
                }
                else
                {
                    MessageBox.Show("no record inserted");
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
        public static class phoneNumber { 
        //regular expressions used to validate a phone number
            public const string motif = @"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$";
            public static bool IsPhoneNbr(string number) {
                if (number != null) return Regex.IsMatch(number, motif);
                else return false;
            }
        }
    }
}
