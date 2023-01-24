using Calcula_Custas.Classes;
//using FirebirdSql;
using FirebirdSql.Data.FirebirdClient;
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
    public partial class frmConfereSelosBDInterno : UserControl
    {
        public frmConfereSelosBDInterno()
        {
            InitializeComponent();
            mskFrmConfSeloANO.Focus();
            //btnConfSelosBDICopiarTotalGeral.BackgroundImage = D:\Dropbox\Dropbox\Cursos e Material de Estudo\Projetos\Alura\Calcula Custas\Calcula Custas\Imagens\iconCopiar.png;

        }

        private void frmConfereSelosBDInterno_Load(object sender, EventArgs e)
        {
            mskFrmConfSeloANO.Focus();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mskFrmConfSeloANO_MouseClick(object sender, MouseEventArgs e)
        {
            mskFrmConfSeloANO.Focus();
            mskFrmConfSeloANO.SelectionStart = 0;
        }

        private void btnConfSelosPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                gbxConfSelosResultadoPesquisa.Visible = false;
                gbxConfSelosTotalConsultas.Visible = false;
                if (!mskFrmConfSeloANO.MaskCompleted || int.Parse(mskFrmConfSeloANO.Text) > DateTime.Now.Year)
                {
                    MessageBox.Show("Digite um valor válido para ANO", "Erro", MessageBoxButtons.OK);
                    return;
                }

                if (cbFrmConfSeloMES.SelectedIndex < 0)
                {
                    MessageBox.Show("Digite um valor válido para MÊS", "Erro", MessageBoxButtons.OK);
                    return;

                }

                if (cbConfSelosSemana.SelectedIndex < 0)
                {
                    MessageBox.Show("Digite um valor válido para SEMANA / PERÍODO", "Erro", MessageBoxButtons.OK);
                    return;
                }

                gbxConfSelosTotalConsultas.Visible = true;
                gbxConfSelosResultadoPesquisa.Visible = true;

                int ano = int.Parse(mskFrmConfSeloANO.Text);
                int mes = 1 + cbFrmConfSeloMES.SelectedIndex;
                int semana = 1 + cbConfSelosSemana.SelectedIndex;

                string dataInicioPeriodo;
                string dataFimPeriodo;

                string diaInicialPeriodo = "";
                string diaFinalPeriodo = "";

                if (semana == 1)
                {
                    diaInicialPeriodo = "01";
                    diaFinalPeriodo = "08";
                }
                if (semana == 2)
                {
                    diaInicialPeriodo = "08";
                    diaFinalPeriodo = "15";
                }
                if (semana == 3)
                {
                    diaInicialPeriodo = "15";
                    diaFinalPeriodo = "22";
                }
                if (semana == 4)
                {
                    diaInicialPeriodo = "22";
                    diaFinalPeriodo = "01";
                }
                if (semana == 5)
                {
                    diaInicialPeriodo = "01";
                    diaFinalPeriodo = "01";
                }

                dataInicioPeriodo = diaInicialPeriodo + "-" + mes + "-" + ano;
                if (semana == 4 || semana == 5)
                {
                    if (mes == 12)
                    {
                        dataFimPeriodo = "01-01-" + (ano + 1);
                    }
                    else
                    {
                        dataFimPeriodo = "01-" + (mes + 1) + "-" + ano;
                    }
                }
                else
                {
                    dataFimPeriodo = diaFinalPeriodo + "-" + mes + "-" + ano;
                }

                FormataData dataInicialFormatada = new FormataData(dataInicioPeriodo);
                FormataData dataFinalFormatada = new FormataData(dataFimPeriodo);

                //MessageBox.Show(dataFinalFormatada.ToString() + "  -  " + dataFinalFormatada.ToString());
                try
                {
                    //string sqlCount = "SELECT SELO, CODATO, TRIBUTACAO FROM SELOSATOS WHERE DATAPRATICA >= '" + dataInicialFormatada.GetDataFormatada(3) + "' AND DATAPRATICA < '" + dataFinalFormatada.GetDataFormatada(3) + "' and STATUS = 1 AND (TRIBUTACAO = '' OR TRIBUTACAO = '1' OR TRIBUTACAO IS NULL) ORDER BY CODATO";
                    string sqlCount = "SELECT CODATO, COUNT(*) FROM SELOSATOS WHERE DATAPRATICA >= '" + dataInicialFormatada.GetDataFormatada(3) + "' AND DATAPRATICA < '" + dataFinalFormatada.GetDataFormatada(3) + "' and STATUS = 1 AND (TRIBUTACAO = '' OR TRIBUTACAO = '1' OR TRIBUTACAO IS NULL) GROUP BY CODATO ORDER BY CODATO";
                    //string sqlCountODBC = "SELECT cd_ato, nu_selo FROM se_selos where TIPO_TRIBUTACAO = 28 and DT_USO_SELO >= '" + dataInicialFormatada.GetDataFormatada(false) + "' and DT_USO_SELO < '" + dataFinalFormatada.GetDataFormatada(false) + "' group by cd_ato order by cd_ato";

                    var acessoDB3 = new DBAccess(3);
                    //MessageBox.Show(sqlCount);
                    DataTable dtbAtos = acessoDB3.SQLQuery(sqlCount);

                    dtgConfSelosBDInterno.DataSource = dtbAtos.DefaultView;

                    double emolUnit;
                    double recompeUnit;
                    double tfjUnit;
                    int qtd;

                    double totalTFJ = 0;
                    double totalRecompe = 0;

                    dtbAtos.Columns.Add();
                    dtbAtos.Columns.Add();
                    dtbAtos.Columns.Add();
                    double totalCustas = 0;
                    //MessageBox.Show("mark");
                    for (int i = 0; i < dtbAtos.Rows.Count; i++)
                    {
                        //MessageBox.Show(""+ dtbAtos.Rows[i][0].ToString());
                        emolUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbAtos.Rows[i][0].ToString(), "EMOLUMBRUTO", ano.ToString()).ToString());
                        recompeUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbAtos.Rows[i][0].ToString(), "RECOMPE", ano.ToString()).ToString());
                        tfjUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbAtos.Rows[i][0].ToString(), "TFJ", ano.ToString()).ToString());
                        qtd = int.Parse(dtbAtos.Rows[i][1].ToString());
                        dtbAtos.Rows[i][2] = (qtd * emolUnit); // acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
                        dtbAtos.Rows[i][3] = (qtd * recompeUnit);
                        dtbAtos.Rows[i][4] = (qtd * tfjUnit);

                        totalCustas += Double.Parse(dtbAtos.Rows[i][2].ToString());
                        totalRecompe += Double.Parse(dtbAtos.Rows[i][3].ToString());
                        totalTFJ += Double.Parse(dtbAtos.Rows[i][4].ToString());
                        //MessageBox.Show(totalCustas+" "+totalRecompe+" "+totalRecompe);
                    }
                    dtbAtos.Columns[0].ColumnName = "Código do Ato";
                    dtbAtos.Columns[1].ColumnName = "Quantidade";
                    dtbAtos.Columns[2].ColumnName = "Valor Emolumentos";
                    dtbAtos.Columns[3].ColumnName = "RECOMPE";
                    dtbAtos.Columns[4].ColumnName = "TFJ";

                    dtgConfSelosBDInterno.DataSource = dtbAtos.DefaultView;

                    lblConfSelosTotalGeralEmolumentosValor.Text = "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalCustas.ToString());
                    lblConfSelosTotalGeralRecompeValor.Text = "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalRecompe.ToString());
                    lblConfSelosTotalGeralTFJValor.Text = "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalTFJ.ToString());
                    dtgConfSelosBDInterno.AutoResizeColumns();
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

        private void fbConnection1_InfoMessage_1(object sender, FbInfoMessageEventArgs e)
        {

        }

        private void lblConfSelosValorEmolValor_Click(object sender, EventArgs e)
        {

        }

        private void grpConfSelosTotalCustas_Enter(object sender, EventArgs e)
        {

        }

        private void gbxConfSelosResultadoPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void btnConfSelosRecalcularValores_Click(object sender, EventArgs e)
        {


        }


        private void gbxConfSelosTotalConsultas_Enter(object sender, EventArgs e)
        {

        }

        private void frmConfereSelosBDInterno_Load_1(object sender, EventArgs e)
        {
            mskFrmConfSeloANO.Focus();
        }

        private void cbFrmConfSeloMES_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int index = cbFrmConfSeloMES.FindString(cbFrmConfSeloMES.Text);
            //cbFrmConfSeloMES.SelectedIndex = index;
        }

        private void cbFrmConfSeloMES_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void cbFrmConfSeloMES_KeyUp(object sender, KeyEventArgs e)
        {
            //cbFrmConfSeloMES.DisplayMember = cbFrmConfSeloMES.Text;

            ////MessageBox.Show(e.KeyChar.ToString());
            ////MessageBox.Show(cbFrmConfSeloMES.Text);
            //int number;
            //MessageBox.Show(cbFrmConfSeloMES.SelectedIndex.ToString());
            //if ((e.KeyCode > Keys.D0 && e.KeyCode <= Keys.D9)|| (e.KeyCode > Keys.NumPad0 && e.KeyCode <= Keys.NumPad9))
            //{
            //    //if (number > 0 && number <= 9)
            //    //{
            //        //switch (number)
            //        //{
            //        //    case 0:
            //        //        cbFrmConfSeloMES.SelectedIndex = 9;
            //        //        break;

            //        //    case 1:
            //        //        //MessageBox.Show("oi");
            //        //        cbFrmConfSeloMES.SelectedIndex = 10;
            //        //        break;

            //        //    case 2:
            //        //        cbFrmConfSeloMES.DisplayMember = "";
            //        //        cbFrmConfSeloMES.SelectedIndex = 11;
            //        //        break;

            //        //    default:
            //        //        break;
            //        //}
            //    //}
            //}
            //else
            //{
            //    cbFrmConfSeloMES.Text = "";
            //}
            //if(cbFrmConfSeloMES.Text.Length == 3)
            //{
            //    cbFrmConfSeloMES.Text = "";
            //}
            ////MessageBox.Show(cbFrmConfSeloMES.Text);
        }

        private void cbFrmConfSeloMES_KeyPress(object sender, KeyPressEventArgs e)
        {


            
            //cbFrmConfSeloMES.
        }

        private void btnConfSelosBDICopiarTotalRecompe_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(lblConfSelosTotalGeralRecompeValor.Text);
        }
    }
}