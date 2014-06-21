namespace HiveManagementStudio
{
    partial class frmHMSMain
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
            this.cboDSNList = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblDSNName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboDSNList
            // 
            this.cboDSNList.FormattingEnabled = true;
            this.cboDSNList.Location = new System.Drawing.Point(191, 69);
            this.cboDSNList.Name = "cboDSNList";
            this.cboDSNList.Size = new System.Drawing.Size(435, 28);
            this.cboDSNList.TabIndex = 0;
            this.cboDSNList.SelectedIndexChanged += new System.EventHandler(this.cboDSNList_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(448, 138);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(178, 32);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblDSNName
            // 
            this.lblDSNName.AutoSize = true;
            this.lblDSNName.Location = new System.Drawing.Point(96, 72);
            this.lblDSNName.Name = "lblDSNName";
            this.lblDSNName.Size = new System.Drawing.Size(89, 20);
            this.lblDSNName.TabIndex = 2;
            this.lblDSNName.Text = "DSN Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(191, 106);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(157, 26);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(96, 106);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(89, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(365, 109);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(449, 106);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(177, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // frmHMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 627);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblDSNName);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboDSNList);
            this.Name = "frmHMSMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDSNList;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblDSNName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
    }
}

