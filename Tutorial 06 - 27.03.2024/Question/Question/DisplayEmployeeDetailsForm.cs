using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Question
{
    public partial class DisplayEmployeeDetailsForm : Form
    {
        public DisplayEmployeeDetailsForm()
        {
            InitializeComponent();
        }

        private void btnSearchByUsername_Click(object sender, EventArgs e)
        {
            if (IsFieldEmpty(txtUsername))
            {
                MessageBox.Show("Please enter Employee Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = txtUsername.Text;

            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NSBM\\Year 1\\Semester 3\\Object Oriented Programming with C# (CS107.3)\\Tutorials\\Tutorial 06 - 27.03.2024\\Question\\Question\\EmployeeDatabase.mdf\";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT e.Name, e.DOB, c.Contact_No, c.Email, c.Address 
                                FROM Employee e 
                                JOIN Contact c ON e.Username = c.Username
                                WHERE e.Username = @Username";

                // Retrieves the name, date of birth, contact number, email, and address of employee.
                // It joins the Employee table (aliased as 'e') with the Contact table (aliased as 'c') based on the Username column (Employee Username == Contact Username).

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Username", $"{username}");

                    DataTable dataTable = new DataTable(); 

                    try
                    {
                        connection.Open();

                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count == 0)
                        {
                            dataGridViewEmployeeDetails.Enabled = false;
                            dataGridViewEmployeeDetails.Visible = false;

                            lblDisplayEmployeeUsername.Enabled = false;
                            lblDisplayEmployeeUsername.Visible = false;

                            MessageBox.Show("Employee not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dataGridViewEmployeeDetails.Enabled = true;
                            dataGridViewEmployeeDetails.Visible = true;

                            lblDisplayEmployeeUsername.Enabled = true;
                            lblDisplayEmployeeUsername.Visible = true;

                            lblDisplayEmployeeUsername.Text = $"Details of Employee: {username}";

                            dataGridViewEmployeeDetails.DataSource = dataTable;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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
    }
}
