using Calcula_Custas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_Custas
{
    public partial class frmLerDespesasPDF : UserControl
    {
        private DataTable dtDespesa;
        public frmLerDespesasPDF()
        {
            InitializeComponent();
        }

        private void frmLerDespesasPDFBtnAbrir_Click(object sender, EventArgs e)
        {
            string nomeArquivo = "";
            string nomeDespesa = "";
            string dataDespesa = "";
            string[] valorDespesa;
            string[] valores = new string[4];
            string[] colunas = new string[4];



            var dlg = new OpenFileDialog();


            //DialogResult dr = dlg.ShowDialog();


            dlg.ValidateNames = false;
            dlg.CheckFileExists = false;
            dlg.CheckPathExists = true;
            dlg.Multiselect = true;
            string[] fileNames;


            // Always default to Folder Selection.
            //dlg.FileName = "Select folder.";

            //dlg.InputPath = @"c:\windows\system32";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(dlg.FileName);
                //MessageBox.Show(Path.GetDirectoryName(dlg.FileName));
                //DialogResult dr = dlg.ShowDialog();
                //if (dr == System.Windows.Forms.DialogResult.OK)
                fileNames = dlg.FileNames;
                DBAccess db3 = new DBAccess(3);

                foreach (var caminhoArquivo in fileNames)
                {
                    nomeArquivo = Path.GetFileName(caminhoArquivo);
                    LerPDF lerPDF = new LerPDF();

                    valorDespesa = new string[lerPDF.numberOfPages(caminhoArquivo)];

                    valorDespesa = lerPDF.pdfText(caminhoArquivo);

                    dataDespesa = nomeArquivo.Remove(nomeArquivo.IndexOf(" "));
                    nomeDespesa = nomeArquivo.Remove(nomeArquivo.IndexOf(".")).Substring(nomeArquivo.IndexOf(" "));
                    //Me0ssageBox.Show("Despesa: " +nomeDespesa+ "\nData: "+dataDespesa+"\nValor: " + valorDespesa);
                    colunas[0] = "DATAEAUTENTICACAO";
                    colunas[1] = "DATA";
                    colunas[2] = "NOME";
                    colunas[3] = "VALOR";

                    for (int i = 0; i < valorDespesa.Length; i++)
                    {

                        valores[1] = dataDespesa;
                        valores[2] = nomeDespesa;
                        valores[3] = valorDespesa[i];

                        if (valorDespesa.Length > 1)
                        {
                            valores[2] = valores[2] + "_p" + (i + 1) + "_";
                        }
                        valores[0] = valores[1] + valores[2] + valores[3];

                        //MessageBox.Show(valores[0]);
                        db3.SQLReplaceGenerico(valores[0], "DESPESAS", colunas, valores);
                    }

                }
                db3.CloseConn();
                MessageBox.Show("Despesas incluídas com sucesso no nanco de dados!");
            }
        }

        private void frmLerDespesasPDFRbtSim_CheckedChanged(object sender, EventArgs e)
        {
            frmLerDespesasPDFGbxInclusao.Visible = true;
            dtDespesa = new DataTable();
            dtDespesa.Columns.Add("Data");
            dtDespesa.Columns.Add("Descrição");
            dtDespesa.Columns.Add("Valor despesa");

            dtDespesa.Rows.Add();

            frmLerDespesasPDFDtg.DataSource = dtDespesa.DefaultView;
            frmLerDespesasPDFDtg.Columns[0].Width = 100;
            frmLerDespesasPDFDtg.Columns[1].Width = 400;
            frmLerDespesasPDFDtg.Columns[2].Width = 100;
            //frmLerDespesasPDFDtg.Rows.Remove(frmLerDespesasPDFDtg.Rows[frmLerDespesasPDFDtg.Rows.Count-1]);


        }

        private void frmLerDespesasPDFRbtNao_CheckedChanged(object sender, EventArgs e)
        {
            frmLerDespesasPDFGbxInclusao.Visible = false;
        }

        private void frmLerDespesasPDFDtg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            frmLerDespesasPDFDtg.CurrentCell.Value = frmLerDespesasPDFDtg.CurrentCell.EditedFormattedValue;

        }

        private void frmLerDespesasPDFBtnInclusao_Click(object sender, EventArgs e)
        {
            var acessoDB3 = new DBAccess(3);

            string data = frmLerDespesasPDFDtg.Rows[0].Cells[0].Value.ToString();
            string descricao = frmLerDespesasPDFDtg.Rows[0].Cells[1].Value.ToString();
            string valorDespesa = frmLerDespesasPDFDtg.Rows[0].Cells[2].Value.ToString();

            double despesa;
            if (valorDespesa.Length == 0 || !Double.TryParse(valorDespesa, out despesa) || despesa <= 0)
            {
                MessageBox.Show("Digite um valor válido para a despesa", "Erro!");
                return;
            }

            if (descricao.Trim().Length == 0)
            {
                MessageBox.Show("Digite um valor válido para a descrição", "Erro!");
                return;
            }
            DateTime dateTime;
            if (data.Trim().Length == 0 || !DateTime.TryParse(data, out dateTime))
            {
                MessageBox.Show("Digite um valor válido para a data :" + data, "Erro!");
                return;
            }

            string[] valores = new string[4];
            string[] colunas = new string[4];

            colunas[0] = "DATAEAUTENTICACAO";
            colunas[1] = "DATA";
            colunas[2] = "NOME";
            colunas[3] = "VALOR";

            string key = data + " " + descricao + valorDespesa;

            valores[0] = key;
            valores[1] = data;
            valores[2] = descricao;
            valores[3] = valorDespesa;


            acessoDB3.SQLReplaceGenerico(key, "DESPESAS", colunas, valores);

            //acessoDB3.SQLReplace(selo, codato, datapratica, termo, folha, substituiSelo, status, tributacao);

            acessoDB3.CloseConn();

            //frmLerDespesasPDFDtg.DataSource = dtDespesa.DefaultView;
            frmLerDespesasPDFRbtSim.Checked = false;
            frmLerDespesasPDFRbtSim.Checked = true;
            MessageBox.Show("Despesa incluída com sucesso!");


        }
    }
}
