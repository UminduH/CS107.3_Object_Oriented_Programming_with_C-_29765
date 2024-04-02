using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question
{
    public partial class EmployeeMainForm : Form
    {
        public EmployeeMainForm()
        {
            InitializeComponent();
        }

        private void btnEnterEmployeeDetails_Click(object sender, EventArgs e)
        {
            bool enterEmployeeDetailsFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is EnterEmployeeDetailsForm)
                {
                    form.Show();
                    enterEmployeeDetailsFormFound = true;
                    break;
                }
            }

            if (!enterEmployeeDetailsFormFound)
            {
                EnterEmployeeDetailsForm enterEmployeeDetailsForm = new EnterEmployeeDetailsForm();
                enterEmployeeDetailsForm.Show();
            }

            this.Hide();

            // The above code is used to check whether there already is an instance of the form to be displayed (in this case, EnterEmployeeForm) currently opened, and if so, it is displayed (rather than creating a new instance of the form every time)
        }
        private void btnEditEmployeeDetails_Click(object sender, EventArgs e)
        {
            bool editEmployeeDetailsFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is EditEmployeeDetailsForm)
                {
                    form.Show();
                    editEmployeeDetailsFormFound = true;
                    break;
                }
            }

            if (!editEmployeeDetailsFormFound)
            {
                EditEmployeeDetailsForm editEmployeeDetailsForm = new EditEmployeeDetailsForm();
                editEmployeeDetailsForm.Show();
            }

            this.Hide();
        }
        private void btnDisplayEmployeeDetails_Click(object sender, EventArgs e)
        {
            bool displayEmployeeDetailsFormFound = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form is DisplayEmployeeDetailsForm)
                {
                    form.Show();
                    displayEmployeeDetailsFormFound = true;
                    break;
                }
            }

            if (!displayEmployeeDetailsFormFound)
            {
                DisplayEmployeeDetailsForm displayEmployeeDetailsForm = new DisplayEmployeeDetailsForm();
                displayEmployeeDetailsForm.Show();
            }

            this.Hide();
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
