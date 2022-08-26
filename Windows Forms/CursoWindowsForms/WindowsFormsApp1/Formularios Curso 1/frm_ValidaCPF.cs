using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_ValidaCPF : Form
    {
        public frm_ValidaCPF()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = Cls_Uteis.Valida(msk_CPF.Text);
            if (validaCPF)
            {
                lbl_Resultado.Text = "CPF VÁLIDO";
                lbl_Resultado.ForeColor = Color.Green;
            }
            else 
            {
                lbl_Resultado.Text = "CPF INVÁLIDO";
                lbl_Resultado.ForeColor = Color.Red;
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            lbl_Resultado.Text = "";
            msk_CPF.Text = "";
        }

        private void frm_ValidaCPF_Load(object sender, EventArgs e)
        {

        }
    }
}
