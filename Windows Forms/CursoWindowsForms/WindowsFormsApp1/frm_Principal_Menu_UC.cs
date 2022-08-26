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
    public partial class frm_Principal_Menu_UC : Form
    {
        public frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }
        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_UC = new frm_Demonstracao_UC();
            frm_UC.Dock= DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Demonstração Key (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.Text = "Demonstração Key (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.ImageIndex = 0;
            TB.Controls.Add(frm_UC);
            tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_UC = new frm_HelloWorld_UC();
            frm_UC.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Hello World (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.Text = "Hello World (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.ImageIndex = 1;
            TB.Controls.Add(frm_UC);
            tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_UC = new frm_Mascara_UC();
            frm_UC.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Mascara (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.Text = "Mascara (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.ImageIndex = 1;
            TB.Controls.Add(frm_UC);
            tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_UC = new frm_ValidaCPF_UC();
            frm_UC.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Valida CPF (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.Text = "Valida CPF (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.ImageIndex = 1;
            TB.Controls.Add(frm_UC);
            tbc_Aplicacoes.TabPages.Add(TB);
        }
        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_UC = new frm_ValidaCPF2_UC();
            frm_UC.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Valida CPF 2 (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.Text = "Valida CPF 2 (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.ImageIndex = 1;
            TB.Controls.Add(frm_UC);
            tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var frm_UC = new frm_ValidaSenha_UC();
            frm_UC.Dock = DockStyle.Fill;
            var TB = new TabPage();
            TB.Name = "Valida Senha (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.Text = "Valida Senha (" + (tbc_Aplicacoes.TabCount + 1) + ")";
            TB.ImageIndex = 1;
            TB.Controls.Add(frm_UC);
            tbc_Aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_Principal_Menu_Load(object sender, EventArgs e)
        {

        }

        private void mnu_Principal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tbc_Aplicacoes.TabCount > 0)
            {
                tbc_Aplicacoes.TabPages.Remove(tbc_Aplicacoes.SelectedTab);

                for (int i = 0; i < tbc_Aplicacoes.TabCount; i++)
                {
                    string texto = tbc_Aplicacoes.TabPages[i].Text;
                    texto = texto.Remove(texto.IndexOf('(') + 1);
                    texto = texto + (i + 1) + ")";
                    tbc_Aplicacoes.TabPages[i].Text = texto;
                    tbc_Aplicacoes.TabPages[i].Name = texto;
                }
            }
        }
    }
}

