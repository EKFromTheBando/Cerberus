using Cerberus.Cerberus.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Cerberus.Cerberus.Forms
{
    public partial class KeyvaultCheckerForm : DevExpress.XtraEditors.XtraForm
    {
        private string[] subFiles;
        private Exception exception;
        private IList<string> Names = new List<string>();

        public KeyvaultCheckerForm()
        {
            InitializeComponent();
            InitializeGridControl();
        }

        private void InitializeGridControl()
        {
            // Ensure GridControlKVList and GridViewKVList are initialized
            if (GridControlKVList == null || GridViewKVList == null)
            {
                MessageBox.Show("GridControl or GridView is not initialized.", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Set up GridControl and GridView
            DataTable dataTable = CreateDataTable();
            GridControlKVList.DataSource = dataTable;

            // Set column captions
            if (GridViewKVList != null)
            {
                GridViewKVList.Columns["ColumnKV"].Caption = "Keyvault";
                GridViewKVList.Columns["ColumnBanStatus"].Caption = "Ban Status";
            }
        }

        private DataTable CreateDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ColumnKV", typeof(string));
            table.Columns.Add("ColumnBanStatus", typeof(string));
            return table;
        }

        private void ButtonCheckAll_Click(object sender, EventArgs e)
        {
            ButtonCheckAll.Enabled = false;
            string logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "KVs", "log.txt");

            if (File.Exists(logPath))
            {
                try
                {
                    File.Delete(logPath);
                }
                catch (Exception ex)
                {
                    exception = ex;
                    ButtonCheckAll.Enabled = true;
                    return;
                }
            }

            ThreadPool.QueueUserWorkItem(doWork);
        }

        private void doWork(object state)
        {
            Program program = new Program();
            base.Invoke(new MethodInvoker(delegate ()
            {
                // Set the MarqueeProgressBarControl to indicate ongoing work
                this.ProgressBarKeyvaultChecker.Visible = true;
                this.ProgressBarKeyvaultChecker.Properties.MarqueeAnimationSpeed = 50; // Adjust the speed as needed
                this.ProgressBarKeyvaultChecker.EditValue = 0;
                this.GridViewKVList.BeginUpdate(); // Begin updating the GridView
            }));

            foreach (string text in this.Names)
            {
                program.getStatus(text);
                string status = program.returnStatus() ? "Banned" : "Unbanned";

                // Update the status in the DataTable
                base.Invoke(new MethodInvoker(delegate ()
                {
                    DataTable dataTable = (DataTable)GridControlKVList.DataSource;
                    if (dataTable != null)
                    {
                        // Find the row with the matching Keyvault name
                        DataRow[] rows = dataTable.Select($"ColumnKV = '{text}'");
                        if (rows.Length > 0)
                        {
                            rows[0]["ColumnBanStatus"] = status;
                        }
                    }
                }));

                // Optionally update UI elements here
            }

            base.Invoke(new MethodInvoker(delegate ()
            {
                // Hide the MarqueeProgressBarControl after completion
                this.ProgressBarKeyvaultChecker.Visible = false;
                this.GridViewKVList.EndUpdate(); // End updating the GridView
                this.ButtonCheckAll.Enabled = true;
            }));
        }



        private void KeyvaultCheckerForm_Load(object sender, EventArgs e)
        {
            // Launch folder browser dialog to select directory
            using (FolderBrowserDialog folderBrowser = new FolderBrowserDialog())
            {
                folderBrowser.Description = "Select the folder containing KV files";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string path = folderBrowser.SelectedPath;
                    if (!Directory.Exists(path))
                    {
                        MessageBox.Show("The selected directory does not exist.", "Directory Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string[] files = Directory.GetFiles(path);
                    string[] directories = Directory.GetDirectories(path);

                    foreach (string directory in directories)
                    {
                        subFiles = Directory.GetFiles(directory);
                        foreach (string file in subFiles)
                        {
                            if (file.EndsWith(".bin"))
                            {
                                int num = directory.LastIndexOf('\\');
                                int num2 = (num > 0) ? file.LastIndexOf('\\', num - 1) : -1;
                                string item = file.Substring(num2 + 1);
                                Names.Add(item);

                                // Add to DataTable on the main thread
                                this.Invoke(new Action(() =>
                                {
                                    DataTable dataTable = (DataTable)GridControlKVList.DataSource;
                                    if (dataTable != null)
                                    {
                                        dataTable.Rows.Add(item, "Unknown");
                                    }
                                }));
                            }
                        }
                    }

                    foreach (string file in files)
                    {
                        if (file.EndsWith(".bin"))
                        {
                            int num3 = file.LastIndexOf('\\');
                            int num4 = (num3 > 0) ? file.LastIndexOf('\\', num3 - 1) : -1;
                            string item2 = file.Substring(num4 + 1);
                            Names.Add(item2);

                            // Add to DataTable on the main thread
                            this.Invoke(new Action(() =>
                            {
                                DataTable dataTable = (DataTable)GridControlKVList.DataSource;
                                if (dataTable != null)
                                {
                                    dataTable.Rows.Add(item2, "Unknown");
                                }
                            }));
                        }
                    }
                }
            }
        }

        private void ButtonImportKVs_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "BIN files (*.bin)|*.bin";
                openFileDialog.Multiselect = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Add selected files to the Names list and GridControl on the main thread
                    foreach (string fileName in openFileDialog.FileNames)
                    {
                        string item = Path.GetFileName(fileName);

                        // Add to Names list
                        if (!Names.Contains(item))
                        {
                            Names.Add(item);

                            // Add to DataTable on the main thread
                            this.Invoke(new Action(() =>
                            {
                                DataTable dataTable = (DataTable)GridControlKVList.DataSource;
                                if (dataTable != null)
                                {
                                    dataTable.Rows.Add(item, "Unknown");
                                }
                            }));
                        }
                    }
                }
            }
        }
    }
}
