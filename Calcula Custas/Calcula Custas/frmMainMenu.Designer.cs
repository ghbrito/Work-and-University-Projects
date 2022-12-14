namespace Calcula_Custas
{
    partial class frmMainMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptConfSelosBDI = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptConfSelos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptAbrirArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuImportarAtos = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuConsultarAlterarSelos = new System.Windows.Forms.ToolStripMenuItem();
            this.incluirSeloAvulsoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptImportarDespesasPDF = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.relatóriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptRelatorioMensalContabilidade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptRelatorioUtilizacaoDeSelos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOptLivroCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.testesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teste1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbcApplications = new System.Windows.Forms.TabControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnFrmMainMenuFecharAba = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.relatóriosToolStripMenuItem,
            this.testesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptConfSelosBDI,
            this.menuOptConfSelos,
            this.menuOptAbrirArquivo,
            this.toolStripMenuImportarAtos,
            this.toolStripMenuConsultarAlterarSelos,
            this.incluirSeloAvulsoToolStripMenuItem,
            this.menuOptImportarDespesasPDF,
            this.toolStripMenuItem5});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(60, 24);
            this.toolStripMenuItem1.Text = "Menu";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuOptConfSelosBDI
            // 
            this.menuOptConfSelosBDI.Name = "menuOptConfSelosBDI";
            this.menuOptConfSelosBDI.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.C)));
            this.menuOptConfSelosBDI.Size = new System.Drawing.Size(319, 26);
            this.menuOptConfSelosBDI.Text = "Conferência Selos BDI";
            this.menuOptConfSelosBDI.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // menuOptConfSelos
            // 
            this.menuOptConfSelos.Name = "menuOptConfSelos";
            this.menuOptConfSelos.Size = new System.Drawing.Size(319, 26);
            this.menuOptConfSelos.Text = "Conferência Selos";
            this.menuOptConfSelos.Click += new System.EventHandler(this.conferênciaSelosToolStripMenuItem_Click);
            // 
            // menuOptAbrirArquivo
            // 
            this.menuOptAbrirArquivo.Name = "menuOptAbrirArquivo";
            this.menuOptAbrirArquivo.Size = new System.Drawing.Size(319, 26);
            this.menuOptAbrirArquivo.Text = "Atualizar Tabela de Emolumentos";
            this.menuOptAbrirArquivo.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuImportarAtos
            // 
            this.toolStripMenuImportarAtos.Name = "toolStripMenuImportarAtos";
            this.toolStripMenuImportarAtos.Size = new System.Drawing.Size(319, 26);
            this.toolStripMenuImportarAtos.Text = "Importar Atos do Banco de Dados";
            this.toolStripMenuImportarAtos.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuConsultarAlterarSelos
            // 
            this.toolStripMenuConsultarAlterarSelos.Name = "toolStripMenuConsultarAlterarSelos";
            this.toolStripMenuConsultarAlterarSelos.Size = new System.Drawing.Size(319, 26);
            this.toolStripMenuConsultarAlterarSelos.Text = "Consultar/Alterar Selos";
            this.toolStripMenuConsultarAlterarSelos.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // incluirSeloAvulsoToolStripMenuItem
            // 
            this.incluirSeloAvulsoToolStripMenuItem.Name = "incluirSeloAvulsoToolStripMenuItem";
            this.incluirSeloAvulsoToolStripMenuItem.Size = new System.Drawing.Size(319, 26);
            this.incluirSeloAvulsoToolStripMenuItem.Text = "Incluir Selo Avulso";
            this.incluirSeloAvulsoToolStripMenuItem.Click += new System.EventHandler(this.incluirSeloAvulsoToolStripMenuItem_Click);
            // 
            // menuOptImportarDespesasPDF
            // 
            this.menuOptImportarDespesasPDF.Name = "menuOptImportarDespesasPDF";
            this.menuOptImportarDespesasPDF.Size = new System.Drawing.Size(319, 26);
            this.menuOptImportarDespesasPDF.Text = "Importar Despesas PDF";
            this.menuOptImportarDespesasPDF.Click += new System.EventHandler(this.menuOptImportarDespesasPDF_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(319, 26);
            this.toolStripMenuItem5.Text = "Sair";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // relatóriosToolStripMenuItem
            // 
            this.relatóriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOptRelatorioMensalContabilidade,
            this.menuOptRelatorioUtilizacaoDeSelos,
            this.menuOptLivroCaixa});
            this.relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            this.relatóriosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // menuOptRelatorioMensalContabilidade
            // 
            this.menuOptRelatorioMensalContabilidade.Name = "menuOptRelatorioMensalContabilidade";
            this.menuOptRelatorioMensalContabilidade.Size = new System.Drawing.Size(246, 26);
            this.menuOptRelatorioMensalContabilidade.Text = "Contabilidade Mensal";
            this.menuOptRelatorioMensalContabilidade.Click += new System.EventHandler(this.toolStripMenuItem2_Click_2);
            // 
            // menuOptRelatorioUtilizacaoDeSelos
            // 
            this.menuOptRelatorioUtilizacaoDeSelos.Name = "menuOptRelatorioUtilizacaoDeSelos";
            this.menuOptRelatorioUtilizacaoDeSelos.Size = new System.Drawing.Size(246, 26);
            this.menuOptRelatorioUtilizacaoDeSelos.Text = "Utilização de Selos BDI";
            this.menuOptRelatorioUtilizacaoDeSelos.Click += new System.EventHandler(this.utilizaçãoDeSelosBDIToolStripMenuItem_Click);
            // 
            // menuOptLivroCaixa
            // 
            this.menuOptLivroCaixa.Name = "menuOptLivroCaixa";
            this.menuOptLivroCaixa.ShortcutKeyDisplayString = "F2";
            this.menuOptLivroCaixa.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuOptLivroCaixa.Size = new System.Drawing.Size(246, 26);
            this.menuOptLivroCaixa.Text = "Livro Caixa";
            this.menuOptLivroCaixa.Click += new System.EventHandler(this.menuOptLivroCaixa_Click);
            // 
            // testesToolStripMenuItem
            // 
            this.testesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teste1ToolStripMenuItem});
            this.testesToolStripMenuItem.Name = "testesToolStripMenuItem";
            this.testesToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.testesToolStripMenuItem.Text = "Testes";
            // 
            // teste1ToolStripMenuItem
            // 
            this.teste1ToolStripMenuItem.Name = "teste1ToolStripMenuItem";
            this.teste1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.teste1ToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.teste1ToolStripMenuItem.Text = "Teste1";
            this.teste1ToolStripMenuItem.Click += new System.EventHandler(this.teste1ToolStripMenuItem_Click);
            // 
            // tbcApplications
            // 
            this.tbcApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcApplications.ImageList = this.imageList1;
            this.tbcApplications.Location = new System.Drawing.Point(0, 28);
            this.tbcApplications.Margin = new System.Windows.Forms.Padding(4);
            this.tbcApplications.Name = "tbcApplications";
            this.tbcApplications.SelectedIndex = 0;
            this.tbcApplications.Size = new System.Drawing.Size(1067, 526);
            this.tbcApplications.TabIndex = 1;
            this.tbcApplications.Visible = false;
            this.tbcApplications.SelectedIndexChanged += new System.EventHandler(this.tbcApplications_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "cartBritoFundo.jpg");
            this.imageList1.Images.SetKeyName(1, "iconCopiar.png");
            // 
            // btnFrmMainMenuFecharAba
            // 
            this.btnFrmMainMenuFecharAba.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFrmMainMenuFecharAba.Location = new System.Drawing.Point(957, 1);
            this.btnFrmMainMenuFecharAba.Margin = new System.Windows.Forms.Padding(4);
            this.btnFrmMainMenuFecharAba.Name = "btnFrmMainMenuFecharAba";
            this.btnFrmMainMenuFecharAba.Size = new System.Drawing.Size(100, 25);
            this.btnFrmMainMenuFecharAba.TabIndex = 2;
            this.btnFrmMainMenuFecharAba.Text = "Fechar Aba";
            this.btnFrmMainMenuFecharAba.UseVisualStyleBackColor = true;
            this.btnFrmMainMenuFecharAba.Visible = false;
            this.btnFrmMainMenuFecharAba.Click += new System.EventHandler(this.btnFrmMainMenuFecharAba_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btnFrmMainMenuFecharAba);
            this.Controls.Add(this.tbcApplications);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcula Custas";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuOptConfSelosBDI;
        private System.Windows.Forms.ToolStripMenuItem menuOptAbrirArquivo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuImportarAtos;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.TabControl tbcApplications;
        private System.Windows.Forms.Button btnFrmMainMenuFecharAba;
        private System.Windows.Forms.ToolStripMenuItem testesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teste1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuConsultarAlterarSelos;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem relatóriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOptRelatorioMensalContabilidade;
        private System.Windows.Forms.ToolStripMenuItem menuOptConfSelos;
        private System.Windows.Forms.ToolStripMenuItem incluirSeloAvulsoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOptRelatorioUtilizacaoDeSelos;
        private System.Windows.Forms.ToolStripMenuItem menuOptImportarDespesasPDF;
        private System.Windows.Forms.ToolStripMenuItem menuOptLivroCaixa;
    }
}

