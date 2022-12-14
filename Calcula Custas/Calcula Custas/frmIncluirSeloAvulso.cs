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
    public partial class frmIncluirSeloAvulso : UserControl
    {
        public frmIncluirSeloAvulso()
        {
            InitializeComponent();
        }

        

        

        private void alteraSelosBDMskSeloInicial_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            incluirSelosQTD.Text = "";

        }

        private void alteraSelosBDMskSeloInicial_MouseClick(object sender, MouseEventArgs e)
        {
            //alteraSelosBDMskSeloInicial.Text = "";
            incluirSelosQTD.Mask = "000";
            incluirSelosQTD.SelectionStart = 0;
        }

        private void alteraSelosBDBtnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                incluirSelosBDDtgConsulta.Visible = false;
                alteraSelosBDBtnIncluir.Visible = false;

                if (incluirSelosQTD.Text == "" || int.Parse(incluirSelosQTD.Text) < 1 || incluirSelosQTD.Text.Contains(" "))
                {
                    MessageBox.Show("Digite um valor válido no campo Quantidade de Selos", "Erro", MessageBoxButtons.OK);
                    return;
                }

                int qtdSelos = int.Parse(incluirSelosQTD.Text);


                incluirSelosBDDtgConsulta.Visible = true;
                alteraSelosBDBtnIncluir.Visible = true;

                //string periodoFB = "SAN4540.DATAHIST >= '" + inicial + "' AND SAN4540.DATAHIST <= '" + final + "'";
                //string periodoODBC = ">= '" + inicial + "' and DT_USO_SELO <= '" + final + "'";





                //FbConnection conexao = new FbConnection(@"Data Source=localhost;Database=D:\bkp BDs cart\SAN.fdb;User ID=SYSDBA;password=masterkey");

                //FbCommand sqlQuery = new FbCommand("select * from SAN4520 where SELOSEQ = 2245", conexao);

                try
                {
                    //string sqlDB = "SELECT SAN4540.SELO, SAN7510.CODIGO, SAN4540.DATAHIST, SAN4540.LIVRO, SAN4540.FOLHA, SAN4540.STATUS FROM SAN4540, SAN7510 WHERE SAN4540.TIPSEQ = SAN7510.TIPSEQ AND SAN4540.DATAHIST >= '" + dataInicialFormatada.GetDataFormatada(true) + "' AND SAN4540.DATAHIST <= '" + dataFinalFormatada.GetDataFormatada(true) + "' and SAN4540.STATUS = 1 AND SAN4540.TIPOISENTO is null ORDER BY SAN4540.DATAHIST";
                    //string sqlODBC = "SELECT nu_selo, cd_ato, DT_PRATICA, nu_termo, cd_situacao FROM se_selos where cd_situacao = 1 and TIPO_TRIBUTACAO = 1 and DT_PRATICA >= '" + dataInicialFormatada.GetDataFormatada(false) + "' and DT_PRATICA < '" + dataFinalFormatada.GetDataFormatada(false) + "' order by DT_PRATICA";

                    //string SQL = "SELECT * FROM SELOSATOS WHERE SELO = '" + seloInicial + "'";
                    //var acessoDB3 = new DBAccess(3);
                    //MessageBox.Show("mark");
                    DataTable dt = new DataTable();
                    dt.Columns.Add("SELO");
                    dt.Columns.Add("CODATO");
                    dt.Columns.Add("DATAPRATICA");
                    dt.Columns.Add("TERMO");
                    dt.Columns.Add("FOLHA");
                    dt.Columns.Add("SUBSTITUISELO");
                    dt.Columns.Add("STATUS");
                    dt.Columns.Add("TRIBUTACAO");


                    for (int i = 0; i < qtdSelos; i++)
                    {
                        dt.Rows.Add();
                    }

                    incluirSelosBDDtgConsulta.DataSource = dt.DefaultView;





                    //acessoDB3.CloseConn();


                    //        DataTable dtbNotas = acessoDB1.SQLQuery(sqlFB);
                    //        //MessageBox.Show("mark");
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
            //MessageBox.Show("mark");
            int linhasTabela = incluirSelosBDDtgConsulta.RowCount;
            if (linhasTabela < 1)
            {
                MessageBox.Show(incluirSelosBDDtgConsulta.RowCount.ToString());
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
                selo = incluirSelosBDDtgConsulta.Rows[i].Cells[0].Value.ToString();
                codato = incluirSelosBDDtgConsulta.Rows[i].Cells[1].Value.ToString();
                datapratica = incluirSelosBDDtgConsulta.Rows[i].Cells[2].Value.ToString();
                termo = incluirSelosBDDtgConsulta.Rows[i].Cells[3].Value.ToString();
                folha = incluirSelosBDDtgConsulta.Rows[i].Cells[4].Value.ToString();
                substituiSelo = incluirSelosBDDtgConsulta.Rows[i].Cells[5].Value.ToString();
                status = incluirSelosBDDtgConsulta.Rows[i].Cells[6].Value.ToString();
                tributacao = incluirSelosBDDtgConsulta.Rows[i].Cells[7].Value.ToString();

                acessoDB3.SQLReplace(selo, codato, datapratica, termo, folha, substituiSelo, status, tributacao);
            }
            acessoDB3.CloseConn();
            MessageBox.Show("Registros incluídos com sucesso!");
            return;
        }

        private void alteraSelosBDDtgConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            incluirSelosBDDtgConsulta.BeginEdit(true);
        }

        private void alteraSelosBDDtgConsulta_KeyUp(object sender, KeyEventArgs e)
        {
            //alteraSelosBDDtgConsulta.CurrentCell.Value = alteraSelosBDDtgConsulta.CurrentCell.EditedFormattedValue;
            //MessageBox.Show(alteraSelosBDDtgConsulta.CurrentCell.Value.ToString());
        }

        private void alteraSelosBDBtnAtualizar_Click(object sender, EventArgs e)
        {
            incluirSelosBDDtgConsulta.Update();
        }

        private void alteraSelosBDDtgConsulta_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            incluirSelosBDDtgConsulta.CurrentCell.Value = incluirSelosBDDtgConsulta.CurrentCell.EditedFormattedValue;
        }
    }
}
