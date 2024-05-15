namespace Question_1.b
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtTaxP = new System.Windows.Forms.TextBox();
            this.txtGrossSal = new System.Windows.Forms.TextBox();
            this.lblNetSal = new System.Windows.Forms.Label();
            this.lblNetSalary = new System.Windows.Forms.Label();
            this.lblTaxAmt = new System.Windows.Forms.Label();
            this.lblTaxAmount = new System.Windows.Forms.Label();
            this.lblTaxPercentage = new System.Windows.Forms.Label();
            this.lblGrossSalary = new System.Windows.Forms.Label();
            this.lblTitme = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(258, 367);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 55);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(73, 367);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(154, 55);
            this.btnCalc.TabIndex = 14;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtTaxP
            // 
            this.txtTaxP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTaxP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxP.Location = new System.Drawing.Point(305, 177);
            this.txtTaxP.Multiline = true;
            this.txtTaxP.Name = "txtTaxP";
            this.txtTaxP.Size = new System.Drawing.Size(216, 29);
            this.txtTaxP.TabIndex = 11;
            this.txtTaxP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInput);
            // 
            // txtGrossSal
            // 
            this.txtGrossSal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrossSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossSal.Location = new System.Drawing.Point(305, 123);
            this.txtGrossSal.Multiline = true;
            this.txtGrossSal.Name = "txtGrossSal";
            this.txtGrossSal.Size = new System.Drawing.Size(216, 29);
            this.txtGrossSal.TabIndex = 12;
            this.txtGrossSal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateInput);
            // 
            // lblNetSal
            // 
            this.lblNetSal.AutoSize = true;
            this.lblNetSal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNetSal.Location = new System.Drawing.Point(300, 279);
            this.lblNetSal.Name = "lblNetSal";
            this.lblNetSal.Size = new System.Drawing.Size(147, 29);
            this.lblNetSal.TabIndex = 5;
            this.lblNetSal.Text = "(Net Salary)";
            this.lblNetSal.Visible = false;
            // 
            // lblNetSalary
            // 
            this.lblNetSalary.AutoSize = true;
            this.lblNetSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNetSalary.Location = new System.Drawing.Point(68, 279);
            this.lblNetSalary.Name = "lblNetSalary";
            this.lblNetSalary.Size = new System.Drawing.Size(131, 29);
            this.lblNetSalary.TabIndex = 6;
            this.lblNetSalary.Text = "Net Salary";
            // 
            // lblTaxAmt
            // 
            this.lblTaxAmt.AutoSize = true;
            this.lblTaxAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTaxAmt.Location = new System.Drawing.Point(300, 231);
            this.lblTaxAmt.Name = "lblTaxAmt";
            this.lblTaxAmt.Size = new System.Drawing.Size(165, 29);
            this.lblTaxAmt.TabIndex = 7;
            this.lblTaxAmt.Text = "(Tax Amount)";
            this.lblTaxAmt.Visible = false;
            // 
            // lblTaxAmount
            // 
            this.lblTaxAmount.AutoSize = true;
            this.lblTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTaxAmount.Location = new System.Drawing.Point(68, 231);
            this.lblTaxAmount.Name = "lblTaxAmount";
            this.lblTaxAmount.Size = new System.Drawing.Size(149, 29);
            this.lblTaxAmount.TabIndex = 8;
            this.lblTaxAmount.Text = "Tax Amount";
            // 
            // lblTaxPercentage
            // 
            this.lblTaxPercentage.AutoSize = true;
            this.lblTaxPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTaxPercentage.Location = new System.Drawing.Point(68, 177);
            this.lblTaxPercentage.Name = "lblTaxPercentage";
            this.lblTaxPercentage.Size = new System.Drawing.Size(190, 29);
            this.lblTaxPercentage.TabIndex = 9;
            this.lblTaxPercentage.Text = "Tax Percentage";
            // 
            // lblGrossSalary
            // 
            this.lblGrossSalary.AutoSize = true;
            this.lblGrossSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGrossSalary.Location = new System.Drawing.Point(68, 123);
            this.lblGrossSalary.Name = "lblGrossSalary";
            this.lblGrossSalary.Size = new System.Drawing.Size(159, 29);
            this.lblGrossSalary.TabIndex = 10;
            this.lblGrossSalary.Text = "Gross Salary";
            // 
            // lblTitme
            // 
            this.lblTitme.AutoSize = true;
            this.lblTitme.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitme.Location = new System.Drawing.Point(67, 51);
            this.lblTitme.Name = "lblTitme";
            this.lblTitme.Size = new System.Drawing.Size(312, 32);
            this.lblTitme.TabIndex = 4;
            this.lblTitme.Text = "Please enter the details";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 470);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTaxP);
            this.Controls.Add(this.txtGrossSal);
            this.Controls.Add(this.lblNetSal);
            this.Controls.Add(this.lblNetSalary);
            this.Controls.Add(this.lblTaxAmt);
            this.Controls.Add(this.lblTaxAmount);
            this.Controls.Add(this.lblTaxPercentage);
            this.Controls.Add(this.lblGrossSalary);
            this.Controls.Add(this.lblTitme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtTaxP;
        private System.Windows.Forms.TextBox txtGrossSal;
        private System.Windows.Forms.Label lblNetSal;
        private System.Windows.Forms.Label lblNetSalary;
        private System.Windows.Forms.Label lblTaxAmt;
        private System.Windows.Forms.Label lblTaxAmount;
        private System.Windows.Forms.Label lblTaxPercentage;
        private System.Windows.Forms.Label lblGrossSalary;
        private System.Windows.Forms.Label lblTitme;
    }
}

