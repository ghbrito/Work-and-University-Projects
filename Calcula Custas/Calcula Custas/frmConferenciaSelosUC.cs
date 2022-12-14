using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;
using Calcula_Custas.Classes;
using Microsoft.VisualBasic;

namespace Calcula_Custas
{
    public partial class frmConferenciaSelosUC : UserControl
    {
        public frmConferenciaSelosUC()
        {
            InitializeComponent();
        }

        private void frmConferenciaSelosUC_Load(object sender, EventArgs e)
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
                if (!mskFrmConfSeloANO.MaskCompleted || int.Parse(mskFrmConfSeloANO.Text) > 2022)
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
                //string mes = "";

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
                    //periodo = "SAN4540.dtHIST >= '" + mes + "-" + diaInicialPeriodo + "-" + ano + "' AND SAN4540.dtHIST < '" + (mes + 1) + "-01-" + ano + "'";
                }
                if (semana == 5)
                {
                    diaInicialPeriodo = "01";
                    diaFinalPeriodo = "01";
                    //periodo = "SAN4540.dtHIST >= '" + mes + "-" + diaInicialPeriodo + "-" + ano + "' AND SAN4540.dtHIST < '" + (mes + 1) + "-01-" + ano + "'";
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






                //string periodoFB = "SAN4540.DATAHIST >= '" + inicial + "' AND SAN4540.DATAHIST <= '" + final + "'";
                //string periodoODBC = ">= '" + inicial + "' and DT_USO_SELO <= '" + final + "'";





                //FbConnection conexao = new FbConnection(@"Data Source=localhost;Database=D:\bkp BDs cart\SAN.fdb;User ID=SYSDBA;password=masterkey");

                //FbCommand sqlQuery = new FbCommand("select * from SAN4520 where SELOSEQ = 2245", conexao);

                try
                {
                    string sqlFB = "SELECT SAN4540.SELO, SAN7510.CODIGO, SAN4540.DATAHIST, SAN4540.LIVRO, SAN4540.FOLHA, SAN4540.STATUS, SAN4540.TIPOISENTO FROM SAN4540, SAN7510 WHERE SAN4540.TIPSEQ = SAN7510.TIPSEQ AND SAN4540.DATAHIST >= '" + dataInicialFormatada.GetDataFormatada(1) + "' AND SAN4540.DATAHIST <= '" + dataFinalFormatada.GetDataFormatada(1) + "' and SAN4540.STATUS = 1 ORDER BY SAN4540.DATAHIST";
                    //string sqlFB = "SELECT SAN4540.SELO, SAN7510.CODIGO, SAN4540.DATAHIST, SAN4540.LIVRO, SAN4540.FOLHA, SAN4540.STATUS FROM SAN4540, SAN7510 WHERE SAN4540.TIPSEQ = SAN7510.TIPSEQ AND SAN4540.DATAHIST >= '" + dataInicialFormatada.GetDataFormatada(true) + "' AND SAN4540.DATAHIST <= '" + dataFinalFormatada.GetDataFormatada(true) + "' and SAN4540.STATUS = 1 AND SAN4540.TIPOISENTO is null ORDER BY SAN4540.DATAHIST";
                    string sqlODBC = "SELECT nu_selo, cd_ato, DT_PRATICA, nu_termo, cd_situacao, TIPO_TRIBUTACAO FROM se_selos where cd_situacao = 1 and DT_PRATICA >= '" + dataInicialFormatada.GetDataFormatada(2) + "' and DT_PRATICA < '" + dataFinalFormatada.GetDataFormatada(2) + "' order by DT_PRATICA";

                    string sqlCountFB = "SELECT SAN7510.CODIGO, COUNT(*) FROM SAN4540, SAN7510 WHERE SAN4540.TIPSEQ = SAN7510.TIPSEQ AND SAN4540.DATAHIST >= '" + dataInicialFormatada.GetDataFormatada(1) + "' AND SAN4540.DATAHIST <= '" + dataFinalFormatada.GetDataFormatada(1) + "' and SAN4540.STATUS = 1 AND SAN4540.TIPOISENTO is null GROUP BY SAN7510.CODIGO ORDER BY SAN7510.CODIGO";
                    string sqlCountODBC = "SELECT cd_ato, count(*) FROM se_selos where cd_situacao = 1 and TIPO_TRIBUTACAO = 1 and DT_PRATICA >= '" + dataInicialFormatada.GetDataFormatada(2) + "' and DT_PRATICA < '" + dataFinalFormatada.GetDataFormatada(2) + "' group by cd_ato order by cd_ato";
                    //string sqlCountODBC = "SELECT cd_ato, nu_selo FROM se_selos where TIPO_TRIBUTACAO = 28 and DT_USO_SELO >= '" + dataInicialFormatada.GetDataFormatada(false) + "' and DT_USO_SELO < '" + dataFinalFormatada.GetDataFormatada(false) + "' group by cd_ato order by cd_ato";



                    //string sqlReplaceFB = "REPLACE INTO SELOSATOS (SELO, CODATO, DATAPRATICA, TERMO, FOLHA, SUBSTITUIUSELO) VALUES ()";

                    //"SELECT SAN7510.CODIGO, COUNT(*) FROM SAN4540, SAN7510 WHERE SAN4540.TIPSEQ = SAN7510.TIPSEQ AND SAN4540.DATAHIST >= '" + dataInicialFormatada.GetDataFormatada(true) + "' AND SAN4540.DATAHIST <= '" + dataFinalFormatada.GetDataFormatada(true) + "' and SAN4540.STATUS = 1 AND SAN4540.TIPOISENTO is null GROUP BY SAN7510.CODIGO ORDER BY SAN7510.CODIGO";

                    //MessageBox.Show("sqlFB= " + sqlFB + "\n\nsqlODBC= " + sqlODBC);


                    //MessageBox.Show("mark");

                    var acessoDB1 = new DBAccess(1);
                    var acessoDB2 = new DBAccess(2);
                    var acessoDB3 = new DBAccess(3);
                    //MessageBox.Show("mark");

                    DataTable dtbNotas = acessoDB1.SQLQuery(sqlFB);
                    //MessageBox.Show("mark");
                    DataTable dtbRegCiv = acessoDB2.SQLQuery(sqlODBC);


                    string selo = "";
                    string codato = "";
                    string datapratica = "";
                    string termo = "";
                    string folha = "";
                    string status = "";
                    string tributacao = "";
                    //string sqlReplace = "";


                    for (int i = 0; i < dtbNotas.Rows.Count; i++)
                    {

                        dtbNotas.Rows[i][1] = dtbNotas.Rows[i][1].ToString().Remove(4);
                       //MessageBox.Show(dtbNotas.Rows[i][0].ToString() + "   " + dtbNotas.Rows[i][1].ToString());
                        selo = dtbNotas.Rows[i][0].ToString();
                        codato = dtbNotas.Rows[i][1].ToString();
                        datapratica = dtbNotas.Rows[i][2].ToString();
                        termo = dtbNotas.Rows[i][3].ToString();
                        folha = dtbNotas.Rows[i][4].ToString();
                        status = dtbNotas.Rows[i][5].ToString();
                        tributacao = dtbNotas.Rows[i][6].ToString();
                        if(tributacao == "1")
                        {
                            tributacao = "ISENTO";
                        }
                        else if(tributacao == "")
                        {
                            tributacao = "1";
                        }

                        //sqlReplace = "INSERT INTO SELOSATOS (SELO, CODATO, DATAPRATICA, TERMO, FOLHA, SUBSTITUIUSELO) VALUES (" + selo + ", " + codato + ", " + datapratica + ", " + termo + ", " + folha + ")";
                        //MessageBox.Show("linha dt "+dtbNotas.Rows[i][6].ToString());
                        acessoDB3.SQLReplace(selo, codato, datapratica, termo, folha, "", status, tributacao);
                    }
                    
                    selo = "";
                    codato = "";
                    datapratica = "";
                    termo = "";
                    folha = "";
                    status = "";
                    tributacao = "";
                    
                    for (int i = 0; i < dtbRegCiv.Rows.Count; i++)
                    {
                        selo = dtbRegCiv.Rows[i][0].ToString();
                        codato = dtbRegCiv.Rows[i][1].ToString();
                        datapratica = dtbRegCiv.Rows[i][2].ToString();
                        termo = dtbRegCiv.Rows[i][3].ToString();
                        status = dtbRegCiv.Rows[i][4].ToString();
                        tributacao = dtbRegCiv.Rows[i][5].ToString();

                        //sqlReplace = "SELOSATOS(SELO, CODATO, DATAPRATICA, TERMO) VALUES ('" + selo + "', '" + codato + "', '" + datapratica + "', '" + termo + "')";
                        //MessageBox.Show("SQL REPLACE: "+sqlReplace);
                        acessoDB3.SQLReplace(selo, codato, datapratica, termo, folha, "", status, tributacao);
                    }


                    //sqlReplaceODBC = "REPLACE INTO SELOSATOS (SELO, CODATO, DATAPRATICA, TERMO, FOLHA, SUBSTITUIUSELO) VALUES (" + selo + ", " + codato + ", " + datapratica + ", " + termo + ", " + folha + ")";




                    dtbNotas = acessoDB1.SQLQuery(sqlCountFB);
                    dtbRegCiv = acessoDB2.SQLQuery(sqlCountODBC);

                    dtgConfSelosNotas.DataSource = dtbNotas.DefaultView;
                    dtgConfSelosRegCiv.DataSource = dtbRegCiv.DefaultView;

                    acessoDB1.CloseConn();
                    acessoDB2.CloseConn();

                    //var acessoDB3 = new DBAccess(3);
                    //acessoDB2 = new DBAccess(2);

                    double emolUnit;
                    double recompeUnit;
                    double tfjUnit;
                    int qtd;

                    double totalTFJ = 0;
                    double totalRecompe = 0;

                    dtbRegCiv.Columns.Add();
                    dtbRegCiv.Columns.Add();
                    dtbRegCiv.Columns.Add();
                    double totalCustasRegCiv = 0;
                    for (int i = 0; i < dtbRegCiv.Rows.Count; i++)
                    {

                        //MessageBox.Show(dtbRegCiv.Rows[i][0].ToString() + "   "+ dtbRegCiv.Rows[i][1].ToString());
                        emolUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "EMOLUMBRUTO", ano.ToString()).ToString());
                        recompeUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "RECOMPE", ano.ToString()).ToString());
                        tfjUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "TFJ", ano.ToString()).ToString());
                        qtd = int.Parse(dtbRegCiv.Rows[i][1].ToString());
                        dtbRegCiv.Rows[i][2] = (qtd * emolUnit); // acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
                        dtbRegCiv.Rows[i][3] = (qtd * recompeUnit);
                        dtbRegCiv.Rows[i][4] = (qtd * tfjUnit);

                        totalCustasRegCiv += Double.Parse(dtbRegCiv.Rows[i][2].ToString());
                        totalRecompe += Double.Parse(dtbRegCiv.Rows[i][3].ToString());
                        totalTFJ += Double.Parse(dtbRegCiv.Rows[i][4].ToString());
                    }
                    dtbRegCiv.Columns[0].ColumnName = "Código do Ato";
                    dtbRegCiv.Columns[1].ColumnName = "Quantidade";
                    dtbRegCiv.Columns[2].ColumnName = "Valor Emolumentos";
                    dtbRegCiv.Columns[3].ColumnName = "RECOMPE";
                    dtbRegCiv.Columns[4].ColumnName = "TFJ";

                    dtgConfSelosRegCiv.DataSource = dtbRegCiv.DefaultView;

                    dtbNotas.Columns.Add();
                    dtbNotas.Columns.Add();
                    dtbNotas.Columns.Add();
                    double totalCustasNotas = 0;
                    for (int i = 0; i < dtbNotas.Rows.Count; i++)
                    {
                        dtbNotas.Rows[i][0] = dtbNotas.Rows[i][0].ToString().Remove(4);
                        //MessageBox.Show(dtbNotas.Rows[i][0].ToString() + "   " + dtbNotas.Rows[i][1].ToString());

                        emolUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "EMOLUMBRUTO", ano.ToString()).ToString());
                        recompeUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "RECOMPE", ano.ToString()).ToString());
                        tfjUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "TFJ", ano.ToString()).ToString());
                        qtd = int.Parse(dtbNotas.Rows[i][1].ToString());
                        dtbNotas.Rows[i][2] = (qtd * emolUnit); // acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
                        dtbNotas.Rows[i][3] = (qtd * recompeUnit);
                        dtbNotas.Rows[i][4] = (qtd * tfjUnit);

                        //dtbNotas.Rows[i][2] = acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
                        totalCustasNotas += Double.Parse(dtbNotas.Rows[i][2].ToString());
                        totalRecompe += Double.Parse(dtbNotas.Rows[i][3].ToString());
                        totalTFJ += Double.Parse(dtbNotas.Rows[i][4].ToString());
                    }
                    dtbNotas.Columns[0].ColumnName = "Código do Ato";
                    dtbNotas.Columns[1].ColumnName = "Quantidade";
                    dtbNotas.Columns[2].ColumnName = "Valor Emolumentos";
                    dtbNotas.Columns[3].ColumnName = "RECOMPE";
                    dtbNotas.Columns[4].ColumnName = "TFJ";


                    dtgConfSelosNotas.DataSource = dtbNotas.DefaultView;

                    lblConfSelosTotalEmolRegCivValor.Text = "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalCustasRegCiv.ToString());
                    lblConfSelosTotalEmolNotasValor.Text = "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalCustasNotas.ToString());
                    double totalGeral = totalCustasNotas + totalCustasRegCiv;
                    lblConfSelosTotalGeralEmolumentosValor.Text = "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalGeral.ToString());
                    lblConfSelosTotalGeralRecompeValor.Text = "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalRecompe.ToString());
                    lblConfSelosTotalGeralTFJValor.Text = "R$ " + ConverteStringParaStringContabil.ConverteDouble(totalTFJ.ToString());


                    //lblConfSelosValorEmolValor.Text = acessoDB3.consultaEmolumentos(codigoAto,"EMOLUMBRUTO");
                    //grpConfSelosTotalCustas.Visible = true;







                    //MessageBox.Show(acessoDB3.SQLBulkInsert(dtb));
                    acessoDB3.CloseConn();
                    //acessoDB2.CloseConn();

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
            //    double emolUnit;
            //    double recompeUnit;
            //    double tfjUnit;
            //    int qtd;

            //    double totalTFJ = 0;
            //    double totalRecompe = 0;

            //    dtbRegCiv.Columns.Add();
            //    dtbRegCiv.Columns.Add();
            //    dtbRegCiv.Columns.Add();
            //    double totalCustasRegCiv = 0;
            //    for (int i = 0; i < dtbRegCiv.Rows.Count; i++)
            //    {
            //        emolUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "EMOLUMBRUTO", ano.ToString()).ToString());
            //        recompeUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "RECOMPE", ano.ToString()).ToString());
            //        tfjUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "TFJ", ano.ToString()).ToString());
            //        qtd = int.Parse(dtbRegCiv.Rows[i][1].ToString());
            //        dtbRegCiv.Rows[i][2] = (qtd * emolUnit); // acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
            //        dtbRegCiv.Rows[i][3] = (qtd * recompeUnit);
            //        dtbRegCiv.Rows[i][4] = (qtd * tfjUnit);

            //        totalCustasRegCiv += Double.Parse(dtbRegCiv.Rows[i][2].ToString());
            //        totalRecompe += Double.Parse(dtbRegCiv.Rows[i][3].ToString());
            //        totalTFJ += Double.Parse(dtbRegCiv.Rows[i][4].ToString());
            //    }
            //    dtbRegCiv.Columns[0].ColumnName = "Código do Ato";
            //    dtbRegCiv.Columns[1].ColumnName = "Quantidade";
            //    dtbRegCiv.Columns[2].ColumnName = "Valor Emolumentos";
            //    dtbRegCiv.Columns[3].ColumnName = "RECOMPE";
            //    dtbRegCiv.Columns[4].ColumnName = "TFJ";

            //    dtgConfSelosRegCiv.DataSource = dtbRegCiv.DefaultView;

            //    dtbNotas.Columns.Add();
            //    dtbNotas.Columns.Add();
            //    dtbNotas.Columns.Add();
            //    double totalCustasNotas = 0;
            //    for (int i = 0; i < dtbNotas.Rows.Count; i++)
            //    {
            //        dtbNotas.Rows[i][0] = dtbNotas.Rows[i][0].ToString().Remove(4);

            //        emolUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "EMOLUMBRUTO", ano.ToString()).ToString());
            //        recompeUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "RECOMPE", ano.ToString()).ToString());
            //        tfjUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "TFJ", ano.ToString()).ToString());
            //        qtd = int.Parse(dtbNotas.Rows[i][1].ToString());
            //        dtbNotas.Rows[i][2] = (qtd * emolUnit); // acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
            //        dtbNotas.Rows[i][3] = (qtd * recompeUnit);
            //        dtbNotas.Rows[i][4] = (qtd * tfjUnit);

            //        //dtbNotas.Rows[i][2] = acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
            //        totalCustasNotas += Double.Parse(dtbNotas.Rows[i][2].ToString());
            //        totalRecompe += Double.Parse(dtbNotas.Rows[i][3].ToString());
            //        totalTFJ += Double.Parse(dtbNotas.Rows[i][4].ToString());
            //    }
            //    dtbNotas.Columns[0].ColumnName = "Código do Ato";
            //    dtbNotas.Columns[1].ColumnName = "Quantidade";
            //    dtbNotas.Columns[2].ColumnName = "Valor Emolumentos";
            //    dtbNotas.Columns[3].ColumnName = "RECOMPE";
            //    dtbNotas.Columns[4].ColumnName = "TFJ";


            //    dtgConfSelosNotas.DataSource = dtbNotas.DefaultView;

            //    lblConfSelosTotalEmolRegCivValor.Text = "R$ " + totalCustasRegCiv.ToString();
            //    lblConfSelosTotalEmolNotasValor.Text = "R$ " + totalCustasNotas.ToString();
            //    double totalGeral = totalCustasNotas + totalCustasRegCiv;
            //    lblConfSelosTotalGeralEmolumentosValor.Text = "R$ " + totalGeral.ToString();
            //    lblConfSelosTotalGeralRecompeValor.Text = "R$ " + totalRecompe.ToString();
            //    lblConfSelosTotalGeralTFJValor.Text = "R$ " + totalTFJ.ToString();


        }

        private void gbxConfSelosTotalConsultas_Enter(object sender, EventArgs e)
        {

        }
    }
}
