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
    public partial class frmRelatorioConsultaSelosBDInterno : UserControl
    {
        public frmRelatorioConsultaSelosBDInterno()
        {
            InitializeComponent();
            frmRelatorioConsultaSelosCmbCodigoAto.SelectedIndex = (frmRelatorioConsultaSelosCmbCodigoAto.Items.Count - 1);

        }






        private void alteraSelosBDMskSeloInicial_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            frmRelatorioConsultaSelosMskDataInicial.Text = "";

        }





        private void alteraSelosBDBtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Enabled = true;
                DateTime dataInicial;// = Convert.ToDateTime(frmRelatorioConsultaSelosMskDataInicial.Text);
                DateTime dataFinal;

                if (!frmRelatorioConsultaSelosMskDataInicial.MaskCompleted || !DateTime.TryParse(frmRelatorioConsultaSelosMskDataInicial.Text, out dataInicial))
                {
                    MessageBox.Show("Digite uma data válida no campo Data Inicial", "Erro", MessageBoxButtons.OK);
                    return;
                }


                if (!frmRelatorioConsultaSelosMskDataFinal.MaskCompleted || !DateTime.TryParse(frmRelatorioConsultaSelosMskDataFinal.Text, out dataFinal))
                {
                    MessageBox.Show("Digite uma data válida no campo Data Final", "Erro", MessageBoxButtons.OK);
                    return;
                }
                dataFinal = Convert.ToDateTime(frmRelatorioConsultaSelosMskDataFinal.Text+" 23:59:59");

                string codigoAto = "";
                if (frmRelatorioConsultaSelosCmbCodigoAto.SelectedIndex != (frmRelatorioConsultaSelosCmbCodigoAto.Items.Count - 1))
                {
                    codigoAto = frmRelatorioConsultaSelosCmbCodigoAto.Items[frmRelatorioConsultaSelosCmbCodigoAto.SelectedIndex].ToString();

                }



                //DateTime dataInicial = Convert.ToDateTime(frmRelatorioConsultaSelosMskDataInicial.Text);
                //DateTime dataFinal = Convert.ToDateTime(frmRelatorioConsultaSelosMskDataFinal.Text);

                //MessageBox.Show("Datas : " + dataInicial + dataFinal);
                //return;





                frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Visible = true;


                //string periodoFB = "SAN4540.DATAHIST >= '" + inicial + "' AND SAN4540.DATAHIST <= '" + final + "'";
                //string periodoODBC = ">= '" + inicial + "' and DT_USO_SELO <= '" + final + "'";





                //FbConnection conexao = new FbConnection(@"Data Source=localhost;Database=D:\bkp BDs cart\SAN.fdb;User ID=SYSDBA;password=masterkey");

                //FbCommand sqlQuery = new FbCommand("select * from SAN4520 where SELOSEQ = 2245", conexao);

                try
                {
                    //string sqlDB = "SELECT SAN4540.SELO, SAN7510.CODIGO, SAN4540.DATAHIST, SAN4540.LIVRO, SAN4540.FOLHA, SAN4540.STATUS FROM SAN4540, SAN7510 WHERE SAN4540.TIPSEQ = SAN7510.TIPSEQ AND SAN4540.DATAHIST >= '" + dataInicialFormatada.GetDataFormatada(true) + "' AND SAN4540.DATAHIST <= '" + dataFinalFormatada.GetDataFormatada(true) + "' and SAN4540.STATUS = 1 AND SAN4540.TIPOISENTO is null ORDER BY SAN4540.DATAHIST";
                    //string sqlODBC = "SELECT nu_selo, cd_ato, DT_PRATICA, nu_termo, cd_situacao FROM se_selos where cd_situacao = 1 and TIPO_TRIBUTACAO = 1 and DT_PRATICA >= '" + dataInicialFormatada.GetDataFormatada(false) + "' and DT_PRATICA < '" + dataFinalFormatada.GetDataFormatada(false) + "' order by DT_PRATICA";
                    string SQL = "";
                    if (codigoAto != "")
                    {
                        SQL = "SELECT * FROM SELOSATOS WHERE CODATO = '" + codigoAto + "' AND (TRIBUTACAO = '1' OR TRIBUTACAO = '' OR TRIBUTACAO IS NULL) AND DATAPRATICA >= '" + dataInicial + "' AND DATAPRATICA <= '" + dataFinal + "' ORDER BY CAST(DATAPRATICA AS DATE), SELO";
                    }
                    else
                    {
                        SQL = "SELECT * FROM SELOSATOS WHERE (TRIBUTACAO = '1' OR TRIBUTACAO = '' OR TRIBUTACAO IS NULL) AND DATAPRATICA >= '" + dataInicial + "' AND DATAPRATICA <= '" + dataFinal + "' ORDER BY CAST(DATAPRATICA AS DATE), SELO";
                    }
                    if (frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico.Checked)
                    {

                        SQL = SQL.Replace("*", "CAST(DATAPRATICA AS DATE), CODATO");
                        int indiceInsert = SQL.IndexOf("CODATO");
                        SQL = SQL.Insert(indiceInsert + 6, ", COUNT(*)");
                        indiceInsert = SQL.IndexOf("ORDER");
                        SQL = SQL.Insert(indiceInsert, "GROUP BY CAST(DATAPRATICA AS DATE), CODATO ");
                        indiceInsert = SQL.IndexOf(", SELO");
                        SQL = SQL.Remove(indiceInsert);
                        //SQL = SQL + " GROUP BY CODATO";

                    }

                    var acessoDB3 = new DBAccess(3);
                    MessageBox.Show(SQL);
                    DataTable consultaBD = acessoDB3.SQLQuery(SQL);
                    if (frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico.Checked)
                    {
                        consultaBD.Columns[0].ColumnName = "Data";
                        consultaBD.Columns[2].ColumnName = "Quantidade";
                    }
                    frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.DataSource = consultaBD.DefaultView;





                    acessoDB3.CloseConn();


                    //        DataTable dtbNotas = acessoDB1.SQLQuery(sqlFB);
                    //MessageBox.Show("mark");
                    //        DataTable dtbRegCiv = acessoDB2.SQLQuery(sqlODBC);


                    //        string selo = "";
                    //        string codato = "";
                    //        string datapratica = "";
                    //        string termo = "";
                    //        string folha = "";
                    //        string status = "";
                    //        string sqlReplace = "";


                    //        for (int i = 0; i < dtbNotas.Rows.Count; i++)
                    //        {
                    //            selo = dtbNotas.Rows[i][0].ToString();
                    //            codato = dtbNotas.Rows[i][1].ToString();
                    //            datapratica = dtbNotas.Rows[i][2].ToString();
                    //            termo = dtbNotas.Rows[i][3].ToString();
                    //            folha = dtbNotas.Rows[i][4].ToString();
                    //            status = dtbNotas.Rows[i][5].ToString();

                    //            sqlReplace = "INSERT INTO SELOSATOS (SELO, CODATO, DATAPRATICA, TERMO, FOLHA, SUBSTITUIUSELO) VALUES (" + selo + ", " + codato + ", " + datapratica + ", " + termo + ", " + folha + ")";
                    //            //MessageBox.Show("SQL REPLACE: "+sqlReplace);
                    //            acessoDB3.SQLReplace(selo, codato, datapratica, termo, folha, status);
                    //        }

                    //        selo = "";
                    //        codato = "";
                    //        datapratica = "";
                    //        termo = "";
                    //        folha = "";
                    //        status = "";

                    //        for (int i = 0; i < dtbRegCiv.Rows.Count; i++)
                    //        {
                    //            selo = dtbRegCiv.Rows[i][0].ToString();
                    //            codato = dtbRegCiv.Rows[i][1].ToString();
                    //            datapratica = dtbRegCiv.Rows[i][2].ToString();
                    //            termo = dtbRegCiv.Rows[i][3].ToString();
                    //            status = dtbRegCiv.Rows[i][4].ToString();

                    //            sqlReplace = "SELOSATOS(SELO, CODATO, DATAPRATICA, TERMO) VALUES ('" + selo + "', '" + codato + "', '" + datapratica + "', '" + termo + "')";
                    //            //MessageBox.Show("SQL REPLACE: "+sqlReplace);
                    //            acessoDB3.SQLReplace(selo, codato, datapratica, termo, "", status);
                    //        }


                    //        //sqlReplaceODBC = "REPLACE INTO SELOSATOS (SELO, CODATO, DATAPRATICA, TERMO, FOLHA, SUBSTITUIUSELO) VALUES (" + selo + ", " + codato + ", " + datapratica + ", " + termo + ", " + folha + ")";




                    //        dtbNotas = acessoDB1.SQLQuery(sqlCountFB);
                    //        dtbRegCiv = acessoDB2.SQLQuery(sqlCountODBC);

                    //        dtgConfSelosNotas.DataSource = dtbNotas.DefaultView;
                    //        dtgConfSelosRegCiv.DataSource = dtbRegCiv.DefaultView;

                    //        acessoDB1.CloseConn();
                    //        acessoDB2.CloseConn();

                    //        //var acessoDB3 = new DBAccess(3);
                    //        //acessoDB2 = new DBAccess(2);

                    //        double emolUnit;
                    //        double recompeUnit;
                    //        double tfjUnit;
                    //        int qtd;

                    //        double totalTFJ = 0;
                    //        double totalRecompe = 0;

                    //        dtbRegCiv.Columns.Add();
                    //        dtbRegCiv.Columns.Add();
                    //        dtbRegCiv.Columns.Add();
                    //        double totalCustasRegCiv = 0;
                    //        for (int i = 0; i < dtbRegCiv.Rows.Count; i++)
                    //        {
                    //            emolUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "EMOLUMBRUTO", ano.ToString()).ToString());
                    //            recompeUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "RECOMPE", ano.ToString()).ToString());
                    //            tfjUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "TFJ", ano.ToString()).ToString());
                    //            qtd = int.Parse(dtbRegCiv.Rows[i][1].ToString());
                    //            dtbRegCiv.Rows[i][2] = (qtd * emolUnit); // acessoDB3.consultaEmolumentos(dtbRegCiv.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
                    //            dtbRegCiv.Rows[i][3] = (qtd * recompeUnit);
                    //            dtbRegCiv.Rows[i][4] = (qtd * tfjUnit);

                    //            totalCustasRegCiv += Double.Parse(dtbRegCiv.Rows[i][2].ToString());
                    //            totalRecompe += Double.Parse(dtbRegCiv.Rows[i][3].ToString());
                    //            totalTFJ += Double.Parse(dtbRegCiv.Rows[i][4].ToString());
                    //        }
                    //        dtbRegCiv.Columns[0].ColumnName = "Código do Ato";
                    //        dtbRegCiv.Columns[1].ColumnName = "Quantidade";
                    //        dtbRegCiv.Columns[2].ColumnName = "Valor Emolumentos";
                    //        dtbRegCiv.Columns[3].ColumnName = "RECOMPE";
                    //        dtbRegCiv.Columns[4].ColumnName = "TFJ";

                    //        dtgConfSelosRegCiv.DataSource = dtbRegCiv.DefaultView;

                    //        dtbNotas.Columns.Add();
                    //        dtbNotas.Columns.Add();
                    //        dtbNotas.Columns.Add();
                    //        double totalCustasNotas = 0;
                    //        for (int i = 0; i < dtbNotas.Rows.Count; i++)
                    //        {
                    //            dtbNotas.Rows[i][0] = dtbNotas.Rows[i][0].ToString().Remove(4);

                    //            emolUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "EMOLUMBRUTO", ano.ToString()).ToString());
                    //            recompeUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "RECOMPE", ano.ToString()).ToString());
                    //            tfjUnit = Double.Parse(acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "TFJ", ano.ToString()).ToString());
                    //            qtd = int.Parse(dtbNotas.Rows[i][1].ToString());
                    //            dtbNotas.Rows[i][2] = (qtd * emolUnit); // acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
                    //            dtbNotas.Rows[i][3] = (qtd * recompeUnit);
                    //            dtbNotas.Rows[i][4] = (qtd * tfjUnit);

                    //            //dtbNotas.Rows[i][2] = acessoDB3.consultaEmolumentos(dtbNotas.Rows[i][0].ToString(), "EMOLUMBRUTO").ToString();
                    //            totalCustasNotas += Double.Parse(dtbNotas.Rows[i][2].ToString());
                    //            totalRecompe += Double.Parse(dtbNotas.Rows[i][3].ToString());
                    //            totalTFJ += Double.Parse(dtbNotas.Rows[i][4].ToString());
                    //        }
                    //        dtbNotas.Columns[0].ColumnName = "Código do Ato";
                    //        dtbNotas.Columns[1].ColumnName = "Quantidade";
                    //        dtbNotas.Columns[2].ColumnName = "Valor Emolumentos";
                    //        dtbNotas.Columns[3].ColumnName = "RECOMPE";
                    //        dtbNotas.Columns[4].ColumnName = "TFJ";


                    //        dtgConfSelosNotas.DataSource = dtbNotas.DefaultView;

                    //        lblConfSelosTotalEmolRegCivValor.Text = "R$ " + totalCustasRegCiv.ToString();
                    //        lblConfSelosTotalEmolNotasValor.Text = "R$ " + totalCustasNotas.ToString();
                    //        double totalGeral = totalCustasNotas + totalCustasRegCiv;
                    //        lblConfSelosTotalGeralEmolumentosValor.Text = "R$ " + totalGeral.ToString();
                    //        lblConfSelosTotalGeralRecompeValor.Text = "R$ " + totalRecompe.ToString();
                    //        lblConfSelosTotalGeralTFJValor.Text = "R$ " + totalTFJ.ToString();
                    //        //lblConfSelosValorEmolValor.Text = acessoDB3.consultaEmolumentos(codigoAto,"EMOLUMBRUTO");
                    //        //grpConfSelosTotalCustas.Visible = true;







                    //        //MessageBox.Show(acessoDB3.SQLBulkInsert(dtb));
                    //        acessoDB3.CloseConn();
                    //        //acessoDB2.CloseConn();

                }
                catch (Exception ex)
                {
                    throw new Exception("Erro: " + ex.Message, ex);
                }




                //    //var msg = "Index " + cbConfSelosSemana.SelectedIndex + " selecionado !";
                //    //MessageBox.Show(msg, "erro ", MessageBoxButtons.OK);




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de Exceção: " + ex.Message, "Erro de Exceção");
            }
            ////MessageBox.Show("msg: " + int.Parse(mskFrmConfSeloANO.Text), "msg: " + int.Parse(mskFrmConfSeloANO.Text));
        }

        private void alteraSelosBDBtnAlterar_Click(object sender, EventArgs e)
        {
            int linhasTabela = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.RowCount;
            if (linhasTabela < 1)
            {
                //MessageBox.Show(alteraSelosBDDtgConsulta.RowCount.ToString());
                return;
            }

            string selo = "";
            string codato = "";
            string datapratica = "";
            string termo = "";
            string folha = "";
            string substituiSelo = "";
            string status = "";
            string tributacao = "";

            var acessoDB3 = new DBAccess(3);

            for (int i = 0; i < (linhasTabela); i++)
            {
                selo = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Rows[i].Cells[0].Value.ToString();
                codato = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Rows[i].Cells[1].Value.ToString();
                datapratica = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Rows[i].Cells[2].Value.ToString();
                termo = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Rows[i].Cells[3].Value.ToString();
                folha = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Rows[i].Cells[4].Value.ToString();
                substituiSelo = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Rows[i].Cells[5].Value.ToString();
                status = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Rows[i].Cells[6].Value.ToString();
                tributacao = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Rows[i].Cells[7].Value.ToString();

                acessoDB3.SQLReplace(selo, codato, datapratica, termo, folha, substituiSelo, status, tributacao);
            }
            acessoDB3.CloseConn();
            MessageBox.Show("Registros alterados com sucesso!");
            return;
        }

        private void alteraSelosBDDtgConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.BeginEdit(true);

        }

        private void alteraSelosBDDtgConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            //alteraSelosBDDtgConsulta.CurrentCell.Value = alteraSelosBDDtgConsulta.CurrentCell.EditedFormattedValue;
            //MessageBox.Show(alteraSelosBDDtgConsulta.CurrentCell.Value.ToString());
        }

        private void alteraSelosBDBtnAtualizar_Click(object sender, EventArgs e)
        {
            frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.CurrentCell.Value = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.CurrentCell.EditedFormattedValue;
            frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Update();
        }

        private void alteraSelosBDDtgConsulta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.CurrentCell.Value = frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.CurrentCell.EditedFormattedValue;

        }

        private void alteraSelosBDMskSeloInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (frmRelatorioConsultaSelosMskDataInicial.Text == "Selo Inicial")
            {
                //frmRelatorioConsultaSelosMskDataInicial.Text = "";
                //frmRelatorioConsultaSelosMskDataInicial.Mask = "LLL00000";
            }
        }

        private void alteraSelosBDMskSeloInicial_MouseClick(object sender, MouseEventArgs e)
        {

            frmRelatorioConsultaSelosMskDataInicial.SelectionStart = 0;

            //alteraSelosBDMskSeloInicial.Text = "";
            //frmRelatorioConsultaSelosMskDataInicial.Mask = "LLL00000";
        }

        private void frmRelatorioConsultaSelosMskDataFinal_MouseClick(object sender, MouseEventArgs e)
        {

            frmRelatorioConsultaSelosMskDataFinal.SelectionStart = 0;

        }

        private void frmRelatorioConsultaSelosMskDataInicial_Enter(object sender, EventArgs e)
        {
            frmRelatorioConsultaSelosMskDataInicial.SelectionStart = 0;
        }

        private void frmRelatorioConsultaSelosMskDataFinal_Enter(object sender, EventArgs e)
        {
            frmRelatorioConsultaSelosMskDataFinal.SelectionStart = 0;
        }

        private void frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
