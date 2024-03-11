using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Question_04
{
    public partial class Form1 : Form
    {
        // Calculation related attributes
        int result = 0;
        string operation = string.Empty;
        string firstNum, secondNum;
        bool enterValue = false;

        // Form movement related attributes
        bool isDragging;
        Point lastCursorPosition;

        public Form1()
        {
            InitializeComponent();

            this.KeyPreview = true; // Makes sure that the form receives key events and it is handled first

            rtbDisplayHistory.Text = " There's no history yet.";
        }

        private void BtnNum_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || enterValue)
                txtResult.Text = string.Empty;

            enterValue = false;

            Button button = (Button)sender;
            txtResult.Text = txtResult.Text + button.Text;
        }

        private void BtnPM_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(-1 * Convert.ToInt32(txtResult.Text));
            rtbDisplayHistory.AppendText($" {txtPending.Text} = {txtResult.Text} \n");
        }

        private void BtnOperation_Click(object sender, EventArgs e)
        {
            if (!enterValue)
                btnEquals.PerformClick();
            else
                result = Convert.ToInt32(txtResult.Text);

            Button button = (Button)sender;
            operation = button.Text;

            enterValue = true;

            if (txtResult.Text != "0")
                txtPending.Text = firstNum = $"{result} {operation}";
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            secondNum = txtResult.Text;
            txtPending.Text = $"{txtPending.Text} {txtResult.Text} =";

            if (txtResult.Text != string.Empty)
            {
                if (txtResult.Text == "0")
                    txtPending.Text = string.Empty;

                switch (operation)
                {
                    case "+":
                        txtResult.Text = (result + Convert.ToInt32(txtResult.Text)).ToString();
                        HandleHistory();
                        break;
                    case "-":
                        txtResult.Text = (result - Convert.ToInt32(txtResult.Text)).ToString();
                        HandleHistory();
                        break;
                    case "×":
                        txtResult.Text = (result * Convert.ToInt32(txtResult.Text)).ToString();
                        HandleHistory();
                        break;
                    case "÷":
                        txtResult.Text = (result / Convert.ToInt32(txtResult.Text)).ToString();
                        HandleHistory();
                        break;
                    default:
                        txtPending.Text = $"{txtResult.Text} = ";
                        break;
                }

                result = Convert.ToInt32(txtResult.Text);
                operation = string.Empty;
            }
        }

        private void HandleHistory()
        {
            if (rtbDisplayHistory.Text == " There's no history yet.")
                rtbDisplayHistory.Clear();

            rtbDisplayHistory.AppendText($" {firstNum} {secondNum} = {txtResult.Text} \n");
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            pnlHistory.BringToFront();
            pnlHistory.Height = (pnlHistory.Height == 5) ? pnlHistory.Height = 300 : 5;
        }

        private void BtnClearHistory_Click(object sender, EventArgs e)
        {
            rtbDisplayHistory.Clear();
            if (rtbDisplayHistory.Text == string.Empty)
                rtbDisplayHistory.Text = " There's no history yet.";
        }

        private void BtnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);

            if (txtResult.Text == string.Empty)
                txtResult.Text = "0";
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            txtPending.Text = string.Empty;
            result = 0;
        }

        private void BtnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void KeyboardInput(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                    btn1.PerformClick();
                    break;
                case '2':
                    btn2.PerformClick();
                    break;
                case '3':
                    btn3.PerformClick();
                    break;
                case '4':
                    btn4.PerformClick();
                    break;
                case '5':
                    btn5.PerformClick();
                    break;
                case '6':
                    btn6.PerformClick();
                    break;
                case '7':
                    btn7.PerformClick();
                    break;
                case '8':
                    btn8.PerformClick();
                    break;
                case '9':
                    btn9.PerformClick();
                    break;
                case '0':
                    btn0.PerformClick();
                    break;

                case '+':
                    btnAdd.PerformClick();
                    break;
                case '-':
                    btnSubtract.PerformClick();
                    break;
                case '*':
                    btnMultiply.PerformClick();
                    break;
                case '/':
                    btnDivide.PerformClick();
                    break;

                case '=':
                    btnEquals.PerformClick();
                    break;

                case (char)Keys.Escape:  // 'Escape' key
                    btnClear.PerformClick();
                    break;
                case (char)Keys.Back:  // 'Backspace' key
                    btnBackSpace.PerformClick();
                    break;
            }
        }

        private void PnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            // 'e' contains all details related to this event
            if (e.Button == MouseButtons.Left)  // Checks if the Left Mouse Button is clicked (or held down)
            {
                isDragging = true;
                lastCursorPosition = new Point(e.X, e.Y);   // Coordinates of the current position of the mouse
                // 'e.X' represents the x-coordinate
                // 'e.Y' represents the y-coordindate
            }
        }

        private void PnlTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                // Calculating the coordinates of the mouse everytime (final position - initial position)
                int deltaX = e.X - lastCursorPosition.X;
                int deltaY = e.Y - lastCursorPosition.Y;

                this.Location = new Point(this.Left + deltaX, this.Top + deltaY);
                // this.Left --> current horizontal position of the left edge of the form
                // this.Top -->  current vertical position of the top edge of the form
            }
        }

        private void PnlTitle_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }
    }
}
