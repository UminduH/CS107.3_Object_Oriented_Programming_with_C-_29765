using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_1.c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValidateInput(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                // Check if the entered character is not a control, not a digit, or not a decimal point
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' || e.KeyChar == (char)Keys.Enter)
                {
                    e.Handled = true;
                }

                // Prevent entering more than one decimal point
                if (e.KeyChar == '.' && textBox.Text.Contains('.'))
                {
                    e.Handled |= true;
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGrossSal.Text = "";
            txtTaxP.Text = "";
            lblTaxAmt.Visible = false;
            lblNetSal.Visible = false;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGrossSal.Text.Trim()) || string.IsNullOrWhiteSpace(txtTaxP.Text.Trim()))
            {
                return;
            }

            double grossSalary = Convert.ToDouble(txtGrossSal.Text.Trim());
            double taxPercentage = Convert.ToDouble(txtTaxP.Text.Trim());

            double taxAmountValue = CalcTax(grossSalary, taxPercentage);
            double netSalaryValue = CalcNetSal(grossSalary, taxAmountValue);

            lblTaxAmt.Text = taxAmountValue.ToString();
            lblNetSal.Text = netSalaryValue.ToString();

            lblTaxAmt.Visible = true;
            lblNetSal.Visible = true;

            MessageBox.Show($"Net Salary: {netSalaryValue}", "Net Salary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double CalcTax(double grossSal, double taxPercent)
        {
            return grossSal * taxPercent / 100;
        }
        private double CalcNetSal(double grossSal, double taxAmount)
        {
            return grossSal - taxAmount;
        }
    }
}
