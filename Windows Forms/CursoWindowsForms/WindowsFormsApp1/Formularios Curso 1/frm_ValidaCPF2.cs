using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca;

namespace WindowsFormsApp1
{
    public partial class frm_ValidaCPF2 : Form
    {
        public frm_ValidaCPF2()
        {
            InitializeComponent();
        }

        private void btn_Valida_Click(object sender, EventArgs e)
        {
            var conteudoTexto = msk_CPF.Text;
            conteudoTexto = conteudoTexto.Replace(".", "").Replace("-", "");
            conteudoTexto = conteudoTexto.Trim();
            //MessageBox.Show(">"+conteudoTexto+"<", "Conteúdo Texto", MessageBoxButtons.OK);

            if (!conteudoTexto.Equals(""))
            {
                if (conteudoTexto.Length != 11)
                {
                    MessageBox.Show("CPF deve ter 11 dígitos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("Você deseja realmente validar o CPF?", "Mensagem de Validação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool validaCPF = false;
                    validaCPF = Cls_Uteis.Valida(msk_CPF.Text);
                    if (validaCPF)
                    {
                        MessageBox.Show("CPF VÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("CPF INVÁLIDO", "Mensagem de Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Campo CPF está vazio !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_Limpa_Click(object sender, EventArgs e)
        {
            msk_CPF.Text = "";
        }

        private void frm_ValidaCPF2_Load(object sender, EventArgs e)
        {

        }
    }
}
