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
    public partial class transaction : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=viva_db;Integrated Security=True");
        public transaction()
        {
            InitializeComponent();
        }

        private void transaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viva_dbDataSetTransaction.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.viva_dbDataSetTransaction.Transactions);
            LoadCustomerIDs();

        }
        private void LoadCustomerIDs()
        {
            try
            {
                con.Open();
                string query = "SELECT IdNumber FROM Customer";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxCustId.Items.Add(reader["IdNumber"].ToString());
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer IDs: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void txtMaxColAmt_TextChanged(object sender, EventArgs e)
        {
            txtMaxColAmt.Text = "4000";
            txtMaxColAmt.ReadOnly = true;
            txtMaxColAmt.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect input values from textboxes
                string IdNumber = comboBoxCustId.SelectedItem.ToString();
                string transDate = dateTimePickerDateOfTrans.Value.ToString("yyyy-MM-dd");
                string maxcol = txtMaxColAmt.Text.Trim();
                string amountReq = txtAmtReq.Text.Trim();
                string debitDate = dateTimePickerDebtDate.Value.ToString("yyyy-MM-dd");
                string tobePaid = txtToBePaid.Text.Trim();

                // Validate required fields
                if (string.IsNullOrEmpty(IdNumber) || string.IsNullOrEmpty(transDate) || string.IsNullOrEmpty(maxcol) || string.IsNullOrEmpty(amountReq) || string.IsNullOrEmpty(debitDate) || string.IsNullOrEmpty(tobePaid))
                {
                    MessageBox.Show("Please enter required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Open DB connection
                con.Open();

                // SQL insert command
                string query = @"INSERT INTO Transactions 
                        (IdNumber, DateOfTransaction, MaxCollectionAmount, AmountRequested, DateOfDebit, toBePaid)
                         VALUES
                        (@IdNumber, @DateOfTransaction, @MaxCollectionAmount, @AmountRequested, @DateOfDebit, @tobePaid)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IdNumber", IdNumber);
                cmd.Parameters.AddWithValue("@DateOfTransaction", transDate);
                cmd.Parameters.AddWithValue("@MaxCollectionAmount", maxcol);
                cmd.Parameters.AddWithValue("@AmountRequested", amountReq);
                cmd.Parameters.AddWithValue("@DateOfDebit", debitDate);
                cmd.Parameters.AddWithValue("@tobePaid", tobePaid);

                // Execute query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Transaction has been made successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Transaction Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                // Close connection
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            txtTransId.Clear();
            txtTransId.Clear();
            txtSearchCust.Clear();
            txtMaxColAmt.Clear();
            txtAmtReq.Clear();
            comboBoxCustId.SelectedIndex = -1;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert the input to decimal
                decimal amountRequested = Convert.ToDecimal(txtAmtReq.Text.Trim());

                // Calculate 40%
                decimal toBePaid = amountRequested * 0.4m;

                // Display result in the txtToBePaid TextBox
                txtToBePaid.Text = toBePaid.ToString("0.00"); // optional formatting
            }
            catch (Exception ex) 
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void txtToBePaid_TextChanged(object sender, EventArgs e)
        {
            txtToBePaid.ReadOnly = true;
            txtToBePaid.Enabled = false;
        }

        private void comboBoxCustId_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCustId.Enabled = false;
        }

        private void txtTransId_TextChanged(object sender, EventArgs e)
        {
            txtTransId.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string searchValue = txtSearchCust.Text.Trim();
                string query = "SELECT * FROM Transactions WHERE IdNumber LIKE @search";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", "%" + searchValue + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No customer found.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search failed: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string email = "";
            adminDashboard dash = new adminDashboard(email);
            dash.Show();
            this.Hide();
        }
    }
}
