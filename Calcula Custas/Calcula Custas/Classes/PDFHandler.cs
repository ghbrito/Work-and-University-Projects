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
using Rectangle = iTextSharp.text.Rectangle;

namespace Calcula_Custas.Classes
{
    internal class PDFHandler
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
        public PDFHandler(DataTable tabela, DataTable emolDias, DataTable emolTotalPorDia, string nomeArquivo, string caminhoArquivo)
        {
            //This is the absolute path to the PDF that we will create
            outputFile = Path.Combine(caminhoArquivo, nomeArquivo);
            this.dt = tabela;
            this.dtEmolDias = emolDias;
            this.dtEmolTotalPorDia = emolTotalPorDia;
            this.fileName = nomeArquivo;
            this.outputFolderPath = caminhoArquivo;
        }

        public PDFHandler(DataTable tabela, int NumeroLivro, int FolhaInicial, string Anomes, string nomeArquivo, string caminhoArquivo)
        {
            outputFile = Path.Combine(caminhoArquivo, nomeArquivo);
            this.dt = tabela;
            this.numeroLivro = NumeroLivro;
            this.folhaInicial = FolhaInicial;
            this.anomes = Anomes;
        }

        public void cabecalho(Document document, int pageNumber)
        {
            //PdfPTable tbfooter = new PdfPTable(3);
            //tbfooter.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
            //tbfooter.DefaultCell.Border = 0;
            //tbfooter.AddCell(new Paragraph());
            //tbfooter.AddCell(new Paragraph());
            //var _cell2 = new PdfPCell(new Paragraph(new Chunk("This is my Footer...", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE))));
            //_cell2.HorizontalAlignment = Element.ALIGN_RIGHT;
            //_cell2.Border = 0;
            //tbfooter.AddCell(_cell2);
            //tbfooter.AddCell(new Paragraph());
            //tbfooter.AddCell(new Paragraph());
            //var _celly = new PdfPCell(new Paragraph(pageNumber));//For page no.
            //_celly.HorizontalAlignment = Element.ALIGN_RIGHT;
            //_celly.Border = 0;
            //tbfooter.AddCell(_celly);
            //float[] widths1 = new float[] { 20f, 20f, 60f };
            //tbfooter.SetWidths(widths1);
            //tbfooter.WriteSelectedRows(0, -1, document.LeftMargin, writer.PageSize.GetBottom(document.BottomMargin), writer.DirectContent);
        }

