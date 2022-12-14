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

namespace Calcula_Custas
{
    public partial class frmImportaDadosBD : UserControl
    {
        public frmImportaDadosBD()
        {
            InitializeComponent();
        }


        private void frmConferenciaSelosUC_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskFrmConfSeloANO_MouseClick(object sender, MouseEventArgs e)
        {
            mskFrmImportaAtosDataInicial.Focus();
            mskFrmImportaAtosDataInicial.SelectionStart = 0;
        }

        private void btnFrmImportaAtosImportar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!mskFrmImportaAtosDataInicial.MaskCompleted)
                {
                    MessageBox.Show("Digite um valor válido para DATA INICIAL", "Erro", MessageBoxButtons.OK);
                    return;
                }

                if (!mskFrmImportaAtosDataFinal.MaskCompleted)
                {
                    MessageBox.Show("Digite um valor válido para DATA FINAL", "Erro", MessageBoxButtons.OK);
                    return;
                }
                DateTime dataInicial = Convert.ToDateTime(mskFrmImportaAtosDataInicial.Text);
                DateTime dataFinal = Convert.ToDateTime(mskFrmImportaAtosDataFinal.Text);

                if (dataInicial > dataFinal)
                {
                    MessageBox.Show("Data Inicial não pode ser maior que Data Final", "Erro", MessageBoxButtons.OK);
                    return;
                }

                int anoInicial = dataInicial.Year;
                int mesInicial = dataInicial.Month;
                int diaInicial = dataInicial.Day;

                int anoFinal = dataFinal.Year;
                int mesFinal = dataFinal.Month;
                int diaFinal = dataFinal.Day;

                string inicial = "";
                string final = "";



                if (dataInicial.Month < 10)
                {
                    inicial += "0" + dataInicial.Month + "-";
                }
                else
                {
                    inicial += dataInicial.Month + "-";
                }
                if (dataInicial.Day < 10)
                {
                    inicial += "0" + dataInicial.Day + "-" + dataInicial.Year;
                }
                else
                {
                    inicial += dataInicial.Day + "-" + dataInicial.Year;
                }

                if (dataFinal.Month < 10)
                {
                    final += "0" + dataFinal.Month + "-";
                }
                else
                {   
                    final += dataFinal.Month + "-";
                }
                if (dataFinal.Day < 10)
                {
                    final += "0" + dataFinal.Day + "-" + dataFinal.Year;
                }
                else
                {
                    final += dataFinal.Day + "-" + dataFinal.Year;
                }



                string periodo = "SAN4540.DATAHIST >= '" +inicial + "' AND SAN4540.DATAHIST <= '" + final+"'";





                //FbConnection conexao = new FbConnection(@"Data Source=localhost;Database=D:\bkp BDs cart\SAN.fdb;User ID=SYSDBA;password=masterkey");

                //FbCommand sqlQuery = new FbCommand("select * from SAN4520 where SELOSEQ = 2245", conexao);

                try
                {
                    //conexao.Open();
                    //FbDataReader reader = sqlQuery.ExecuteReader();
                    var acessoDB1 = new DBAccess(1);
                    //MessageBox.Show(acessoDB.SQLQuery("select * from SAN4520 where SELOSEQ = 2245"));
                    //while (reader.Read())
                    //{
                    //    MessageBox.Show(reader["SELOCOD"].ToString() + reader["SELOSERIE"].ToString(),"oeee",MessageBoxButtons.OK);
                    //}
                    //conexao.Close();
                    //string query = Interaction.InputBox("Digite sua query SQL:", "SQLQuery", "");


                    string query = "SELECT SAN4540.SELO, SAN7510.CODIGO, SAN4540.LIVRO, SAN4540.FOLHA, SAN4540.CLINOM, SAN4540.CLICPFCGC, SAN4540.DATAHIST FROM SAN4540, SAN7510 WHERE SAN4540.TIPSEQ = SAN7510.TIPSEQ AND " + periodo + " and SAN4540.STATUS = 1 AND SAN4540.TIPOISENTO is null ORDER BY SAN4540.DATAHIST";

                    MessageBox.Show("DATA: " + periodo + "\nQUERY: " + query);

                    DataTable dtb = acessoDB1.SQLQuery(query);
                    //dtgConfSelos.DataSource = dtb.DefaultView;


                    //"select * from SAN4520 where SELOSEQ between 2222 and 2245").DefaultView;
                    //
                    acessoDB1.CloseConn();
                    var acessoDB3 = new DBAccess(3);
                    MessageBox.Show(acessoDB3.SQLBulkInsert(dtb));
                    acessoDB3.CloseConn();

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro: " + ex.Message, ex);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Exceção: " + ex.Message, "Erro de Exceção");
            }
            //MessageBox.Show("msg: " + int.Parse(mskFrmConfSeloANO.Text), "msg: " + int.Parse(mskFrmConfSeloANO.Text));

        }

        private void cbConfSelosSemana_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fbConnection1_InfoMessage(object sender, FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs e)
        {

        }


    }
}
