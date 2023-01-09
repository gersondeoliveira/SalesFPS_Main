using FileReaderWriterSales.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace FileReaderWriterSales.ImportExportData
{
       
    public class MainTasks
    {

        #region Methods
        public void ListFilesDirectory(ListBox listBoxName, string folderName)
        {

            if (!string.IsNullOrEmpty(folderName))
            {
                foreach (var item in Directory.GetFiles(folderName))
                {
                    listBoxName.Items.Add(item);
                }
            }

        }

        public void FileDelete(string fileName)
        {

            File.Delete(@fileName);

        }

        public void StartImport(ListBox listBoxIN, string folderNameIN,  string fileLogError)
        {

            // Master array with data from SalesMan, customers and sales movement

            // Array master com dados dos Vendedores, clientes e movimentação de vendas
            string[,] salesManRecords;
            string[,] customersRecords;
            string[,] salesRecords;

            string nameFileAndPath = string.Empty;
            string[] linesOfFileContent;

            int totalRecords = 0;

            try
            {
                for (int i = 0; i < listBoxIN.Items.Count; i++)
                {
                    nameFileAndPath = listBoxIN.Items[i].ToString();
                    linesOfFileContent = System.IO.File.ReadAllLines(nameFileAndPath);
                    totalRecords = 0;

                    //
                    //Check here if the file is in the expected format, that is, text within the required layout.
                    //Being text, validate the received layout format in three steps.
                    //The process will be aborted with the absence of any of the types: 001, 002 or 003 and the file will be REJECTED
                    //ToDo: before calling the main method, make sure it is standard text.
                    //

                    //
                    // Verificar aqui se o arquivo está no formato esperado, ou seja, texto dentro do layout exigido
                    // Sendo texto, validar o formato do layout recebido em três etapas
                    // O processo será abortado com a ausência de qqr um dos tipos: 001, 002 ou 003
                    // e o arquivo será REJEITADO
                    // Todo: antes de chamar o método principal, certificar-se q o mesmo é padrão texto
                    //
                    var allData = GetAllInformationsFile(linesOfFileContent, nameFileAndPath, fileLogError);


                    if (allData == null)
                    {
                        System.IO.File.Move(nameFileAndPath, nameFileAndPath.Replace("\\in\\", "\\out\\_REJECTED__"));
                        continue;
                    }
                    else
                    {
                        System.IO.File.Move(nameFileAndPath, nameFileAndPath.Replace("\\in\\", "\\out\\_IMPORTED__"));
                        salesManRecords = allData.Item1;
                        customersRecords = allData.Item2;
                        salesRecords = allData.Item3;
                    }

                    totalRecords += salesManRecords.Length/3 + customersRecords.Length/3 + salesRecords.Length/3;


                    //
                    // Count of SELLERS & CUSTOMERS of the successfully processed file
                    // As a rule, I'm counting only the different CPFs and CNPJs
                    //

                    //
                    // Contagem dos VENDEDORES & CLIENTES do arquivo processado com sucesso
                    // Por via de regra estou contando apenas os CPFs e CNPJs distintos
                    //

                    string[] uniqueSalesMan = new string[salesManRecords.Length / 3];
                    for (int j = 0; j < uniqueSalesMan.Length; j++)
                    {
                        uniqueSalesMan[j] = salesManRecords[j, 1];
                    }

                    string[] uniqueCustomers = new string[customersRecords.Length / 3];
                    for (int j = 0; j < uniqueCustomers.Length; j++)
                    {
                        uniqueCustomers[j] = customersRecords[j, 1];
                    }

                    var uniqueSalesManToReport = uniqueSalesMan.Distinct().ToArray();
                    var uniqueCustomersToReport = uniqueCustomers.Distinct().ToArray();

                    //
                    // Here the manipulation of the SALES MOVEMENT arrays to finally
                    // produce the FINAL REPORT requested in the briefing.
                    // To diversify my code, I cast the arrays to ILIST so we could use a bit of LINQ.
                    // In practice I would use ONE or OTHER and not hybridism.
                    //

                    //
                    // Aqui a manipulação dos arrays de MOVIMENTO DE VENDAS para produzirmos,
                    // finalmente, o REPORT FINAL solicitado no briefing.
                    // Para diversificar o meu código, fiz o cast dos arrays para ILIST
                    // Para podermos usar um pouco de LINQ
                    // Na prática eu usaria UM ou OUTRO e não hibridismo.
                    //

                    IList<SalesMovimentation> salesMovimentation = new List<SalesMovimentation>();

                    for (int j = 0; j < salesRecords.Length / 3; j++)
                    {
                        salesMovimentation.Add(new SalesMovimentation
                        {
                            SaleId = int.Parse(salesRecords[j, 0]),
                            AmountSale = Decimal.Parse(salesRecords[j, 1]),
                            SalesManName = salesRecords[j, 2]
                        });
                    }

                    var bestSale = salesMovimentation.Max(x => x.AmountSale);
                    var bestSaleId = salesMovimentation.First(x => x.AmountSale == bestSale);

                    var lessSale = salesMovimentation.Min(x => x.AmountSale);
                    var lessSaleId = salesMovimentation.First(x => x.AmountSale == lessSale);

                    //
                    // ToDo: improve briefing and "select".use group By by SELLER
                    // Here it would fit to DEFINE the 'worst seller'.
                    // At first, would it be the sum of sales of a GROUP BY per seller?
                    // Would his MIN bring the "worst seller in the file" ?
                    // I think so, but instead, I used the same reasoning as
                    // the BEST SALE here, without using a grouping function.
                    //

                    //
                    // Todo: questionar briefing e melhorar o select. usar group By por VENDEDOR
                    //
                    // Aqui caberia DEFINIR o 'pior vendedor'.
                    // A princípio seria o somatório de vendas de um GROUP BY por vendedor?
                    // O MIN dele traria o "pior vendedor do arquivo"? Eu acho que sim mas
                    // ao invés disso, usei aqui usei o mesmo raciocínio
                    // da MELHOR VENDA sem uso de função de agrupamento.
                    //

                    var worseSalesMan = salesMovimentation.Min(x => x.AmountSale);
                    var worseSalesManName = salesMovimentation.First(x => x.AmountSale == worseSalesMan);

                    var bestSalesMan = salesMovimentation.Max(x => x.AmountSale);
                    var bestSalesManName = salesMovimentation.First(x => x.AmountSale == bestSalesMan);

                    GenerateReport(nameFileAndPath, uniqueCustomersToReport.Length.ToString(), uniqueSalesManToReport.Length.ToString(), 
                                   bestSaleId.SaleId.ToString(), lessSaleId.SaleId.ToString(),
                                   worseSalesManName.SalesManName.ToString(), worseSalesManName.SaleId.ToString(), 
                                   totalRecords.ToString(), 
                                   bestSalesManName.SalesManName.ToString(), bestSalesManName.SaleId.ToString());


                }

                return;

            }
            catch (Exception ex)
            {
                LogErrors(ex.Message, nameFileAndPath, fileLogError, "0");
                return;
            }

        }

        public static Tuple<string[,], string[,], string[,]> GetAllInformationsFile(string[] linesOfFileContent, string nameFileAndPath, string fileLogError)
        {
            //
            // Initializes the array with the total number of lines in the file and 
            // only adds records with identifiers 001, 002 and 003.
            // After that, all elements of the array that will not be used are removed.
            // (+performance with a FOR only)
            //
            // Inicializa array com a quantidade total de linhas do arquivo e vai adicionando apenas
            // registros com identificadores 001, 002 e 003
            // Após isso remove-se todos os elementos do array que não serão utilizados.
            // ( + performance com um FOR apenas )
            //



            try
            {
                string[,] salesManRecordsPass = new string[linesOfFileContent.Length, 3];
                string[,] customersRecordsPass = new string[linesOfFileContent.Length, 3];
                string[,] salesRecordsPass = new string[linesOfFileContent.Length, 3];

                string[] splitSalesEntireLine;
                string[] splitSaleAmount;
                string[] splitSaleAmountItem;

                int countSalesMan = 0;
                int countCustomers = 0;
                int countSales = 0;

                int qtdSaleItem;
                decimal priceSaleItem;

                //
                // Checks the number of salesperson records and populates the master array of Salespeople.
                //
                // If there are more than 3 columns('ç' or '#'...), I will abort with
                // error "Record in format NOT expected.
                // There are possibilities for the seller's name field to have 'ç'. Why not?
                // In this case the data must be TREATMENT and not rejected but
                // for this POC I will not treat it.

                //
                // Verifica a quantidade de registros de vendedores e popula array master de Vendedores.
                //
                // Caso haja mais de 3 colunas('ç' ou '#'...), abortarei com erro
                // "Registro em formato NÃO esperado.
                // Há possibilidades do campo nome do vendedor possuir 'ç'. Por que não?
                // Nesse caso o dado deve ser TRATADO e não rejeitado mas para esta POC(Proof of Concept)
                // eu não tratarei.
                //

                for (int i = 0; i < linesOfFileContent.Length; i++)
                {
                    //
                    // ToDo: Implement file checking to make sure it is text BEFORE
                    // get into that routine.
                    // Thus, we will be able to create a specialized message about which
                    // wrong content it has.
                    //
                    // Todo: Implementar verificação do arquivo para certificar-se que ele é texto ANTES de
                    // chegar nessa rotina.
                    // Assim sendo conseguiremos criar uma mensagem especializada sobre qual o
                    // conteúdo errado que ele possui.
                    //

                    splitSalesEntireLine = linesOfFileContent[i].Split('ç');

                    //
                    // Some semantic errors handled here but
                    // we need a lot more than these two errors handled.
                    //
                    // Alguns erros semânticos tratados aqui mas 
                    // precisamos bem mais do que esses dois erros tratados
                    // 

                    if (splitSalesEntireLine.Length > 4 || splitSalesEntireLine[0].Length > 3)
                    {
                        LogErrors("Unrecognized line!", nameFileAndPath, fileLogError, (i + 1).ToString());
                        return null;
                    }

                    if (linesOfFileContent[i].Length > 3)
                    {
                        if (linesOfFileContent[i].Substring(0, 3) == "001")
                        {
                            // 001çCPFçNameçSalary
                            // CPF Name Salary

                            //
                            // Processing the line containing SELLERS information
                            //
                            // The seller's data has the identifier 001 and follows the above format.
                            //

                            //
                            // Processamento da linha que contém informações de VENDEDORES
                            //
                            // Os dados do vendedor possuem o identificador 001 e
                            // seguem o formato acima.
                            //

                            salesManRecordsPass[countSalesMan, 0] = splitSalesEntireLine[1];
                            salesManRecordsPass[countSalesMan, 1] = splitSalesEntireLine[2];
                            salesManRecordsPass[countSalesMan, 2] = splitSalesEntireLine[3];
                            countSalesMan++;

                        }
                        else if (linesOfFileContent[i].Substring(0, 3) == "002")
                        {
                            // 002çCNPJçNameçBusiness Area
                            // CNPJ Name Business Area

                            //
                            // Processing of the line containing CUSTOMERS information
                            //
                            // customers's data
                            // Customer data has identifier 002 and follows and the above format.
                            //

                            //
                            // Processamento da linha que contém informações de CLIENTES
                            //
                            // Dados do cliente
                            // Os dados do cliente possuem o identificador 002 e seguem o formato acima.
                            //

                            customersRecordsPass[countCustomers, 0] = splitSalesEntireLine[1];
                            customersRecordsPass[countCustomers, 1] = splitSalesEntireLine[2];
                            customersRecordsPass[countCustomers, 2] = splitSalesEntireLine[3];
                            countCustomers++;

                        }
                        else if (linesOfFileContent[i].Substring(0, 3) == "003")
                        {

                            // 003çSale IDç[Item ID - Item Quantity - Item Price]çSalesman name
                            // Sale ID [Item ID - Item Quantity - Item Price] Salesman name
                            // ç08ç[1-34-10,2-33-1.50,3-40-0.10]çPaulo

                            //
                            // Processing of the line containing SALES MOVIMENTATION information
                            //
                            // Sales data
                            // Sales data have identifier 003 and the above format.

                            //
                            // Processamento da linha que contém informações de movimentação de VENDAS
                            //
                            // Dados de venda
                            // Os dados de venda possuem o identificador 003 e seguem o formato acima.
                            //

                            // Dados que resultam o TOTAL DA VENDA
                            //
                            // Decompõe as informações de venda e calcula seu TOTAL
                            //
                            splitSaleAmount = splitSalesEntireLine[2].Split(',');
                            splitSaleAmount[0] = splitSaleAmount[0].Remove(0, 1);
                            splitSaleAmount[splitSaleAmount.Length - 1] = splitSaleAmount[splitSaleAmount.Length - 1].Remove(splitSaleAmount[splitSaleAmount.Length - 1].LastIndexOf("]"), 1);

                            decimal totalSaleAmount = 0;

                            //
                            // "FOR" that decomposes the sold items
                            // Apparently the layout is filled with THREE items,
                            // what if the 3 don't come?
                            // The code snippet below ensures that the application will work
                            // with at least ONE item, not THREE fixed, and NO item limit.
                            //
                            // FOR que decompõe os itens vendidos
                            // Aparentemente o layout está chumbado(FIXO) com TRÊS itens,
                            // e se não vierem os 3?
                            // O trecho de código abaixo garante que a aplicação funcionará
                            // com no mínimo UM item, não TRÊS fixos, e SEM limite de itens.
                            //

                            for (int j = 0; j < splitSaleAmount.Length; j++)
                            {
                                splitSaleAmountItem = splitSaleAmount[j].Split('-');

                                //
                                // Here A very simple cast / conversion control of
                                // the QUANTITY and PRICE fields.
                                // Remembering that Quantity == 0 ABORTs the conversion
                                // ToDo: improve conversions

                                //
                                // Aqui Um controle muito simples de cast/conversão dos
                                // campos QUANTIDADE e PREÇO.
                                // Relembrando que Quantidade == 0 ABORTA a conversão
                                // Todo: melhorar as conversões
                                //

                                qtdSaleItem = int.TryParse(splitSaleAmountItem[1], out qtdSaleItem) ? qtdSaleItem : 0;
                                if (!decimal.TryParse(splitSaleAmountItem[2], out priceSaleItem) || qtdSaleItem == 0)
                                {
                                    LogErrors("Erro de CONVERSÃO! A string não está no formato esperado.", nameFileAndPath, fileLogError, i + 1.ToString());
                                    return null;
                                }

                                totalSaleAmount += qtdSaleItem * priceSaleItem;

                            }

                            salesRecordsPass[countSales, 0] = splitSalesEntireLine[1];
                            salesRecordsPass[countSales, 1] = totalSaleAmount.ToString();
                            salesRecordsPass[countSales, 2] = splitSalesEntireLine[3];
                            totalSaleAmount = 0;
                            countSales++;

                        }
                        else
                        {
                            LogErrors("Valid codes = Only 001, 002 or 003.", nameFileAndPath, fileLogError, (i + 1).ToString());
                            return null;
                        }

                    }
                    else if (linesOfFileContent.Length-1 == i)
                    {
                        continue;
                    }
                    else
                    {
                        LogErrors("Invalid size line.", nameFileAndPath, fileLogError, (i + 1).ToString());
                        return null;
                    }
                        

                }

                if (countSalesMan == 0 || countCustomers == 0 || countSales == 0)
                {
                    LogErrors("Identifier record 001, 002 or 003 NOT FOUND!", nameFileAndPath, fileLogError, "0");
                    return null;
                }


                // SELLERS
                // Remove blank elements from the MASTER array.
                // Multidimensional arrays do not
                // inherit resize / truncate methods, etc...
                // The "FOR" below simplifies the remove operation
                //
                // VENDEDORES
                // Remove elementos em branco do array MASTER.
                // Arrays multidimensionais não herdam métodos de resize / truncate, etc...
                // O FOR abaixo simplifica a operação de remoção
                // 

                string[,] salesManRecords = new string[countSalesMan, 3];

                for (int j = 0; j < countSalesMan; j++)
                {
                    salesManRecords[j, 0] = salesManRecordsPass[j, 0];
                    salesManRecords[j, 1] = salesManRecordsPass[j, 1];
                    salesManRecords[j, 2] = salesManRecordsPass[j, 2];
                }

                //
                // CUSTOMERS: same reasoning as above.
                //
                // CLIENTES: mesmo raciocínio acima.
                //

                string[,] customersRecords = new string[countCustomers, 3];

                for (int j = 0; j < countCustomers; j++)
                {
                    customersRecords[j, 0] = customersRecordsPass[j, 0];
                    customersRecords[j, 1] = customersRecordsPass[j, 1];
                    customersRecords[j, 2] = customersRecordsPass[j, 2];
                }

                //
                // SALES MOVIMENTATION: same reasoning as above.
                //
                // VENDAS: mesmo raciocínio acima.
                //

                string[,] salesRecords = new string[countSales, 3];

                for (int j = 0; j < countSales; j++)
                {
                    salesRecords[j, 0] = salesRecordsPass[j, 0];
                    salesRecords[j, 1] = salesRecordsPass[j, 1];
                    salesRecords[j, 2] = salesRecordsPass[j, 2];
                }

                return Tuple.Create(salesManRecords, customersRecords, salesRecords);
            }
            catch (Exception ex)
            {
                LogErrors(ex.Message, nameFileAndPath, fileLogError, "0");
                return null;

            }

        }

        public static void LogErrors(string message, string nameFileAndPath, string fileLogError, string lineError)
        {

            string filePath = @fileLogError + "\\LogFileError.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine();
                writer.WriteLine("File........... : " + nameFileAndPath);
                writer.WriteLine("Line Error..... : " + lineError);
                writer.WriteLine("Date........... : " + DateTime.Now);
                writer.WriteLine("Message........ : " + message);
                writer.WriteLine("Status......... : " + "File Rejected");
                writer.WriteLine();
            }
        }

        public static void GenerateReport(string nameFileAndPath, string qtCustomers, string qtSalesMan, 
                                          string idSaleMoreExpensive, string idSaleLessExpensive,
                                          string worseSalesMan, string worseSalesManSaleId, 
                                          string totalRecords,
                                          string bestSalesMan, string bestSalesManSaleId)
        {

            try
            {
                StringBuilder reportReturnSB = new StringBuilder();
                reportReturnSB.AppendLine("---------------------------------------------------------------------------------------------------------------------");
                reportReturnSB.AppendLine("  Sales Movimentation Date: " + DateTime.Now);
                reportReturnSB.AppendLine("---------------------------------------------------------------------------------------------------------------------");
                reportReturnSB.AppendLine();
                reportReturnSB.AppendLine("  File.............. : " + nameFileAndPath);
                reportReturnSB.AppendLine("  Number of Records. : " + totalRecords);
                reportReturnSB.AppendLine();
                reportReturnSB.AppendLine("     Qt Customers....................: " + qtCustomers);
                reportReturnSB.AppendLine("     Qt Sales Man....................: " + qtSalesMan);
                reportReturnSB.AppendLine();
                reportReturnSB.AppendLine("     Worse Sale(Sales Name + SALE ID): " + worseSalesMan + " - " + worseSalesManSaleId);
                reportReturnSB.AppendLine("     Best  Sale(Sales Name + SALE ID): " + bestSalesMan + " - " + bestSalesManSaleId);
                reportReturnSB.AppendLine();
                reportReturnSB.AppendLine("---------------------------------------------------------------------------------------------------------------------");
                string filePath = nameFileAndPath.Replace("\\in\\", "\\out\\REPORT_");
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.Write(reportReturnSB.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GenerateReport method: "+ex.Message);
            }
        }




        #endregion

    }
}


