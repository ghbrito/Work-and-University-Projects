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
    public partial class frmGerarRelatorioContabilidade : UserControl
    {
        DataTable dtRelatorioMensal;
        DataTable codAtoPorDiaMensal;
        DataTable dtCustasTotalDiarioPorCod;
        DataTable despesas;
        DataTable emolumentoTotalPorDia;
        string nomeArquivo;
        string anomes;
        public frmGerarRelatorioContabilidade()
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
            if (gerarRelatorioContabilidadeCmbMes.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione uma opção válida no campo MÊS", "Erro", MessageBoxButtons.OK);
                return;
            }
            anomes = "";
            if ((gerarRelatorioContabilidadeCmbMes.SelectedIndex + 1) < 10)
            {
                anomes = (gerarRelatorioContabilidadeMaskAno.Text + "0" + (gerarRelatorioContabilidadeCmbMes.SelectedIndex + 1).ToString());
            }
            else
            {
                anomes = (gerarRelatorioContabilidadeMaskAno.Text + (gerarRelatorioContabilidadeCmbMes.SelectedIndex + 1).ToString());
            }
            //MessageBox.Show("ANOMES = " + anomes);
            //DataTable dt;
            DBAccess dbA3 = new DBAccess(3);
            if (dbA3.KeyExists(anomes, "CONSOLIDACAOMENSAL", "ANOMES"))
            {

                string sql = "SELECT * FROM CONSOLIDACAOMENSAL WHERE ANOMES = '" + anomes + "'";
                string mes = anomes.Substring(4);
                string ano = anomes.Substring(0, 4);
                nomeArquivo = "Relatório Contabilidade - Ano " + ano + " - Mês " + mes + ".pdf";
                dtRelatorioMensal = dbA3.SQLQuery(sql);
                //MessageBox.Show("mes existe na tabela");
                btnGerarRelatorioContabilidadeSalvarPDF.Visible = true;
                dtRelatorioMensal.Columns[0].MaxLength = 50;


                string dataInicial = FormataData.getInicioEFimDoMes(anomes, true);
                string dataFinal = FormataData.getInicioEFimDoMes(anomes, false);

                int anoInt = int.Parse(ano);
                int mesInt = int.Parse(mes);

                ConsultaDadosBDInterno consulta = new ConsultaDadosBDInterno();

                codAtoPorDiaMensal = consulta.consultaCodatoPorDiaMensal(anomes);

                dtCustasTotalDiarioPorCod = consulta.consultaCustasTotalDiarioPorCodMensal(anomes);

                despesas = consulta.consultaDespesasMensal(anomes);

                string despesasSalvasBD = dtRelatorioMensal.Rows[0][10].ToString();

                if (despesasSalvasBD == "" || despesasSalvasBD == "0")
                {
                    MessageBox.Show("Despesas não constam no BD Interno.\nRecuperando dados da tabela de despesas.");
                    double totalDespesas = consulta.consultaDespesaTotalMensal(anomes);

                    dtRelatorioMensal.Rows[0][10] = totalDespesas.ToString();
                }

                //gerarRelatorioContabilidadeDtgAtos.DataSource = dtCustasTotalDiarioPorCod.DefaultView;

                DataTable despesasFormatada = new DataTable();
                despesasFormatada.Columns.Add("Data");
                despesasFormatada.Columns.Add("Descrição");
                despesasFormatada.Columns.Add("Valor");
                for (int i = 0; i < despesas.Rows.Count; i++)
                {
                    despesasFormatada.Rows.Add(despesas.Rows[i][1].ToString().Substring(0, 10), despesas.Rows[i][2], despesas.Rows[i][3]);
                }
                //despesasFormatada.Columns.Add(despesas.Rows.);


                despesasFormatada.Rows.Add(despesas.Rows);


                gerarRelatorioContabilidadeDtgDespesas.DataSource = despesasFormatada.DefaultView;





                var agrupado = dtCustasTotalDiarioPorCod.AsEnumerable().GroupBy(f => f.Field<string>("DATA")).Select(f => new { DATA = f.Key, EMOLBRUTO = f.Sum(s => s.Field<double>("EMOLBRUTO")), EMOLLIQ = f.Sum(s => s.Field<double>("EMOLLIQ")), RECOMPE = f.Sum(s => s.Field<double>("RECOMPE")), TFJ = f.Sum(s => s.Field<double>("TFJ")), ISSQN = f.Sum(s => s.Field<double>("ISSQN")) });
                //MessageBox.Show(agrupado.GetType().ToString());
                emolumentoTotalPorDia = new DataTable();



                emolumentoTotalPorDia.Columns.Add("DATA", Type.GetType("System.String"));
                emolumentoTotalPorDia.Columns.Add("EMOLBRUTOTOTAL", Type.GetType("System.Double"));
                emolumentoTotalPorDia.Columns.Add("EMOLLIQTOTAL", Type.GetType("System.Double"));
                emolumentoTotalPorDia.Columns.Add("RECOMPE", Type.GetType("System.Double"));
                emolumentoTotalPorDia.Columns.Add("TFJ", Type.GetType("System.Double"));
                emolumentoTotalPorDia.Columns.Add("ISSQN", Type.GetType("System.Double"));

                //MessageBox.Show(agrupado.Count().ToString());

                double emolBrutoMensal = 0;
                double emolLiqMensal = 0;
                double recompeMensal = 0;
                double tfjMensal = 0;
                double issqnMensal = 0;

                foreach (var dia in agrupado)
                {

                    emolumentoTotalPorDia.Rows.Add(dia.DATA, ConverteStringParaStringContabil.ConverteDouble(dia.EMOLBRUTO), ConverteStringParaStringContabil.ConverteDouble(dia.EMOLLIQ), ConverteStringParaStringContabil.ConverteDouble(dia.RECOMPE), ConverteStringParaStringContabil.ConverteDouble(dia.TFJ), ConverteStringParaStringContabil.ConverteDouble(dia.ISSQN));
                    emolBrutoMensal += dia.EMOLBRUTO;
                    emolLiqMensal += dia.EMOLLIQ;
                    recompeMensal += dia.RECOMPE;
                    tfjMensal += dia.TFJ;
                    issqnMensal += dia.ISSQN;

                    //MessageBox.Show("Data: " + dia.DATA + " EMOL TOTAL: " + dia.EMOLLIQ);
                }
                double recBruto = 0;
                double descIR = 0;
                double txRecivil = 0;
                double recLiq = 0;

                gerarRelatorioContabilidadeDtgAtos.DataSource = emolumentoTotalPorDia.DefaultView;

                for (int i = 1; i < gerarRelatorioContabilidadeDtgAtos.Columns.Count; i++)
                {
                    gerarRelatorioContabilidadeDtgAtos.Columns[i].Width = 120;
                }
                gerarRelatorioContabilidadeDtgDespesas.Columns[0].Width = 70;
                gerarRelatorioContabilidadeDtgDespesas.Columns[1].Width = 220;
                gerarRelatorioContabilidadeDtgDespesas.Columns[2].Width = 60;


            }
            else
            {
                btnGerarRelatorioContabilidadeSalvarPDF.Visible = false;
                dtRelatorioMensal = new DataTable();
                dtRelatorioMensal.Columns.Add("ANOMES");
                dtRelatorioMensal.Columns.Add("TOTALEMOLBRUTO");
                dtRelatorioMensal.Columns.Add("TOTALEMOLLIQ");
                dtRelatorioMensal.Columns.Add("TOTALRECOMPE");
                dtRelatorioMensal.Columns.Add("TOTALTFJ");
                dtRelatorioMensal.Columns.Add("TOTALISSQN");
                dtRelatorioMensal.Columns.Add("COMPBRUTO");
                dtRelatorioMensal.Columns.Add("COMPLIQ");
                dtRelatorioMensal.Columns.Add("COMPDESCONTOIR");
                dtRelatorioMensal.Columns.Add("COMPTXRECIVIL");
                dtRelatorioMensal.Columns.Add("TOTALDESPESAS");
                dtRelatorioMensal.Columns.Add("QTDATOS");
                MessageBox.Show("mes ainda não existe na tabela");

                //string anomes = dtRelatorioMensal.Rows[0][0].ToString();
                string mes = anomes.Substring(4);
                string ano = anomes.Substring(0, 4);
                nomeArquivo = "Relatório Contabilidade - Ano " + ano + " - Mês " + mes + ".pdf";
                //MessageBox.Show(dt.Columns[0].MaxLength.ToString());
                dtRelatorioMensal.Columns[0].MaxLength = 50;


                string dataInicial = FormataData.getInicioEFimDoMes(anomes, true);
                string dataFinal = FormataData.getInicioEFimDoMes(anomes, false);

                int anoInt = int.Parse(ano);
                int mesInt = int.Parse(mes);

                //string diaFinal = "";



                //int[] meses30 = new int[4] { 4, 6, 9, 11 };
                //int[] meses31 = new int[7] { 1, 3, 5, 7, 8, 10, 12 };


                //if (meses30.Contains(mesInt))
                //{
                //    diaFinal = "30";
                //}
                //else
                //{
                //    if (meses31.Contains(mesInt))
                //    {
                //        diaFinal = "31";
                //    }
                //    else
                //    {
                //        if ((anoInt % 4) == 0)
                //        {
                //            diaFinal = "29";
                //        }
                //        else
                //        {
                //            diaFinal = "28";
                //        }
                //    }
                //}

                //dataInicial = "01-" + mes + "-" + ano;
                //dataFinal = diaFinal + "-" + mes + "-" + ano;

                //string sqlCountCodatoPorDia = "select CODATO, CAST(DATAPRATICA as DATE), COUNT(*) from SELOSATOS where (TRIBUTACAO = '1' OR TRIBUTACAO = '' OR TRIBUTACAO IS NULL) AND DATAPRATICA >= '" + dataInicial + " 00:00:00' and DATAPRATICA <= '" + dataFinal + " 23:59:59' group by CODATO, CAST(DATAPRATICA as DATE) order by CAST(DATAPRATICA as DATE)";

                //DataTable emolDias = new DataTable();

                //DBAccess db3 = new DBAccess(3);


                //emolDias = db3.SQLQuery(sqlCountCodatoPorDia);


                //// string emolTotalDia = "";
                ////MessageBox.Show("gettype do double : "+emolUnitario.GetType());

                //emolDias.Columns.Add();
                //emolDias.Columns.Add();
                //emolDias.Columns[1].ColumnName = "DATADATETIME";
                //emolDias.Columns[2].ColumnName = "QTD";
                //emolDias.Columns[3].ColumnName = "DATASTRING";
                //emolDias.Columns[4].ColumnName = "EMOL";

                //dtEmolTotalDiario = new DataTable();

                //dtEmolTotalDiario.Columns.Add("DATA", Type.GetType("System.String"));
                //dtEmolTotalDiario.Columns.Add("EMOLBRUTO", Type.GetType("System.Double"));
                //dtEmolTotalDiario.Columns.Add("EMOLLIQ", Type.GetType("System.Double"));
                //dtEmolTotalDiario.Columns.Add("RECOMPE", Type.GetType("System.Double"));
                //dtEmolTotalDiario.Columns.Add("TFJ", Type.GetType("System.Double"));
                //dtEmolTotalDiario.Columns.Add("ISSQN", Type.GetType("System.Double"));

                //double emolBrutoUnitario = 0;
                //double emolLiqUnitario = 0;
                //double recompeUnitario = 0;
                //double tfjUnitario = 0;
                //double issqnUnitario = 0;
                //double qtd = 0;

                //for (int i = 0; i < emolDias.Rows.Count; i++)
                //{

                //    emolBrutoUnitario = Convert.ToDouble(db3.consultaEmolumentos(emolDias.Rows[i][0].ToString(), "EMOLUMBRUTO", ano));
                //    emolLiqUnitario = Convert.ToDouble(db3.consultaEmolumentos(emolDias.Rows[i][0].ToString(), "EMOLUMLIQ", ano));
                //    tfjUnitario = Convert.ToDouble(db3.consultaEmolumentos(emolDias.Rows[i][0].ToString(), "TFJ", ano));
                //    recompeUnitario = Convert.ToDouble(db3.consultaEmolumentos(emolDias.Rows[i][0].ToString(), "RECOMPE", ano));
                //    issqnUnitario = Convert.ToDouble(db3.consultaEmolumentos(emolDias.Rows[i][0].ToString(), "ISSQN", ano));
                //    //emolTotalDia = int.Parse(emolDias.Rows[i][2].ToString()) ;

                //    emolDias.Rows[i][3] = emolDias.Rows[i][1].ToString();
                //    emolDias.Rows[i][4] = Convert.ToDouble(emolLiqUnitario * Double.Parse(emolDias.Rows[i][2].ToString()));
                //    qtd = Double.Parse(emolDias.Rows[i][2].ToString());
                //    //MessageBox.Show(emolDias.Rows[i][4]+" Cod "+ emolDias.Rows[i][0].ToString()+" - qtd: "+ emolDias.Rows[i][2].ToString());
                //    dtEmolTotalDiario.Rows.Add(emolDias.Rows[i][3], Convert.ToDouble(emolBrutoUnitario * qtd), Convert.ToDouble(emolLiqUnitario * qtd), Convert.ToDouble(recompeUnitario * qtd), Convert.ToDouble(tfjUnitario * qtd), Convert.ToDouble(issqnUnitario * qtd));

                //}

                ConsultaDadosBDInterno consulta = new ConsultaDadosBDInterno();

                codAtoPorDiaMensal = consulta.consultaCodatoPorDiaMensal(anomes);

                dtCustasTotalDiarioPorCod = consulta.consultaCustasTotalDiarioPorCodMensal(anomes);

                despesas = consulta.consultaDespesasMensal(anomes);

                double totalDespesas = consulta.consultaDespesaTotalMensal(anomes);

                //gerarRelatorioContabilidadeDtgAtos.DataSource = dtCustasTotalDiarioPorCod.DefaultView;

                DataTable despesasFormatada = new DataTable();
                despesasFormatada.Columns.Add("Data");
                despesasFormatada.Columns.Add("Descrição");
                despesasFormatada.Columns.Add("Valor");
                for (int i = 0; i < despesas.Rows.Count; i++)
                {
                    despesasFormatada.Rows.Add(despesas.Rows[i][1].ToString().Substring(0, 10), despesas.Rows[i][2], despesas.Rows[i][3]);
                }
                //despesasFormatada.Columns.Add(despesas.Rows.);


                despesasFormatada.Rows.Add(despesas.Rows);


                gerarRelatorioContabilidadeDtgDespesas.DataSource = despesasFormatada.DefaultView;



                //SQL query para consultar as despesas do mês
                //string SQL = "SELECT * FROM DESPESAS WHERE DATA >= '" + dataInicial + "' and DATA <= '" + dataFinal + "'";
                //despesas = db3.SQLQuery(SQL);
                //for (int i = 0; i < despesas.Rows.Count; i++)
                //{
                //    totalDespesas += Convert.ToDouble(despesas.Rows[i][3]);
                //}

                //MessageBox.Show("Total despesas: "+totalDespesas);





                //db3.CloseConn();




                var agrupado = dtCustasTotalDiarioPorCod.AsEnumerable().GroupBy(f => f.Field<string>("DATA")).Select(f => new { DATA = f.Key, EMOLBRUTO = f.Sum(s => s.Field<double>("EMOLBRUTO")), EMOLLIQ = f.Sum(s => s.Field<double>("EMOLLIQ")), RECOMPE = f.Sum(s => s.Field<double>("RECOMPE")), TFJ = f.Sum(s => s.Field<double>("TFJ")), ISSQN = f.Sum(s => s.Field<double>("ISSQN")) });
                //MessageBox.Show(agrupado.GetType().ToString());
                emolumentoTotalPorDia = new DataTable();



                emolumentoTotalPorDia.Columns.Add("DATA", Type.GetType("System.String"));
                emolumentoTotalPorDia.Columns.Add("EMOLBRUTOTOTAL", Type.GetType("System.Double"));
                emolumentoTotalPorDia.Columns.Add("EMOLLIQTOTAL", Type.GetType("System.Double"));
                emolumentoTotalPorDia.Columns.Add("RECOMPE", Type.GetType("System.Double"));
                emolumentoTotalPorDia.Columns.Add("TFJ", Type.GetType("System.Double"));
                emolumentoTotalPorDia.Columns.Add("ISSQN", Type.GetType("System.Double"));

                //MessageBox.Show(agrupado.Count().ToString());

                double emolBrutoMensal = 0;
                double emolLiqMensal = 0;
                double recompeMensal = 0;
                double tfjMensal = 0;
                double issqnMensal = 0;

                foreach (var dia in agrupado)
                {

                    emolumentoTotalPorDia.Rows.Add(dia.DATA, ConverteStringParaStringContabil.ConverteDouble(dia.EMOLBRUTO), ConverteStringParaStringContabil.ConverteDouble(dia.EMOLLIQ), ConverteStringParaStringContabil.ConverteDouble(dia.RECOMPE), ConverteStringParaStringContabil.ConverteDouble(dia.TFJ), ConverteStringParaStringContabil.ConverteDouble(dia.ISSQN));
                    emolBrutoMensal += dia.EMOLBRUTO;
                    emolLiqMensal += dia.EMOLLIQ;
                    recompeMensal += dia.RECOMPE;
                    tfjMensal += dia.TFJ;
                    issqnMensal += dia.ISSQN;

                    //MessageBox.Show("Data: " + dia.DATA + " EMOL TOTAL: " + dia.EMOLLIQ);
                }
                double recBruto = 0;
                double descIR = 0;
                double txRecivil = 0;
                double recLiq = 0;

                gerarRelatorioContabilidadeDtgAtos.DataSource = emolumentoTotalPorDia.DefaultView;

                for (int i = 1; i < gerarRelatorioContabilidadeDtgAtos.Columns.Count; i++)
                {
                    gerarRelatorioContabilidadeDtgAtos.Columns[i].Width = 120;
                }
                gerarRelatorioContabilidadeDtgDespesas.Columns[0].Width = 70;
                gerarRelatorioContabilidadeDtgDespesas.Columns[1].Width = 220;
                gerarRelatorioContabilidadeDtgDespesas.Columns[2].Width = 60;

                using (var form = new frmInputDialog())
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        recBruto = form.returnValue(1);            //values preserved after close
                        descIR = form.returnValue(2);
                        txRecivil = form.returnValue(3);
                        recLiq = form.returnValue(4);

                    }
                }


                dtRelatorioMensal.Rows.Add(anomes, emolBrutoMensal, emolLiqMensal, recompeMensal, tfjMensal, issqnMensal, recBruto, recLiq, descIR, txRecivil, totalDespesas, 0);

                //dtRelatorioMensal.Rows[1][0] = anomes;
                //dtRelatorioMensal.Rows[1][1] = emolBrutoMensal;
                //dtRelatorioMensal.Rows[1][2] = emolLiqMensal;
                //dtRelatorioMensal.Rows[1][3] = recompeMensal;
                //dtRelatorioMensal.Rows[1][4] = tfjMensal;
                //dtRelatorioMensal.Rows[1][5] = issqnMensal;
                //dtRelatorioMensal.Rows[1][6] = recBruto;
                //dtRelatorioMensal.Rows[1][7] = recLiq;
                //dtRelatorioMensal.Rows[1][8] = descIR;
                //dtRelatorioMensal.Rows[1][9] = txRecivil;

                //dtRelatorioMensal.Rows[1][10] = 0;
                //dtRelatorioMensal.Rows[1][11] = 0;

                //dtRelatorioMensal.Columns.Add("ANOMES");
                //dtRelatorioMensal.Columns.Add("TOTALEMOLBRUTO");
                //dtRelatorioMensal.Columns.Add("TOTALEMOLLIQ");
                //dtRelatorioMensal.Columns.Add("TOTALRECOMPE");
                //dtRelatorioMensal.Columns.Add("TOTALTFJ");
                //dtRelatorioMensal.Columns.Add("TOTALISSQN");
                //dtRelatorioMensal.Columns.Add("COMPBRUTO");
                //dtRelatorioMensal.Columns.Add("COMPLIQ");
                //dtRelatorioMensal.Columns.Add("COMPDESCONTOIR");
                //dtRelatorioMensal.Columns.Add("COMPTXRECIVIL");
                //dtRelatorioMensal.Columns.Add("TOTALDESPESAS");
                //dtRelatorioMensal.Columns.Add("QTDATOS");


            }

            dbA3.CloseConn();
            gerarRelatorioContabilidadeDtg.DataSource = dtRelatorioMensal.DefaultView;

            gerarRelatorioContabilidadeDtg.Visible = true;
            gerarRelatorioContabilidadeDtgAtos.Visible = true;
            gerarRelatorioContabilidadeDtgDespesas.Visible = true;
            buttonGerarRelatorioContabilidadeSalvar.Visible = true;
            frmGerarRelatorioContabilidadeLblAtosPagos.Visible = true;
            frmGerarRelatorioContabilidadeLblDespesas.Visible = true;

        }

        private void buttonGerarRelatorioContabilidadeSalvar_Click(object sender, EventArgs e)
        {
            //int linhasTabela = incluirSelosBDDtgConsulta.RowCount;
            //if (linhasTabela < 1)
            //{
            //    MessageBox.Show(incluirSelosBDDtgConsulta.RowCount.ToString());
            //    return;
            //}

            if (Double.TryParse(dtRelatorioMensal.Rows[0][10].ToString(), out double desp))
            {
                if (desp < 1)
                {
                    ConsultaDadosBDInterno consulta = new ConsultaDadosBDInterno();
                    dtRelatorioMensal.Rows[0][10] = consulta.consultaDespesaTotalMensal(anomes);
                }
            }

            var acessoDB3 = new DBAccess(3);


            string[] colunas = new string[12];
            for (int i = 0; i < colunas.Length; i++)
            {
                colunas[i] = gerarRelatorioContabilidadeDtg.Columns[i].HeaderText;
            }

            string[] valores = new string[12];
            for (int i = 0; i < valores.Length; i++)
            {
                valores[i] = gerarRelatorioContabilidadeDtg.Rows[0].Cells[i].Value.ToString();
            }

            acessoDB3.SQLReplaceGenerico(valores[0], "CONSOLIDACAOMENSAL", colunas, valores);

            acessoDB3.CloseConn();
            MessageBox.Show("Registros incluídos com sucesso!");
            btnGerarRelatorioContabilidadeSalvarPDF.Visible = true;
            return;
        }

        private void btnGerarRelatorioContabilidadeSalvarPDF_Click(object sender, EventArgs e)
        {
            //OpenFileDialog dlg = new OpenFileDialog();
            //var dlg = new FolderPicker();
            //FolderBrowserDialog dlg = new FolderBrowserDialog();
            //dlg.Filter = "PDF Files|*.pdf";
            //dlg.FilterIndex = 1;
            //dlg.SelectedPath
            //dlg.ShowDialog();

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

            //= dlg.;




            //MessageBox.Show(caminhoArquivo);

            //select CODATO, CAST(DATAPRATICA as DATE), COUNT(*) from SELOSATOS where (TRIBUTACAO = '1' OR TRIBUTACAO = '' OR TRIBUTACAO IS NULL) AND DATAPRATICA > '01-09-2022' and DATAPRATICA <= '14-09-2022' group by CODATO, CAST(DATAPRATICA as DATE) order by CAST(DATAPRATICA as DATE)


            //string anomes = dtRelatorioMensal.Rows[0][0].ToString();
            //string mes = anomes.Substring(4);
            //string ano = anomes.Substring(0, 4);
            //string nomeArquivo = "Relatório Contabilidade - Ano " + ano + " - Mês " + mes + ".pdf";
            ////MessageBox.Show(dt.Columns[0].MaxLength.ToString());
            //dtRelatorioMensal.Columns[0].MaxLength = 50;
            ////dt.Columns[1].
            ////dt.Rows[0][0] = nomeArquivo;
            ////nomeArquivo = nomeArquivo + ".pdf";
            ////MessageBox.Show("mes: "+mes+"\nano: "+ano);

            //string dataInicial = "";
            //string dataFinal = "";

            //int anoInt = int.Parse(ano);
            //int mesInt = int.Parse(mes);

            //string diaFinal = "";



            //int[] meses30 = new int[4] { 4, 6, 9, 11 };
            //int[] meses31 = new int[7] { 1, 3, 5, 7, 8, 10, 12 };


            //if (meses30.Contains(mesInt))
            //{
            //    diaFinal = "30";
            //}
            //else
            //{
            //    if (meses31.Contains(mesInt))
            //    {
            //        diaFinal = "31";
            //    }
            //    else
            //    {
            //        if ((anoInt % 4) == 0)
            //        {
            //            diaFinal = "29";
            //        }
            //        else
            //        {
            //            diaFinal = "28";
            //        }
            //    }
            //}

            //dataInicial = "01-" + mes + "-" + ano;
            //dataFinal = diaFinal + "-" + mes + "-" + ano;


            //string sqlCountCodatoPorDia = "select CODATO, CAST(DATAPRATICA as DATE), COUNT(*) from SELOSATOS where (TRIBUTACAO = '1' OR TRIBUTACAO = '' OR TRIBUTACAO IS NULL) AND DATAPRATICA >= '" + dataInicial + "' and DATAPRATICA <= '" + dataFinal + "' group by CODATO, CAST(DATAPRATICA as DATE) order by CAST(DATAPRATICA as DATE)";

            //DataTable emolDias = new DataTable();

            //DBAccess db3 = new DBAccess(3);


            //emolDias = db3.SQLQuery(sqlCountCodatoPorDia);

            //double emolUnitario = 0;
            //// string emolTotalDia = "";
            ////MessageBox.Show("gettype do double : "+emolUnitario.GetType());

            //emolDias.Columns.Add();
            //emolDias.Columns.Add();
            //emolDias.Columns[1].ColumnName = "DATADATETIME";
            //emolDias.Columns[2].ColumnName = "QTD";
            //emolDias.Columns[3].ColumnName = "EMOL";
            //emolDias.Columns[4].ColumnName = "DATASTRING";

            //dtEmolTotalDiario = new DataTable();

            //dtEmolTotalDiario.Columns.Add("DATA", Type.GetType("System.String"));

            //dtEmolTotalDiario.Columns.Add("EMOL", Type.GetType("System.Double"));

            ////dtEmolTotalDiario.Columns.Add("EMOL", Type.GetType("System.Double"));

            ////dtEmolTotalDiario.Columns.Add("EMOL", Type.GetType("System.Double"));

            ////dtEmolTotalDiario.Columns.Add("EMOL", Type.GetType("System.Double"));

            ////dtEmolTotalDiario.Columns.Add("EMOL", Type.GetType("System.Double"));


            ////dtRelatorioMensal.Columns.Add("TOTALEMOLBRUTO");
            ////dtRelatorioMensal.Columns.Add("TOTALEMOLLIQ");
            ////dtRelatorioMensal.Columns.Add("TOTALRECOMPE");
            ////dtRelatorioMensal.Columns.Add("TOTALTFJ");
            ////dtRelatorioMensal.Columns.Add("TOTALISSQN");
            ////dtRelatorioMensal.Columns.Add("COMPBRUTO");
            ////dtRelatorioMensal.Columns.Add("COMPLIQ");
            ////dtRelatorioMensal.Columns.Add("COMPDESCONTOIR");
            ////dtRelatorioMensal.Columns.Add("COMPTXRECIVIL");
            ////dtRelatorioMensal.Columns.Add("TOTALDESPESAS");
            ////dtRelatorioMensal.Columns.Add("QTDATOS");


            //for (int i = 0; i < emolDias.Rows.Count; i++)
            //{
            //    emolUnitario = Convert.ToDouble(db3.consultaEmolumentos(emolDias.Rows[i][0].ToString(), "EMOLUMLIQ", ano));
            //    //emolTotalDia = int.Parse(emolDias.Rows[i][2].ToString()) ;
            //    emolDias.Rows[i][3] = Convert.ToDouble(emolUnitario * Double.Parse(emolDias.Rows[i][2].ToString()));
            //    emolDias.Rows[i][4] = emolDias.Rows[i][1].ToString();
            //    //MessageBox.Show(emolDias.Rows[i][4]+" Cod "+ emolDias.Rows[i][0].ToString()+" - qtd: "+ emolDias.Rows[i][2].ToString());
            //    dtEmolTotalDiario.Rows.Add(emolDias.Rows[i][1].ToString(), Convert.ToDouble(emolUnitario * Double.Parse(emolDias.Rows[i][2].ToString())));

            //}
            //db3.CloseConn();

            //double emolTotalDoDia = 0;
            ////string dia = emolDias.Rows[i][1].ToString();
            //string dataProximaLinha = "";


            //var agrupado = dtEmolTotalDiario.AsEnumerable().GroupBy(f => f.Field<string>("DATA")).Select(f => new { DATA = f.Key, EMOLUMENTOS = f.Sum(s => s.Field<double>("EMOL")) });
            ////MessageBox.Show(agrupado.GetType().ToString());
            //DataTable emolumentoTotalPorDia = new DataTable();



            //emolumentoTotalPorDia.Columns.Add("DATA", Type.GetType("System.String"));
            //emolumentoTotalPorDia.Columns.Add("EMOLTOTAL", Type.GetType("System.Double"));

            ////MessageBox.Show(agrupado.Count().ToString());




            //foreach (var dia in agrupado)
            //{
            //    //emolumentoTotalPorDia.Rows[]
            //    emolumentoTotalPorDia.Rows.Add(dia.DATA,dia.EMOLUMENTOS);
            //    //emolumentoTotalPorDia.Rows.Add
            //    //MessageBox.Show("Data: " + dia.DATA + " EMOL TOTAL: " + dia.EMOLUMENTOS);
            //}









            //MessageBox.Show(nomeArquivo+caminhoArquivo);


            GerarPDF pdf = new GerarPDF(dtRelatorioMensal, codAtoPorDiaMensal, emolumentoTotalPorDia, nomeArquivo, caminhoArquivo);
            pdf.novoPDF();
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
            gerarRelatorioContabilidadeDtg.BeginEdit(true);

        }

        private void gerarRelatorioContabilidadeDtg_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            gerarRelatorioContabilidadeDtg.CurrentCell.Value = gerarRelatorioContabilidadeDtg.CurrentCell.EditedFormattedValue;
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
