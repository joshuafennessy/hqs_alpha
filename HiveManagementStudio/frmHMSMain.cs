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
                lblConnectionStatus.Text = "Attempting Connection.";
                conn.Open();
                lblConnectionStatus.Text = "Connected to " + DSNName;
                
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
                cmd.CommandText = txtQuery.Text;
                cmd.Connection = conn;

                daResults.SelectCommand = cmd;
                lblQueryStatus.Text = "Query Executing...";
                daResults.Fill(dsResults);
                bsResult.DataSource = dsResults.Tables[0];

                dgResults.DataSource = bsResult;
                dgResults.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                lblQueryStatus.Text = "Query Execution Completed. " + dsResults.Tables[0].Rows.Count.ToString() + " rows returned.";
                txtMessage.Text = "Query Execution Completed. " + dsResults.Tables[0].Rows.Count.ToString() + " rows returned.";
            }
            catch (Exception ex)
            {
                lblQueryStatus.Text = "Error Message Returned. Check Messages tab for more information.";
                txtMessage.Text = ex.Message.ToString();
            }
        }
            //MessageBox.Show(dsResults.Tables[0].Rows.Count.ToString());
        

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

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
