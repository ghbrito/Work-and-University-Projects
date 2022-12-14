using Calcula_Custas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Windows.Interop;
using System.IO;

namespace Calcula_Custas
{
    public partial class frmGerarLivroCaixaImpressao : UserControl
    {
        DataTable livroCaixa;
        string anomes;

        string nomeArquivo;
        public frmGerarLivroCaixaImpressao()
        {
            InitializeComponent();
        }

        private void frmGerarRelatorioContabilidade_Load(object sender, EventArgs e)
        {
            frmGerarLivroCaixaMaskAno.Focus();
            frmGerarLivroCaixaMaskAno.SelectionStart = 0;
        }

        private void gerarPDF(string caminhoArquivo, string nomeArquivo)
        {

        }

        private void buttonGerarRelatorioContabilidadeConsultar_Click(object sender, EventArgs e)
        {
            frmGerarLivroImpressaoGbxConsulta.Visible = false;
            if (!frmGerarLivroCaixaMaskAno.MaskCompleted || int.Parse(frmGerarLivroCaixaMaskAno.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Digite um valor válido para ANO", "Erro", MessageBoxButtons.OK);
                return;
            }
            if (frmGerarLivroCaixaCmbMes.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma opção válida no campo MÊS", "Erro", MessageBoxButtons.OK);
                return;
            }
            anomes = "";
            if ((frmGerarLivroCaixaCmbMes.SelectedIndex + 1) < 10)
            {
                anomes = (frmGerarLivroCaixaMaskAno.Text + "0" + (frmGerarLivroCaixaCmbMes.SelectedIndex + 1).ToString());
            }
            else
            {
                anomes = (frmGerarLivroCaixaMaskAno.Text + (frmGerarLivroCaixaCmbMes.SelectedIndex + 1).ToString());
            }
            try
            {
                //MessageBox.Show("ANOMES = " + anomes);
                //DataTable dt;
                DBAccess dbA3 = new DBAccess(3);

                string mes = anomes.Substring(4);
                string ano = anomes.Substring(0, 4);
                nomeArquivo = "Livro Caixa - Ano " + ano + " - Mês " + mes + ".pdf";

                //dtRelatorioMensal.Columns[0].MaxLength = 50;

                string dataInicial = FormataData.getInicioEFimDoMes(anomes, true);
                string dataFinal = FormataData.getInicioEFimDoMes(anomes, false);

                int anoInt = int.Parse(ano);
                int mesInt = int.Parse(mes);

                //string diaFinal = "";


                livroCaixa = new DataTable();

                livroCaixa.Columns.Add("Data");
                livroCaixa.Columns.Add("Qtd");
                livroCaixa.Columns.Add("Código Ato");
                livroCaixa.Columns.Add("Termo/Lv.Fl./Identificação");
                livroCaixa.Columns.Add("Receita");
                livroCaixa.Columns.Add("Despesa");

                double totalReceitas = 0;
                double totalDespesas = 0;


                DataTable receitaAtos = new DataTable();
                DataTable despesas = new DataTable();

                DataTable AutRF = new DataTable();
                DataTable OutrosAtos = new DataTable();


                string SQLreceitaAutRF = "select CAST(DATAPRATICA AS DATE), CODATO, COUNT(*) from SELOSATOS where (CODATO = '1301' OR CODATO = '1302' OR CODATO = '1501' OR CODATO = '1502' OR(CODATO = '8101' AND TERMO = '')) AND (TRIBUTACAO = '1' OR TRIBUTACAO = '' OR TRIBUTACAO IS NULL) AND DATAPRATICA >= '" + dataInicial + " 00:00:00' and DATAPRATICA <= '" + dataFinal + " 23:59:59' group by CAST(DATAPRATICA AS DATE), CODATO order by CAST(DATAPRATICA AS DATE)";
                string SQLreceitaOutroAtos = "select CAST(DATAPRATICA as DATE), CODATO, TERMO, FOLHA from SELOSATOS where (CODATO != '1301' AND CODATO != '1302' AND CODATO != '1501' AND CODATO != '1502') AND (TERMO != '') AND (TRIBUTACAO = '1' OR TRIBUTACAO = '' OR TRIBUTACAO IS NULL) AND DATAPRATICA >= '" + dataInicial + " 00:00:00' and DATAPRATICA <= '" + dataFinal + " 23:59:59' order by CAST(DATAPRATICA as DATE)";

                AutRF = dbA3.SQLQuery(SQLreceitaAutRF);
                OutrosAtos = dbA3.SQLQuery(SQLreceitaOutroAtos);

                string dataAto = "";
                double qtd = 0;
                string codAto = "";
                string identificacaoAto = "";
                double receita = 0;
                double despesa = 0;

                for (int i = 0; i < AutRF.Rows.Count; i++)
                {
                    dataAto = AutRF.Rows[i][0].ToString();
                    qtd = Double.Parse(AutRF.Rows[i][2].ToString());
                    codAto = AutRF.Rows[i][1].ToString();
                    receita = qtd * (dbA3.consultaEmolumentos(codAto, "EMOLUMLIQ", ano));

                    totalReceitas += receita;

                    if (codAto == "1301" || codAto == "1302")
                    {
                        identificacaoAto = "Autenticação";
                    }
                    else if (codAto == "1501")
                    {
                        identificacaoAto = "Reconhecimento de Firma";
                    }
                    else if (codAto == "1502")
                    {
                        identificacaoAto = "Cartão de Assinatura";
                    }
                    else if (codAto == "8101")
                    {
                        identificacaoAto = "Arquivamento";
                    }

                    livroCaixa.Rows.Add(dataAto, qtd, codAto, identificacaoAto, ConverteStringParaStringContabil.ConverteDouble(receita.ToString()), "");


                }


                int qtdArquivamentos = 0;
                string idAto = "";
                string idAtoPosterior = "";
                string codAtoPosterior = "";
                for (int i = 0; i < OutrosAtos.Rows.Count; i++)
                {
                    dataAto = OutrosAtos.Rows[i][0].ToString();
                    qtd = 1;
                    codAto = OutrosAtos.Rows[i][1].ToString();
                    identificacaoAto = OutrosAtos.Rows[i][2].ToString() + OutrosAtos.Rows[i][3].ToString();
                    receita = qtd * (dbA3.consultaEmolumentos(codAto, "EMOLUMLIQ", ano));

                    totalReceitas += receita;

                    idAto = OutrosAtos.Rows[i][2].ToString() + OutrosAtos.Rows[i][3].ToString();
                    if (OutrosAtos.Rows.Count - i > 1)
                    {
                        idAtoPosterior = OutrosAtos.Rows[i + 1][2].ToString() + OutrosAtos.Rows[i + 1][3].ToString();
                        codAtoPosterior = OutrosAtos.Rows[i + 1][1].ToString();
                    }
                    else
                    {
                        idAtoPosterior = "";
                        codAtoPosterior = "";
                    }

                    if (codAto == "8101")
                    {
                        qtdArquivamentos++;
                        if (idAto != idAtoPosterior && codAto != codAtoPosterior)
                        {
                            livroCaixa.Rows.Add(dataAto, qtdArquivamentos, codAto, identificacaoAto, ConverteStringParaStringContabil.ConverteDouble(receita.ToString()), "");
                            qtdArquivamentos = 0;
                        }
                    }
                    else
                    {
                        livroCaixa.Rows.Add(dataAto, qtd, codAto, identificacaoAto, ConverteStringParaStringContabil.ConverteDouble(receita.ToString()), "");
                    }



                }


                //SQL query para consultar as despesas do mês
                string SQL = "SELECT * FROM DESPESAS WHERE DATA >= '" + dataInicial + "' and DATA <= '" + dataFinal + "'";
                DataTable dtDespesas = new DataTable();

                ConsultaDadosBDInterno consulta = new ConsultaDadosBDInterno();



                dtDespesas = dbA3.SQLQuery(SQL);

                //MessageBox.Show("SQL despesas : " + SQL);

                dataAto = "";
                qtd = 0;
                codAto = "-";
                identificacaoAto = "";
                receita = 0;
                despesa = 0;
                //MessageBox.Show("Despesas rows: " + dtDespesas.Rows.Count);

                for (int i = 0; i < dtDespesas.Rows.Count; i++)
                {
                    dataAto = dtDespesas.Rows[i][1].ToString();
                    qtd = 1;
                    //codAto = OutrosAtos.Rows[i][1].ToString();
                    identificacaoAto = dtDespesas.Rows[i][2].ToString();
                    //receita = qtd * (dbA3.consultaEmolumentos(codAto, "EMOLUMLIQ", ano));
                    //MessageBox.Show("1-3"+despesas.Rows[i][3]);
                    Double.TryParse(dtDespesas.Rows[i][3].ToString(), out despesa);
                    //despesa = Convert.ToDouble(despesas.Rows[i][3]);

                    livroCaixa.Rows.Add(dataAto, qtd, codAto, identificacaoAto, "", ConverteStringParaStringContabil.ConverteDouble(despesa.ToString()));
                    //MessageBox.Show("Despesa: " + dataAto + " - " + identificacaoAto + " - " + despesa);
                    totalDespesas += despesa;

                }

                //MessageBox.Show("Total despesas: "+totalDespesas);

                SQL = "SELECT COMPBRUTO FROM CONSOLIDACAOMENSAL WHERE ANOMES = '" + anomes + "'";
                string recompe = dbA3.SQLQuerySimples(SQL);
                totalReceitas += Double.Parse(recompe);
                //MessageBox.Show(recompe);
                livroCaixa.Rows.Add("20/" + mes + "/" + ano, 1, "-", "RECOMPE", ConverteStringParaStringContabil.ConverteDouble(recompe.ToString()), "");


                livroCaixa.DefaultView.Sort = "Data";
                livroCaixa = livroCaixa.DefaultView.ToTable();


                totalReceitas = Math.Round(totalReceitas, 2);
                totalDespesas = Math.Round(totalDespesas, 2);

                //livroCaixa.Rows.Add(" ", " ", " ", " ", " ", " ");
                livroCaixa.Rows.Add(" ", " ", " ", " ", " ", " ");
                livroCaixa.Rows.Add("", "", "", "Relatório Mensal " + mes + "/" + ano, "RECEITAS", "DESPESAS");
                livroCaixa.Rows.Add("", "", "", "TOTAL: ", "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalReceitas.ToString()), "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalDespesas.ToString()));
                livroCaixa.Rows.Add("", "", "", "SALDO: ", "R$ " + ConverteStringParaStringContabil.ConverteDouble((totalReceitas - totalDespesas).ToString()), "");




                dbA3.CloseConn();
                frmGerarLivroCaixaDtg.DataSource = livroCaixa.DefaultView;
                frmGerarLivroImpressaoGbxConsulta.Visible = true;
                //frmGerarLivroCaixaSalvarPDF.Visible = true;
                //frmGerarLivroCaixaDtg.Visible = true;
                //buttonGerarRelatorioContabilidadeSalvar.Visible = true;
            }
            catch (Exception ex)
            {
                new Exception(ex.Message);
            }


        }


