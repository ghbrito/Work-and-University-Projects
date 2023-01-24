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
    public partial class frmMainMenu : Form
    {

        public frmMainMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.BackgroundImage = imageList1.Images[0];
            this.BackgroundImageLayout = ImageLayout.Center;

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }



        public void FecharAba()
        {
            tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFrmMainMenuFecharAba_Click(object sender, EventArgs e)
        {
            if (tbcApplications.TabCount > 0)
            {
                switch (tbcApplications.SelectedTab.Text)
                {
                    case "Conferência de Selos BDI":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        menuOptConfSelosBDI.Enabled = true;
                        break;
                    case "Importar Atos SAN / CARTOSOFT":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        menuOptConfSelos.Enabled = true;
                        break;
                    case "Atualizar Valores da Tabela":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        menuOptAbrirArquivo.Enabled = true;
                        break;
                    case "Importar Atos do Banco de Dados":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        toolStripMenuImportarAtos.Enabled = true;
                        break;
                    case "Consultar e Alterar Selos":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        toolStripMenuConsultarAlterarSelos.Enabled = true;
                        break;
                    case "Inclusão de Selo Avulso":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        incluirSeloAvulsoToolStripMenuItem.Enabled = true;
                        break;
                    case "Gerar Relatório Contabilidade":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        menuOptRelatorioMensalContabilidade.Enabled = true;
                        break;
                    case "Utilização de Selos":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        menuOptRelatorioUtilizacaoDeSelos.Enabled = true;
                        break;
                    case "Ler Despesas PDF":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        menuOptImportarDespesasPDF.Enabled = true;
                        break;
                    case "Gerar Livro Caixa":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        menuOptLivroCaixa.Enabled = true;
                        break;
                    case "Relatório Semestral CNJ":
                        tbcApplications.TabPages.Remove(tbcApplications.SelectedTab);
                        menuOptCNJSemestral.Enabled = true;
                        break;


                        


                    default:

                        break;
                }
                if (tbcApplications.TabCount == 0)
                {
                    tbcApplications.Visible = false;
                    btnFrmMainMenuFecharAba.Visible = false;
                }
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            menuOptAbrirArquivo.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmAtualizarValoresTabelas f = new frmAtualizarValoresTabelas();
            TabPage tp = new TabPage();
            tp.Text = "Atualizar Valores da Tabela";
            tp.Name = "Atualizar Valores da Tabela";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            toolStripMenuImportarAtos.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmImportaDadosBD f = new frmImportaDadosBD();
            TabPage tp = new TabPage();
            tp.Text = "Importar Atos do Banco de Dados";
            tp.Name = "Importar Atos do Banco de Dados";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;
        }

        private void teste1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string principal = "8101-5";
            string cortada = principal.TrimEnd('-');
            //string cortada2 = principal.Remove('-');
            string cortada2 = principal.Length.ToString();
            string cortada3 = principal.Remove(4);
            MessageBox.Show("String principal: " + principal + "\nString c1: " + cortada + "\nString c2: " + cortada2 + "\nString c3: " + cortada3);
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            toolStripMenuConsultarAlterarSelos.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmAlteraSelosBDInterno f = new frmAlteraSelosBDInterno();
            TabPage tp = new TabPage();
            tp.Text = "Consultar e Alterar Selos";
            tp.Name = "Consultar e Alterar Selos";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;

        }

        private void tbcApplications_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_2(object sender, EventArgs e)
        {
            menuOptRelatorioMensalContabilidade.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmGerarRelatorioContabilidade f = new frmGerarRelatorioContabilidade();
            TabPage tp = new TabPage();
            tp.Text = "Gerar Relatório Contabilidade";
            tp.Name = "Gerar Relatório Contabilidade";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;
        }

        private void conferênciaSelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuOptConfSelos.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmConferenciaSelosUC f = new frmConferenciaSelosUC();
            TabPage tp = new TabPage();
            tp.Text = "Importar Atos SAN / CARTOSOFT";
            tp.Name = "Importar Atos SAN / CARTOSOFT";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            menuOptConfSelosBDI.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmConfereSelosBDInterno f = new frmConfereSelosBDInterno();
            TabPage tp = new TabPage();
            tp.Text = "Conferência de Selos BDI";
            tp.Name = "Conferência de Selos BDI";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;

        }

        private void incluirSeloAvulsoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            incluirSeloAvulsoToolStripMenuItem.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmIncluirSeloAvulso f = new frmIncluirSeloAvulso();
            TabPage tp = new TabPage();
            tp.Text = "Inclusão de Selo Avulso";
            tp.Name = "Inclusão de Selo Avulso";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;
        }

        private void utilizaçãoDeSelosBDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuOptRelatorioUtilizacaoDeSelos.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmRelatorioConsultaSelosBDInterno f = new frmRelatorioConsultaSelosBDInterno();
            TabPage tp = new TabPage();
            tp.Text = "Utilização de Selos";
            tp.Name = "Utilização de Selos";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;
        }

        private void menuOptImportarDespesasPDF_Click(object sender, EventArgs e)
        {
            menuOptImportarDespesasPDF.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmLerDespesasPDF f = new frmLerDespesasPDF();
            TabPage tp = new TabPage();
            tp.Text = "Ler Despesas PDF";
            tp.Name = "Ler Despesas PDF";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;
        }

        private void menuOptLivroCaixa_Click(object sender, EventArgs e)
        {
            menuOptLivroCaixa.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmGerarLivroCaixaImpressao f = new frmGerarLivroCaixaImpressao();
            TabPage tp = new TabPage();
            tp.Text = "Gerar Livro Caixa";
            tp.Name = "Gerar Livro Caixa";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;
        }

        private void cNJSemestralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuOptCNJSemestral.Enabled = false;
            btnFrmMainMenuFecharAba.Visible = true;
            frmGerarRelatorioSemestralCNJ f = new frmGerarRelatorioSemestralCNJ();
            TabPage tp = new TabPage();
            tp.Text = "Relatório Semestral CNJ";
            tp.Name = "Relatório Semestral CNJ";
            tp.Controls.Add(f);
            tbcApplications.TabPages.Add(tp);
            tbcApplications.SelectedTab = tp;
            tbcApplications.Visible = true;
        }
    }
}
