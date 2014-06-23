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
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.tabQueryResults = new System.Windows.Forms.TabControl();
            this.tabpQuery = new System.Windows.Forms.TabPage();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.tabpResult = new System.Windows.Forms.TabPage();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.tabpMessages = new System.Windows.Forms.TabPage();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tabQueryResults.SuspendLayout();
            this.tabpQuery.SuspendLayout();
            this.tabpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.tabpMessages.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDSNList
            // 
            this.cboDSNList.FormattingEnabled = true;
            this.cboDSNList.Location = new System.Drawing.Point(807, 7);
            this.cboDSNList.Name = "cboDSNList";
            this.cboDSNList.Size = new System.Drawing.Size(435, 28);
            this.cboDSNList.TabIndex = 0;
            this.cboDSNList.SelectedIndexChanged += new System.EventHandler(this.cboDSNList_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(1064, 76);
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
            this.lblDSNName.Location = new System.Drawing.Point(712, 10);
            this.lblDSNName.Name = "lblDSNName";
            this.lblDSNName.Size = new System.Drawing.Size(89, 20);
            this.lblDSNName.TabIndex = 2;
            this.lblDSNName.Text = "DSN Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(807, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(157, 26);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(712, 44);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(89, 20);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(981, 47);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(78, 20);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(1065, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(177, 26);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(1043, 111);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConnectionStatus.Size = new System.Drawing.Size(203, 20);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.Text = "Press Connect to Continue.";
            // 
            // tabQueryResults
            // 
            this.tabQueryResults.Controls.Add(this.tabpQuery);
            this.tabQueryResults.Controls.Add(this.tabpResult);
            this.tabQueryResults.Controls.Add(this.tabpMessages);
            this.tabQueryResults.Location = new System.Drawing.Point(12, 134);
            this.tabQueryResults.Name = "tabQueryResults";
            this.tabQueryResults.SelectedIndex = 0;
            this.tabQueryResults.Size = new System.Drawing.Size(1243, 437);
            this.tabQueryResults.TabIndex = 8;
            // 
            // tabpQuery
            // 
            this.tabpQuery.Controls.Add(this.btnExecute);
            this.tabpQuery.Controls.Add(this.txtQuery);
            this.tabpQuery.Location = new System.Drawing.Point(4, 29);
            this.tabpQuery.Name = "tabpQuery";
            this.tabpQuery.Padding = new System.Windows.Forms.Padding(3);
            this.tabpQuery.Size = new System.Drawing.Size(1235, 404);
            this.tabpQuery.TabIndex = 0;
            this.tabpQuery.Text = "Query";
            this.tabpQuery.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(1061, 358);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(164, 40);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(4, 7);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1221, 345);
            this.txtQuery.TabIndex = 0;
            // 
            // tabpResult
            // 
            this.tabpResult.Controls.Add(this.dgResults);
            this.tabpResult.Location = new System.Drawing.Point(4, 29);
            this.tabpResult.Name = "tabpResult";
            this.tabpResult.Padding = new System.Windows.Forms.Padding(3);
            this.tabpResult.Size = new System.Drawing.Size(1235, 404);
            this.tabpResult.TabIndex = 1;
            this.tabpResult.Text = "Result";
            this.tabpResult.UseVisualStyleBackColor = true;
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(6, 6);
            this.dgResults.Name = "dgResults";
            this.dgResults.RowTemplate.Height = 28;
            this.dgResults.Size = new System.Drawing.Size(1226, 392);
            this.dgResults.TabIndex = 0;
            // 
            // tabpMessages
            // 
            this.tabpMessages.Controls.Add(this.txtMessage);
            this.tabpMessages.Location = new System.Drawing.Point(4, 29);
            this.tabpMessages.Name = "tabpMessages";
            this.tabpMessages.Size = new System.Drawing.Size(1235, 404);
            this.tabpMessages.TabIndex = 2;
            this.tabpMessages.Text = "Messages";
            this.tabpMessages.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(4, 4);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(1222, 386);
            this.txtMessage.TabIndex = 0;
            // 
            // frmHMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 643);
            this.Controls.Add(this.tabQueryResults);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblDSNName);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboDSNList);
            this.Name = "frmHMSMain";
            this.Text = "Hive Query Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabQueryResults.ResumeLayout(false);
            this.tabpQuery.ResumeLayout(false);
            this.tabpQuery.PerformLayout();
            this.tabpResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.tabpMessages.ResumeLayout(false);
            this.tabpMessages.PerformLayout();
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
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.TabControl tabQueryResults;
        private System.Windows.Forms.TabPage tabpQuery;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TabPage tabpResult;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.TabPage tabpMessages;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

