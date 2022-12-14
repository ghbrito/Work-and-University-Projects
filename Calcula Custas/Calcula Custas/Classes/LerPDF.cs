using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Globalization;

namespace Calcula_Custas.Classes
{
    internal class LerPDF
    {
        public LerPDF()
        {

        }

        public int numberOfPages(string path)
        {
            PdfReader reader = new PdfReader(path);
            return reader.NumberOfPages;
        }
        public string[] pdfText(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;

            int indexSearch = 0;
            string[] idValores = new string[9]
            {
                "valor total:",
                "Valor do pagamento (R$):",
                "valor:",
                "valor do pagamento:",
                "Valor do documento:",
                "valor recolhido:",
                "Valor Recolhido:",
                "total a pagar:",
                "Valor Total Recebido: R$"
            };
            string[] idDatas = new string[6]
            {
                "data da transferência:",
                "Data de pagamento:",
                "data do pagamento:",
                "pagar em:",
                "Operação efetuada em",
                "transação efetuada em"
            };

            string[] idNomePagamento = new string[7]
            {
                "Beneficiário:",
                "Identificação no extrato:",
                "nome do recebedor:",
                "GRF",
                "DOCUMENTO DE ARRECADACAO DO E-SOCIAL",
                "nome:",
                "dados do beneficiário"
            };

            //valores = new string[reader.NumberOfPages];
            //MessageBox.Show(reader.NumberOfPages.ToString());

            string[] valores = new string[reader.NumberOfPages];

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text = PdfTextExtractor.GetTextFromPage(reader, page);
                //MessageBox.Show("Pagina: " + page + "\n\n" + text);
                for (int i = 0; i < idValores.Length; i++)
                {
                    
                    //MessageBox.Show("idValores: " + idValores[i]);
                    //MessageBox.Show(page.ToString());
                    indexSearch = text.IndexOf(idValores[i]);
                    //text.IndexOf()
                    //MessageBox.Show("Index: " + indexSearch);
                    //MessageBox.Show("idValores[i].Lenght= " + idValores[i].Length);
                    //MessageBox.Show("valores lenght: "+valores.Length);

                    if (indexSearch > 0)
                    {
                        //MessageBox.Show("text rest: " + text.Substring(indexSearch));
                        //valores[page] = text.Substring(indexSearch + idValores[i].Length, 15);
                        //MessageBox.Show("idValores[i].Lenght= " + idValores[i].Length);
                        //MessageBox.Show(text.Substring(indexSearch + idValores[i].Length, 100));
                        
                        valores[page - 1] = text.Substring(indexSearch);
                        
                        //MessageBox.Show(valores[page].GetType().ToString());
                        //MessageBox.Show(valores.GetType().ToString());

                        valores[page - 1] = text.Substring(indexSearch);
                        if (i == 1)
                        {
                            if (valores[page-1].IndexOf(",") >= 0)
                            {
                                //MessageBox.Show("mark");
                                valores[page - 1] = valores[page - 1].Substring(valores[page - 1].IndexOf(",") - 7);
                                valores[page - 1] = valores[page - 1].Trim();
                                valores[page - 1] = valores[page - 1].Remove(valores[page - 1].IndexOf(",") + 3);
                                if (valores[page - 1].IndexOf(" ") >= 0)
                                {
                                    valores[page - 1] = valores[page - 1].Substring(valores[page - 1].IndexOf(" ") + 1);
                                }
                                //MessageBox.Show(valor);
                            }
                        }
                        else if (valores[page - 1].IndexOf("R$") >= 0)
                        {
                            valores[page - 1] = valores[page - 1].Substring(valores[page - 1].IndexOf("R$") + 3);
                            valores[page - 1] = valores[page - 1].Trim();
                            valores[page - 1] = valores[page - 1].Remove(valores[page - 1].IndexOf(",") + 3);
                            //MessageBox.Show(valor);


                        }
                        //MessageBox.Show("page: "+page+" - valor: "+valores[page-1]);
                    }
                    indexSearch = -1;
                }
            }
            reader.Close();
            return valores;


            //MessageBox.Show(valor);
            //return valor;
        }
    }
}