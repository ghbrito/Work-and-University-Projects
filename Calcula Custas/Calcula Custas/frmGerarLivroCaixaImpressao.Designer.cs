namespace Calcula_Custas
{
    partial class frmGerarLivroCaixaImpressao
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmGerarLivroCaixaTitulo = new System.Windows.Forms.Label();
            this.frmGerarLivroCaixaConsultar = new System.Windows.Forms.Button();
            this.labelGerarRelatorioContabilidadeANO = new System.Windows.Forms.Label();
            this.labelGerarRelatorioContabilidadeMES = new System.Windows.Forms.Label();
            this.frmGerarLivroCaixaMaskAno = new System.Windows.Forms.MaskedTextBox();
            this.frmGerarLivroCaixaCmbMes = new System.Windows.Forms.ComboBox();
            this.frmGerarLivroCaixaDtg = new System.Windows.Forms.DataGridView();
            this.frmGerarLivroCaixaSalvarPDF = new System.Windows.Forms.Button();
            this.frmGerarLivroImpressaoMskLivro = new System.Windows.Forms.MaskedTextBox();
            this.frmGerarLivroImpressaoMskFolha = new System.Windows.Forms.MaskedTextBox();
            this.frmGerarLivroImpressaoLblLivro = new System.Windows.Forms.Label();
            this.frmGerarLivroImpressaoLblFolha = new System.Windows.Forms.Label();
            this.frmGerarLivroImpressaoGbxConsulta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.frmGerarLivroCaixaDtg)).BeginInit();
            this.frmGerarLivroImpressaoGbxConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmGerarLivroCaixaTitulo
            // 
            this.frmGerarLivroCaixaTitulo.AutoSize = true;
            this.frmGerarLivroCaixaTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmGerarLivroCaixaTitulo.Location = new System.Drawing.Point(4, 4);
            this.frmGerarLivroCaixaTitulo.Name = "frmGerarLivroCaixaTitulo";
            this.frmGerarLivroCaixaTitulo.Size = new System.Drawing.Size(337, 23);
            this.frmGerarLivroCaixaTitulo.TabIndex = 0;
            this.frmGerarLivroCaixaTitulo.Text = "Selecione o período a ser consultado";
            // 
            // frmGerarLivroCaixaConsultar
            // 
            this.frmGerarLivroCaixaConsultar.Location = new System.Drawing.Point(238, 67);
            this.frmGerarLivroCaixaConsultar.Name = "frmGerarLivroCaixaConsultar";
            this.frmGerarLivroCaixaConsultar.Size = new System.Drawing.Size(75, 23);
            this.frmGerarLivroCaixaConsultar.TabIndex = 3;
            this.frmGerarLivroCaixaConsultar.Text = "Consultar";
            this.frmGerarLivroCaixaConsultar.UseVisualStyleBackColor = true;
            this.frmGerarLivroCaixaConsultar.Click += new System.EventHandler(this.buttonGerarRelatorioContabilidadeConsultar_Click);
            // 
            // labelGerarRelatorioContabilidadeANO
            // 
            this.labelGerarRelatorioContabilidadeANO.AutoSize = true;
            this.labelGerarRelatorioContabilidadeANO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerarRelatorioContabilidadeANO.Location = new System.Drawing.Point(35, 32);
            this.labelGerarRelatorioContabilidadeANO.Name = "labelGerarRelatorioContabilidadeANO";
            this.labelGerarRelatorioContabilidadeANO.Size = new System.Drawing.Size(44, 23);
            this.labelGerarRelatorioContabilidadeANO.TabIndex = 3;
            this.labelGerarRelatorioContabilidadeANO.Text = "Ano";
            // 
            // labelGerarRelatorioContabilidadeMES
            // 
            this.labelGerarRelatorioContabilidadeMES.AutoSize = true;
            this.labelGerarRelatorioContabilidadeMES.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerarRelatorioContabilidadeMES.Location = new System.Drawing.Point(141, 32);
            this.labelGerarRelatorioContabilidadeMES.Name = "labelGerarRelatorioContabilidadeMES";
            this.labelGerarRelatorioContabilidadeMES.Size = new System.Drawing.Size(48, 23);
            this.labelGerarRelatorioContabilidadeMES.TabIndex = 4;
            this.labelGerarRelatorioContabilidadeMES.Text = "Mês";
            // 
            // frmGerarLivroCaixaMaskAno
            // 
            this.frmGerarLivroCaixaMaskAno.Location = new System.Drawing.Point(34, 69);
            this.frmGerarLivroCaixaMaskAno.Mask = "0000";
            this.frmGerarLivroCaixaMaskAno.Name = "frmGerarLivroCaixaMaskAno";
            this.frmGerarLivroCaixaMaskAno.Size = new System.Drawing.Size(50, 22);
            this.frmGerarLivroCaixaMaskAno.TabIndex = 1;
            // 
            // frmGerarLivroCaixaCmbMes
            // 
            this.frmGerarLivroCaixaCmbMes.FormattingEnabled = true;
            this.frmGerarLivroCaixaCmbMes.Items.AddRange(new object[] {
            "1 - JANEIRO",
            "2 - FEVEREIRO",
            "3 - MARÇO",
            "4 - ABRIL",
            "5 - MAIO",
            "6 - JUNHO",
            "7 - JULHO",
            "8 - AGOSTO",
            "9 - SETEMBRO",
            "10 - OUTUBRO",
            "11 - NOVEMBRO",
            "12 - DEZEMBRO"});
            this.frmGerarLivroCaixaCmbMes.Location = new System.Drawing.Point(90, 67);
            this.frmGerarLivroCaixaCmbMes.Name = "frmGerarLivroCaixaCmbMes";
            this.frmGerarLivroCaixaCmbMes.Size = new System.Drawing.Size(142, 24);
            this.frmGerarLivroCaixaCmbMes.TabIndex = 2;
            // 
            // frmGerarLivroCaixaDtg
            // 
            this.frmGerarLivroCaixaDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmGerarLivroCaixaDtg.Location = new System.Drawing.Point(6, 12);
            this.frmGerarLivroCaixaDtg.Name = "frmGerarLivroCaixaDtg";
            this.frmGerarLivroCaixaDtg.RowHeadersWidth = 51;
            this.frmGerarLivroCaixaDtg.RowTemplate.Height = 24;
            this.frmGerarLivroCaixaDtg.Size = new System.Drawing.Size(872, 428);
            this.frmGerarLivroCaixaDtg.TabIndex = 7;
            // 
            // frmGerarLivroCaixaSalvarPDF
            // 
            this.frmGerarLivroCaixaSalvarPDF.Location = new System.Drawing.Point(264, 445);
            this.frmGerarLivroCaixaSalvarPDF.Name = "frmGerarLivroCaixaSalvarPDF";
            this.frmGerarLivroCaixaSalvarPDF.Size = new System.Drawing.Size(104, 23);
            this.frmGerarLivroCaixaSalvarPDF.TabIndex = 6;
            this.frmGerarLivroCaixaSalvarPDF.Text = "Gerar PDF";
            this.frmGerarLivroCaixaSalvarPDF.UseVisualStyleBackColor = true;
            this.frmGerarLivroCaixaSalvarPDF.Click += new System.EventHandler(this.frmGerarLivroCaixaSalvarPDF_Click);
            // 
            // frmGerarLivroImpressaoMskLivro
            // 
            this.frmGerarLivroImpressaoMskLivro.Location = new System.Drawing.Point(67, 446);
            this.frmGerarLivroImpressaoMskLivro.Mask = "00";
            this.frmGerarLivroImpressaoMskLivro.Name = "frmGerarLivroImpressaoMskLivro";
            this.frmGerarLivroImpressaoMskLivro.Size = new System.Drawing.Size(39, 22);
            this.frmGerarLivroImpressaoMskLivro.TabIndex = 4;
            // 
            // frmGerarLivroImpressaoMskFolha
            // 
            this.frmGerarLivroImpressaoMskFolha.Location = new System.Drawing.Point(219, 446);
            this.frmGerarLivroImpressaoMskFolha.Mask = "000";
            this.frmGerarLivroImpressaoMskFolha.Name = "frmGerarLivroImpressaoMskFolha";
            this.frmGerarLivroImpressaoMskFolha.Size = new System.Drawing.Size(39, 22);
            this.frmGerarLivroImpressaoMskFolha.TabIndex = 5;
            // 
            // frmGerarLivroImpressaoLblLivro
            // 
            this.frmGerarLivroImpressaoLblLivro.AutoSize = true;
            this.frmGerarLivroImpressaoLblLivro.Location = new System.Drawing.Point(7, 449);
            this.frmGerarLivroImpressaoLblLivro.Name = "frmGerarLivroImpressaoLblLivro";
            this.frmGerarLivroImpressaoLblLivro.Size = new System.Drawing.Size(54, 16);
            this.frmGerarLivroImpressaoLblLivro.TabIndex = 10;
            this.frmGerarLivroImpressaoLblLivro.Text = "Nº Livro";
            // 
            // frmGerarLivroImpressaoLblFolha
            // 
            this.frmGerarLivroImpressaoLblFolha.AutoSize = true;
            this.frmGerarLivroImpressaoLblFolha.Location = new System.Drawing.Point(117, 449);
            this.frmGerarLivroImpressaoLblFolha.Name = "frmGerarLivroImpressaoLblFolha";
            this.frmGerarLivroImpressaoLblFolha.Size = new System.Drawing.Size(96, 16);
            this.frmGerarLivroImpressaoLblFolha.TabIndex = 11;
            this.frmGerarLivroImpressaoLblFolha.Text = "Nº Folha Inicial";
            // 
            // frmGerarLivroImpressaoGbxConsulta
            // 
            this.frmGerarLivroImpressaoGbxConsulta.Controls.Add(this.frmGerarLivroCaixaDtg);
            this.frmGerarLivroImpressaoGbxConsulta.Controls.Add(this.frmGerarLivroImpressaoLblFolha);
            this.frmGerarLivroImpressaoGbxConsulta.Controls.Add(this.frmGerarLivroImpressaoLblLivro);
            this.frmGerarLivroImpressaoGbxConsulta.Controls.Add(this.frmGerarLivroCaixaSalvarPDF);
            this.frmGerarLivroImpressaoGbxConsulta.Controls.Add(this.frmGerarLivroImpressaoMskFolha);
            this.frmGerarLivroImpressaoGbxConsulta.Controls.Add(this.frmGerarLivroImpressaoMskLivro);
            this.frmGerarLivroImpressaoGbxConsulta.Location = new System.Drawing.Point(34, 96);
            this.frmGerarLivroImpressaoGbxConsulta.Name = "frmGerarLivroImpressaoGbxConsulta";
            this.frmGerarLivroImpressaoGbxConsulta.Size = new System.Drawing.Size(884, 477);
            this.frmGerarLivroImpressaoGbxConsulta.TabIndex = 12;
            this.frmGerarLivroImpressaoGbxConsulta.TabStop = false;
            this.frmGerarLivroImpressaoGbxConsulta.Visible = false;
            // 
            // frmGerarLivroCaixaImpressao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmGerarLivroImpressaoGbxConsulta);
            this.Controls.Add(this.frmGerarLivroCaixaCmbMes);
            this.Controls.Add(this.frmGerarLivroCaixaMaskAno);
            this.Controls.Add(this.labelGerarRelatorioContabilidadeMES);
            this.Controls.Add(this.labelGerarRelatorioContabilidadeANO);
            this.Controls.Add(this.frmGerarLivroCaixaConsultar);
            this.Controls.Add(this.frmGerarLivroCaixaTitulo);
            this.Name = "frmGerarLivroCaixaImpressao";
            this.Size = new System.Drawing.Size(1765, 662);
            this.Load += new System.EventHandler(this.frmGerarRelatorioContabilidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmGerarLivroCaixaDtg)).EndInit();
            this.frmGerarLivroImpressaoGbxConsulta.ResumeLayout(false);
            this.frmGerarLivroImpressaoGbxConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label frmGerarLivroCaixaTitulo;
        private System.Windows.Forms.Button frmGerarLivroCaixaConsultar;
        private System.Windows.Forms.Label labelGerarRelatorioContabilidadeANO;
        private System.Windows.Forms.Label labelGerarRelatorioContabilidadeMES;
        private System.Windows.Forms.MaskedTextBox frmGerarLivroCaixaMaskAno;
        private System.Windows.Forms.ComboBox frmGerarLivroCaixaCmbMes;
        private System.Windows.Forms.DataGridView frmGerarLivroCaixaDtg;
        private System.Windows.Forms.Button frmGerarLivroCaixaSalvarPDF;
        private System.Windows.Forms.MaskedTextBox frmGerarLivroImpressaoMskLivro;
        private System.Windows.Forms.MaskedTextBox frmGerarLivroImpressaoMskFolha;
        private System.Windows.Forms.Label frmGerarLivroImpressaoLblLivro;
        private System.Windows.Forms.Label frmGerarLivroImpressaoLblFolha;
        private System.Windows.Forms.GroupBox frmGerarLivroImpressaoGbxConsulta;
    }
}
