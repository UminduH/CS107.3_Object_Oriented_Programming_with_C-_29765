using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_01
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToInt32(txtFirstNumber.Text);
            num2 = Convert.ToInt32(txtSecondNumber.Text);

            answer = num1 + num2;

            lblAnswer.Text = Convert.ToString(answer);
        }
    }
}
