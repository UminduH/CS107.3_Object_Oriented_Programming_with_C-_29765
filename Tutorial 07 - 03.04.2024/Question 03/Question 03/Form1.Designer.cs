namespace Question_03
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnVerifyId = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tblIdInfoContainer = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdInfo = new System.Windows.Forms.Label();
            this.tblIdInfoContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(29, 36);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(187, 25);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Enter the id number:";
            // 
            // txtId
            // 
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(241, 36);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(309, 25);
            this.txtId.TabIndex = 1;
            // 
            // btnVerifyId
            // 
            this.btnVerifyId.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnVerifyId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerifyId.Location = new System.Drawing.Point(35, 159);
            this.btnVerifyId.Name = "btnVerifyId";
            this.btnVerifyId.Size = new System.Drawing.Size(161, 43);
            this.btnVerifyId.TabIndex = 3;
            this.btnVerifyId.Text = "Verify id number";
            this.btnVerifyId.UseVisualStyleBackColor = false;
            this.btnVerifyId.Click += new System.EventHandler(this.btnVerifyId_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(212, 159);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 43);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(389, 159);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(161, 43);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tblIdInfoContainer
            // 
            this.tblIdInfoContainer.ColumnCount = 1;
            this.tblIdInfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIdInfoContainer.Controls.Add(this.lblIdInfo, 0, 0);
            this.tblIdInfoContainer.Enabled = false;
            this.tblIdInfoContainer.Location = new System.Drawing.Point(35, 75);
            this.tblIdInfoContainer.Name = "tblIdInfoContainer";
            this.tblIdInfoContainer.RowCount = 1;
            this.tblIdInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblIdInfoContainer.Size = new System.Drawing.Size(515, 67);
            this.tblIdInfoContainer.TabIndex = 6;
            this.tblIdInfoContainer.Visible = false;
            // 
            // lblIdInfo
            // 
            this.lblIdInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdInfo.Location = new System.Drawing.Point(3, 0);
            this.lblIdInfo.Name = "lblIdInfo";
            this.lblIdInfo.Size = new System.Drawing.Size(509, 67);
            this.lblIdInfo.TabIndex = 7;
            this.lblIdInfo.Text = "(Employee found/not found)";
            this.lblIdInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 237);
            this.Controls.Add(this.tblIdInfoContainer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnVerifyId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification of Employee";
            this.tblIdInfoContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnVerifyId;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TableLayoutPanel tblIdInfoContainer;
        private System.Windows.Forms.Label lblIdInfo;
    }
}

