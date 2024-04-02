namespace Question
{
    partial class DisplayEmployeeDetailsForm
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.picBoxForm = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSearchByUsername = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.dataGridViewEmployeeDetails = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanelGoBack = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxGoBack = new System.Windows.Forms.PictureBox();
            this.lblGoBack = new System.Windows.Forms.Label();
            this.lblDisplayEmployeeUsername = new System.Windows.Forms.Label();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDetails)).BeginInit();
            this.tableLayoutPanelGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).BeginInit();
            this.SuspendLayout();
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
            this.pnlTitle.Size = new System.Drawing.Size(958, 40);
            this.pnlTitle.TabIndex = 39;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(43, 11);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(211, 24);
            this.lblFormTitle.TabIndex = 4;
            this.lblFormTitle.Text = "Employee Data Display";
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
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::Question.Properties.Resources.minimize__20px_;
            this.btnMinimize.Location = new System.Drawing.Point(778, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(60, 40);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.Enabled = false;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::Question.Properties.Resources.maximize__20px_;
            this.btnMaximize.Location = new System.Drawing.Point(838, 0);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(60, 40);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::Question.Properties.Resources.close__20px_;
            this.btnClose.Location = new System.Drawing.Point(898, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 40);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(212, 127);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 51);
            this.lblTitle.TabIndex = 49;
            this.lblTitle.Text = "View Employee Details";
            // 
            // btnSearchByUsername
            // 
            this.btnSearchByUsername.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSearchByUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchByUsername.FlatAppearance.BorderSize = 0;
            this.btnSearchByUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchByUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchByUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearchByUsername.Location = new System.Drawing.Point(576, 293);
            this.btnSearchByUsername.Name = "btnSearchByUsername";
            this.btnSearchByUsername.Size = new System.Drawing.Size(152, 50);
            this.btnSearchByUsername.TabIndex = 52;
            this.btnSearchByUsername.Text = "Search";
            this.btnSearchByUsername.UseVisualStyleBackColor = false;
            this.btnSearchByUsername.Click += new System.EventHandler(this.btnSearchByUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(403, 234);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(325, 39);
            this.txtUsername.TabIndex = 51;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(166, 234);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(186, 38);
            this.lblUsername.TabIndex = 50;
            this.lblUsername.Text = "Username:";
            // 
            // dataGridViewEmployeeDetails
            // 
            this.dataGridViewEmployeeDetails.AllowUserToAddRows = false;
            this.dataGridViewEmployeeDetails.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeeDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeDetails.Enabled = false;
            this.dataGridViewEmployeeDetails.Location = new System.Drawing.Point(173, 429);
            this.dataGridViewEmployeeDetails.Name = "dataGridViewEmployeeDetails";
            this.dataGridViewEmployeeDetails.ReadOnly = true;
            this.dataGridViewEmployeeDetails.RowHeadersWidth = 51;
            this.dataGridViewEmployeeDetails.RowTemplate.Height = 24;
            this.dataGridViewEmployeeDetails.Size = new System.Drawing.Size(740, 253);
            this.dataGridViewEmployeeDetails.TabIndex = 53;
            this.dataGridViewEmployeeDetails.TabStop = false;
            this.dataGridViewEmployeeDetails.Visible = false;
            // 
            // tableLayoutPanelGoBack
            // 
            this.tableLayoutPanelGoBack.ColumnCount = 1;
            this.tableLayoutPanelGoBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelGoBack.Controls.Add(this.pictureBoxGoBack, 0, 0);
            this.tableLayoutPanelGoBack.Controls.Add(this.lblGoBack, 0, 1);
            this.tableLayoutPanelGoBack.Location = new System.Drawing.Point(12, 633);
            this.tableLayoutPanelGoBack.Name = "tableLayoutPanelGoBack";
            this.tableLayoutPanelGoBack.RowCount = 2;
            this.tableLayoutPanelGoBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.79775F));
            this.tableLayoutPanelGoBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.20225F));
            this.tableLayoutPanelGoBack.Size = new System.Drawing.Size(108, 89);
            this.tableLayoutPanelGoBack.TabIndex = 54;
            // 
            // pictureBoxGoBack
            // 
            this.pictureBoxGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGoBack.Image = global::Question.Properties.Resources.go_back;
            this.pictureBoxGoBack.Location = new System.Drawing.Point(23, 3);
            this.pictureBoxGoBack.Name = "pictureBoxGoBack";
            this.pictureBoxGoBack.Size = new System.Drawing.Size(61, 48);
            this.pictureBoxGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGoBack.TabIndex = 0;
            this.pictureBoxGoBack.TabStop = false;
            this.pictureBoxGoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // lblGoBack
            // 
            this.lblGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGoBack.AutoSize = true;
            this.lblGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoBack.Location = new System.Drawing.Point(12, 62);
            this.lblGoBack.Name = "lblGoBack";
            this.lblGoBack.Size = new System.Drawing.Size(83, 18);
            this.lblGoBack.TabIndex = 1;
            this.lblGoBack.Text = "GO BACK";
            this.lblGoBack.Click += new System.EventHandler(this.GoBack_Click);
            // 
            // lblDisplayEmployeeUsername
            // 
            this.lblDisplayEmployeeUsername.AutoSize = true;
            this.lblDisplayEmployeeUsername.Enabled = false;
            this.lblDisplayEmployeeUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayEmployeeUsername.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblDisplayEmployeeUsername.Location = new System.Drawing.Point(173, 384);
            this.lblDisplayEmployeeUsername.Name = "lblDisplayEmployeeUsername";
            this.lblDisplayEmployeeUsername.Size = new System.Drawing.Size(400, 29);
            this.lblDisplayEmployeeUsername.TabIndex = 55;
            this.lblDisplayEmployeeUsername.Text = "Details of Employee: {Username}";
            this.lblDisplayEmployeeUsername.Visible = false;
            // 
            // DisplayEmployeeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 734);
            this.Controls.Add(this.lblDisplayEmployeeUsername);
            this.Controls.Add(this.tableLayoutPanelGoBack);
            this.Controls.Add(this.dataGridViewEmployeeDetails);
            this.Controls.Add(this.btnSearchByUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "DisplayEmployeeDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayEmployeeDetailsForm";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeDetails)).EndInit();
            this.tableLayoutPanelGoBack.ResumeLayout(false);
            this.tableLayoutPanelGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.PictureBox picBoxForm;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSearchByUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeDetails;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelGoBack;
        private System.Windows.Forms.PictureBox pictureBoxGoBack;
        private System.Windows.Forms.Label lblGoBack;
        private System.Windows.Forms.Label lblDisplayEmployeeUsername;
    }
}