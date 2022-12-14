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
    public partial class frmInputDialog : Form
    {
        double recBruto = 0;
        double descIR = 0;
        double txRecivil = 0;
        double recLiq = 0;
        public frmInputDialog()
        {
            InitializeComponent();
        }

        private void frmInputDialogOK_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("-"+frmInputDialogMskRecBruto.Text.Remove(0,3).Trim()+"-");

            if (!Double.TryParse(frmInputDialogNumberBoxValorBruto.Text, out recBruto) || !Double.TryParse(frmInputDialogNumberBoxDescontoIR.Text, out descIR) || !Double.TryParse(frmInputDialogNumberBoxTaxaRecivil.Text, out txRecivil) || !Double.TryParse(frmInputDialogNumberBoxValorLiquidoDepositado.Text, out recLiq))
            {
                MessageBox.Show("Valores inválidos, digite novamente.");
                return;
            }
            //recBruto = Convert.ToDouble(frmInputDialogNumberBoxValorBruto.Text.Trim());
            //descIR = Convert.ToDouble(frmInputDialogNumberBoxDescontoIR.Text.Trim());
            //txRecivil = Convert.ToDouble(frmInputDialogNumberBoxTaxaRecivil.Text.Trim());
            //recLiq = Convert.ToDouble(frmInputDialogNumberBoxValorLiquidoDepositado.Text.Trim());
            if (recBruto <= 0 || descIR <= 0 || txRecivil <= 0 || recLiq <= 0)
            {
                MessageBox.Show("Valores inválidos, digite novamente.");
                //MessageBox.Show(recBruto + "\n" + descIR + "\n" + txRecivil + "\n" + recLiq);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
        public double returnValue(int index)
        {
            if (index == 1)
            {
                return recBruto;
            }
            else if (index == 2)
            {
                return descIR;
            }
            else if (index == 3)
            {
                return txRecivil;
            }
            else if (index == 4)
            {
                return recLiq;
            }
            return 0;
        }

        private string valorFormatado(string valor)
        {
            string retorno = valor.Trim();
            retorno = retorno.Replace(".", "");
            if (retorno.Length < 1)
            {
                return "";
            }
            else if (retorno.Length == 1)
            {
                return "0,0" + retorno;
            }
            else if (retorno.Length == 2)
            {
                return "0," + retorno;
            }

            int indexVirgula = retorno.Length - 2;
            retorno = retorno.Insert(indexVirgula, ",");
            //MessageBox.Show(retorno);
            return retorno;
        }
    }
}
