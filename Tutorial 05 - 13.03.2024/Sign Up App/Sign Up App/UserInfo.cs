using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sign_Up_App
{
    public partial class UserInfo : Form
    {
        public UserInfo(string firstName, string lastName, string username, string email)
        {
            InitializeComponent();

            this.FormClosing += UserInfo_FormClosing;

            lblDisplayName.Text = firstName + " " + lastName;
            lblDisplayUsername.Text = username;
            lblDisplayEmailAddress.Text = email;
        }

        private void UserInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is Form1)
                {
                    form.Close();
                    break;
                }
            }
        }
    }
}
