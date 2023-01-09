namespace FileReaderWriterSales
{
    partial class SalesFPS
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
            this.listBoxIN = new System.Windows.Forms.ListBox();
            this.lblPathIN = new System.Windows.Forms.Label();
            this.folderBrowserDialogIN = new System.Windows.Forms.FolderBrowserDialog();
            this.btnGetIN = new System.Windows.Forms.Button();
            this.panelIN = new System.Windows.Forms.Panel();
            this.btnINRefresh = new System.Windows.Forms.Button();
            this.lblFilesINQtd = new System.Windows.Forms.Label();
            this.panelOUT = new System.Windows.Forms.Panel();
            this.btnOutReportRefresh = new System.Windows.Forms.Button();
            this.lblFilesOUTQtd = new System.Windows.Forms.Label();
            this.btnOUT = new System.Windows.Forms.Button();
            this.lblPathOUT = new System.Windows.Forms.Label();
            this.listBoxOUT = new System.Windows.Forms.ListBox();
            this.folderBrowserDialogOUT = new System.Windows.Forms.FolderBrowserDialog();
            this.pnlINReport = new System.Windows.Forms.Panel();
            this.lblINReport = new System.Windows.Forms.Label();
            this.richTextBoxINReport = new System.Windows.Forms.RichTextBox();
            this.lblTotalRecords = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblFileProcessing = new System.Windows.Forms.Label();
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.rdbAsync = new System.Windows.Forms.RadioButton();
            this.rdbSync = new System.Windows.Forms.RadioButton();
            this.btnStopImport = new System.Windows.Forms.Button();
            this.btnStartImport = new System.Windows.Forms.Button();
            this.textBoxTimeThread = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeFileInterval = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.panelIN.SuspendLayout();
            this.panelOUT.SuspendLayout();
            this.pnlINReport.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlTasks.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxIN
            // 
            this.listBoxIN.FormattingEnabled = true;
            this.listBoxIN.Location = new System.Drawing.Point(13, 35);
            this.listBoxIN.Name = "listBoxIN";
            this.listBoxIN.Size = new System.Drawing.Size(435, 134);
            this.listBoxIN.TabIndex = 1;
            this.listBoxIN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxIN_MouseClick);
            // 
            // lblPathIN
            // 
            this.lblPathIN.AutoSize = true;
            this.lblPathIN.Location = new System.Drawing.Point(10, 10);
            this.lblPathIN.Name = "lblPathIN";
            this.lblPathIN.Size = new System.Drawing.Size(62, 13);
            this.lblPathIN.TabIndex = 2;
            this.lblPathIN.Text = "( IN PATH )";
            // 
            // btnGetIN
            // 
            this.btnGetIN.Location = new System.Drawing.Point(277, 3);
            this.btnGetIN.Name = "btnGetIN";
            this.btnGetIN.Size = new System.Drawing.Size(90, 23);
            this.btnGetIN.TabIndex = 3;
            this.btnGetIN.Text = "IN directory";
            this.btnGetIN.UseVisualStyleBackColor = true;
            this.btnGetIN.Click += new System.EventHandler(this.btnGetIN_Click);
            // 
            // panelIN
            // 
            this.panelIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIN.Controls.Add(this.btnINRefresh);
            this.panelIN.Controls.Add(this.lblFilesINQtd);
            this.panelIN.Controls.Add(this.btnGetIN);
            this.panelIN.Controls.Add(this.lblPathIN);
            this.panelIN.Controls.Add(this.panelOUT);
            this.panelIN.Controls.Add(this.listBoxIN);
            this.panelIN.Location = new System.Drawing.Point(12, 137);
            this.panelIN.Name = "panelIN";
            this.panelIN.Size = new System.Drawing.Size(465, 417);
            this.panelIN.TabIndex = 4;
            // 
            // btnINRefresh
            // 
            this.btnINRefresh.Location = new System.Drawing.Point(373, 3);
            this.btnINRefresh.Name = "btnINRefresh";
            this.btnINRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnINRefresh.TabIndex = 3;
            this.btnINRefresh.Text = "Refresh";
            this.btnINRefresh.UseVisualStyleBackColor = true;
            this.btnINRefresh.Click += new System.EventHandler(this.btnInRefresh_Click);
            // 
            // lblFilesINQtd
            // 
            this.lblFilesINQtd.AutoSize = true;
            this.lblFilesINQtd.Location = new System.Drawing.Point(10, 181);
            this.lblFilesINQtd.Name = "lblFilesINQtd";
            this.lblFilesINQtd.Size = new System.Drawing.Size(31, 13);
            this.lblFilesINQtd.TabIndex = 4;
            this.lblFilesINQtd.Text = "Files:";
            // 
            // panelOUT
            // 
            this.panelOUT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOUT.Controls.Add(this.btnOutReportRefresh);
            this.panelOUT.Controls.Add(this.lblFilesOUTQtd);
            this.panelOUT.Controls.Add(this.btnOUT);
            this.panelOUT.Controls.Add(this.lblPathOUT);
            this.panelOUT.Controls.Add(this.listBoxOUT);
            this.panelOUT.Location = new System.Drawing.Point(-1, 197);
            this.panelOUT.Name = "panelOUT";
            this.panelOUT.Size = new System.Drawing.Size(465, 225);
            this.panelOUT.TabIndex = 5;
            // 
            // btnOutReportRefresh
            // 
            this.btnOutReportRefresh.Location = new System.Drawing.Point(373, 10);
            this.btnOutReportRefresh.Name = "btnOutReportRefresh";
            this.btnOutReportRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnOutReportRefresh.TabIndex = 3;
            this.btnOutReportRefresh.Text = "Refresh";
            this.btnOutReportRefresh.UseVisualStyleBackColor = true;
            this.btnOutReportRefresh.Click += new System.EventHandler(this.btnOutReportRefresh_Click);
            // 
            // lblFilesOUTQtd
            // 
            this.lblFilesOUTQtd.AutoSize = true;
            this.lblFilesOUTQtd.Location = new System.Drawing.Point(10, 197);
            this.lblFilesOUTQtd.Name = "lblFilesOUTQtd";
            this.lblFilesOUTQtd.Size = new System.Drawing.Size(31, 13);
            this.lblFilesOUTQtd.TabIndex = 4;
            this.lblFilesOUTQtd.Text = "Files:";
            // 
            // btnOUT
            // 
            this.btnOUT.Location = new System.Drawing.Point(279, 10);
            this.btnOUT.Name = "btnOUT";
            this.btnOUT.Size = new System.Drawing.Size(88, 23);
            this.btnOUT.TabIndex = 3;
            this.btnOUT.Text = "OUT directory";
            this.btnOUT.UseVisualStyleBackColor = true;
            this.btnOUT.Click += new System.EventHandler(this.btnGetOUT_Click);
            // 
            // lblPathOUT
            // 
            this.lblPathOUT.AutoSize = true;
            this.lblPathOUT.Location = new System.Drawing.Point(10, 10);
            this.lblPathOUT.Name = "lblPathOUT";
            this.lblPathOUT.Size = new System.Drawing.Size(74, 13);
            this.lblPathOUT.TabIndex = 2;
            this.lblPathOUT.Text = "( OUT PATH )";
            // 
            // listBoxOUT
            // 
            this.listBoxOUT.FormattingEnabled = true;
            this.listBoxOUT.Location = new System.Drawing.Point(13, 35);
            this.listBoxOUT.Name = "listBoxOUT";
            this.listBoxOUT.Size = new System.Drawing.Size(435, 147);
            this.listBoxOUT.TabIndex = 1;
            this.listBoxOUT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBoxOUT_MouseClick);
            // 
            // pnlINReport
            // 
            this.pnlINReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlINReport.Controls.Add(this.lblINReport);
            this.pnlINReport.Controls.Add(this.richTextBoxINReport);
            this.pnlINReport.Location = new System.Drawing.Point(490, 137);
            this.pnlINReport.Name = "pnlINReport";
            this.pnlINReport.Size = new System.Drawing.Size(653, 417);
            this.pnlINReport.TabIndex = 10;
            // 
            // lblINReport
            // 
            this.lblINReport.AutoSize = true;
            this.lblINReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINReport.Location = new System.Drawing.Point(10, 10);
            this.lblINReport.Name = "lblINReport";
            this.lblINReport.Size = new System.Drawing.Size(138, 13);
            this.lblINReport.TabIndex = 1;
            this.lblINReport.Text = "Content of Data IN File";
            // 
            // richTextBoxINReport
            // 
            this.richTextBoxINReport.Location = new System.Drawing.Point(13, 34);
            this.richTextBoxINReport.Name = "richTextBoxINReport";
            this.richTextBoxINReport.ReadOnly = true;
            this.richTextBoxINReport.Size = new System.Drawing.Size(618, 346);
            this.richTextBoxINReport.TabIndex = 0;
            this.richTextBoxINReport.Text = "";
            // 
            // lblTotalRecords
            // 
            this.lblTotalRecords.AutoSize = true;
            this.lblTotalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRecords.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTotalRecords.Location = new System.Drawing.Point(280, 49);
            this.lblTotalRecords.Name = "lblTotalRecords";
            this.lblTotalRecords.Size = new System.Drawing.Size(24, 25);
            this.lblTotalRecords.TabIndex = 0;
            this.lblTotalRecords.Text = "0";
            this.lblTotalRecords.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblRecords
            // 
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.Location = new System.Drawing.Point(18, 45);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(238, 29);
            this.lblRecords.TabIndex = 1;
            this.lblRecords.Text = "Records to process:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "File:";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.Color.Red;
            this.lblMode.Location = new System.Drawing.Point(20, 76);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(268, 17);
            this.lblMode.TabIndex = 2;
            this.lblMode.Text = "ASYNCH MODE running. Last Thread is: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblMode);
            this.panel2.Controls.Add(this.lblFileProcessing);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblRecords);
            this.panel2.Controls.Add(this.lblTotalRecords);
            this.panel2.Location = new System.Drawing.Point(490, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(653, 104);
            this.panel2.TabIndex = 11;
            // 
            // lblFileProcessing
            // 
            this.lblFileProcessing.AutoSize = true;
            this.lblFileProcessing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileProcessing.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblFileProcessing.Location = new System.Drawing.Point(85, 7);
            this.lblFileProcessing.Name = "lblFileProcessing";
            this.lblFileProcessing.Size = new System.Drawing.Size(30, 25);
            this.lblFileProcessing.TabIndex = 4;
            this.lblFileProcessing.Text = "...";
            this.lblFileProcessing.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnlTasks
            // 
            this.pnlTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTasks.Controls.Add(this.rdbAsync);
            this.pnlTasks.Controls.Add(this.rdbSync);
            this.pnlTasks.Controls.Add(this.btnStopImport);
            this.pnlTasks.Controls.Add(this.btnStartImport);
            this.pnlTasks.Controls.Add(this.textBoxTimeThread);
            this.pnlTasks.Controls.Add(this.label1);
            this.pnlTasks.Controls.Add(this.lblTimeFileInterval);
            this.pnlTasks.Enabled = false;
            this.pnlTasks.Location = new System.Drawing.Point(12, 15);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(465, 102);
            this.pnlTasks.TabIndex = 3;
            // 
            // rdbAsync
            // 
            this.rdbAsync.AutoSize = true;
            this.rdbAsync.Cursor = System.Windows.Forms.Cursors.Default;
            this.rdbAsync.Location = new System.Drawing.Point(114, 28);
            this.rdbAsync.Name = "rdbAsync";
            this.rdbAsync.Size = new System.Drawing.Size(92, 17);
            this.rdbAsync.TabIndex = 6;
            this.rdbAsync.Text = "Asynchronous";
            this.rdbAsync.UseVisualStyleBackColor = true;
            this.rdbAsync.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdbAsync_Click);
            // 
            // rdbSync
            // 
            this.rdbSync.AutoSize = true;
            this.rdbSync.Checked = true;
            this.rdbSync.Location = new System.Drawing.Point(114, 5);
            this.rdbSync.Name = "rdbSync";
            this.rdbSync.Size = new System.Drawing.Size(87, 17);
            this.rdbSync.TabIndex = 5;
            this.rdbSync.TabStop = true;
            this.rdbSync.Text = "Synchronous";
            this.rdbSync.UseVisualStyleBackColor = true;
            this.rdbSync.Click += new System.EventHandler(this.rdbSync_Click);
            // 
            // btnStopImport
            // 
            this.btnStopImport.Location = new System.Drawing.Point(97, 62);
            this.btnStopImport.Name = "btnStopImport";
            this.btnStopImport.Size = new System.Drawing.Size(75, 23);
            this.btnStopImport.TabIndex = 4;
            this.btnStopImport.Text = "Stop";
            this.btnStopImport.UseVisualStyleBackColor = true;
            this.btnStopImport.Click += new System.EventHandler(this.btnStopImport_Click);
            // 
            // btnStartImport
            // 
            this.btnStartImport.Location = new System.Drawing.Point(16, 62);
            this.btnStartImport.Name = "btnStartImport";
            this.btnStartImport.Size = new System.Drawing.Size(75, 23);
            this.btnStartImport.TabIndex = 3;
            this.btnStartImport.Text = "Start";
            this.btnStartImport.UseVisualStyleBackColor = true;
            this.btnStartImport.Click += new System.EventHandler(this.btnStartImport_Click);
            // 
            // textBoxTimeThread
            // 
            this.textBoxTimeThread.Location = new System.Drawing.Point(390, 8);
            this.textBoxTimeThread.Name = "textBoxTimeThread";
            this.textBoxTimeThread.Size = new System.Drawing.Size(31, 20);
            this.textBoxTimeThread.TabIndex = 1;
            this.textBoxTimeThread.Text = "10";
            this.textBoxTimeThread.TextChanged += new System.EventHandler(this.textBoxTimeThread_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Method";
            // 
            // lblTimeFileInterval
            // 
            this.lblTimeFileInterval.AutoSize = true;
            this.lblTimeFileInterval.Location = new System.Drawing.Point(221, 11);
            this.lblTimeFileInterval.Name = "lblTimeFileInterval";
            this.lblTimeFileInterval.Size = new System.Drawing.Size(163, 13);
            this.lblTimeFileInterval.TabIndex = 0;
            this.lblTimeFileInterval.Text = "File processing interval(seconds):";
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.Color.Red;
            this.lblWait.Location = new System.Drawing.Point(54, 563);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(0, 37);
            this.lblWait.TabIndex = 12;
            // 
            // SalesFPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 609);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.pnlTasks);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlINReport);
            this.Controls.Add(this.panelIN);
            this.Name = "SalesFPS";
            this.Text = "SalesFPS - File Processing System - v1.01";
            this.Load += new System.EventHandler(this.SalesFPS_Load);
            this.panelIN.ResumeLayout(false);
            this.panelIN.PerformLayout();
            this.panelOUT.ResumeLayout(false);
            this.panelOUT.PerformLayout();
            this.pnlINReport.ResumeLayout(false);
            this.pnlINReport.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTasks.ResumeLayout(false);
            this.pnlTasks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxIN;
        private System.Windows.Forms.Label lblPathIN;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogIN;
        private System.Windows.Forms.Button btnGetIN;
        private System.Windows.Forms.Panel panelIN;
        private System.Windows.Forms.Label lblFilesINQtd;
        private System.Windows.Forms.Panel panelOUT;
        private System.Windows.Forms.Label lblFilesOUTQtd;
        private System.Windows.Forms.Button btnOUT;
        private System.Windows.Forms.Label lblPathOUT;
        private System.Windows.Forms.ListBox listBoxOUT;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogOUT;
        private System.Windows.Forms.Button btnOutReportRefresh;
        private System.Windows.Forms.Panel pnlINReport;
        private System.Windows.Forms.Button btnINRefresh;
        private System.Windows.Forms.Label lblINReport;
        private System.Windows.Forms.RichTextBox richTextBoxINReport;
        private System.Windows.Forms.Label lblTotalRecords;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlTasks;
        private System.Windows.Forms.RadioButton rdbAsync;
        private System.Windows.Forms.RadioButton rdbSync;
        private System.Windows.Forms.Button btnStopImport;
        private System.Windows.Forms.Button btnStartImport;
        private System.Windows.Forms.TextBox textBoxTimeThread;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimeFileInterval;
        private System.Windows.Forms.Label lblFileProcessing;
        private System.Windows.Forms.Label lblWait;
    }
}

