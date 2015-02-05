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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabQueryResults = new System.Windows.Forms.TabControl();
            this.tabpMessages = new System.Windows.Forms.TabPage();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.tabpResult = new System.Windows.Forms.TabPage();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.lblQueryStatus = new System.Windows.Forms.Label();
            this.tbctlQuery = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tblMainPage = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSConnectionInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSQueryResults = new System.Windows.Forms.ToolStripStatusLabel();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabQueryResults.SuspendLayout();
            this.tabpMessages.SuspendLayout();
            this.tabpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.tbctlQuery.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tblMainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboDSNList
            // 
            this.cboDSNList.FormattingEnabled = true;
            this.cboDSNList.Location = new System.Drawing.Point(67, 2);
            this.cboDSNList.Margin = new System.Windows.Forms.Padding(2);
            this.cboDSNList.Name = "cboDSNList";
            this.cboDSNList.Size = new System.Drawing.Size(291, 21);
            this.cboDSNList.TabIndex = 0;
            this.cboDSNList.SelectedIndexChanged += new System.EventHandler(this.cboDSNList_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(716, 2);
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
            this.lblDSNName.Location = new System.Drawing.Point(2, 0);
            this.lblDSNName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSNName.Name = "lblDSNName";
            this.lblDSNName.Size = new System.Drawing.Size(61, 13);
            this.lblDSNName.TabIndex = 2;
            this.lblDSNName.Text = "DSN Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(426, 2);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(106, 20);
            this.txtUserName.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(362, 0);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(60, 13);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(536, 0);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(593, 2);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(119, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDSNName);
            this.flowLayoutPanel1.Controls.Add(this.cboDSNList);
            this.flowLayoutPanel1.Controls.Add(this.lblUserName);
            this.flowLayoutPanel1.Controls.Add(this.txtUserName);
            this.flowLayoutPanel1.Controls.Add(this.lblPassword);
            this.flowLayoutPanel1.Controls.Add(this.txtPassword);
            this.flowLayoutPanel1.Controls.Add(this.btnConnect);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(231, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(847, 24);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // tabQueryResults
            // 
            this.tabQueryResults.Controls.Add(this.tabpResult);
            this.tabQueryResults.Controls.Add(this.tabpMessages);
            this.tabQueryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabQueryResults.Location = new System.Drawing.Point(0, 0);
            this.tabQueryResults.Margin = new System.Windows.Forms.Padding(2);
            this.tabQueryResults.Name = "tabQueryResults";
            this.tabQueryResults.SelectedIndex = 0;
            this.tabQueryResults.Size = new System.Drawing.Size(1075, 324);
            this.tabQueryResults.TabIndex = 8;
            // 
            // tabpMessages
            // 
            this.tabpMessages.Controls.Add(this.txtMessage);
            this.tabpMessages.Location = new System.Drawing.Point(4, 22);
            this.tabpMessages.Margin = new System.Windows.Forms.Padding(2);
            this.tabpMessages.Name = "tabpMessages";
            this.tabpMessages.Size = new System.Drawing.Size(600, 229);
            this.tabpMessages.TabIndex = 2;
            this.tabpMessages.Text = "Messages";
            this.tabpMessages.UseVisualStyleBackColor = true;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Location = new System.Drawing.Point(0, 0);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(600, 229);
            this.txtMessage.TabIndex = 0;
            // 
            // tabpResult
            // 
            this.tabpResult.Controls.Add(this.dgResults);
            this.tabpResult.Controls.Add(this.lblQueryStatus);
            this.tabpResult.Location = new System.Drawing.Point(4, 22);
            this.tabpResult.Margin = new System.Windows.Forms.Padding(2);
            this.tabpResult.Name = "tabpResult";
            this.tabpResult.Padding = new System.Windows.Forms.Padding(2);
            this.tabpResult.Size = new System.Drawing.Size(1067, 298);
            this.tabpResult.TabIndex = 1;
            this.tabpResult.Text = "Result";
            this.tabpResult.UseVisualStyleBackColor = true;
            // 
            // dgResults
            // 
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgResults.Location = new System.Drawing.Point(2, 2);
            this.dgResults.Margin = new System.Windows.Forms.Padding(2);
            this.dgResults.Name = "dgResults";
            this.dgResults.RowTemplate.Height = 28;
            this.dgResults.Size = new System.Drawing.Size(1063, 294);
            this.dgResults.TabIndex = 0;
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
            // tbctlQuery
            // 
            this.tbctlQuery.Controls.Add(this.tabPage1);
            this.tbctlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctlQuery.Location = new System.Drawing.Point(0, 0);
            this.tbctlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.tbctlQuery.Name = "tbctlQuery";
            this.tbctlQuery.SelectedIndex = 0;
            this.tbctlQuery.Size = new System.Drawing.Size(1075, 328);
            this.tbctlQuery.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tbctlQuery.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1067, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(952, 267);
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
            this.txtQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuery.Location = new System.Drawing.Point(2, 2);
            this.txtQuery.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuery.Multiline = true;
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(1059, 261);
            this.txtQuery.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnExecute, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtQuery, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.99083F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.00917F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1063, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tblMainPage
            // 
            this.tblMainPage.ColumnCount = 1;
            this.tblMainPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainPage.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tblMainPage.Controls.Add(this.splitContainer1, 0, 2);
            this.tblMainPage.Controls.Add(this.statusStrip1, 0, 3);
            this.tblMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainPage.Location = new System.Drawing.Point(0, 0);
            this.tblMainPage.Name = "tblMainPage";
            this.tblMainPage.RowCount = 4;
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblMainPage.Size = new System.Drawing.Size(1081, 735);
            this.tblMainPage.TabIndex = 11;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 55);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tbctlQuery);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabQueryResults);
            this.splitContainer1.Size = new System.Drawing.Size(1075, 656);
            this.splitContainer1.SplitterDistance = 328;
            this.splitContainer1.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSConnectionInfo,
            this.toolSQueryResults});
            this.statusStrip1.Location = new System.Drawing.Point(0, 714);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1081, 21);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolSConnectionInfo
            // 
            this.toolSConnectionInfo.Name = "toolSConnectionInfo";
            this.toolSConnectionInfo.Size = new System.Drawing.Size(88, 17);
            this.toolSConnectionInfo.Text = "Not Connected";
            // 
            // toolSQueryResults
            // 
            this.toolSQueryResults.Name = "toolSQueryResults";
            this.toolSQueryResults.Size = new System.Drawing.Size(947, 17);
            this.toolSQueryResults.Spring = true;
            this.toolSQueryResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmHMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 735);
            this.Controls.Add(this.tblMainPage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHMSMain";
            this.Text = "Hive Query Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabQueryResults.ResumeLayout(false);
            this.tabpMessages.ResumeLayout(false);
            this.tabpMessages.PerformLayout();
            this.tabpResult.ResumeLayout(false);
            this.tabpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.tbctlQuery.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tblMainPage.ResumeLayout(false);
            this.tblMainPage.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDSNList;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblDSNName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabQueryResults;
        private System.Windows.Forms.TabPage tabpResult;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.Label lblQueryStatus;
        private System.Windows.Forms.TabPage tabpMessages;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TabControl tbctlQuery;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tblMainPage;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolSConnectionInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolSQueryResults;
    }
}

