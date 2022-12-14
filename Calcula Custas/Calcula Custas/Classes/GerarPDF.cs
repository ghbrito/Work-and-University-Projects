using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Globalization;

namespace Calcula_Custas.Classes
{
    internal class GerarPDF
    {
        private string outputFile;
        private string fileName;
        private string outputFolderPath;
        private DataTable dt;
        private DataTable dtEmolDias;
        private DataTable dtEmolTotalPorDia;
        private int numeroLivro;
        private int folhaInicial;
        string anomes;
        public GerarPDF(DataTable tabela, DataTable emolDias, DataTable emolTotalPorDia, string nomeArquivo, string caminhoArquivo)
        {


            //This is the absolute path to the PDF that we will create
            outputFile = Path.Combine(caminhoArquivo, nomeArquivo);
            this.dt = tabela;
            this.dtEmolDias = emolDias;
            this.dtEmolTotalPorDia = emolTotalPorDia;
            this.fileName = nomeArquivo;
            this.outputFolderPath = caminhoArquivo;
        }

        public GerarPDF(DataTable tabela, int NumeroLivro, int FolhaInicial, string Anomes, string nomeArquivo, string caminhoArquivo)
        {
            this.dt = tabela;
            this.numeroLivro = NumeroLivro;
            this.folhaInicial = FolhaInicial;
            this.anomes = Anomes;
        }



        public void novoPDF()
        {
            //outputFilePath.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Sample.pdf");

            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Create a new PDF document setting the size to A4
                using (Document doc = new Document(PageSize.A4))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter w = PdfWriter.GetInstance(doc, fs))
                    {
                        //Open the document for writing
                        doc.Open();

                        //PdfPTable pdfPTable = new PdfPTable()
                        //Create a table with two columns
                        PdfPTable t = new PdfPTable(2);
                        //int[] widths = new int[2];
                        //widths[0] = 50;
                        //widths[1] = 30;
                        //widths[2] = 40;
                        //widths[3] = 40;
                        //widths[4] = 40;
                        //widths[5] = 40;
                        //t.SetWidths(widths);
                        //Borders are drawn by the individual cells, not the table itself.
                        //Tell the default cell that we do not want a border drawn
                        //t.DefaultCell.Border = 1;
                        t.DefaultCell.Border = 0;

                        //t.HeaderRows = 1;


                        
                            //"Livro " + numeroLivro + " Folha: " + folhaInicial;

                        //Add four cells. Cells are added starting at the top left of the table working left to right first, then down
                        //for (int i = 0; i < 7; i++)
                        //{
                        //    t.AddCell();
                        //}

                        string anomes = dt.Rows[0][0].ToString();
                        string mes = anomes.Substring(4);
                        string ano = anomes.Substring(0, 4);

                        t.AddCell("Relatório Contabilidade - Ano: " + ano + " - Mês: " + mes);
                        t.AddCell("");
                        t.AddCell("\n");
                        t.AddCell("\n");



                        //t.AddCell("\n");
                        //t.AddCell("\n");

                        //for (int i = 0; i < dtEmolDias.Rows.Count; i++)
                        //{
                        //    t.AddCell("Data: " + dtEmolDias.Rows[i][1]);
                        //    //t.AddCell("Data: " + emolTotalPorDia.Rows[i][0]);
                        //    t.AddCell("Código: " + dtEmolDias.Rows[i][0] + " -  " + dtEmolDias.Rows[i][2]);

                        //}




                        //t.AddCell("\n");
                        //t.AddCell("\n");

                        for (int i = 0; i < dtEmolTotalPorDia.Rows.Count; i++)
                        {
                            folhaInicial = folhaInicial + doc.PageNumber;

                            //MessageBox.Show(dtEmolTotalPorDia.Rows[i][0].ToString().Remove(dtEmolTotalPorDia.Rows[i][0].ToString().IndexOf(" "))+" - "+ dtEmolTotalPorDia.Rows[i][0].ToString().Remove(dtEmolTotalPorDia.Rows[i][0].ToString().IndexOf(" ")));
                            t.AddCell("Data: " + (dtEmolTotalPorDia.Rows[i][0].ToString()));//.Remove(dtEmolTotalPorDia.Rows[i][0].ToString().IndexOf(" "))));
                            t.AddCell("Emolumentos: " + dtEmolTotalPorDia.Rows[i][1]);

                        }

                        t.AddCell("Total de Emolumentos: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.ConverteDouble(dt.Rows[0][2].ToString()));
                        t.AddCell("\n");
                        t.AddCell("\n");

                        t.AddCell("ISSQN Arrecadado dos usuários: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.ConverteDouble(dt.Rows[0][5].ToString()));
                        t.AddCell("\n");
                        t.AddCell("\n");

                        t.AddCell("Repasses RECOMPE");
                        t.AddCell("");
                        t.AddCell("Valor Bruto do repasse: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.ConverteDouble(dt.Rows[0][6].ToString()));
                        //float d = float.Parse(dt.Rows[0][6].ToString());
                        //NumberStyles styles = NumberStyles.Float;
                        //double d = Convert.ToDouble(dt.Rows[0][6].ToString(),CultureInfo.InvariantCulture);
                        //string s = String.Format("{0:#,#}", CultureInfo.InvariantCulture, d);
                        //MessageBox.Show("db parse : " + d + "\n string format: " + s);
                        t.AddCell("Desconto Taxa RECIVIL: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.ConverteDouble(dt.Rows[0][9].ToString()));

                        t.AddCell("Desconto IR: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.ConverteDouble(dt.Rows[0][8].ToString()));

                        t.AddCell("Valor Líquido depositado: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.ConverteDouble(dt.Rows[0][7].ToString()));

                        //Add the table to our document
                        doc.Add(t);

                        //Close our document
                        doc.Close();
                        MessageBox.Show("Arquivo \"Relatório Contabilidade - Ano: " + ano + " - Mês: " + mes + "\" gerado com sucesso!");
                    }
                }
            }
        }
    }


}

