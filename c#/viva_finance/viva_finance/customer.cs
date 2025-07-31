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
    public partial class customer : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=viva_db;Integrated Security=True");
        public customer()
        {
            InitializeComponent();
        }

        private void customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'viva_dbDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.viva_dbDataSet.Customer);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Collect input values from textboxes 
                string idNumber = txtId.Text.Trim();
                string name = txtName.Text.Trim();
                string surname = txtSurname.Text.Trim();
                string gender = comboBoxGender.SelectedItem.ToString(); // e.g., ComboBox for gender
                string physicalAddress = richTextBoxAddress.Text.Trim();
                string cellNo = txtCellNumber.Text.Trim();
                string nextOfKin = txtNextOfKin.Text.Trim();
                string cellNoOfNextOfKin = txtCellOfNextOfKin.Text.Trim();
                string customerType = comboBoxCustType.SelectedItem.ToString();

                // Validate required fields
                if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(idNumber) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(gender) || string.IsNullOrEmpty(physicalAddress) || string.IsNullOrEmpty(cellNo) || string.IsNullOrEmpty(nextOfKin) || string.IsNullOrEmpty(cellNoOfNextOfKin) || string.IsNullOrEmpty(customerType))
                {
                    MessageBox.Show("Please enter required fields.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Open DB connection
                con.Open();

                // SQL insert command
                string query = @"INSERT INTO Customer 
                        (idNumber, name, surname, gender, physicalAddress, cellNo, nextOfKin, cellNoOfNextOfKin, customerType)
                         VALUES
                        (@idNumber, @name, @surname, @gender, @physicalAddress, @cellNo, @nextOfKin, @cellNoOfNextOfKin, @customerType)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idNumber", idNumber);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@physicalAddress", physicalAddress);
                cmd.Parameters.AddWithValue("@cellNo", cellNo);
                cmd.Parameters.AddWithValue("@nextOfKin", nextOfKin);
                cmd.Parameters.AddWithValue("@cellNoOfNextOfKin", cellNoOfNextOfKin);
                cmd.Parameters.AddWithValue("@customerType", customerType);

                // Execute query
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to add customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtName.Clear();
            txtSurname.Clear();
            txtId.Clear();
            comboBoxGender.SelectedIndex = -1;
            richTextBoxAddress.Clear();
            txtCellNumber.Clear();
            txtNextOfKin.Clear();
            txtCellOfNextOfKin.Clear();
            comboBoxCustType.SelectedIndex = -1;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            string email = "";
            adminDashboard dash = new adminDashboard(email);
            dash.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try {
                // Collect updated values from textboxes 
                string idNumber = txtId.Text.Trim(); // Assuming ID number is the unique identifier
                string name = txtName.Text.Trim();
                string surname = txtSurname.Text.Trim();
                string gender = comboBoxGender.SelectedItem.ToString();
                string physicalAddress = richTextBoxAddress.Text.Trim();
                string cellNo = txtCellNumber.Text.Trim();
                string nextOfKin = txtNextOfKin.Text.Trim();
                string cellNoOfNextOfKin = txtCellOfNextOfKin.Text.Trim();
                string customerType = comboBoxCustType.SelectedItem.ToString();

                // Validation
                if (string.IsNullOrEmpty(idNumber))
                {
                    MessageBox.Show("Please enter ID Number to update the customer.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // Open database connection
                con.Open();

                string updateQuery = @"UPDATE Customer 
                               SET name = @name, 
                                   surname = @surname, 
                                   gender = @gender, 
                                   physicalAddress = @physicalAddress, 
                                   cellNo = @cellNo, 
                                   nextOfKin = @nextOfKin, 
                                   cellNoOfNextOfKin = @cellNoOfNextOfKin, 
                                   customerType = @customerType
                               WHERE idNumber = @idNumber";

                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@idNumber", idNumber);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@physicalAddress", physicalAddress);
                cmd.Parameters.AddWithValue("@cellNo", cellNo);
                cmd.Parameters.AddWithValue("@nextOfKin", nextOfKin);
                cmd.Parameters.AddWithValue("@cellNoOfNextOfKin", cellNoOfNextOfKin);
                cmd.Parameters.AddWithValue("@customerType", customerType);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed. Check if the ID number exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            txtName.Clear();
            txtSurname.Clear();
            txtId.Clear();
            comboBoxGender.SelectedIndex = -1;
            richTextBoxAddress.Clear();
            txtCellNumber.Clear();
            txtNextOfKin.Clear();
            txtCellOfNextOfKin.Clear();
            comboBoxCustType.SelectedIndex = -1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
                string idNumber = txtId.Text.Trim(); // Assuming this is the unique identifier

                if (string.IsNullOrEmpty(idNumber))
                {
                    MessageBox.Show("Please enter the ID Number of the customer to delete.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    return;
                }

                con.Open();
                string deleteQuery = "DELETE FROM Customer WHERE idNumber = @idNumber";

                SqlCommand cmd = new SqlCommand(deleteQuery, con);
                cmd.Parameters.AddWithValue("@idNumber", idNumber);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Delete failed. Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
            txtName.Clear();
            txtSurname.Clear();
            txtId.Clear();
            comboBoxGender.SelectedIndex = -1;
            richTextBoxAddress.Clear();
            txtCellNumber.Clear();
            txtNextOfKin.Clear();
            txtCellOfNextOfKin.Clear();
            comboBoxCustType.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string searchValue = txtSearch.Text.Trim();
                string query = "SELECT * FROM Customer WHERE IdNumber LIKE @search";

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
            txtName.Clear();
            txtSurname.Clear();
            txtId.Clear();
            comboBoxGender.SelectedIndex = -1;
            richTextBoxAddress.Clear();
            txtCellNumber.Clear();
            txtNextOfKin.Clear();
            txtCellOfNextOfKin.Clear();
            comboBoxCustType.SelectedIndex = -1;
            txtSearch.Clear();
        }

    }
}
