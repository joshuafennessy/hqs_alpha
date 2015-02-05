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
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.tabpResult = new System.Windows.Forms.TabPage();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.tabpMessages = new System.Windows.Forms.TabPage();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblQueryStatus = new System.Windows.Forms.Label();
            this.tabQueryResults.SuspendLayout();
            this.tabpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.tabpMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDSNList
            // 
            this.cboDSNList.FormattingEnabled = true;
            this.cboDSNList.Location = new System.Drawing.Point(538, 5);
            this.cboDSNList.Margin = new System.Windows.Forms.Padding(2);
            this.cboDSNList.Name = "cboDSNList";
            this.cboDSNList.Size = new System.Drawing.Size(291, 21);
            this.cboDSNList.TabIndex = 0;
            this.cboDSNList.SelectedIndexChanged += new System.EventHandler(this.cboDSNList_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(709, 49);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(119, 21);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblDSNName
            // 
            this.lblDSNName.AutoSize = true;
            this.lblDSNName.Location = new System.Drawing.Point(475, 6);
            this.lblDSNName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSNName.Name = "lblDSNName";
            this.lblDSNName.Size = new System.Drawing.Size(61, 13);
            this.lblDSNName.TabIndex = 2;
            this.lblDSNName.Text = "DSN Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(538, 29);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(106, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(475, 29);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(654, 31);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(710, 29);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(119, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Location = new System.Drawing.Point(475, 72);
            this.lblConnectionStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblConnectionStatus.Size = new System.Drawing.Size(136, 13);
            this.lblConnectionStatus.TabIndex = 7;
            this.lblConnectionStatus.Text = "Press Connect to Continue.";
            // 
            // tabQueryResults
            // 
            this.tabQueryResults.Controls.Add(this.tabpResult);
            this.tabQueryResults.Controls.Add(this.tabpMessages);
            this.tabQueryResults.Location = new System.Drawing.Point(2, 6);
            this.tabQueryResults.Margin = new System.Windows.Forms.Padding(2);
            this.tabQueryResults.Name = "tabQueryResults";
            this.tabQueryResults.SelectedIndex = 0;
            this.tabQueryResults.Size = new System.Drawing.Size(1220, 450);
            this.tabQueryResults.TabIndex = 8;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(1093, 398);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(2);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(109, 26);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(0, 2);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1202, 392);
            this.txtQuery.TabIndex = 0;
            // 
            // tabpResult
            // 
            this.tabpResult.Controls.Add(this.lblQueryStatus);
            this.tabpResult.Controls.Add(this.dgResults);
            this.tabpResult.Location = new System.Drawing.Point(4, 22);
            this.tabpResult.Margin = new System.Windows.Forms.Padding(2);
            this.tabpResult.Name = "tabpResult";
            this.tabpResult.Padding = new System.Windows.Forms.Padding(2);
            this.tabpResult.Size = new System.Drawing.Size(1212, 424);
            this.tabpResult.TabIndex = 1;
            this.tabpResult.Text = "Result";
            this.tabpResult.UseVisualStyleBackColor = true;
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(4, 4);
            this.dgResults.Margin = new System.Windows.Forms.Padding(2);
            this.dgResults.Name = "dgResults";
            this.dgResults.RowTemplate.Height = 28;
            this.dgResults.Size = new System.Drawing.Size(1202, 392);
            this.dgResults.TabIndex = 0;
            // 
            // tabpMessages
            // 
            this.tabpMessages.Controls.Add(this.txtMessage);
            this.tabpMessages.Location = new System.Drawing.Point(4, 22);
            this.tabpMessages.Margin = new System.Windows.Forms.Padding(2);
            this.tabpMessages.Name = "tabpMessages";
            this.tabpMessages.Size = new System.Drawing.Size(1212, 424);
            this.tabpMessages.TabIndex = 2;
            this.tabpMessages.Text = "Messages";
            this.tabpMessages.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(3, 3);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(1205, 419);
            this.txtMessage.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 103);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabQueryResults);
            this.splitContainer1.Size = new System.Drawing.Size(1222, 923);
            this.splitContainer1.SplitterDistance = 461;
            this.splitContainer1.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(2, 4);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1218, 455);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtQuery);
            this.tabPage1.Controls.Add(this.btnExecute);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1210, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblQueryStatus
            // 
            this.lblQueryStatus.AutoSize = true;
            this.lblQueryStatus.Location = new System.Drawing.Point(706, 398);
            this.lblQueryStatus.MinimumSize = new System.Drawing.Size(500, 13);
            this.lblQueryStatus.Name = "lblQueryStatus";
            this.lblQueryStatus.Size = new System.Drawing.Size(500, 13);
            this.lblQueryStatus.TabIndex = 1;
            this.lblQueryStatus.Text = "Idle";
            this.lblQueryStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmHMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 1038);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblDSNName);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cboDSNList);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHMSMain";
            this.Text = "Hive Query Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabQueryResults.ResumeLayout(false);
            this.tabpResult.ResumeLayout(false);
            this.tabpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.tabpMessages.ResumeLayout(false);
            this.tabpMessages.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TabPage tabpResult;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.TabPage tabpMessages;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblQueryStatus;
    }
}

