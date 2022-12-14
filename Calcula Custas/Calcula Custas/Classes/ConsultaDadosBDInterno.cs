using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_Custas.Classes
{
    internal class ConsultaDadosBDInterno
    {
        private DBAccess dbAccessBDInterno;

        public ConsultaDadosBDInterno()
        {
            this.dbAccessBDInterno = new DBAccess(3);
        }

        public DataTable consultaDespesasMensal(string anomes)
        {
            DataTable dtRetorno = new DataTable();

            string dataInicial = FormataData.getInicioEFimDoMes(anomes, true);
            string dataFinal = FormataData.getInicioEFimDoMes(anomes, false);

            string SQL = "SELECT * FROM DESPESAS WHERE DATA >= '" + dataInicial + "' and DATA <= '" + dataFinal + "'";

            dtRetorno = dbAccessBDInterno.SQLQuery(SQL);

            return dtRetorno;
        }

        public double consultaDespesaTotalMensal(string anomes)
        {
            string dataInicial = FormataData.getInicioEFimDoMes(anomes, true);
            string dataFinal = FormataData.getInicioEFimDoMes(anomes, false);

            string SQL = "SELECT * FROM DESPESAS WHERE DATA >= '" + dataInicial + "' and DATA <= '" + dataFinal + "'";
            DataTable despesas = new DataTable();

            despesas = this.dbAccessBDInterno.SQLQuery(SQL);
            double totalDespesas = 0;

            for (int i = 0; i < despesas.Rows.Count; i++)
            {
                totalDespesas += Convert.ToDouble(despesas.Rows[i][3]);
            }

            return totalDespesas;
        }

        public DataTable consultaCodatoPorDiaMensal(string anomes)
        {
            DataTable codAtoPorDiaMensal = new DataTable();
            string dataInicial = FormataData.getInicioEFimDoMes(anomes, true);
            string dataFinal = FormataData.getInicioEFimDoMes(anomes, false);

            string sqlCountCodatoPorDia = "select CODATO, CAST(DATAPRATICA as DATE), COUNT(*) from SELOSATOS where (TRIBUTACAO = '1' OR TRIBUTACAO = '' OR TRIBUTACAO IS NULL) AND DATAPRATICA >= '" + dataInicial + " 00:00:00' and DATAPRATICA <= '" + dataFinal + " 23:59:59' group by CODATO, CAST(DATAPRATICA as DATE) order by CAST(DATAPRATICA as DATE)";

            codAtoPorDiaMensal = this.dbAccessBDInterno.SQLQuery(sqlCountCodatoPorDia);

            codAtoPorDiaMensal.Columns.Add();
            codAtoPorDiaMensal.Columns.Add();
            codAtoPorDiaMensal.Columns[1].ColumnName = "DATADATETIME";
            codAtoPorDiaMensal.Columns[2].ColumnName = "QTD";
            codAtoPorDiaMensal.Columns[3].ColumnName = "DATASTRING";
            codAtoPorDiaMensal.Columns[4].ColumnName = "EMOL";

            return codAtoPorDiaMensal;
        }

        public DataTable consultaCustasTotalDiarioPorCodMensal(string anomes)
        {
            DataTable custasTotalDiarioPorCodMensal = new DataTable();
            DataTable codAtoPorDiaMensal = new DataTable();
            codAtoPorDiaMensal = this.consultaCodatoPorDiaMensal(anomes);

            string mes = anomes.Substring(4);
            string ano = anomes.Substring(0, 4);

            string dataInicial = FormataData.getInicioEFimDoMes(anomes, true);
            string dataFinal = FormataData.getInicioEFimDoMes(anomes, false);

            custasTotalDiarioPorCodMensal.Columns.Add("DATA", Type.GetType("System.String"));
            custasTotalDiarioPorCodMensal.Columns.Add("CODATO", Type.GetType("System.String"));
            custasTotalDiarioPorCodMensal.Columns.Add("QTD", Type.GetType("System.String"));
            custasTotalDiarioPorCodMensal.Columns.Add("EMOLBRUTO", Type.GetType("System.Double"));
            custasTotalDiarioPorCodMensal.Columns.Add("EMOLLIQ", Type.GetType("System.Double"));
            custasTotalDiarioPorCodMensal.Columns.Add("RECOMPE", Type.GetType("System.Double"));
            custasTotalDiarioPorCodMensal.Columns.Add("TFJ", Type.GetType("System.Double"));
            custasTotalDiarioPorCodMensal.Columns.Add("ISSQN", Type.GetType("System.Double"));

            double emolBrutoUnitario = 0;
            double emolLiqUnitario = 0;
            double recompeUnitario = 0;
            double tfjUnitario = 0;
            double issqnUnitario = 0;
            double qtd = 0;

            for (int i = 0; i < codAtoPorDiaMensal.Rows.Count; i++)
            {

                emolBrutoUnitario = Convert.ToDouble(this.dbAccessBDInterno.consultaEmolumentos(codAtoPorDiaMensal.Rows[i][0].ToString(), "EMOLUMBRUTO", ano));
                emolLiqUnitario = Convert.ToDouble(this.dbAccessBDInterno.consultaEmolumentos(codAtoPorDiaMensal.Rows[i][0].ToString(), "EMOLUMLIQ", ano));
                tfjUnitario = Convert.ToDouble(this.dbAccessBDInterno.consultaEmolumentos(codAtoPorDiaMensal.Rows[i][0].ToString(), "TFJ", ano));
                recompeUnitario = Convert.ToDouble(this.dbAccessBDInterno.consultaEmolumentos(codAtoPorDiaMensal.Rows[i][0].ToString(), "RECOMPE", ano));
                issqnUnitario = Convert.ToDouble(this.dbAccessBDInterno.consultaEmolumentos(codAtoPorDiaMensal.Rows[i][0].ToString(), "ISSQN", ano));

                codAtoPorDiaMensal.Rows[i][3] = codAtoPorDiaMensal.Rows[i][1].ToString();
                codAtoPorDiaMensal.Rows[i][4] = Convert.ToDouble(emolLiqUnitario * Double.Parse(codAtoPorDiaMensal.Rows[i][2].ToString()));
                qtd = Double.Parse(codAtoPorDiaMensal.Rows[i][2].ToString());
                custasTotalDiarioPorCodMensal.Rows.Add(codAtoPorDiaMensal.Rows[i][3].ToString().Remove(codAtoPorDiaMensal.Rows[i][3].ToString().IndexOf(" ")), codAtoPorDiaMensal.Rows[i][0], qtd, ConverteStringParaStringContabil.ConverteDouble(emolBrutoUnitario * qtd), ConverteStringParaStringContabil.ConverteDouble(emolLiqUnitario * qtd), ConverteStringParaStringContabil.ConverteDouble(recompeUnitario * qtd), ConverteStringParaStringContabil.ConverteDouble(tfjUnitario * qtd), ConverteStringParaStringContabil.ConverteDouble(issqnUnitario * qtd));
            }
            return custasTotalDiarioPorCodMensal;
        }

        public void Close()
        {
            this.dbAccessBDInterno.CloseConn();
        }
    }
}
