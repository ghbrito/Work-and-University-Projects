using Calcula_Custas.Classes;
using DocumentFormat.OpenXml.ExtendedProperties;
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
    public partial class frmGerarRelatorioSemestralCNJ : UserControl
    {
        DataTable dtRelatorioMensal;
        DataTable codAtoPorDiaMensal;
        DataTable emolumentoTotalPorDia;
        DataTable RelatorioCNJ;
        DataTable qtdAtos;
        string nomeArquivo;
        string anomes;
        string ano;
        string[] meses;
        public frmGerarRelatorioSemestralCNJ()
        {
            InitializeComponent();
        }

        private void frmGerarRelatorioContabilidade_Load(object sender, EventArgs e)
        {
            gerarRelatorioContabilidadeMaskAno.Focus();
            gerarRelatorioContabilidadeMaskAno.SelectionStart = 0;
        }

        private void gerarPDF(string caminhoArquivo, string nomeArquivo)
        {

        }

        private void buttonGerarRelatorioContabilidadeConsultar_Click(object sender, EventArgs e)
        {
            if (!gerarRelatorioContabilidadeMaskAno.MaskCompleted || int.Parse(gerarRelatorioContabilidadeMaskAno.Text) > DateTime.Now.Year)
            {
                MessageBox.Show("Digite um valor válido para ANO", "Erro", MessageBoxButtons.OK);
                return;
            }
            double arrecadacaoTotal = 0;    //Arecadação do semestre = Emolumentos + Recompe + TFJ
            double despesasTotal = 0;       //CUSTEIO = Despesas do semestre
            double repassesTotal = 0;       //Repasses = TFJ + Recompe do semestre
            int quantidadeAtosTotal = 0;    //Quantidade total e atos no semestre

            RelatorioCNJ = new DataTable();
            RelatorioCNJ.Columns.Add("Período");
            RelatorioCNJ.Columns.Add("Arrecadação");
            RelatorioCNJ.Columns.Add("Despesas");
            RelatorioCNJ.Columns.Add("Repasses");
            RelatorioCNJ.Columns.Add("Qtd Atos");

            ano = gerarRelatorioContabilidadeMaskAno.Text;
            string semestre = "";

            DBAccess dbA3 = new DBAccess(3);

            if (frmGerarRelatorioSemestralCNJRdBtn1.Checked)
            {
                meses = new string[6] { "01", "02", "03", "04", "05", "06" };
                semestre = "_1ºS";
            }
            else
            {
                meses = new string[6] { "07", "08", "09", "10", "11", "12" };
                semestre = "_2ºS";
            }

            string dataInicial = "";
            string dataFinal = "";

            int anoInt;
            int mesInt;

            string diaFinal = "";

            int[] meses30 = new int[4] { 4, 6, 9, 11 };
            int[] meses31 = new int[7] { 1, 3, 5, 7, 8, 10, 12 };

            for (int i = 0; i < 6; i++)
            {
                anomes = ano + meses[i];
                string sql;
                if (dbA3.KeyExists(anomes, "CONSOLIDACAOMENSAL", "ANOMES"))
                {
                    sql = "SELECT * FROM CONSOLIDACAOMENSAL WHERE ANOMES = '" + anomes + "'";
                }
                else
                {
                    MessageBox.Show("Período " + anomes + " não foi encontrado no Banco de Dados", "Erro", MessageBoxButtons.OK);
                    return;
                }
                

                dtRelatorioMensal = dbA3.SQLQuery(sql);
                double arrecadacaoMes = (Double.Parse(dtRelatorioMensal.Rows[0][2].ToString()) + Double.Parse(dtRelatorioMensal.Rows[0][3].ToString()) + Double.Parse(dtRelatorioMensal.Rows[0][4].ToString()));
                double despesaMes = Double.Parse(dtRelatorioMensal.Rows[0][10].ToString());
                double repassesMes = (Double.Parse(dtRelatorioMensal.Rows[0][3].ToString()) + Double.Parse(dtRelatorioMensal.Rows[0][4].ToString()));


                anoInt = int.Parse(ano);
                mesInt = int.Parse(meses[i]);

                if (meses30.Contains(mesInt))
                {
                    diaFinal = "30";
                }
                else
                {
                    if (meses31.Contains(mesInt))
                    {
                        diaFinal = "31";
                    }
                    else
                    {
                        if ((anoInt % 4) == 0)
                        {
                            diaFinal = "29";
                        }
                        else
                        {
                            diaFinal = "28";
                        }
                    }
                }

                dataInicial = "01-" + meses[i] + "-" + ano;
                dataFinal = diaFinal + "-" + meses[i] + "-" + ano;


                sql = "SELECT COUNT(*) FROM SELOSATOS WHERE DATAPRATICA >= '" + dataInicial + "' and DATAPRATICA <= '" + dataFinal + "'";
                qtdAtos = dbA3.SQLQuery(sql);
                int qtdATosMes = int.Parse(qtdAtos.Rows[0][0].ToString());
                //MessageBox.Show("qtd atos = " + qtdATosMes);

                arrecadacaoTotal += arrecadacaoMes;
                despesasTotal += despesaMes;
                repassesTotal += repassesMes;
                quantidadeAtosTotal += qtdATosMes;

                RelatorioCNJ.Rows.Add(anomes,arrecadacaoMes,despesaMes,repassesMes, qtdATosMes);
            }

            RelatorioCNJ.Rows.Add("TOTAL", "TOTAL", "TOTAL", "TOTAL", "TOTAL");

            RelatorioCNJ.Rows.Add(ano+semestre, arrecadacaoTotal, despesasTotal, repassesTotal, quantidadeAtosTotal);


            dbA3.CloseConn();
            gerarRelatorioContabilidadeDtg.DataSource = RelatorioCNJ.DefaultView;

            gerarRelatorioContabilidadeDtg.Visible = true;


        }

       
        private void gerarRelatorioContabilidadeMaskAno_Enter(object sender, EventArgs e)
        {
            gerarRelatorioContabilidadeMaskAno.SelectionStart = 0;
        }

        private void gerarRelatorioContabilidadeMaskAno_MouseClick(object sender, MouseEventArgs e)
        {
            gerarRelatorioContabilidadeMaskAno.SelectionStart = 0;
        }

    
    }
}