        //public string[] consultaMes(string ano, string mes)
        //{
        //    string[] consultaMes = new string[12];
        //    string sql = "";
        //    string anomes = ano + mes;
        //    sql = "SELECT * FROM CONSOLIDACAOMENSAL WHERE ANOMES = '" + anomes + "'";

        //    DBAccess dbA3 = new DBAccess(3);
        //    //consultaMes = dbA3.consultaConsolidacaoMensal(sql);
        //    dbA3.CloseConn();

        //    return consultaMes;
        //}

        private void gerarRelatorioContabilidadeDtg_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmGerarLivroCaixaDtg.BeginEdit(true);

        }

        private void gerarRelatorioContabilidadeDtg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            frmGerarLivroCaixaDtg.CurrentCell.Value = frmGerarLivroCaixaDtg.CurrentCell.EditedFormattedValue;
        }

        private void gerarRelatorioContabilidadeMaskAno_Enter(object sender, EventArgs e)
        {
            frmGerarLivroCaixaMaskAno.SelectionStart = 0;
        }

        private void gerarRelatorioContabilidadeMaskAno_MouseClick(object sender, MouseEventArgs e)
        {
            frmGerarLivroCaixaMaskAno.SelectionStart = 0;
        }

        private void frmGerarLivroCaixaSalvarPDF_Click(object sender, EventArgs e)
        {
            int numeroLivro = 0;
            int numeroFolhaInicial = 0;
            if (!int.TryParse(frmGerarLivroImpressaoMskLivro.Text, out numeroLivro) || numeroLivro < 1)
            {
                MessageBox.Show("Digite um valor válido para \"Nº Livro\"", "Erro", MessageBoxButtons.OK);
                return;
            }
            if (!int.TryParse(frmGerarLivroImpressaoMskFolha.Text, out numeroFolhaInicial) || numeroFolhaInicial < 1)
            {
                MessageBox.Show("Digite um valor válido para \"Nº Folha Inicial\"", "Erro", MessageBoxButtons.OK);
                return;
            }


            string caminhoArquivo = "";

            var dlg = new OpenFileDialog();

            dlg.ValidateNames = false;
            dlg.CheckFileExists = false;
            dlg.CheckPathExists = true;
            // Always default to Folder Selection.
            dlg.FileName = "Select folder.";
            //dlg.InputPath = @"c:\windows\system32";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(dlg.FileName);
                //MessageBox.Show(Path.GetDirectoryName(dlg.FileName));
                caminhoArquivo = Path.GetDirectoryName(dlg.FileName);
            }

            //caminhoArquivo = "C:\\Users\\guibr\\OneDrive\\Área de Trabalho";

            //int numeroLivro = 2;
            //int numeroFolhaInicial = 10;


            PDFHandler gerarPDF = new PDFHandler(livroCaixa, numeroLivro, numeroFolhaInicial, anomes, nomeArquivo, caminhoArquivo);
            gerarPDF.writePDF();


            //GerarPDF pdf = new GerarPDF(livroCaixa, numeroLivro, numeroFolhaInicial, anomes, nomeArquivo, caminhoArquivo);
            //pdf.novoPDF();
        }
    }
}
