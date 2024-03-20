namespace Sign_Up_App
{
    partial class UserInfo
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
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblDisplayName = new System.Windows.Forms.Label();
            this.lblDisplayUsername = new System.Windows.Forms.Label();
            this.lblDisplayEmailAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(145, 268);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(219, 32);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "Email Address:";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(145, 204);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(161, 32);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "Username:";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(145, 144);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(102, 32);
            this.lblFirstName.TabIndex = 6;
            this.lblFirstName.Text = "Name:";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayName
            // 
            this.lblDisplayName.AutoSize = true;
            this.lblDisplayName.BackColor = System.Drawing.Color.Black;
            this.lblDisplayName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDisplayName.Location = new System.Drawing.Point(419, 144);
            this.lblDisplayName.Name = "lblDisplayName";
            this.lblDisplayName.Size = new System.Drawing.Size(113, 32);
            this.lblDisplayName.TabIndex = 11;
            this.lblDisplayName.Text = "(Name)";
            this.lblDisplayName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayUsername
            // 
            this.lblDisplayUsername.AutoSize = true;
            this.lblDisplayUsername.BackColor = System.Drawing.Color.Black;
            this.lblDisplayUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDisplayUsername.Location = new System.Drawing.Point(419, 204);
            this.lblDisplayUsername.Name = "lblDisplayUsername";
            this.lblDisplayUsername.Size = new System.Drawing.Size(172, 32);
            this.lblDisplayUsername.TabIndex = 12;
            this.lblDisplayUsername.Text = "(Username)";
            this.lblDisplayUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDisplayEmailAddress
            // 
            this.lblDisplayEmailAddress.AutoSize = true;
            this.lblDisplayEmailAddress.BackColor = System.Drawing.Color.Black;
            this.lblDisplayEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayEmailAddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDisplayEmailAddress.Location = new System.Drawing.Point(419, 268);
            this.lblDisplayEmailAddress.Name = "lblDisplayEmailAddress";
            this.lblDisplayEmailAddress.Size = new System.Drawing.Size(230, 32);
            this.lblDisplayEmailAddress.TabIndex = 13;
            this.lblDisplayEmailAddress.Text = "(Email Address)";
            this.lblDisplayEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.lblDisplayEmailAddress);
            this.Controls.Add(this.lblDisplayUsername);
            this.Controls.Add(this.lblDisplayName);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(948, 497);
            this.MinimumSize = new System.Drawing.Size(948, 497);
            this.Name = "UserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserInfo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblDisplayName;
        private System.Windows.Forms.Label lblDisplayUsername;
        private System.Windows.Forms.Label lblDisplayEmailAddress;
    }
}