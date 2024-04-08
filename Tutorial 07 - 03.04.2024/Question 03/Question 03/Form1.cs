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

namespace Question_03
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\NSBM\\Year 1\\Semester 3\\Object Oriented Programming with C# (CS107.3)\\CS107.3_Object_Oriented_Programming_with_C_Sharp_29765\\Tutorial 07 - 03.04.2024\\Question 03\\Question 03\\Employee.mdf\";Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private bool VerifyEmployeeId(int id)
        {
            bool isEmployee = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Employees WHERE emp_id = @Id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@Id", id);

                        connection.Open();

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            isEmployee = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return isEmployee;
        }

        private void btnVerifyId_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please enter the person's id.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id;
            try
            {
                id = Convert.ToInt32(txtId.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isEmployee = VerifyEmployeeId(id);

            tblIdInfoContainer.Enabled = true;
            tblIdInfoContainer.Visible = true;

            lblIdInfo.Text = isEmployee ? $"The person whose id number is {id} is an employee" : $"The person whose id number is {id} is not an employee";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";

            tblIdInfoContainer.Enabled = false;
            tblIdInfoContainer.Visible = false;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
