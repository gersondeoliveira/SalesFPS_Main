namespace DataGeneratorToImport
{
    partial class DataGenerator
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
            this.btnGenerateSalesMan = new System.Windows.Forms.Button();
            this.richTextBoxSalesMan = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSalesMan = new System.Windows.Forms.TextBox();
            this.textBoxCustomers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSales = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxCustomers = new System.Windows.Forms.RichTextBox();
            this.richTextBoxSales = new System.Windows.Forms.RichTextBox();
            this.btnGenerateCustomers = new System.Windows.Forms.Button();
            this.btnGenerateSalesMov = new System.Windows.Forms.Button();
            this.richTextBoxEntireFile = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnCreateFileFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialogIN = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPathIN = new System.Windows.Forms.Label();
            this.lblAllRecords = new System.Windows.Forms.Label();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbDelimiter = new System.Windows.Forms.ComboBox();
            this.lblDelimiter = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLast = new System.Windows.Forms.Label();
            this.txtLastIdGenerated = new System.Windows.Forms.TextBox();
            this.chkAppendToFile = new System.Windows.Forms.CheckBox();
            this.rdbPortugueseSaleName = new System.Windows.Forms.RadioButton();
            this.rdbEnglishSaleName = new System.Windows.Forms.RadioButton();
            this.lblWaiting = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateSalesMan
            // 
            this.btnGenerateSalesMan.Location = new System.Drawing.Point(494, 67);
            this.btnGenerateSalesMan.Name = "btnGenerateSalesMan";
            this.btnGenerateSalesMan.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateSalesMan.TabIndex = 0;
            this.btnGenerateSalesMan.Text = "Generate";
            this.btnGenerateSalesMan.UseVisualStyleBackColor = true;
            this.btnGenerateSalesMan.Click += new System.EventHandler(this.btnGenerateSalesMan_Click);
            // 
            // richTextBoxSalesMan
            // 
            this.richTextBoxSalesMan.Location = new System.Drawing.Point(24, 106);
            this.richTextBoxSalesMan.Name = "richTextBoxSalesMan";
            this.richTextBoxSalesMan.Size = new System.Drawing.Size(558, 109);
            this.richTextBoxSalesMan.TabIndex = 1;
            this.richTextBoxSalesMan.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sales Man:";
            // 
            // textBoxSalesMan
            // 
            this.textBoxSalesMan.Location = new System.Drawing.Point(150, 80);
            this.textBoxSalesMan.Name = "textBoxSalesMan";
            this.textBoxSalesMan.Size = new System.Drawing.Size(100, 20);
            this.textBoxSalesMan.TabIndex = 3;
            this.textBoxSalesMan.Text = "1000";
            // 
            // textBoxCustomers
            // 
            this.textBoxCustomers.Location = new System.Drawing.Point(137, 221);
            this.textBoxCustomers.Name = "textBoxCustomers";
            this.textBoxCustomers.Size = new System.Drawing.Size(100, 20);
            this.textBoxCustomers.TabIndex = 5;
            this.textBoxCustomers.Text = "1000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customers:";
            // 
            // textBoxSales
            // 
            this.textBoxSales.Location = new System.Drawing.Point(137, 379);
            this.textBoxSales.Name = "textBoxSales";
            this.textBoxSales.Size = new System.Drawing.Size(100, 20);
            this.textBoxSales.TabIndex = 7;
            this.textBoxSales.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sales Movimentation:";
            // 
            // richTextBoxCustomers
            // 
            this.richTextBoxCustomers.Location = new System.Drawing.Point(11, 250);
            this.richTextBoxCustomers.Name = "richTextBoxCustomers";
            this.richTextBoxCustomers.Size = new System.Drawing.Size(558, 114);
            this.richTextBoxCustomers.TabIndex = 8;
            this.richTextBoxCustomers.Text = "";
            // 
            // richTextBoxSales
            // 
            this.richTextBoxSales.Location = new System.Drawing.Point(11, 449);
            this.richTextBoxSales.Name = "richTextBoxSales";
            this.richTextBoxSales.Size = new System.Drawing.Size(558, 149);
            this.richTextBoxSales.TabIndex = 9;
            this.richTextBoxSales.Text = "";
            // 
            // btnGenerateCustomers
            // 
            this.btnGenerateCustomers.Location = new System.Drawing.Point(494, 221);
            this.btnGenerateCustomers.Name = "btnGenerateCustomers";
            this.btnGenerateCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateCustomers.TabIndex = 10;
            this.btnGenerateCustomers.Text = "Generate";
            this.btnGenerateCustomers.UseVisualStyleBackColor = true;
            this.btnGenerateCustomers.Click += new System.EventHandler(this.btnGenerateCustomers_Click);
            // 
            // btnGenerateSalesMov
            // 
            this.btnGenerateSalesMov.Enabled = false;
            this.btnGenerateSalesMov.Location = new System.Drawing.Point(494, 409);
            this.btnGenerateSalesMov.Name = "btnGenerateSalesMov";
            this.btnGenerateSalesMov.Size = new System.Drawing.Size(75, 23);
            this.btnGenerateSalesMov.TabIndex = 11;
            this.btnGenerateSalesMov.Text = "Generate";
            this.btnGenerateSalesMov.UseVisualStyleBackColor = true;
            this.btnGenerateSalesMov.Click += new System.EventHandler(this.btnGenerateSalesMov_Click);
            // 
            // richTextBoxEntireFile
            // 
            this.richTextBoxEntireFile.Location = new System.Drawing.Point(615, 59);
            this.richTextBoxEntireFile.Name = "richTextBoxEntireFile";
            this.richTextBoxEntireFile.ReadOnly = true;
            this.richTextBoxEntireFile.Size = new System.Drawing.Size(460, 549);
            this.richTextBoxEntireFile.TabIndex = 12;
            this.richTextBoxEntireFile.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "All Records:";
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(277, 12);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(196, 23);
            this.btnShuffle.TabIndex = 15;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // btnCreateFileFolder
            // 
            this.btnCreateFileFolder.Enabled = false;
            this.btnCreateFileFolder.Location = new System.Drawing.Point(11, 616);
            this.btnCreateFileFolder.Name = "btnCreateFileFolder";
            this.btnCreateFileFolder.Size = new System.Drawing.Size(127, 23);
            this.btnCreateFileFolder.TabIndex = 16;
            this.btnCreateFileFolder.Text = "Choose File FOLDER:";
            this.btnCreateFileFolder.UseVisualStyleBackColor = true;
            this.btnCreateFileFolder.Click += new System.EventHandler(this.btnCreateFileFolder_Click);
            // 
            // lblPathIN
            // 
            this.lblPathIN.AutoSize = true;
            this.lblPathIN.Location = new System.Drawing.Point(144, 621);
            this.lblPathIN.Name = "lblPathIN";
            this.lblPathIN.Size = new System.Drawing.Size(16, 13);
            this.lblPathIN.TabIndex = 17;
            this.lblPathIN.Text = "...";
            // 
            // lblAllRecords
            // 
            this.lblAllRecords.AutoSize = true;
            this.lblAllRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllRecords.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblAllRecords.Location = new System.Drawing.Point(114, 6);
            this.lblAllRecords.Name = "lblAllRecords";
            this.lblAllRecords.Size = new System.Drawing.Size(34, 29);
            this.lblAllRecords.TabIndex = 18;
            this.lblAllRecords.Text = "...";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Enabled = false;
            this.btnCreateFile.Location = new System.Drawing.Point(442, 616);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(127, 23);
            this.btnCreateFile.TabIndex = 19;
            this.btnCreateFile.Text = "C R E A T E !";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbDelimiter);
            this.panel1.Controls.Add(this.lblDelimiter);
            this.panel1.Location = new System.Drawing.Point(24, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 45);
            this.panel1.TabIndex = 20;
            // 
            // cmbDelimiter
            // 
            this.cmbDelimiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDelimiter.FormattingEnabled = true;
            this.cmbDelimiter.Items.AddRange(new object[] {
            "ç",
            "#",
            "$",
            "&"});
            this.cmbDelimiter.Location = new System.Drawing.Point(104, 12);
            this.cmbDelimiter.Name = "cmbDelimiter";
            this.cmbDelimiter.Size = new System.Drawing.Size(121, 21);
            this.cmbDelimiter.TabIndex = 0;
            // 
            // lblDelimiter
            // 
            this.lblDelimiter.AutoSize = true;
            this.lblDelimiter.Location = new System.Drawing.Point(17, 15);
            this.lblDelimiter.Name = "lblDelimiter";
            this.lblDelimiter.Size = new System.Drawing.Size(77, 13);
            this.lblDelimiter.TabIndex = 0;
            this.lblDelimiter.Text = "Delimiter fields:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblLast);
            this.panel2.Controls.Add(this.lblPathIN);
            this.panel2.Controls.Add(this.btnCreateFile);
            this.panel2.Controls.Add(this.txtLastIdGenerated);
            this.panel2.Controls.Add(this.btnCreateFileFolder);
            this.panel2.Controls.Add(this.chkAppendToFile);
            this.panel2.Controls.Add(this.rdbPortugueseSaleName);
            this.panel2.Controls.Add(this.rdbEnglishSaleName);
            this.panel2.Controls.Add(this.richTextBoxSales);
            this.panel2.Controls.Add(this.lblWaiting);
            this.panel2.Controls.Add(this.textBoxSales);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.richTextBoxCustomers);
            this.panel2.Controls.Add(this.btnGenerateSalesMan);
            this.panel2.Controls.Add(this.btnGenerateCustomers);
            this.panel2.Controls.Add(this.btnGenerateSalesMov);
            this.panel2.Controls.Add(this.textBoxCustomers);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 660);
            this.panel2.TabIndex = 21;
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(12, 415);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(44, 13);
            this.lblLast.TabIndex = 24;
            this.lblLast.Text = "Last ID:";
            // 
            // txtLastIdGenerated
            // 
            this.txtLastIdGenerated.Location = new System.Drawing.Point(137, 412);
            this.txtLastIdGenerated.Name = "txtLastIdGenerated";
            this.txtLastIdGenerated.Size = new System.Drawing.Size(100, 20);
            this.txtLastIdGenerated.TabIndex = 24;
            this.txtLastIdGenerated.Text = "0";
            // 
            // chkAppendToFile
            // 
            this.chkAppendToFile.AutoSize = true;
            this.chkAppendToFile.Checked = true;
            this.chkAppendToFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAppendToFile.Location = new System.Drawing.Point(243, 415);
            this.chkAppendToFile.Name = "chkAppendToFile";
            this.chkAppendToFile.Size = new System.Drawing.Size(224, 17);
            this.chkAppendToFile.TabIndex = 27;
            this.chkAppendToFile.Text = "Append to file \'c:\\Temp\\ManyRecords.txt\'";
            this.chkAppendToFile.UseVisualStyleBackColor = true;
            // 
            // rdbPortugueseSaleName
            // 
            this.rdbPortugueseSaleName.AutoSize = true;
            this.rdbPortugueseSaleName.Location = new System.Drawing.Point(329, 71);
            this.rdbPortugueseSaleName.Name = "rdbPortugueseSaleName";
            this.rdbPortugueseSaleName.Size = new System.Drawing.Size(90, 17);
            this.rdbPortugueseSaleName.TabIndex = 26;
            this.rdbPortugueseSaleName.Text = "in Portuguese";
            this.rdbPortugueseSaleName.UseVisualStyleBackColor = true;
            // 
            // rdbEnglishSaleName
            // 
            this.rdbEnglishSaleName.AutoSize = true;
            this.rdbEnglishSaleName.Checked = true;
            this.rdbEnglishSaleName.Location = new System.Drawing.Point(244, 72);
            this.rdbEnglishSaleName.Name = "rdbEnglishSaleName";
            this.rdbEnglishSaleName.Size = new System.Drawing.Size(70, 17);
            this.rdbEnglishSaleName.TabIndex = 25;
            this.rdbEnglishSaleName.TabStop = true;
            this.rdbEnglishSaleName.Text = "in English";
            this.rdbEnglishSaleName.UseVisualStyleBackColor = true;
            // 
            // lblWaiting
            // 
            this.lblWaiting.AutoSize = true;
            this.lblWaiting.BackColor = System.Drawing.SystemColors.Control;
            this.lblWaiting.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaiting.ForeColor = System.Drawing.Color.Red;
            this.lblWaiting.Location = new System.Drawing.Point(243, 409);
            this.lblWaiting.Name = "lblWaiting";
            this.lblWaiting.Size = new System.Drawing.Size(0, 20);
            this.lblWaiting.TabIndex = 24;
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(13, 616);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(460, 23);
            this.btnClear.TabIndex = 22;
            this.btnClear.Text = "CLEAR ALL RECORDS";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.lblAllRecords);
            this.panel3.Controls.Add(this.btnShuffle);
            this.panel3.Location = new System.Drawing.Point(601, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(494, 660);
            this.panel3.TabIndex = 23;
            // 
            // DataGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 679);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBoxEntireFile);
            this.Controls.Add(this.textBoxSalesMan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxSalesMan);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "DataGenerator";
            this.Text = "SalesFPS - Data Generator to IMPORT - v1.01";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateSalesMan;
        private System.Windows.Forms.RichTextBox richTextBoxSalesMan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSalesMan;
        private System.Windows.Forms.TextBox textBoxCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxCustomers;
        private System.Windows.Forms.RichTextBox richTextBoxSales;
        private System.Windows.Forms.Button btnGenerateCustomers;
        private System.Windows.Forms.Button btnGenerateSalesMov;
        private System.Windows.Forms.RichTextBox richTextBoxEntireFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnCreateFileFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogIN;
        private System.Windows.Forms.Label lblPathIN;
        private System.Windows.Forms.Label lblAllRecords;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbDelimiter;
        private System.Windows.Forms.Label lblDelimiter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblWaiting;
        private System.Windows.Forms.RadioButton rdbPortugueseSaleName;
        private System.Windows.Forms.RadioButton rdbEnglishSaleName;
        private System.Windows.Forms.CheckBox chkAppendToFile;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.TextBox txtLastIdGenerated;
    }
}

