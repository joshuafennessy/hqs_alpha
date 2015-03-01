using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace HiveManagementStudio
{
    public partial class frmHMSMain : Form
    {
        private string DSNName;
        private OdbcConnection conn;
        private OdbcCommand cmd;


        private enum DataSourceType
        {
            System,
            User
        };

        public frmHMSMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //populate combo box with DSN Names
            System.Collections.SortedList dsnList = GetAllDSN();
            for (int i = 0; i < dsnList.Count; i++)
            {
                string sName = dsnList.GetKey(i) as string;
                DataSourceType type = (DataSourceType)dsnList.GetByIndex(i);
                cboDSNList.Items.Add(sName + " - (" + type.ToString() + " DSN)");
            }
        }

        private System.Collections.SortedList GetSystemDSN()
        {
            System.Collections.SortedList dsnList = new System.Collections.SortedList();

            //open registry and get a list of system DSNs
            Microsoft.Win32.RegistryKey reg = (Microsoft.Win32.Registry.LocalMachine).OpenSubKey("Software");
            if (reg != null)
            {
                reg = reg.OpenSubKey("ODBC");
                if (reg != null)
                {
                    //foreach (string sName in reg.GetSubKeyNames())
                    //{
                    //    MessageBox.Show(sName);
                    //} 
                    reg = reg.OpenSubKey("ODBC.INI");
                    if (reg != null)
                    {
                        //foreach (string sName in reg.GetSubKeyNames())
                        //{
                        //    MessageBox.Show(sName);
                        //}
                        reg = reg.OpenSubKey("ODBC Data Sources");
                        if (reg != null)
                        {
                            foreach (string sName in reg.GetValueNames())
                            {
                                dsnList.Add(sName, DataSourceType.System);
                            }
                        }
                        try
                        {
                            reg.Close();
                        }
                        catch { }
                    }
                }
            }
            return dsnList;
        }

        private System.Collections.SortedList GetUserDSN()
        {
            System.Collections.SortedList dsnList = new System.Collections.SortedList();

            //open registry and get a list of system DSNs
            Microsoft.Win32.RegistryKey reg = (Microsoft.Win32.Registry.CurrentUser).OpenSubKey("Software");
            if (reg != null)
            {
                reg = reg.OpenSubKey("ODBC");
                if (reg != null)
                {
                   reg = reg.OpenSubKey("ODBC.INI");
                    if (reg != null)
                    {
                        //foreach (string sName in reg.GetSubKeyNames())
                        //{
                        //    MessageBox.Show(sName);
                        //}
                        reg = reg.OpenSubKey("ODBC Data Sources");
                        if (reg != null)
                        {
                            foreach (string sName in reg.GetValueNames())
                            {
                                dsnList.Add(sName, DataSourceType.User);
                            }
                        }
                        try
                        {
                            reg.Close();
                        }
                        catch { }
                    }
                }
            }
            return dsnList;
        }

        public System.Collections.SortedList GetAllDSN()
        {
            System.Collections.SortedList masterDSNList = GetUserDSN();

            System.Collections.SortedList systemDSNList = GetSystemDSN();
            for(int i = 0; i < systemDSNList.Count; i++)
            {
                string sName = systemDSNList.GetKey(i) as string;
                DataSourceType type = (DataSourceType)systemDSNList.GetByIndex(i);
                try
                {
                    //try to add this DSN to master list
                    //an exception can be thrown if it's a duplicate DSN
                    masterDSNList.Add(sName, type);
                }
                catch { }
            }
            return masterDSNList;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            conn = new OdbcConnection();
    
            string cleanDSNName = DSNName.Substring(0, DSNName.IndexOf("-") - 1).Trim();

            conn.ConnectionString = "Provider=MSDASQL.1;Persist Security Info=True;User ID=" + txtUserName.Text + ";DSN=" + cleanDSNName + ";Password=" + txtPassword.Text + ";";

            try
            {
                conn.Open();
                toolSConnectionInfo.Text = "Connected to " + cleanDSNName;
                LoadDatabaseMetadata();    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open the connection: " + ex.Message.ToString());
            }
        }

        private void cboDSNList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            DSNName = cboDSNList.SelectedItem.ToString();
            string cleanDSNName = DSNName.Substring(0, DSNName.IndexOf("-") - 1).Trim();
                   
            Microsoft.Win32.RegistryKey reg = (Microsoft.Win32.Registry.CurrentUser).OpenSubKey("Software");
            if (reg != null)
            {
                reg = reg.OpenSubKey("ODBC");
                if (reg != null)
                {
                    reg = reg.OpenSubKey("ODBC.INI");
                    if (reg != null)
                    {
                        reg = reg.OpenSubKey(cleanDSNName);
                        if (reg != null)
                        {
                            string userName = reg.GetValue("UID").ToString();
                            txtUserName.Text = userName;
                        }
                    }
                }
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            cmd = new OdbcCommand();
            OdbcDataAdapter daResults = new OdbcDataAdapter();
            System.Data.DataSet dsResults = new System.Data.DataSet();
            BindingSource bsResult = new BindingSource();
            txtMessage.Text = String.Empty;

            try
            {
                toolSQueryResults.Text = "Query Executing...";
                this.Cursor = Cursors.WaitCursor;
                cmd.CommandText = txtQuery.Text;
                cmd.Connection = conn;

                daResults.SelectCommand = cmd;
                
                daResults.Fill(dsResults);
                bsResult.DataSource = dsResults.Tables[0];

                dgResults.DataSource = bsResult;
                dgResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                toolSQueryResults.Text = "Query Execution Complete. " + dsResults.Tables[0].Rows.Count.ToString() + " rows returned.";
                this.Cursor = Cursors.Default;
                btnExecute.Visible = true;
            }
            catch (Exception ex)
            {
                toolSQueryResults.Text = "Error Message Returned. Check Messages tab for more information.";
                txtMessage.Text = ex.Message.ToString();
            }
        }

        private StringBuilder FormatResults(System.Data.DataSet dsResults)
        {
            StringBuilder sbOutput = new StringBuilder();
            
            //loop through columns and append to String Builder
            foreach (System.Data.DataColumn dc in dsResults.Tables[0].Columns)
            {
                sbOutput.Append(dc.ToString() + "\t");

            }
            sbOutput.Append("\r\n\r\n");

            //loop through rows and append to String Builder
            foreach (System.Data.DataRow dr in dsResults.Tables[0].Rows)
            {
                int intRow = dgResults.Rows.Add();
                foreach (System.Data.DataColumn dc in dsResults.Tables[0].Columns)
                {
                    sbOutput.Append(dr[dc].ToString() + "\t");
                }
                sbOutput.Append("\r\n");
            }

            return sbOutput;
        }


        private void LoadDatabaseMetadata()
        {
            //routine to load the database metadata dropdown selector
            OdbcCommand cmd = new OdbcCommand("show databases");
            OdbcDataAdapter daDBMetadata = new OdbcDataAdapter();
            System.Data.DataSet dsDBMetadata = new System.Data.DataSet();
            
            cmd.Connection = conn;
            daDBMetadata.SelectCommand = cmd;
            daDBMetadata.Fill(dsDBMetadata);
            
            cboDatabase.DataSource = dsDBMetadata.Tables[0];
            cboDatabase.ValueMember = "database_name";
            cboDatabase.DisplayMember = "database_name";

        }

        private void LoadDatabaseTables()
        {
            //routine to load the database tables after a database is selected
            OdbcCommand cmd = new OdbcCommand("show tables");
            OdbcDataAdapter daDBMetadata = new OdbcDataAdapter();
            System.Data.DataSet dsDBMetadata = new System.Data.DataSet();

            cmd.Connection = conn;
            daDBMetadata.SelectCommand = cmd;
            daDBMetadata.Fill(dsDBMetadata);

            treeTables.Nodes.Clear();

            if (dsDBMetadata.Tables.Count > 0)
            {
                foreach (DataRow row in dsDBMetadata.Tables[0].Rows)
                {
                    //adds a new tree node at the highest level
                    TreeNode NewNode = new TreeNode(row[0].ToString());
                    treeTables.Nodes.Add(NewNode); 
                    //add a dummy child node
                    TreeNode ChildNode = new TreeNode("");
                    NewNode.Nodes.Add(ChildNode);
                }
            }
        }


        private void btnDatabaseRefresh_Click(object sender, EventArgs e)
        {
            LoadDatabaseMetadata();
        }

        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            //first run a command to use the selected database
            OdbcCommand cmd = new OdbcCommand();
            try
            {
                string cmdtext = "use " + cboDatabase.GetItemText(cboDatabase.SelectedItem).ToString();
                cmd.CommandText = cmdtext;
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            LoadDatabaseTables();
        }

        private void treeTables_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //after a new row is selected, a query needs to be executed to add the nodes.
            //if the nodes are already added, then don't run the query again
            if (treeTables.SelectedNode.IsExpanded)
            {
                if (treeTables.SelectedNode.Nodes.Count == 1)
                {
                    OdbcCommand cmd = new OdbcCommand();
                    OdbcDataAdapter daColumns = new OdbcDataAdapter();
                    System.Data.DataSet dsColumns = new System.Data.DataSet();
                    try
                    {
                        string cmdtext = "describe " + treeTables.SelectedNode.Text.ToString();
                        cmd.CommandText = cmdtext;
                        cmd.Connection = conn;
                        daColumns.SelectCommand = cmd;
                        daColumns.Fill(dsColumns);

                        if (dsColumns.Tables.Count > 0)
                        {
                            treeTables.SelectedNode.Nodes.Clear(); //clear the list of nodes to remove the previously placed dummy node
                            foreach (DataRow row in dsColumns.Tables[0].Rows)
                            {
                                string strNodeText = row["col_name"].ToString() + " (" + row["data_type"].ToString() + ")";
                                TreeNode NewNode = new TreeNode(strNodeText);
                                treeTables.SelectedNode.Nodes.Add(NewNode);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

    }
}
