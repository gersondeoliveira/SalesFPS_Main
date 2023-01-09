using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DataGeneratorToImport
{
    public partial class DataGenerator : Form
    {

        #region Properties

        private List<string> nameSalesManToSales;
        private string folderNameIN = string.Empty;
        private int recordsFile = 0;


        #endregion

        #region Methods
        public DataGenerator()
        {
            InitializeComponent();
            this.cmbDelimiter.SelectedIndex = 0;
            this.btnShuffle.Enabled = false;
        }

        public void GenerateSalesMan(int length, string strDelimiter, string languageSaleName)
        {
            try
            {

                // 001ç1234567891234çPedroç50000

                nameSalesManToSales = new List<string>();

                string[] linesOfFileContent;
                linesOfFileContent = System.IO.File.ReadAllLines(@languageSaleName+".txt");
                Random rnd = new Random();

                string nameSalesMan;
                string entireLine;

                if (length > 1000)
                {
                    textBoxSalesMan.Text = "1000";
                    length = 999;
                }

                for (int i = 0; i < length; i++)
                {
                    nameSalesMan = linesOfFileContent[i];
                    entireLine = "001" + strDelimiter + GenerateRandomString(11) + strDelimiter + nameSalesMan + strDelimiter + rnd.Next(0, 100) + "00" + Environment.NewLine;
                    richTextBoxSalesMan.AppendText(entireLine);
                    nameSalesManToSales.Add(nameSalesMan);
                }

                richTextBoxEntireFile.AppendText(richTextBoxSalesMan.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GenerateSalesMan method: " + ex.Message);
            }

        }

        public void GenerateCustomers(int length, string strDelimiter)
        {
            try
            {
                // 002ç2345675434544345çJose da SilvaçRural
                if (length > 1000)
                {
                    textBoxCustomers.Text = "1000";
                    length = 999;
                }

                List<string> sectors = new List<string>();
                sectors.Add("Rural");
                sectors.Add("Energy");
                sectors.Add("Materials");
                sectors.Add("Industrials");
                sectors.Add("Consumer Discretionary");
                sectors.Add("Consumer Staples");
                sectors.Add("Health Care");
                sectors.Add("Financials");
                sectors.Add("Information Technology");
                sectors.Add("Telecommunication Services");
                sectors.Add("Utilities");
                sectors.Add("Real Estat");

                string[] linesOfFileContent;
                linesOfFileContent = System.IO.File.ReadAllLines(@"Customers.txt");

                Random rnd = new Random();
                int customerPointer;
                string nameCustomer;

                string entireLine;

                for (int i = 0; i < length; i++)
                {
                    customerPointer = rnd.Next(0, linesOfFileContent.Length - 1);
                    nameCustomer = linesOfFileContent[i];
                    entireLine = "002" + strDelimiter + GenerateRandomString(16) + strDelimiter + nameCustomer + strDelimiter + sectors[rnd.Next(0, sectors.Count())] + Environment.NewLine;
                    richTextBoxCustomers.AppendText(entireLine);
                }

                richTextBoxEntireFile.AppendText(richTextBoxCustomers.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GenerateCustomers method: " + ex.Message);
            }

        }

        public void GenerateSales(int length, string strDelimiter)
        {

            try
            {
                // 003ç08ç[1-34-10,2-33-1.50,3-40-0.10]çPaulo

                Random rnd = new Random();

                string entireLine;
                string allLines = String.Empty;
                int lastId = Convert.ToInt32(txtLastIdGenerated.Text);


                richTextBoxSales.Text = String.Empty;

                StringBuilder salesGeneratedSB = new StringBuilder();

                for (int i = 0; i < length; i++)
                {

                    // The SALES movement only accepts records with VENDORS present in the file.
                    // Even with the seller's name as the referential integrity key.
                    // The correct would be the NIC, very easy to implement.
                    //
                    // I set 8 random digits for the SALE ID so that TWO or more sequences are not repeated many times
                    // (I changed my mind, the SALE ID will be a unique sequential in all records type "003")

                    // ..........................

                    //
                    // A movimentação de VENDAS só aceita registros com VENDEDORES presentes no arquivo.
                    // Mesmo sendo o nome do vendedor como chave de integridade referencial.
                    // O correto seria o CPF, bem tranquilo de implementar.
                    //
                    // Setei 8 dígitos randômicos para SALE ID para que não se repitam muitas vezes DUAS ou mais sequências iguais
                    // ( mudei de idéia, o SALE ID será um sequencial único em todos registros tipo "003" )
                    //

                    entireLine = "003" + strDelimiter + (lastId + i + 1).ToString() + strDelimiter + "[1-" + rnd.Next(1, 100) + "-" + rnd.Next(1, 100) + "," +
                                                                      "2 - " + rnd.Next(1, 100) + " - " + rnd.Next(1, 100) + "," +
                                                                      "3 - " + rnd.Next(1, 100) + " - " + rnd.Next(1, 100) + "]" + strDelimiter +
                                                                      nameSalesManToSales[rnd.Next(0, nameSalesManToSales.Count() - 1)]; // + Environment.NewLine;
                    salesGeneratedSB.AppendLine(entireLine);

                }

                if (chkAppendToFile.Checked)
                {
                    System.IO.File.WriteAllText(@"C:\temp\ManyRecords.txt", salesGeneratedSB.ToString());
                    MessageBox.Show("Finished process.");
                }
                else
                {
                    richTextBoxSales.AppendText(salesGeneratedSB.ToString());
                    richTextBoxEntireFile.AppendText(richTextBoxSales.Text);
                }

                salesGeneratedSB.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GenerateSales method: " + ex.Message);
            }

        }


        private void CheckResultToImport()
        {
            if (richTextBoxSales.TextLength > 0 && richTextBoxCustomers.TextLength > 0 && richTextBoxSalesMan.TextLength > 0)
            {
                this.btnShuffle.Enabled = true;
                this.btnClear.Enabled = true;
                this.btnCreateFileFolder.Enabled = true;
            }
            else if (richTextBoxEntireFile.TextLength > 0)
            {
                this.btnClear.Enabled = true;
            }
            else
            {
                this.btnShuffle.Enabled = false;
                this.btnClear.Enabled = false;
                this.btnCreateFileFolder.Enabled = false;
            }

        }



        private void ClearForm()
        {
            this.richTextBoxEntireFile.Text = String.Empty;
            this.richTextBoxSalesMan.Text = String.Empty;
            this.richTextBoxCustomers.Text = String.Empty;
            this.richTextBoxSales.Text = String.Empty;
            this.btnClear.Enabled = false;
            this.btnCreateFileFolder.Enabled = false;
            this.btnCreateFile.Enabled = false;
            this.btnGenerateSalesMov.Enabled = false;
            this.lblAllRecords.Text = "...";
            this.lblPathIN.Text = "...";
        }

        #endregion

        #region Actions
        private void btnCreateFileFolder_Click(object sender, EventArgs e)
        {
            recordsFile = Convert.ToInt32(textBoxSalesMan.Text) + Convert.ToInt32(textBoxCustomers.Text) + Convert.ToInt32(textBoxSales.Text);
            this.lblAllRecords.Text = recordsFile.ToString();
            this.folderBrowserDialogIN.ShowDialog();
            folderNameIN = this.folderBrowserDialogIN.SelectedPath;
            this.lblPathIN.Text = folderNameIN;
            if (this.richTextBoxEntireFile.TextLength > 0 && !String.IsNullOrEmpty(this.folderBrowserDialogIN.SelectedPath))
            {
                this.btnCreateFile.Enabled = true;
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = @folderNameIN + "\\ToImport_" + recordsFile.ToString() + "_SalesMov_" + DateTime.Now.Ticks.ToString() + ".txt";
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(richTextBoxEntireFile.Text);
                }
                MessageBox.Show("Create file Success!");
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                ClearForm();
            }
        }


        private void btnGenerateSalesMan_Click(object sender, EventArgs e)
        {
            string language = String.Empty;

            if (rdbEnglishSaleName.Checked)
            {
                language = "SalesMan_English";
            }
            else
            {
                language = "SalesMan_Portuguese";
            }

            GenerateSalesMan(Convert.ToInt32(textBoxSalesMan.Text), cmbDelimiter.SelectedItem.ToString(), language );
            btnGenerateSalesMov.Enabled = true;
            CheckResultToImport();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnGenerateCustomers_Click(object sender, EventArgs e)
        {
            GenerateCustomers(Convert.ToInt32(textBoxCustomers.Text), cmbDelimiter.SelectedItem.ToString());
            CheckResultToImport();
        }

        private void btnGenerateSalesMov_Click(object sender, EventArgs e)
        {

            btnGenerateSalesMan.Enabled = false;
            btnGenerateCustomers.Enabled = false;

            lblWaiting.Text = "Processing...";
            lblWaiting.Refresh();

            btnGenerateSalesMov.Text = "Wait...";
            btnGenerateSalesMov.Enabled = false;
            btnGenerateSalesMov.Refresh();


            GenerateSales(Convert.ToInt32(textBoxSales.Text), cmbDelimiter.SelectedItem.ToString());
            CheckResultToImport();

            lblWaiting.Text = "";
            lblWaiting.Enabled = true;

            btnGenerateSalesMov.Text = "Generate";

            btnGenerateSalesMan.Enabled = true;
            btnGenerateCustomers.Enabled = true;
            btnGenerateSalesMov.Enabled = true;

        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            string[] lines = richTextBoxEntireFile.Lines;
            Shuffle(lines);
            richTextBoxEntireFile.Lines = lines;

        }



        #endregion

        #region Misc

        private static Random random = new Random();
        public static string GenerateRandomString(int length)
        {
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        void Shuffle<T>(IList<T> items)
        {

            var random = new Random();

            for (int i = items.Count; i > 1; i--)
            {

                int j = random.Next(i); 

                T tmp = items[j];
                items[j] = items[i - 1];
                items[i - 1] = tmp;
            }
        }


        #endregion

    }
}