        public void writePDF()
        {
            //Create a standard .Net FileStream for the file, setting various flags
            using (FileStream fs = new FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                //Create a new PDF document setting the size to A4
                float leftMargin = 48f;
                float rightMargin = 0.5f;
                float topMargin = 86f;
                float bottomMargin = 50f;
                using (Document doc = new Document(new Rectangle(595, 842), leftMargin, rightMargin, topMargin, bottomMargin))
                {
                    //Bind the PDF document to the FileStream using an iTextSharp PdfWriter
                    using (PdfWriter writer = PdfWriter.GetInstance(doc, fs))
                    {
                        //Open the document for writing
                        doc.Open();

                        //doc.PageNumber = folhaInicial;
                        _events e = new _events();
                        e.livro = numeroLivro;
                        e.pag = folhaInicial;

                        writer.PageEvent = e;
                        //e.OnEndPage(writer, doc);
                        e.OnStartPage(writer, doc);


                        //string headerCellLeft = "Livro nº " + numeroLivro;
                        //string headerCellCenter = "Cartório do Registro Civil das Pessoas Naturais e de Notas de São Benedito - Santa Luzia/MG\nLivro Diário Auxiliar da Receita e da Despesa";
                        //string headerCellRight = "Página nº " + folhaInicial;

                        //var headerLeft = new PdfPCell(new Paragraph(new Chunk(headerCellLeft, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                        //var headerCenter = new PdfPCell(new Paragraph(new Chunk(headerCellCenter, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                        //var headerRight = new PdfPCell(new Paragraph(new Chunk(headerCellRight, FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                        //headerCenter.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                        //headerCenter.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                        //headerCenter.Border = 0;
                        //headerLeft.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                        ////headerLeft.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                        //headerLeft.Border = 0;
                        //headerRight.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                        ////headerRight.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;
                        //headerRight.Border = 0;


                        ////headerCenter.Width = 100;
                        ////headerCenter.Width = 200;
                        //PdfPTable header = new PdfPTable(3);
                        ////header.HorizontalAlignment = 0;
                        //header.LockedWidth = true;
                        //header.TotalWidth = 500f;
                        //header.DefaultCell.Border = 0;
                        ////MessageBox.Show(header.TotalWidth.ToString());
                        //float[] widths = new float[3];
                        //widths[0] = 50;
                        //widths[1] = 250;
                        //widths[2] = 50;
                        //header.SetWidths(widths);
                        ////header.DefaultCell.Width = 100f;
                        //header.AddCell(headerLeft);
                        //header.AddCell(headerCenter);
                        //header.AddCell(headerRight);

                        //PdfPTable header2 = new PdfPTable(6);
                        ////header.HorizontalAlignment = 0;
                        //header2.LockedWidth = true;
                        //header2.TotalWidth = 500f;
                        //header2.DefaultCell.Border = 0;
                        ////header2.SpacingBefore = leftMargin;

                        ////MessageBox.Show(header.TotalWidth.ToString());
                        float[] widths = new float[6];
                        widths[0] = 10.78f;
                        widths[1] = 5.22f;
                        widths[2] = 9.89f;
                        widths[3] = 30.11f;
                        widths[4] = 13.89f;
                        widths[5] = 13.89f;

                        float cellHeight = 10f;
                        float totalWidth = 500f;
                        int fontSize = 11;

                        //header2.SetWidths(widths);


                        //var p1 = new Paragraph(new Chunk("Data", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                        //p1.IndentationLeft = 0;
                        //var header2_1 = new PdfPCell(p1);
                        //header2_1.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                        ////header2_1.Border = 0;
                        //var header2_2 = new PdfPCell(new Paragraph(new Chunk("Qtd", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                        //header2_2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                        ////header2_2.Border = 0;
                        //var header2_3 = new PdfPCell(new Paragraph(new Chunk("Código", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                        //header2_3.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                        ////header2_3.Border = 0;
                        //var header2_4 = new PdfPCell(new Paragraph(new Chunk("Termo/Lv.Fl./Descrição", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                        //header2_4.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                        ////header2_4.Border = 0;
                        //var header2_5 = new PdfPCell(new Paragraph(new Chunk("Receita", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                        //header2_5.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                        ////header2_5.Border = 0;
                        //var header2_6 = new PdfPCell(new Paragraph(new Chunk("Despesa", FontFactory.GetFont("Arial", 8, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                        //header2_6.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                        ////header2_6.Border = 0;

                        ////header.DefaultCell.Width = 100f;
                        //header2.AddCell(header2_1);
                        //header2.AddCell(header2_2);
                        //header2.AddCell(header2_3);
                        //header2.AddCell(header2_4);
                        //header2.AddCell(header2_5);
                        //header2.AddCell(header2_6);

                        //Paragraph p = new Paragraph();
                        //p.IndentationLeft = leftMargin;
                        //outerTable.HorizontalAlignment = Element.ALIGN_LEFT;
                        //p.Add(header2);
                        //document.Add(p);



                        PdfPTable livro = new PdfPTable(6);
                        livro.SetWidths(widths);
                        livro.TotalWidth = totalWidth;
                        livro.LockedWidth = true;
                        //doc.
                        //livro.he
                        //livro.DefaultCell.Height = 15f;
                        //livro.DefaultCell.RightIndent = 0;

                        livro.HeaderRows = 0;
                        livro.SkipFirstHeader = true;
                        //livro.AddCell("");
                        //livro.AddCell("");
                        //livro.AddCell(header);
                        //livro.AddCell("");
                        //livro.AddCell("");
                        //livro.AddCell("");

                        //livro.AddCell("");
                        //livro.AddCell("");
                        //livro.AddCell(header2);
                        //livro.AddCell("");
                        //livro.AddCell("");
                        //livro.AddCell("");
                        //doc.Add(p);


                        doc.SetMargins(leftMargin, rightMargin, topMargin, bottomMargin);

                        //Document document = new Document(PageSize.A4, 36, 36, 36 + < height of table >, 36); // note height should be set here

                        //PdfWriter pw = PdfWriter.GetInstance(document, new FileStream("TableTest.pdf", FileMode.Create));

                        //document.Open();
                        //doc.Add(header);
                        //int pag = writer.PageNumber;


                        //head.
                        PdfPCell cell;
                        PdfPCell cell2;

                        //DateTime.TryParse(dt.Rows[0][0].ToString(), out DateTime dataAtual);

                        //int diaAnterior = dataAtual.Day - 1;
                        //int diaPosterior = dataAtual.Day + 1;

                        //int arquivamentos = 0;
                        int testeP = 0;
                        int resteL = 0;

                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            
                            //if (doc.PageNumber < 1)
                            //{
                            //    testeP = folhaInicial;
                            //}
                            //else
                            //{
                            //    testeP = doc.PageNumber + folhaInicial - 1;
                            //}
                            //MessageBox.Show("Pag = " + testeP + "\nlivro = " + e.livro);

                            if (i >= dt.Rows.Count - 4)
                            {

                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    string celula = dt.Rows[i][j].ToString();
                                    //MessageBox.Show("celulas finais: " + celula);
                                    //if (j == 0)
                                    //{
                                    //    if (DateTime.TryParse(celula, out DateTime celulaDT))
                                    //    {
                                    //        celula = celula.Remove(celula.IndexOf(" "));
                                    //    }
                                    //    //MessageBox.Show(celula+" index = "+ celula.IndexOf(" "));//= celula.Remove(celula.IndexOf(" "));
                                    //}

                                    cell = new PdfPCell(new Paragraph(new Chunk(celula, FontFactory.GetFont("Arial", fontSize, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                                    cell.Border = 0;
                                    if (j == 3)
                                    {
                                        if (i == dt.Rows.Count - 4)
                                        {
                                            cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                                        }
                                        else
                                        {
                                            cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                                        }
                                    }
                                    else
                                    {
                                        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                                    }
                                    //cell.RightIndent = 0;
                                    cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                                    //cell.Height = 15f;
                                    //cell = widths[j];
                                    //cell.FixedHeight = cellHeight;
                                    livro.AddCell(cell);

                                }
                            }
                            else
                            {
                                //doc.Add(new Phrase("TESTING\n"));
                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    //livro.AddCell(dt.Rows[i][j].ToString());
                                    string celula = dt.Rows[i][j].ToString();
                                    if (j == 0)
                                    {
                                        if (DateTime.TryParse(celula, out DateTime celulaDT))
                                        {
                                            if (celula.Contains(" "))
                                            {
                                                celula = celula.Remove(celula.IndexOf(" "));
                                            }
                                            //if (celulaDT.Day != dataAtual.Day)
                                            //{
                                            //    dataAtual = celulaDT;
                                            //    diaAnterior++;
                                            //    diaPosterior++;
                                            //    arquivamentos = 0;
                                            //}
                                        }
                                        //MessageBox.Show(celula+" index = "+ celula.IndexOf(" "));//= celula.Remove(celula.IndexOf(" "));
                                    }

                                    cell = new PdfPCell(new Paragraph(new Chunk(celula, FontFactory.GetFont("Arial", fontSize, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                                    cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_MIDDLE;

                                    if (j == 3)
                                    {
                                        //if (dt.Rows[i][j - 1].ToString() == "8101" && celula == "")
                                        //{

                                        //    celula = "Arquivamento";
                                        //    cell = new PdfPCell(new Paragraph(new Chunk(celula, FontFactory.GetFont("Calibri", fontSize, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                                        //}
                                        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                                    }
                                    else
                                    {
                                        cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                                    }



                                    if (j >= 4)
                                    {
                                        if (celula.Length < 1)
                                        {
                                            cell.FixedHeight = cellHeight;
                                            livro.AddCell(cell);

                                        }
                                        else
                                        {
                                            string valor = celula;
                                            for (int k = 0; k < (12 - celula.Length); k++)
                                            {
                                                valor = " " + valor;
                                            }
                                            valor = "R$" + valor;
                                            cell = new PdfPCell(new Paragraph(new Chunk(valor, FontFactory.GetFont("Arial", fontSize, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));


                                            //cell2 = new PdfPCell(new Paragraph(new Chunk("R$", FontFactory.GetFont("Arial", fontSize - 1, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                                            //cell2.RightIndent = 0;
                                            //cell2.VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                                            //cell2.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT;
                                            //cell2.Border = 0;

                                            //cell = new PdfPCell(new Paragraph(new Chunk(celula, FontFactory.GetFont("Arial", fontSize - 1, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK))));
                                            //cell.RightIndent = 0;
                                            //cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                                            //cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                                            //cell.Border = 0;
                                            //PdfPTable tableCells = new PdfPTable(2);


                                            ////cell.FixedHeight = cellHeight;
                                            ////cell2.FixedHeight = cellHeight;
                                            //widths = new float[2];
                                            //widths[0] = 20f;
                                            //widths[1] = 60f;
                                            //tableCells.SetWidths(widths);
                                            //tableCells.TotalWidth = 80f;
                                            //tableCells.LockedWidth = true;
                                            //tableCells.DefaultCell.Border = 0;
                                            //tableCells.AddCell(cell2);
                                            //tableCells.AddCell(cell);
                                            ////cell = new PdfPCell(tableCells);
                                            ////cell.RightIndent = 0;
                                            ////cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                                            ////cell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                                            //////cell.Border = 0;
                                            ////cell.FixedHeight = cellHeight;
                                            ////tableCells.TotalHeight = cellHeight;
                                            ////tableCells.FixedHeight = 15f;
                                            //livro.AddCell(tableCells);
                                            livro.AddCell(cell);
                                        }
                                    }
                                    else
                                    {
                                        cell.RightIndent = 0;
                                        cell.VerticalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                                        cell.FixedHeight = cellHeight;
                                        //cell = widths[j];
                                        livro.AddCell(cell);
                                    }

                                }

                            }                            
                        }
                        doc.Add(livro);

                        string anomes = dt.Rows[0][0].ToString();
                        string mes = anomes.Substring(4);
                        string ano = anomes.Substring(0, 4);

                        doc.Close();

                        //MessageBox.Show("Arquivo \"Relatório Contabilidade - Ano: " + ano + " - Mês: " + mes + "\" gerado com sucesso!");
                    }
                }
            }

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
                        PdfPTable t = new PdfPTable(6);
                        int[] widths = new int[2];
                        widths[0] = 50;
                        widths[1] = 30;
                        widths[2] = 40;
                        widths[3] = 40;
                        widths[4] = 40;
                        widths[5] = 40;
                        t.SetWidths(widths);
                        //Borders are drawn by the individual cells, not the table itself.
                        //Tell the default cell that we do not want a border drawn
                        //t.DefaultCell.Border = 1;
                        t.DefaultCell.Border = 0;

                        t.HeaderRows = 1;



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



                        t.AddCell("\n");
                        t.AddCell("\n");

                        //for (int i = 0; i < dtEmolDias.Rows.Count; i++)
                        //{
                        //    t.AddCell("Data: " + dtEmolDias.Rows[i][1]);
                        //    //t.AddCell("Data: " + emolTotalPorDia.Rows[i][0]);
                        //    t.AddCell("Código: " + dtEmolDias.Rows[i][0] + " -  " + dtEmolDias.Rows[i][2]);

                        //}




                        t.AddCell("\n");
                        t.AddCell("\n");

                        for (int i = 0; i < dtEmolTotalPorDia.Rows.Count; i++)
                        {


                            t.AddCell("Data: " + (dtEmolTotalPorDia.Rows[i][0].ToString().Remove(dtEmolTotalPorDia.Rows[i][0].ToString().IndexOf(" "))));
                            t.AddCell("Emolumentos: " + dtEmolTotalPorDia.Rows[i][1]);

                        }

                        t.AddCell("Total de Emolumentos: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.Converte(dt.Rows[0][2].ToString()));
                        t.AddCell("\n");
                        t.AddCell("\n");

                        t.AddCell("ISSQN Arrecadado dos usuários: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.Converte(dt.Rows[0][5].ToString()));
                        t.AddCell("\n");
                        t.AddCell("\n");

                        t.AddCell("Repasses RECOMPE");
                        t.AddCell("");
                        t.AddCell("Valor Bruto do repasse: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.Converte(dt.Rows[0][6].ToString()));
                        //float d = float.Parse(dt.Rows[0][6].ToString());
                        //NumberStyles styles = NumberStyles.Float;
                        //double d = Convert.ToDouble(dt.Rows[0][6].ToString(),CultureInfo.InvariantCulture);
                        //string s = String.Format("{0:#,#}", CultureInfo.InvariantCulture, d);
                        //MessageBox.Show("db parse : " + d + "\n string format: " + s);
                        t.AddCell("Desconto Taxa RECIVIL: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.Converte(dt.Rows[0][9].ToString()));

                        t.AddCell("Desconto IR: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.Converte(dt.Rows[0][8].ToString()));

                        t.AddCell("Valor Líquido depositado: ");
                        t.AddCell("R$ " + ConverteStringParaStringContabil.Converte(dt.Rows[0][7].ToString()));

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
