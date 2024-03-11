using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_02
{
    public partial class Form1 : Form
    {
        public int num1;
        public int num2;
        public int answer;

        public Form1()
        {
            InitializeComponent();
            lblAnswer.Text = "";
        }

        private void CalculateResult(object sender, EventArgs e)
        {
            Button operation = (Button)sender;

            num1 = Convert.ToInt32(txtFirstNumber.Text);
            num2 = Convert.ToInt32(txtSecondNumber.Text);

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
