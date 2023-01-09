using FileReaderWriterSales.ImportExportData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReaderWriterSales
{
    public partial class SalesFPS : Form
    {

        #region Properties

        private string folderNameIN = string.Empty;
        private string folderNameOUT = string.Empty;
        private string fileLogError = string.Empty;
        
        private int totalRecordsFileClicked;
        private string nameFileProcessing = string.Empty;
        
        Timer timerEndThread = new Timer();

        #endregion

        #region Methods
        public SalesFPS()
        {
            InitializeComponent();
        }

        private void SalesFPS_Load(object sender, EventArgs e)
        {
            textBoxTimeThread.Enabled = false;
            lblMode.Text = "";

        }

        private void btnGetIN_Click(object sender, EventArgs e)
        {
            listBoxIN.Items.Clear();
            folderBrowserDialogIN.ShowDialog();
            folderNameIN = folderBrowserDialogIN.SelectedPath;

            MainTasks mainT = new MainTasks();
            mainT.ListFilesDirectory(listBoxIN,folderNameIN);

            lblPathIN.Text = folderNameIN;
            lblFilesINQtd.Text = "Files: " + listBoxIN.Items.Count.ToString();

            if (lblPathIN.Text != "( IN PATH )" && lblPathOUT.Text != "( OUT PATH )" && listBoxIN.Items.Count != 0)
            {
                pnlTasks.Enabled = true;
                lblMode.Text = "SYNCH MODE";
                lblMode.ForeColor = Color.Blue;
            }




        }

        private void btnGetOUT_Click(object sender, EventArgs e)
        {
            listBoxOUT.Items.Clear();
            folderBrowserDialogOUT.ShowDialog();
            folderNameOUT = folderBrowserDialogOUT.SelectedPath;

            MainTasks mainT = new MainTasks();
            mainT.ListFilesDirectory(listBoxOUT, folderNameOUT);

            lblPathOUT.Text = folderNameOUT;
            lblFilesOUTQtd.Text = "Files: " + listBoxOUT.Items.Count.ToString();

            if (lblPathIN.Text != "( IN PATH )" &&  lblPathOUT.Text != "( OUT PATH )" && !String.IsNullOrEmpty(folderNameOUT))//&& listBoxOUT.Items.Count != 0)
            {
                pnlTasks.Enabled = true;
                lblMode.Text = "SYNCH MODE";
                lblMode.ForeColor = Color.Blue;
            }

            fileLogError = folderNameOUT;

        }

        private void listBoxIN_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxIN.SelectedItem != null)
            {
                string fileContent = File.ReadAllText(listBoxIN.SelectedItem.ToString());
                totalRecordsFileClicked = File.ReadLines(listBoxIN.SelectedItem.ToString()).Count()-1;
                
                lblTotalRecords.Text = totalRecordsFileClicked.ToString();
                string nameFile = listBoxIN.SelectedItem.ToString();
                lblFileProcessing.Text = nameFile.Substring(nameFile.LastIndexOf(@"\") + 1);

                richTextBoxINReport.Text = fileContent;
            }
        }

        private void listBoxOUT_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxOUT.SelectedItem != null)
            {
                string fileContent = File.ReadAllText(listBoxOUT.SelectedItem.ToString());
            }

        }

        private void rdbAsync_Click(object sender, MouseEventArgs e)
        {
            textBoxTimeThread.Enabled = true;
            lblMode.Text = "ASYNCH MODE";
            lblMode.ForeColor = Color.Red;

        }

        private void rdbSync_Click(object sender, EventArgs e)
        {
            textBoxTimeThread.Enabled = false;
            lblMode.Text = "SYNCH MODE";
            lblMode.ForeColor = Color.Blue;
        }

        private void btnStartImport_Click(object sender, EventArgs e)
        {


            int filesInFolder = listBoxIN.Items.Count;

            if (rdbSync.Checked)
            {
                if (filesInFolder == 0)
                {
                    lblTotalRecords.Text = "0";
                    MessageBox.Show("Folder IN is empty...");
                }
                else
                {
                    lblWait.Text = "Wait!!";
                    lblWait.Refresh();
                    
                    btnStartImport.Enabled = false;

                    CallStartImport();
                    
                    btnStartImport.Enabled = true;

                }
            }
            else
            {
                rdbAsync.Enabled = false;
                rdbSync.Enabled = false;
                btnStartImport.Enabled = false;

                textBoxTimeThread.Enabled=false;

                RefreshFolders("In");
                RefreshFolders("Out");

                lblWait.Text = "Thread mode running... wait or stop!";

                
                timerEndThread.Tick += new EventHandler(timerEndThread_Tick);
                timerEndThread.Interval = (1000) * (Convert.ToInt16(textBoxTimeThread.Text));
                timerEndThread.Enabled = true;
                timerEndThread.Start();

            }


        }

        void timerEndThread_Tick(object sender, EventArgs e)
        {
            CallStartImport();
        }


        private void CallStartImport()
        {
            try
            {

                MainTasks mainT = new MainTasks();
                
                mainT.StartImport(listBoxIN, folderNameIN, fileLogError);

                // Refresh IN
                listBoxIN.Items.Clear();
                mainT.ListFilesDirectory(listBoxIN, folderNameIN);
                lblPathIN.Text = folderNameIN;
                lblFilesINQtd.Text = "Files: " + listBoxIN.Items.Count.ToString();

                // Refresh OUT
                listBoxOUT.Items.Clear();
                mainT.ListFilesDirectory(listBoxOUT, folderNameOUT);
                lblPathOUT.Text = folderNameOUT;
                lblFilesOUTQtd.Text = "Files: " + listBoxOUT.Items.Count.ToString();

                if (rdbSync.Checked)
                {
                    lblWait.Text = "";
                    MessageBox.Show("Finished process.");
                    lblFileProcessing.Text = "...";
                    lblMode.Text = "";
                    lblTotalRecords.Text = "0";
                }

                richTextBoxINReport.Text = String.Empty;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in CallStartImport method:"+ex.Message);
            }
        }

        private void btnInRefresh_Click(object sender, EventArgs e)
        {
            RefreshFolders("In");
        }

        private void btnOutReportRefresh_Click(object sender, EventArgs e)
        {
            RefreshFolders("Out");
        }


        private void RefreshFolders(string nameFolder)
        {

            MainTasks mainT = new MainTasks();

            if (nameFolder == "In")
            {
                listBoxIN.Items.Clear();
                mainT.ListFilesDirectory(listBoxIN, folderNameIN);
                lblPathIN.Text = folderNameIN;
                lblFilesINQtd.Text = "Files: " + listBoxIN.Items.Count.ToString();
            }
            else
            {
                listBoxOUT.Items.Clear();
                mainT.ListFilesDirectory(listBoxOUT, folderNameOUT);
                lblPathOUT.Text = folderNameOUT;
                lblFilesOUTQtd.Text = "Files: " + listBoxOUT.Items.Count.ToString();
            }


        }


        private void btnStopImport_Click(object sender, EventArgs e)
        {
            lblWait.Text = "Stopping thread.... wait!";
            timerEndThread.Stop();
            
            btnStartImport.Enabled = true;

            lblWait.Text = "";
            
            rdbAsync.Enabled = true;
            rdbSync.Enabled = true;
            
            textBoxTimeThread.Enabled = true;


        }

        private void textBoxTimeThread_TextChanged(object sender, EventArgs e)
        {
            int textBoxTime = 0;
            Int32.TryParse(textBoxTimeThread.Text, out textBoxTime);
            if(textBoxTime < 10 && textBoxTimeThread.Text != "")
            {
                textBoxTimeThread.Text = "10";
            }
        }




        #endregion

    }
}

