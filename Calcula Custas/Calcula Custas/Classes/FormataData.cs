using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcula_Custas.Classes
{
    internal class FormataData
    {
        private DateTime dataDateTime;
        private string dataMesDiaAno;
        private string dataAnoMesDia;
        private string dataAnoDiaMes;
        public FormataData(string Data)
        {
            dataDateTime = Convert.ToDateTime(Data);
            dataMesDiaAno = converteData(1);
            dataAnoMesDia = converteData(2);
            dataAnoDiaMes = converteData(3);
        }
        public FormataData(DateTime Data)
        {
            dataDateTime = Data;
            dataMesDiaAno = converteData(1);
            dataAnoMesDia = converteData(2);
            dataAnoDiaMes = converteData(3);
        }

        private string converteData(int tipoFormatacao)
        {
            // mes/dia/ano   ou ano/mes/dia  ou  ano/dia/mes
            string dataFormatada = "";
            string dia = dataDateTime.Day.ToString();
            string mes = dataDateTime.Month.ToString();
            string ano = dataDateTime.Year.ToString();
            if (tipoFormatacao == 1)
            {
                dataFormatada = mes + "-" + dia + "-" + ano;
                return dataFormatada;
            }
            if (tipoFormatacao == 2)
            {
                dataFormatada = ano + "-" + mes + "-" + dia;
                return dataFormatada;
            }
            if (tipoFormatacao == 3)
            {
                dataFormatada = ano + "-" + dia + "-" + mes;
                return dataFormatada;
            }
            return "";
        }
        public string GetDataFormatada(int tipoFormatacao)
        {
            if (tipoFormatacao == 1)
            {
                return dataMesDiaAno;
            }
            if (tipoFormatacao == 2)
            {
                return dataAnoMesDia;
            }
            if (tipoFormatacao == 3)
            {
                return dataAnoDiaMes;
            }
            return "";
        }
        public static string getInicioEFimDoMes(string anomes,bool diaInicial)
        {
            string mes = anomes.Substring(4);
            string ano = anomes.Substring(0, 4);


            string dataInicial = "";
            string dataFinal = "";

            int anoInt = int.Parse(ano);
            int mesInt = int.Parse(mes);

            string diaFinal = "";



            int[] meses30 = new int[4] { 4, 6, 9, 11 };
            int[] meses31 = new int[7] { 1, 3, 5, 7, 8, 10, 12 };


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

            dataInicial = "01-" + mes + "-" + ano;
            dataFinal = diaFinal + "-" + mes + "-" + ano;

            if(diaInicial)
            {
                return dataInicial;
            }
            return dataFinal;
        }

    }
}
