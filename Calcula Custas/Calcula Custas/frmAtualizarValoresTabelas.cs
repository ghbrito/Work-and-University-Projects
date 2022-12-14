using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Data.OleDb;
using ClosedXML.Excel;
using Calcula_Custas.Classes;

namespace Calcula_Custas
{
    public partial class frmAtualizarValoresTabelas : UserControl
    {
        public frmAtualizarValoresTabelas()
        {
            InitializeComponent();
        }

        private void readPDF()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PDF Files|*.pdf";
            dlg.FilterIndex = 1;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string fileName;
                fileName = dlg.FileName;
                PdfReader reader = new PdfReader(fileName);
                int intPageNum = reader.NumberOfPages;
                string[] words;
                string line;
                string text;
                DataTable dt = new DataTable();

                for (int i = 1; i <= intPageNum; i++)
                {
                    text = PdfTextExtractor.GetTextFromPage(reader, i, new LocationTextExtractionStrategy());
                    DataRow row = dt.NewRow();
                    dt.Rows.Add(row);
                    words = text.Split('\n');
                    for (int j = 0, len = words.Length; j < len; j++)
                    {
                        if ((j + 1) > dt.Columns.Count)
                        {
                            dt.Columns.Add(j.ToString(), typeof(string));
                        }
                        line = Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(words[j]));
                        dt.Rows.Add(line);
                    }
                }
            }
        }

        private void readExcel()
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Excel Files|*.xls;*xlsx";
                dlg.FilterIndex = 1;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var acessoDB = new DBAccess(3);
                    string command;
                    string fileName;
                    fileName = dlg.FileName;
                    var xls = new XLWorkbook(fileName);
                    var planilha = xls.Worksheets.First(w => w.Name == "Sheet1");
                    var totalLinhas = planilha.Rows().Count();

                    for (int l = 2; l <= totalLinhas; l++)
                    {
                        string codigoAto = planilha.Cell($"A{l}").Value.ToString();
                        string emolumBruto = planilha.Cell($"B{l}").Value.ToString();
                        string recompe = planilha.Cell($"C{l}").Value.ToString();
                        string issqn = planilha.Cell($"D{l}").Value.ToString();
                        string emolumLiq = planilha.Cell($"E{l}").Value.ToString();
                        string tfj = planilha.Cell($"F{l}").Value.ToString();
                        string valorFinal = planilha.Cell($"G{l}").Value.ToString();
                        string anoref = planilha.Cell($"H{l}").Value.ToString();
                        string tributacao = planilha.Cell($"I{l}").Value.ToString();

                        command = "INSERT INTO EMOLUMENTOSATOS (CODATO, ANOREF, TRIBUTACAO, EMOLUMBRUTO, RECOMPE, ISSQN, EMOLUMLIQ, TFJ, VALORFINAL) VALUES ('" + codigoAto + "', '" + anoref + "', '" + tributacao + "', '" + emolumBruto + "', '" + recompe + "', '" + issqn + "', '" + emolumLiq + "', '" + tfj + "', '" + valorFinal + "');";
                        acessoDB.SQLQuery(command);


                    }
                    acessoDB.CloseConn();
                    MessageBox.Show("Atualização de valores de emolumentos executada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.StackTrace);
            }
        }

        private void btnAtualizarValoresAbrirPDF_Click(object sender, EventArgs e)
        {
            readExcel();
        }


    }

}

