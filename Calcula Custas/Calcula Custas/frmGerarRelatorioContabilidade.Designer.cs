namespace Calcula_Custas
{
    partial class frmGerarRelatorioContabilidade
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
            this.labelGerarRelatorioContabilidadeTitulo = new System.Windows.Forms.Label();
            this.buttonGerarRelatorioContabilidadeConsultar = new System.Windows.Forms.Button();
            this.buttonGerarRelatorioContabilidadeSalvar = new System.Windows.Forms.Button();
            this.labelGerarRelatorioContabilidadeANO = new System.Windows.Forms.Label();
            this.labelGerarRelatorioContabilidadeMES = new System.Windows.Forms.Label();
            this.gerarRelatorioContabilidadeMaskAno = new System.Windows.Forms.MaskedTextBox();
            this.gerarRelatorioContabilidadeCmbMes = new System.Windows.Forms.ComboBox();
            this.gerarRelatorioContabilidadeDtg = new System.Windows.Forms.DataGridView();
            this.btnGerarRelatorioContabilidadeSalvarPDF = new System.Windows.Forms.Button();
            this.gerarRelatorioContabilidadeDtgDespesas = new System.Windows.Forms.DataGridView();
            this.gerarRelatorioContabilidadeDtgAtos = new System.Windows.Forms.DataGridView();
            this.frmGerarRelatorioContabilidadeLblAtosPagos = new System.Windows.Forms.Label();
            this.frmGerarRelatorioContabilidadeLblDespesas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gerarRelatorioContabilidadeDtg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerarRelatorioContabilidadeDtgDespesas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerarRelatorioContabilidadeDtgAtos)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGerarRelatorioContabilidadeTitulo
            // 
            this.labelGerarRelatorioContabilidadeTitulo.AutoSize = true;
            this.labelGerarRelatorioContabilidadeTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerarRelatorioContabilidadeTitulo.Location = new System.Drawing.Point(4, 4);
            this.labelGerarRelatorioContabilidadeTitulo.Name = "labelGerarRelatorioContabilidadeTitulo";
            this.labelGerarRelatorioContabilidadeTitulo.Size = new System.Drawing.Size(337, 23);
            this.labelGerarRelatorioContabilidadeTitulo.TabIndex = 0;
            this.labelGerarRelatorioContabilidadeTitulo.Text = "Selecione o período a ser consultado";
            // 
            // buttonGerarRelatorioContabilidadeConsultar
            // 
            this.buttonGerarRelatorioContabilidadeConsultar.Location = new System.Drawing.Point(238, 67);
            this.buttonGerarRelatorioContabilidadeConsultar.Name = "buttonGerarRelatorioContabilidadeConsultar";
            this.buttonGerarRelatorioContabilidadeConsultar.Size = new System.Drawing.Size(75, 23);
            this.buttonGerarRelatorioContabilidadeConsultar.TabIndex = 3;
            this.buttonGerarRelatorioContabilidadeConsultar.Text = "Consultar";
            this.buttonGerarRelatorioContabilidadeConsultar.UseVisualStyleBackColor = true;
            this.buttonGerarRelatorioContabilidadeConsultar.Click += new System.EventHandler(this.buttonGerarRelatorioContabilidadeConsultar_Click);
            // 
            // buttonGerarRelatorioContabilidadeSalvar
            // 
            this.buttonGerarRelatorioContabilidadeSalvar.Location = new System.Drawing.Point(319, 67);
            this.buttonGerarRelatorioContabilidadeSalvar.Name = "buttonGerarRelatorioContabilidadeSalvar";
            this.buttonGerarRelatorioContabilidadeSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonGerarRelatorioContabilidadeSalvar.TabIndex = 4;
            this.buttonGerarRelatorioContabilidadeSalvar.Text = "Salvar";
            this.buttonGerarRelatorioContabilidadeSalvar.UseVisualStyleBackColor = true;
            this.buttonGerarRelatorioContabilidadeSalvar.Visible = false;
            this.buttonGerarRelatorioContabilidadeSalvar.Click += new System.EventHandler(this.buttonGerarRelatorioContabilidadeSalvar_Click);
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
            // gerarRelatorioContabilidadeMaskAno
            // 
            this.gerarRelatorioContabilidadeMaskAno.Location = new System.Drawing.Point(34, 69);
            this.gerarRelatorioContabilidadeMaskAno.Mask = "0000";
            this.gerarRelatorioContabilidadeMaskAno.Name = "gerarRelatorioContabilidadeMaskAno";
            this.gerarRelatorioContabilidadeMaskAno.Size = new System.Drawing.Size(50, 22);
            this.gerarRelatorioContabilidadeMaskAno.TabIndex = 1;
            this.gerarRelatorioContabilidadeMaskAno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gerarRelatorioContabilidadeMaskAno_MouseClick);
            this.gerarRelatorioContabilidadeMaskAno.Enter += new System.EventHandler(this.gerarRelatorioContabilidadeMaskAno_Enter);
            // 
            // gerarRelatorioContabilidadeCmbMes
            // 
            this.gerarRelatorioContabilidadeCmbMes.FormattingEnabled = true;
            this.gerarRelatorioContabilidadeCmbMes.Items.AddRange(new object[] {
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
            this.gerarRelatorioContabilidadeCmbMes.Location = new System.Drawing.Point(90, 67);
            this.gerarRelatorioContabilidadeCmbMes.Name = "gerarRelatorioContabilidadeCmbMes";
            this.gerarRelatorioContabilidadeCmbMes.Size = new System.Drawing.Size(142, 24);
            this.gerarRelatorioContabilidadeCmbMes.TabIndex = 2;
            // 
            // gerarRelatorioContabilidadeDtg
            // 
            this.gerarRelatorioContabilidadeDtg.AllowUserToAddRows = false;
            this.gerarRelatorioContabilidadeDtg.AllowUserToDeleteRows = false;
            this.gerarRelatorioContabilidadeDtg.AllowUserToResizeColumns = false;
            this.gerarRelatorioContabilidadeDtg.AllowUserToResizeRows = false;
            this.gerarRelatorioContabilidadeDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gerarRelatorioContabilidadeDtg.Location = new System.Drawing.Point(34, 98);
            this.gerarRelatorioContabilidadeDtg.Name = "gerarRelatorioContabilidadeDtg";
            this.gerarRelatorioContabilidadeDtg.RowHeadersWidth = 51;
            this.gerarRelatorioContabilidadeDtg.RowTemplate.Height = 24;
            this.gerarRelatorioContabilidadeDtg.Size = new System.Drawing.Size(1728, 63);
            this.gerarRelatorioContabilidadeDtg.TabIndex = 7;
            this.gerarRelatorioContabilidadeDtg.Visible = false;
            this.gerarRelatorioContabilidadeDtg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gerarRelatorioContabilidadeDtg_CellEndEdit);
            this.gerarRelatorioContabilidadeDtg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gerarRelatorioContabilidadeDtg_KeyPress);
            // 
            // btnGerarRelatorioContabilidadeSalvarPDF
            // 
            this.btnGerarRelatorioContabilidadeSalvarPDF.Location = new System.Drawing.Point(400, 67);
            this.btnGerarRelatorioContabilidadeSalvarPDF.Name = "btnGerarRelatorioContabilidadeSalvarPDF";
            this.btnGerarRelatorioContabilidadeSalvarPDF.Size = new System.Drawing.Size(104, 23);
            this.btnGerarRelatorioContabilidadeSalvarPDF.TabIndex = 5;
            this.btnGerarRelatorioContabilidadeSalvarPDF.Text = "Gerar PDF";
            this.btnGerarRelatorioContabilidadeSalvarPDF.UseVisualStyleBackColor = true;
            this.btnGerarRelatorioContabilidadeSalvarPDF.Visible = false;
            this.btnGerarRelatorioContabilidadeSalvarPDF.Click += new System.EventHandler(this.btnGerarRelatorioContabilidadeSalvarPDF_Click);
            // 
            // gerarRelatorioContabilidadeDtgDespesas
            // 
            this.gerarRelatorioContabilidadeDtgDespesas.AllowUserToAddRows = false;
            this.gerarRelatorioContabilidadeDtgDespesas.AllowUserToDeleteRows = false;
            this.gerarRelatorioContabilidadeDtgDespesas.AllowUserToResizeColumns = false;
            this.gerarRelatorioContabilidadeDtgDespesas.AllowUserToResizeRows = false;
            this.gerarRelatorioContabilidadeDtgDespesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gerarRelatorioContabilidadeDtgDespesas.Location = new System.Drawing.Point(1190, 215);
            this.gerarRelatorioContabilidadeDtgDespesas.Name = "gerarRelatorioContabilidadeDtgDespesas";
            this.gerarRelatorioContabilidadeDtgDespesas.ReadOnly = true;
            this.gerarRelatorioContabilidadeDtgDespesas.RowHeadersWidth = 51;
            this.gerarRelatorioContabilidadeDtgDespesas.RowTemplate.Height = 24;
            this.gerarRelatorioContabilidadeDtgDespesas.Size = new System.Drawing.Size(572, 377);
            this.gerarRelatorioContabilidadeDtgDespesas.TabIndex = 8;
            this.gerarRelatorioContabilidadeDtgDespesas.Visible = false;
            // 
            // gerarRelatorioContabilidadeDtgAtos
            // 
            this.gerarRelatorioContabilidadeDtgAtos.AllowUserToAddRows = false;
            this.gerarRelatorioContabilidadeDtgAtos.AllowUserToDeleteRows = false;
            this.gerarRelatorioContabilidadeDtgAtos.AllowUserToResizeColumns = false;
            this.gerarRelatorioContabilidadeDtgAtos.AllowUserToResizeRows = false;
            this.gerarRelatorioContabilidadeDtgAtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gerarRelatorioContabilidadeDtgAtos.Location = new System.Drawing.Point(34, 215);
            this.gerarRelatorioContabilidadeDtgAtos.Name = "gerarRelatorioContabilidadeDtgAtos";
            this.gerarRelatorioContabilidadeDtgAtos.ReadOnly = true;
            this.gerarRelatorioContabilidadeDtgAtos.RowHeadersWidth = 51;
            this.gerarRelatorioContabilidadeDtgAtos.RowTemplate.Height = 24;
            this.gerarRelatorioContabilidadeDtgAtos.Size = new System.Drawing.Size(1150, 377);
            this.gerarRelatorioContabilidadeDtgAtos.TabIndex = 9;
            this.gerarRelatorioContabilidadeDtgAtos.Visible = false;
            // 
            // frmGerarRelatorioContabilidadeLblAtosPagos
            // 
            this.frmGerarRelatorioContabilidadeLblAtosPagos.AutoSize = true;
            this.frmGerarRelatorioContabilidadeLblAtosPagos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmGerarRelatorioContabilidadeLblAtosPagos.Location = new System.Drawing.Point(493, 177);
            this.frmGerarRelatorioContabilidadeLblAtosPagos.Name = "frmGerarRelatorioContabilidadeLblAtosPagos";
            this.frmGerarRelatorioContabilidadeLblAtosPagos.Size = new System.Drawing.Size(112, 23);
            this.frmGerarRelatorioContabilidadeLblAtosPagos.TabIndex = 10;
            this.frmGerarRelatorioContabilidadeLblAtosPagos.Text = "Atos Pagos";
            this.frmGerarRelatorioContabilidadeLblAtosPagos.Visible = false;
            // 
            // frmGerarRelatorioContabilidadeLblDespesas
            // 
            this.frmGerarRelatorioContabilidadeLblDespesas.AutoSize = true;
            this.frmGerarRelatorioContabilidadeLblDespesas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmGerarRelatorioContabilidadeLblDespesas.Location = new System.Drawing.Point(1386, 177);
            this.frmGerarRelatorioContabilidadeLblDespesas.Name = "frmGerarRelatorioContabilidadeLblDespesas";
            this.frmGerarRelatorioContabilidadeLblDespesas.Size = new System.Drawing.Size(98, 23);
            this.frmGerarRelatorioContabilidadeLblDespesas.TabIndex = 11;
            this.frmGerarRelatorioContabilidadeLblDespesas.Text = "Despesas";
            this.frmGerarRelatorioContabilidadeLblDespesas.Visible = false;
            // 
            // frmGerarRelatorioContabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmGerarRelatorioContabilidadeLblDespesas);
            this.Controls.Add(this.frmGerarRelatorioContabilidadeLblAtosPagos);
            this.Controls.Add(this.gerarRelatorioContabilidadeDtgAtos);
            this.Controls.Add(this.gerarRelatorioContabilidadeDtgDespesas);
            this.Controls.Add(this.btnGerarRelatorioContabilidadeSalvarPDF);
            this.Controls.Add(this.gerarRelatorioContabilidadeDtg);
            this.Controls.Add(this.gerarRelatorioContabilidadeCmbMes);
            this.Controls.Add(this.gerarRelatorioContabilidadeMaskAno);
            this.Controls.Add(this.labelGerarRelatorioContabilidadeMES);
            this.Controls.Add(this.labelGerarRelatorioContabilidadeANO);
            this.Controls.Add(this.buttonGerarRelatorioContabilidadeSalvar);
            this.Controls.Add(this.buttonGerarRelatorioContabilidadeConsultar);
            this.Controls.Add(this.labelGerarRelatorioContabilidadeTitulo);
            this.Name = "frmGerarRelatorioContabilidade";
            this.Size = new System.Drawing.Size(1765, 595);
            this.Load += new System.EventHandler(this.frmGerarRelatorioContabilidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gerarRelatorioContabilidadeDtg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerarRelatorioContabilidadeDtgDespesas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gerarRelatorioContabilidadeDtgAtos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGerarRelatorioContabilidadeTitulo;
        private System.Windows.Forms.Button buttonGerarRelatorioContabilidadeConsultar;
        private System.Windows.Forms.Button buttonGerarRelatorioContabilidadeSalvar;
        private System.Windows.Forms.Label labelGerarRelatorioContabilidadeANO;
        private System.Windows.Forms.Label labelGerarRelatorioContabilidadeMES;
        private System.Windows.Forms.MaskedTextBox gerarRelatorioContabilidadeMaskAno;
        private System.Windows.Forms.ComboBox gerarRelatorioContabilidadeCmbMes;
        private System.Windows.Forms.DataGridView gerarRelatorioContabilidadeDtg;
        private System.Windows.Forms.Button btnGerarRelatorioContabilidadeSalvarPDF;
        private System.Windows.Forms.DataGridView gerarRelatorioContabilidadeDtgDespesas;
        private System.Windows.Forms.DataGridView gerarRelatorioContabilidadeDtgAtos;
        private System.Windows.Forms.Label frmGerarRelatorioContabilidadeLblAtosPagos;
        private System.Windows.Forms.Label frmGerarRelatorioContabilidadeLblDespesas;
    }
}
