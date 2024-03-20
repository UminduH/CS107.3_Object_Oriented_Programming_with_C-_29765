using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_Up_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Placeholder(txtFirstName, "Enter First Name");
            Placeholder(txtLastName, "Enter Last Name");
            dtpDOB.Value = DateTime.Today;
            Placeholder(txtEmailAddress, "eg: abc123@gmail.com");
            Placeholder(txtUsername, "Enter Username");
            Placeholder(txtPassword, "Enter Password");
            Placeholder(txtConfirmPassword, "Confirm Password");
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtFirstName.Text;
                string lastName = txtLastName.Text;
                string DOB = dtpDOB.Value.ToString("yyyy-MM-dd");
                string email = txtEmailAddress.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                string confirmPassword = txtConfirmPassword.Text;

                if (!IsFieldEmpty(txtFirstName) || !IsFieldEmpty(txtLastName) || !IsFieldEmpty(txtEmailAddress) || !IsFieldEmpty(txtUsername) || !IsFieldEmpty(txtPassword) || !IsFieldEmpty(txtConfirmPassword))
                {
                    MessageBox.Show("Please fill out all the fields.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for valid name
                if (!IsValidName(firstName) || !IsValidName(lastName))
                {
                    MessageBox.Show("Please enter a valid name.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for valid date of birth
                if (!IsValidDOB(DOB))
                {
                    MessageBox.Show("You have to be at least 16 years old to register.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for valid email address
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Please enter a valid email address.", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for strong password
                if (!IsStrongPassword(password))
                {
                    MessageBox.Show("Please enter a strong password.\nIt should contain at least 8 characters, including uppercase, lowercase, digits, and special characters(!,@,#,$,_,.,?).", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match!", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                UserInfo userInfoForm = new UserInfo(firstName, lastName, username, email);
                userInfoForm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Signup Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            Placeholder(txtFirstName, "Enter First Name");
            Placeholder(txtLastName, "Enter Last Name");
            dtpDOB.Value = DateTime.Today;
            Placeholder(txtEmailAddress, "eg: abc123@gmail.com");
            Placeholder(txtUsername, "Enter Username");

            Placeholder(txtPassword, "Enter Password");
            txtPassword.PasswordChar = '\0';
            btnPasswordToggleVisibility.Visible = false;
            btnPasswordToggleVisibility.Enabled = false;

            Placeholder(txtConfirmPassword, "Confirm Password");
            txtConfirmPassword.PasswordChar = '\0';
            btnConfirmPasswordToggleVisibility.Visible = false;
            btnConfirmPasswordToggleVisibility.Enabled = false;
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
            if (textBox == txtFirstName)
            {
                if (textBox.Text.Trim() == "Enter First Name" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }
            else if (textBox == txtLastName)
            {
                if (textBox.Text.Trim() == "Enter Last Name" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }
            else if (textBox == txtEmailAddress)
            {
                if (textBox.Text.Trim() == "eg: abc123@gmail.com" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }
            else if (textBox == txtUsername)
            {
                if (textBox.Text.Trim() == "Enter Username" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }
            else if (textBox == txtPassword)
            {
                if (textBox.Text.Trim() == "Enter Password" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }
            else if (textBox == txtConfirmPassword)
            {
                if (textBox.Text.Trim() == "Confirm Password" || string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }
            }

            return true;
        }
        private bool IsValidName(string nameInput)
        {
            string name = nameInput.Trim();
            foreach (char character in name)
            {
                if (!char.IsLetter(character))
                    return false;
            }
            return true;
        }
        private bool IsValidDOB(string dob)
        {
            DateTime DOB = DateTime.ParseExact(dob, "yyyy-MM-dd", null);
            DateTime today = DateTime.Today;

            // assuming the user has to be at least 16 years old to register
            int age = today.Year - DOB.Year;

            if (age < 16)
                return false;
            else
                return true;
        }
        private bool IsValidEmail(string email)
        {
            string emailRegex = @"^[a-zA-Z][a-zA-Z0-9.]*[a-zA-Z0-9]@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, emailRegex);
        }
        private bool IsStrongPassword(string password)
        {
            string passwordRegex = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[!@#$_.?])[A-Za-z0-9!@#$_.?]{8,14}$";
            // contains at least one digit
            // contains at least one lowercase letter
            // contains at least one uppercase letter
            // contains at least one special character (!, @, #, $, _, ., ?)
            // must contain alphanumeric characters and the specified special characters between 8-14 characters

            return Regex.IsMatch(password, passwordRegex);
        }

        private void btnPasswordToggleVisibility_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;

            btnPasswordToggleVisibility.Image = txtPassword.UseSystemPasswordChar ? Properties.Resources.show : Properties.Resources.hide;

            txtPassword.Focus();    // Focus the textbox so that the rectangle (caused due to focus on button) is not displayed on the button (eye)
        }
        private void btnConfirmPasswordToggleVisibility_Click(object sender, EventArgs e)
        {
            txtConfirmPassword.UseSystemPasswordChar = !txtConfirmPassword.UseSystemPasswordChar;

            btnConfirmPasswordToggleVisibility.Image = txtConfirmPassword.UseSystemPasswordChar ? Properties.Resources.show : Properties.Resources.hide;

            txtConfirmPassword.Focus();
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
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtConfirmPassword.Text) && txtConfirmPassword.Text != "Confirm Password")
            {
                txtConfirmPassword.PasswordChar = '•';

                btnConfirmPasswordToggleVisibility.Visible = true;
                btnConfirmPasswordToggleVisibility.Enabled = true;
            }
            else if (string.IsNullOrWhiteSpace(txtConfirmPassword.Text))
            {
                txtConfirmPassword.PasswordChar = '\0';

                btnConfirmPasswordToggleVisibility.Visible = false;
                btnConfirmPasswordToggleVisibility.Enabled = false;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the Enter key from being processed by the textbox
                txtLastName.Focus(); // Move focus to the next textbox (txtLastName)
            }
        }
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                dtpDOB.Focus();
            }
        }
        private void txtDOB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtEmailAddress.Focus();
            }
        }
        private void txtEmailAddress_KeyPress(object sender, KeyPressEventArgs e)
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
                txtConfirmPassword.Focus();
            }
        }
        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnSignUp.PerformClick();
            }
        }
    }
}
