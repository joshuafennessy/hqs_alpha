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
            this.tblMainPage = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolSConnectionInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolSQueryResults = new System.Windows.Forms.ToolStripStatusLabel();
            this.spltMain = new System.Windows.Forms.SplitContainer();
            this.spltDatabaseInfo = new System.Windows.Forms.SplitContainer();
            this.lblDatabaseSelection = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.spltQueryResults = new System.Windows.Forms.SplitContainer();
            this.tbctlQuery = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnExecute = new System.Windows.Forms.Button();
            this.txtQuery = new System.Windows.Forms.TextBox();
            this.tabQueryResults = new System.Windows.Forms.TabControl();
            this.tabpResult = new System.Windows.Forms.TabPage();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.lblQueryStatus = new System.Windows.Forms.Label();
            this.tabpMessages = new System.Windows.Forms.TabPage();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnDatabaseRefresh = new System.Windows.Forms.Button();
            this.treeTables = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1.SuspendLayout();
            this.tblMainPage.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).BeginInit();
            this.spltMain.Panel1.SuspendLayout();
            this.spltMain.Panel2.SuspendLayout();
            this.spltMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltDatabaseInfo)).BeginInit();
            this.spltDatabaseInfo.Panel1.SuspendLayout();
            this.spltDatabaseInfo.Panel2.SuspendLayout();
            this.spltDatabaseInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spltQueryResults)).BeginInit();
            this.spltQueryResults.Panel1.SuspendLayout();
            this.spltQueryResults.Panel2.SuspendLayout();
            this.spltQueryResults.SuspendLayout();
            this.tbctlQuery.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabQueryResults.SuspendLayout();
            this.tabpResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.tabpMessages.SuspendLayout();
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
            this.lblDSNName.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblDSNName.Location = new System.Drawing.Point(2, 0);
            this.lblDSNName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDSNName.Name = "lblDSNName";
            this.lblDSNName.Size = new System.Drawing.Size(61, 13);
            this.lblDSNName.TabIndex = 2;
            this.lblDSNName.Text = "DSN Name";
            this.lblDSNName.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.flowLayoutPanel1.Location = new System.Drawing.Point(357, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(847, 24);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // tblMainPage
            // 
            this.tblMainPage.ColumnCount = 1;
            this.tblMainPage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainPage.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tblMainPage.Controls.Add(this.statusStrip1, 0, 3);
            this.tblMainPage.Controls.Add(this.spltMain, 0, 2);
            this.tblMainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblMainPage.Location = new System.Drawing.Point(0, 0);
            this.tblMainPage.Name = "tblMainPage";
            this.tblMainPage.RowCount = 5;
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainPage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblMainPage.Size = new System.Drawing.Size(1207, 735);
            this.tblMainPage.TabIndex = 11;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSConnectionInfo,
            this.toolSQueryResults});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1207, 21);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolSConnectionInfo
            // 
            this.toolSConnectionInfo.Name = "toolSConnectionInfo";
            this.toolSConnectionInfo.Size = new System.Drawing.Size(88, 16);
            this.toolSConnectionInfo.Text = "Not Connected";
            // 
            // toolSQueryResults
            // 
            this.toolSQueryResults.Name = "toolSQueryResults";
            this.toolSQueryResults.Size = new System.Drawing.Size(1104, 16);
            this.toolSQueryResults.Spring = true;
            this.toolSQueryResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // spltMain
            // 
            this.spltMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltMain.Location = new System.Drawing.Point(3, 55);
            this.spltMain.Name = "spltMain";
            // 
            // spltMain.Panel1
            // 
            this.spltMain.Panel1.Controls.Add(this.spltDatabaseInfo);
            // 
            // spltMain.Panel2
            // 
            this.spltMain.Panel2.Controls.Add(this.spltQueryResults);
            this.spltMain.Size = new System.Drawing.Size(1201, 636);
            this.spltMain.SplitterDistance = 168;
            this.spltMain.TabIndex = 13;
            // 
            // spltDatabaseInfo
            // 
            this.spltDatabaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltDatabaseInfo.Location = new System.Drawing.Point(0, 0);
            this.spltDatabaseInfo.Name = "spltDatabaseInfo";
            this.spltDatabaseInfo.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltDatabaseInfo.Panel1
            // 
            this.spltDatabaseInfo.Panel1.Controls.Add(this.btnDatabaseRefresh);
            this.spltDatabaseInfo.Panel1.Controls.Add(this.lblDatabaseSelection);
            this.spltDatabaseInfo.Panel1.Controls.Add(this.cboDatabase);
            // 
            // spltDatabaseInfo.Panel2
            // 
            this.spltDatabaseInfo.Panel2.Controls.Add(this.treeTables);
            this.spltDatabaseInfo.Size = new System.Drawing.Size(168, 636);
            this.spltDatabaseInfo.SplitterDistance = 133;
            this.spltDatabaseInfo.TabIndex = 0;
            // 
            // lblDatabaseSelection
            // 
            this.lblDatabaseSelection.AutoSize = true;
            this.lblDatabaseSelection.Location = new System.Drawing.Point(10, 4);
            this.lblDatabaseSelection.Name = "lblDatabaseSelection";
            this.lblDatabaseSelection.Size = new System.Drawing.Size(100, 13);
            this.lblDatabaseSelection.TabIndex = 1;
            this.lblDatabaseSelection.Text = "Database Selection";
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Location = new System.Drawing.Point(9, 26);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(121, 21);
            this.cboDatabase.TabIndex = 0;
            this.cboDatabase.SelectedIndexChanged += new System.EventHandler(this.cboDatabase_SelectedIndexChanged);
            // 
            // spltQueryResults
            // 
            this.spltQueryResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltQueryResults.Location = new System.Drawing.Point(0, 0);
            this.spltQueryResults.Name = "spltQueryResults";
            this.spltQueryResults.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltQueryResults.Panel1
            // 
            this.spltQueryResults.Panel1.Controls.Add(this.tbctlQuery);
            // 
            // spltQueryResults.Panel2
            // 
            this.spltQueryResults.Panel2.Controls.Add(this.tabQueryResults);
            this.spltQueryResults.Size = new System.Drawing.Size(1029, 636);
            this.spltQueryResults.SplitterDistance = 318;
            this.spltQueryResults.TabIndex = 12;
            // 
            // tbctlQuery
            // 
            this.tbctlQuery.Controls.Add(this.tabPage1);
            this.tbctlQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctlQuery.Location = new System.Drawing.Point(0, 0);
            this.tbctlQuery.Margin = new System.Windows.Forms.Padding(2);
            this.tbctlQuery.Name = "tbctlQuery";
            this.tbctlQuery.SelectedIndex = 0;
            this.tbctlQuery.Size = new System.Drawing.Size(1029, 318);
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
            this.tabPage1.Size = new System.Drawing.Size(1021, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 288);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(906, 258);
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
            this.txtQuery.Size = new System.Drawing.Size(1013, 252);
            this.txtQuery.TabIndex = 0;
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
            this.tabQueryResults.Size = new System.Drawing.Size(1029, 314);
            this.tabQueryResults.TabIndex = 8;
            // 
            // tabpResult
            // 
            this.tabpResult.Controls.Add(this.dgResults);
            this.tabpResult.Controls.Add(this.lblQueryStatus);
            this.tabpResult.Location = new System.Drawing.Point(4, 22);
            this.tabpResult.Margin = new System.Windows.Forms.Padding(2);
            this.tabpResult.Name = "tabpResult";
            this.tabpResult.Padding = new System.Windows.Forms.Padding(2);
            this.tabpResult.Size = new System.Drawing.Size(1021, 288);
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
            this.dgResults.Size = new System.Drawing.Size(1017, 284);
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
            // tabpMessages
            // 
            this.tabpMessages.Controls.Add(this.txtMessage);
            this.tabpMessages.Location = new System.Drawing.Point(4, 22);
            this.tabpMessages.Margin = new System.Windows.Forms.Padding(2);
            this.tabpMessages.Name = "tabpMessages";
            this.tabpMessages.Size = new System.Drawing.Size(1021, 288);
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
            this.txtMessage.Size = new System.Drawing.Size(1021, 288);
            this.txtMessage.TabIndex = 0;
            // 
            // btnDatabaseRefresh
            // 
            this.btnDatabaseRefresh.Location = new System.Drawing.Point(90, 107);
            this.btnDatabaseRefresh.Name = "btnDatabaseRefresh";
            this.btnDatabaseRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnDatabaseRefresh.TabIndex = 2;
            this.btnDatabaseRefresh.Text = "Refresh";
            this.btnDatabaseRefresh.UseVisualStyleBackColor = true;
            this.btnDatabaseRefresh.Click += new System.EventHandler(this.btnDatabaseRefresh_Click);
            // 
            // treeTables
            // 
            this.treeTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeTables.Location = new System.Drawing.Point(0, 0);
            this.treeTables.Name = "treeTables";
            this.treeTables.Size = new System.Drawing.Size(168, 499);
            this.treeTables.TabIndex = 0;
            this.treeTables.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeTables_AfterSelect);
            // 
            // frmHMSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 735);
            this.Controls.Add(this.tblMainPage);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHMSMain";
            this.Text = "Hive Query Studio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tblMainPage.ResumeLayout(false);
            this.tblMainPage.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spltMain.Panel1.ResumeLayout(false);
            this.spltMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltMain)).EndInit();
            this.spltMain.ResumeLayout(false);
            this.spltDatabaseInfo.Panel1.ResumeLayout(false);
            this.spltDatabaseInfo.Panel1.PerformLayout();
            this.spltDatabaseInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltDatabaseInfo)).EndInit();
            this.spltDatabaseInfo.ResumeLayout(false);
            this.spltQueryResults.Panel1.ResumeLayout(false);
            this.spltQueryResults.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltQueryResults)).EndInit();
            this.spltQueryResults.ResumeLayout(false);
            this.tbctlQuery.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabQueryResults.ResumeLayout(false);
            this.tabpResult.ResumeLayout(false);
            this.tabpResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.tabpMessages.ResumeLayout(false);
            this.tabpMessages.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tblMainPage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolSConnectionInfo;
        private System.Windows.Forms.ToolStripStatusLabel toolSQueryResults;
        private System.Windows.Forms.SplitContainer spltMain;
        private System.Windows.Forms.SplitContainer spltQueryResults;
        private System.Windows.Forms.TabControl tbctlQuery;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.TextBox txtQuery;
        private System.Windows.Forms.TabControl tabQueryResults;
        private System.Windows.Forms.TabPage tabpResult;
        private System.Windows.Forms.DataGridView dgResults;
        private System.Windows.Forms.Label lblQueryStatus;
        private System.Windows.Forms.TabPage tabpMessages;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.SplitContainer spltDatabaseInfo;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Label lblDatabaseSelection;
        private System.Windows.Forms.Button btnDatabaseRefresh;
        private System.Windows.Forms.TreeView treeTables;
    }
}

