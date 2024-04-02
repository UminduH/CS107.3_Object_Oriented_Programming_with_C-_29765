using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Question
{
    public partial class EditEmployeeDetailsForm : Form
    {
        string username;
        bool isDataFetched = false;

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NSBM\\Year 1\\Semester 3\\Object Oriented Programming with C# (CS107.3)\\Tutorials\\Tutorial 06 - 27.03.2024\\Question\\Question\\EmployeeDatabase.mdf\";Integrated Security=True";

        public EditEmployeeDetailsForm()
        {
            InitializeComponent();

            Placeholder(txtUsername, "Search by Username");
        }

        private void btnSearchByUsername_Click(object sender, EventArgs e)
        {
            if (IsFieldEmpty(txtUsername))
            {
                MessageBox.Show("Please enter Employee Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            username = txtUsername.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Contact WHERE Username = @EmployeeUsername";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeUsername", $"{username}");

                    try
                    {
                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                reader.Read();
                                txtContactNo.Text = reader["Contact_No"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                txtAddress.Text = reader["Address"].ToString();

                                isDataFetched = true;
                            }
                            else
                            {
                                MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isDataFetched)
            {
                string errors = "";

                if (IsFieldEmpty(txtContactNo) && IsFieldEmpty(txtEmail) && IsFieldEmpty(txtAddress))
                {
                    errors += "Please fill out all the fields.\n";
                }
                else
                {
                    if (IsFieldEmpty(txtContactNo))
                    {
                        errors += "Please enter contact number.\n";
                    }
                    else if (!IsValidContactNo(txtContactNo))
                    {
                        errors += "Please enter a valid contact number.\n";
                    }

                    if (IsFieldEmpty(txtEmail))
                    {
                        errors += "Please enter an email.\n";
                    }
                    else if (!IsValidEmail(txtEmail))
                    {
                        errors += "Please enter a valid email.\n";
                    }

                    if (IsFieldEmpty(txtAddress))
                    {
                        errors += "Please enter employee address.\n";
                    }
                }

                // Check for any errors
                if (errors != "")
                {
                    MessageBox.Show(errors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Contact SET Contact_No = @ContactNo, Email = @EmployeeEmail, Address = @EmployeeAddress WHERE Username = @EmployeeUsername";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@EmployeeUsername", $"{username}");
                        command.Parameters.AddWithValue("@ContactNo", $"{txtContactNo.Text}");
                        command.Parameters.AddWithValue("@EmployeeEmail", $"{txtEmail.Text}");
                        command.Parameters.AddWithValue("@EmployeeAddress", $"{txtAddress.Text}");

                        try
                        {
                            connection.Open();

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"[Employee Username: {username}]\nEmployee details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show($"[Employee Username: {username}]\nUnable to update employee details.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter Employee Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Placeholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = SystemColors.GrayText;

            textBox.GotFocus += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.WindowText;
                }
            };

            textBox.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = SystemColors.GrayText;
                }
            };
        }


        private bool IsFieldEmpty(TextBox textBox)
        {
            if (textBox == txtUsername)
            {
                if (textBox.Text.Trim() == "Search by Username" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }
        private bool IsValidContactNo(TextBox textBox)
        {
            string contactNo = textBox.Text.Trim();

            if (contactNo.Length == 10 && contactNo.All(char.IsDigit))
            {
                return true;
            }
            return false;
        }
        private bool IsValidEmail(TextBox textBox)
        {
            string email = textBox.Text.Trim();
            string emailRegex = @"^[a-zA-Z][a-zA-Z0-9.]*[a-zA-Z0-9]@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, emailRegex);
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            bool employeeMainFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is EmployeeMainForm)
                {
                    form.Show();
                    employeeMainFormFound = true;
                    break;
                }
            }

            if (!employeeMainFormFound)
            {
                EmployeeMainForm employeeMainForm = new EmployeeMainForm();
                employeeMainForm.Show();
            }

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSearchByUsername.PerformClick();
            }
        }
        private void txtContactNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtEmail.Focus();
            }
        }
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtAddress.Focus();
            }
        }
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnUpdate.PerformClick();
            }
        }
    }
}
