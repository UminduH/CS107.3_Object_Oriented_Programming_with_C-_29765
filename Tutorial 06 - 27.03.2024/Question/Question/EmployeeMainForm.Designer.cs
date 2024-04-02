namespace Question
{
    partial class EmployeeMainForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnEnterEmployeeDetails = new System.Windows.Forms.Button();
            this.btnEditEmployeeDetails = new System.Windows.Forms.Button();
            this.btnDisplayEmployeeDetails = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.picBoxForm = new System.Windows.Forms.PictureBox();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxForm)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(111, 122);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(660, 51);
            this.lblTitle.TabIndex = 39;
            this.lblTitle.Text = "Employee Management System";
            // 
            // btnEnterEmployeeDetails
            // 
            this.btnEnterEmployeeDetails.BackColor = System.Drawing.Color.Coral;
            this.btnEnterEmployeeDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnterEmployeeDetails.FlatAppearance.BorderSize = 0;
            this.btnEnterEmployeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnterEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterEmployeeDetails.ForeColor = System.Drawing.Color.White;
            this.btnEnterEmployeeDetails.Location = new System.Drawing.Point(215, 240);
            this.btnEnterEmployeeDetails.Name = "btnEnterEmployeeDetails";
            this.btnEnterEmployeeDetails.Size = new System.Drawing.Size(455, 83);
            this.btnEnterEmployeeDetails.TabIndex = 40;
            this.btnEnterEmployeeDetails.Text = "Enter Employee Details";
            this.btnEnterEmployeeDetails.UseVisualStyleBackColor = false;
            this.btnEnterEmployeeDetails.Click += new System.EventHandler(this.btnEnterEmployeeDetails_Click);
            // 
            // btnEditEmployeeDetails
            // 
            this.btnEditEmployeeDetails.BackColor = System.Drawing.Color.Turquoise;
            this.btnEditEmployeeDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditEmployeeDetails.FlatAppearance.BorderSize = 0;
            this.btnEditEmployeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmployeeDetails.ForeColor = System.Drawing.Color.White;
            this.btnEditEmployeeDetails.Location = new System.Drawing.Point(215, 364);
            this.btnEditEmployeeDetails.Name = "btnEditEmployeeDetails";
            this.btnEditEmployeeDetails.Size = new System.Drawing.Size(455, 83);
            this.btnEditEmployeeDetails.TabIndex = 40;
            this.btnEditEmployeeDetails.Text = "Edit Employee Details";
            this.btnEditEmployeeDetails.UseVisualStyleBackColor = false;
            this.btnEditEmployeeDetails.Click += new System.EventHandler(this.btnEditEmployeeDetails_Click);
            // 
            // btnDisplayEmployeeDetails
            // 
            this.btnDisplayEmployeeDetails.BackColor = System.Drawing.Color.HotPink;
            this.btnDisplayEmployeeDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisplayEmployeeDetails.FlatAppearance.BorderSize = 0;
            this.btnDisplayEmployeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplayEmployeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayEmployeeDetails.ForeColor = System.Drawing.Color.White;
            this.btnDisplayEmployeeDetails.Location = new System.Drawing.Point(215, 490);
            this.btnDisplayEmployeeDetails.Name = "btnDisplayEmployeeDetails";
            this.btnDisplayEmployeeDetails.Size = new System.Drawing.Size(455, 83);
            this.btnDisplayEmployeeDetails.TabIndex = 40;
            this.btnDisplayEmployeeDetails.Text = "Display Employee Details";
            this.btnDisplayEmployeeDetails.UseVisualStyleBackColor = false;
            this.btnDisplayEmployeeDetails.Click += new System.EventHandler(this.btnDisplayEmployeeDetails_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Question.Properties.Resources.close__20px_;
            this.btnClose.Location = new System.Drawing.Point(844, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Enabled = false;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Question.Properties.Resources.maximize__20px_;
            this.btnMaximize.Location = new System.Drawing.Point(784, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(60, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Question.Properties.Resources.minimize__20px_;
            this.btnMinimize.Location = new System.Drawing.Point(724, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(60, 40);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // picBoxForm
            // 
            this.picBoxForm.Image = global::Question.Properties.Resources.owner;
            this.picBoxForm.Location = new System.Drawing.Point(10, 8);
            this.picBoxForm.Name = "picBoxForm";
            this.picBoxForm.Size = new System.Drawing.Size(25, 25);
            this.picBoxForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxForm.TabIndex = 3;
            this.picBoxForm.TabStop = false;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(43, 11);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(285, 24);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "Employee Management System";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.lblFormTitle);
            this.pnlTitle.Controls.Add(this.picBoxForm);
            this.pnlTitle.Controls.Add(this.btnMinimize);
            this.pnlTitle.Controls.Add(this.btnMaximize);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(904, 40);
            this.pnlTitle.TabIndex = 38;
            // 
            // EmployeeMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 704);
            this.Controls.Add(this.btnDisplayEmployeeDetails);
            this.Controls.Add(this.btnEditEmployeeDetails);
            this.Controls.Add(this.btnEnterEmployeeDetails);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(904, 704);
            this.MinimumSize = new System.Drawing.Size(904, 704);
            this.Name = "EmployeeMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxForm)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnEnterEmployeeDetails;
        private System.Windows.Forms.Button btnEditEmployeeDetails;
        private System.Windows.Forms.Button btnDisplayEmployeeDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.PictureBox picBoxForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlTitle;
    }
}