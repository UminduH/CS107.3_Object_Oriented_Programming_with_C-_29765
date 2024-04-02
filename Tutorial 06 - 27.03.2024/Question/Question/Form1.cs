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

namespace Question
{
    public partial class EnterEmployeeDetailsForm : Form
    {
        public EnterEmployeeDetailsForm()
        {
            InitializeComponent();

            Placeholder(txtName, "Enter Employee Name");
            Placeholder(txtContactNo, "Enter Contact Number");
            Placeholder(txtEmail, "eg: abc123@gmail.com");
            Placeholder(txtAddress, "Enter Address");
            dateTimePickerDOB.Value = DateTime.Today;
            Placeholder(txtUsername, "Enter Username");
            Placeholder(txtPassword, "Enter Password");
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string errors = "";

            if (IsFieldEmpty(txtName) && IsFieldEmpty(txtContactNo) && IsFieldEmpty(txtEmail) && IsFieldEmpty(txtAddress) && IsFieldEmpty(txtUsername) && IsFieldEmpty(txtPassword))
            {
                errors += "Please fill out all the fields.\n";
            }
            else
            {
                // Check for valid name
                if (IsFieldEmpty(txtName))
                {
                    errors += "Please enter employee name.\n";
                }
                else if (!IsValidName(txtName))
                {
                    errors += "Please enter a valid name.\n";
                }

                // Check for valid date of birth
                if (!IsValidDOB(dateTimePickerDOB))
                {
                    errors += "You have to be at least 20 years old to register.\n";
                }

                // Check for valid contact no.
                if (IsFieldEmpty(txtContactNo))
                {
                    errors += "Please enter contact number.\n";
                }
                else if (!IsValidContactNo(txtContactNo))
                {
                    errors += "Please enter a valid contact number.\n";
                }

                // Check for valid email
                if (IsFieldEmpty(txtEmail))
                {
                    errors += "Please enter email address.\n";
                }
                else if (!IsValidEmail(txtEmail))
                {
                    errors += "Please enter a valid email address.\n";
                }

                // Check for address
                if (IsFieldEmpty(txtAddress))
                {
                    errors += "Please enter address.\n";
                }

                // Check for username
                if (IsFieldEmpty(txtUsername))
                {
                    errors += "Please enter userrname.\n";
                }

                // Check for strong password
                if (IsFieldEmpty(txtPassword))
                {
                    errors += "Please enter a password.\n";
                }
                else if (!IsStrongPassword(txtPassword))
                {
                    errors += "Please enter a strong password.\nPassword should contain at least 8 characters, including uppercase, lowercase, digits, and special characters(!,@,#,$,_,.,?).\n";
                }
            }

            // Check for any errors
            if (errors != "")
            {
                MessageBox.Show(errors, "Employee Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = txtName.Text;
            string DOB = dateTimePickerDOB.Value.ToString("yyyy-MM-dd");
            string contact = txtContactNo.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NSBM\\Year 1\\Semester 3\\Object Oriented Programming with C# (CS107.3)\\Tutorials\\Tutorial 06 - 27.03.2024\\Question\\Question\\EmployeeDatabase.mdf\";Integrated Security=True";

            int rowsAffectedEmployee = 0;
            int rowsAffectedContact = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryEmployee = $"INSERT INTO Employee VALUES (@Name, @DOB, @Username, @Password)";

                using (SqlCommand commandEmployee = new SqlCommand(queryEmployee, connection))
                {
                    commandEmployee.Parameters.AddWithValue("@Name", $"{name}");
                    commandEmployee.Parameters.AddWithValue("@DOB", $"{DOB}");
                    commandEmployee.Parameters.AddWithValue("@Username", $"{username}");
                    commandEmployee.Parameters.AddWithValue("@Password", $"{password}");

                    try
                    {
                        connection.Open();
                        rowsAffectedEmployee = commandEmployee.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Employee Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string queryContact = $"INSERT INTO Contact VALUES (@ContactNo, @Email, @Address, @Username)";

                using (SqlCommand commandContact = new SqlCommand (queryContact, connection))
                {
                    commandContact.Parameters.AddWithValue("@ContactNo", $"{contact}");
                    commandContact.Parameters.AddWithValue("@Email", $"{email}");
                    commandContact.Parameters.AddWithValue("@Address", $"{address}");
                    commandContact.Parameters.AddWithValue("@Username", $"{username}");

                    try
                    {
                        connection.Open();
                        rowsAffectedContact = commandContact.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Employee Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (rowsAffectedEmployee > 0 && rowsAffectedContact > 0)
            {
                MessageBox.Show("Employee registered successfuly.", "Employee Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnReset.PerformClick();
            }
            else
            {
                MessageBox.Show("Unable to register employee. Please try again.", "Employee Registration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Placeholder(txtName, "Enter Employee Name");
            Placeholder(txtContactNo, "Enter Contact No.");
            Placeholder(txtEmail, "eg: abc123@gmail.com");
            Placeholder(txtAddress, "Enter Address");
            dateTimePickerDOB.Value = DateTime.Today;
            Placeholder(txtUsername, "Enter Username");

            Placeholder(txtPassword, "Enter Password");
            txtPassword.PasswordChar = '\0';
            btnPasswordToggleVisibility.Visible = false;
            btnPasswordToggleVisibility.Enabled = false;
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
            if (textBox == txtName)
            {
                if (textBox.Text.Trim() == "Enter Employee Name" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }
            else if (textBox == txtContactNo)
            {
                if (textBox.Text.Trim() == "Enter Contact Number" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }
            else if (textBox == txtEmail)
            {
                if (textBox.Text.Trim() == "eg: abc123@gmail.com" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }
            else if (textBox == txtAddress)
            {
                if (textBox.Text.Trim() == "Enter Address" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }
            else if (textBox == txtUsername)
            {
                if (textBox.Text.Trim() == "Enter Username" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }
            else if (textBox == txtPassword)
            {
                if (textBox.Text.Trim() == "Enter Password" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return true;
                }
            }

            return false;
        }
        private bool IsValidName(TextBox textBox)
        {
            string name = textBox.Text.Trim();

            foreach (char character in name)
            {
                if (!char.IsLetter(character) && character != ' ')
                    return false;
            }
            return true;
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
        private bool IsValidDOB(DateTimePicker dtp)
        {
            DateTime DOB = dtp.Value;
            DateTime today = DateTime.Today;

            // assuming the user has to be at least 20 years old to register
            int age = today.Year - DOB.Year;

            if (age < 20)
                return false;
            else
                return true;
        }
        private bool IsValidEmail(TextBox textBox)
        {
            string email = textBox.Text.Trim();
            string emailRegex = @"^[a-zA-Z][a-zA-Z0-9.]*[a-zA-Z0-9]@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, emailRegex);
        }
        private bool IsStrongPassword(TextBox textBox)
        {
            string password = textBox.Text;
            string passwordRegex = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$_.?])[A-Za-z0-9!@#$_.?]{8,14}$";
            // contains at least one digit
            // contains at least one lowercase letter
            // contains at least one uppercase letter
            // contains at least one special character (!, @, #, $, _, ., ?)
            // must contain alphanumeric characters and the specified special characters between 8-14 characters

            return Regex.IsMatch(password, passwordRegex);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key from being processed by the textbox
                dateTimePickerDOB.Focus(); // Move focus to the next textbox
            }
        }
        private void dateTimePickerDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtContactNo.Focus();
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
                txtUsername.Focus();
            }
        }
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtPassword.Focus();
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnEnter.PerformClick();
            }
        }

        private void btnPasswordToggleVisibility_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            btnPasswordToggleVisibility.Image = txtPassword.UseSystemPasswordChar ? Properties.Resources.show : Properties.Resources.hide;

            txtPassword.Focus();    // Focus the textbox so that the rectangle (caused due to focus on button) is not displayed on the button (eye)
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtPassword.Text) && txtPassword.Text != "Enter Password")
            {
                txtPassword.PasswordChar = '•';

                btnPasswordToggleVisibility.Visible = true;
                btnPasswordToggleVisibility.Enabled = true;
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';

                btnPasswordToggleVisibility.Visible = false;
                btnPasswordToggleVisibility.Enabled = false;
            }
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
    }
}
