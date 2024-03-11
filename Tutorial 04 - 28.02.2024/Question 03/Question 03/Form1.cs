using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_03
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int answer;

        Button operation;

        public Form1()
        {
            InitializeComponent();
            lblPendingOperation.Text = "";
            lblAnswer.Text = "";
        }

        private void Operation(object sender, EventArgs e)
        {
            operation = (Button)sender;

            num1 = Convert.ToInt32(txtNumber.Text);

            lblPendingOperation.Text = num1.ToString() + " " + operation.Text;

            txtNumber.Text = "";
        }

        private void Calculate(object sender, EventArgs e)
        {
            num2 = Convert.ToInt32(txtNumber.Text);

            if (operation.Text == "+")
            {
                answer = num1 + num2;
            }
            else if (operation.Text == "-")
            {
                answer = num1 - num2;
            }
            else if (operation.Text == "*")
            {
                answer = num1 * num2;
            }
            else if (operation.Text == "/")
            {
                answer = num1 / num2;
            }

            lblAnswer.Text = answer.ToString();
        }
    }
}
