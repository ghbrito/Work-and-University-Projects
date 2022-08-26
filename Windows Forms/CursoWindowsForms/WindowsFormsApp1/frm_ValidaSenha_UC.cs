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
    public partial class frm_ValidaSenha_UC : UserControl
    {
        public frm_ValidaSenha_UC()
        {
            InitializeComponent();
        }

        private void Btn_MostrarSenha_Click(object sender, EventArgs e)
        {
            if (Txt_Senha.PasswordChar == '\0')
            {
                Txt_Senha.PasswordChar = '*';
                Btn_MostrarSenha.Text = "Mostrar Senha";
            }
            else
            {
                Txt_Senha.PasswordChar = '\0';
                Btn_MostrarSenha.Text = "Esconder Senha";
            }
        }

        private void Btn_MostrarSenha_Click(object sender, MouseEventArgs e)
        {
            while (e.Button == MouseButtons.Left)
            {
                Txt_Senha.PasswordChar = '\0';
            }
            Txt_Senha.PasswordChar = '*';
        }

        private void Btn_MostrarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            //Txt_Senha.UseSystemPasswordChar = false;

        }

        private void Btn_MostrarSenha_KeyUp(object sender, KeyEventArgs e)
        {
            //Txt_Senha.UseSystemPasswordChar = true;
            Txt_Senha.PasswordChar = '*';
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = "";
            Txt_Senha.Text = "";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            var verifica = new Cls_Uteis.ChecaForcaSenha();
            Cls_Uteis.ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();
            if (Lbl_Resultado.Text == "Inaceitavel" || Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor = Color.Red;
            }
            if (Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Blue;
            }
            if (Lbl_Resultado.Text == "Forte" || Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
        }
    }
}
