using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Class used to implement functions for formatting strings to be used when generating reports and PDFs
namespace Calcula_Custas.Classes
{
    internal class ConverteStringParaStringContabil
    {

        public static string Converte(string numeroOriginal)
        {
            return Convert.ToDouble(numeroOriginal, CultureInfo.GetCultureInfo("en-US")).ToString("#,##0.00", CultureInfo.GetCultureInfo("pt-BR"));
        }
        public static string ConverteDouble(string numeroOriginal)
        {
            return Convert.ToDouble(numeroOriginal, CultureInfo.GetCultureInfo("pt-BR")).ToString("#,##0.00", CultureInfo.GetCultureInfo("pt-BR"));
        }
        public static string ConverteDouble(double numeroOriginal)
        {
            return Convert.ToDouble(numeroOriginal.ToString(), CultureInfo.GetCultureInfo("pt-BR")).ToString("#,##0.00", CultureInfo.GetCultureInfo("pt-BR"));
        }
    }
}
