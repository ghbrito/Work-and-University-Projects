namespace Calcula_Custas
{
    partial class frmGerarRelatorioSemestralCNJ
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
            this.labelGerarRelatorioContabilidadeANO = new System.Windows.Forms.Label();
            this.labelGerarRelatorioContabilidadeMES = new System.Windows.Forms.Label();
            this.gerarRelatorioContabilidadeMaskAno = new System.Windows.Forms.MaskedTextBox();
            this.gerarRelatorioContabilidadeDtg = new System.Windows.Forms.DataGridView();
            this.frmGerarRelatorioSemestralCNJRdBtn1 = new System.Windows.Forms.RadioButton();
            this.frmGerarRelatorioSemestralCNJRdBtn2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gerarRelatorioContabilidadeDtg)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGerarRelatorioContabilidadeTitulo
            // 
            this.labelGerarRelatorioContabilidadeTitulo.AutoSize = true;
            this.labelGerarRelatorioContabilidadeTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerarRelatorioContabilidadeTitulo.Location = new System.Drawing.Point(3, 3);
            this.labelGerarRelatorioContabilidadeTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGerarRelatorioContabilidadeTitulo.Name = "labelGerarRelatorioContabilidadeTitulo";
            this.labelGerarRelatorioContabilidadeTitulo.Size = new System.Drawing.Size(266, 18);
            this.labelGerarRelatorioContabilidadeTitulo.TabIndex = 0;
            this.labelGerarRelatorioContabilidadeTitulo.Text = "Selecione o período a ser consultado";
            // 
            // buttonGerarRelatorioContabilidadeConsultar
            // 
            this.buttonGerarRelatorioContabilidadeConsultar.Location = new System.Drawing.Point(190, 56);
            this.buttonGerarRelatorioContabilidadeConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGerarRelatorioContabilidadeConsultar.Name = "buttonGerarRelatorioContabilidadeConsultar";
            this.buttonGerarRelatorioContabilidadeConsultar.Size = new System.Drawing.Size(56, 19);
            this.buttonGerarRelatorioContabilidadeConsultar.TabIndex = 3;
            this.buttonGerarRelatorioContabilidadeConsultar.Text = "Consultar";
            this.buttonGerarRelatorioContabilidadeConsultar.UseVisualStyleBackColor = true;
            this.buttonGerarRelatorioContabilidadeConsultar.Click += new System.EventHandler(this.buttonGerarRelatorioContabilidadeConsultar_Click);
            // 
            // labelGerarRelatorioContabilidadeANO
            // 
            this.labelGerarRelatorioContabilidadeANO.AutoSize = true;
            this.labelGerarRelatorioContabilidadeANO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGerarRelatorioContabilidadeANO.Location = new System.Drawing.Point(26, 26);
            this.labelGerarRelatorioContabilidadeANO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGerarRelatorioContabilidadeANO.Name = "labelGerarRelatorioContabilidadeANO";
            this.labelGerarRelatorioContabilidadeANO.Size = new System.Drawing.Size(36, 18);
            this.labelGerarRelatorioContabilidadeANO.TabIndex = 3;
            this.labelGerarRelatorioContabilidadeANO.Text = "Ano";
            // 
            // labelGerarRelatorioContabilidadeMES
            // 
            this.labelGerarRelatorioContabilidadeMES.Location = new System.Drawing.Point(0, 0);
            this.labelGerarRelatorioContabilidadeMES.Name = "labelGerarRelatorioContabilidadeMES";
            this.labelGerarRelatorioContabilidadeMES.Size = new System.Drawing.Size(100, 23);
            this.labelGerarRelatorioContabilidadeMES.TabIndex = 14;
            // 
            // gerarRelatorioContabilidadeMaskAno
            // 
            this.gerarRelatorioContabilidadeMaskAno.Location = new System.Drawing.Point(26, 56);
            this.gerarRelatorioContabilidadeMaskAno.Margin = new System.Windows.Forms.Padding(2);
            this.gerarRelatorioContabilidadeMaskAno.Mask = "0000";
            this.gerarRelatorioContabilidadeMaskAno.Name = "gerarRelatorioContabilidadeMaskAno";
            this.gerarRelatorioContabilidadeMaskAno.Size = new System.Drawing.Size(38, 20);
            this.gerarRelatorioContabilidadeMaskAno.TabIndex = 1;
            this.gerarRelatorioContabilidadeMaskAno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.gerarRelatorioContabilidadeMaskAno_MouseClick);
            this.gerarRelatorioContabilidadeMaskAno.Enter += new System.EventHandler(this.gerarRelatorioContabilidadeMaskAno_Enter);
            // 
            // gerarRelatorioContabilidadeDtg
            // 
            this.gerarRelatorioContabilidadeDtg.AllowUserToAddRows = false;
            this.gerarRelatorioContabilidadeDtg.AllowUserToDeleteRows = false;
            this.gerarRelatorioContabilidadeDtg.AllowUserToResizeColumns = false;
            this.gerarRelatorioContabilidadeDtg.AllowUserToResizeRows = false;
            this.gerarRelatorioContabilidadeDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gerarRelatorioContabilidadeDtg.Location = new System.Drawing.Point(26, 80);
            this.gerarRelatorioContabilidadeDtg.Margin = new System.Windows.Forms.Padding(2);
            this.gerarRelatorioContabilidadeDtg.Name = "gerarRelatorioContabilidadeDtg";
            this.gerarRelatorioContabilidadeDtg.RowHeadersWidth = 51;
            this.gerarRelatorioContabilidadeDtg.RowTemplate.Height = 24;
            this.gerarRelatorioContabilidadeDtg.Size = new System.Drawing.Size(704, 231);
            this.gerarRelatorioContabilidadeDtg.TabIndex = 7;
            this.gerarRelatorioContabilidadeDtg.Visible = false;
            // 
            // frmGerarRelatorioSemestralCNJRdBtn1
            // 
            this.frmGerarRelatorioSemestralCNJRdBtn1.AutoSize = true;
            this.frmGerarRelatorioSemestralCNJRdBtn1.Checked = true;
            this.frmGerarRelatorioSemestralCNJRdBtn1.Location = new System.Drawing.Point(94, 57);
            this.frmGerarRelatorioSemestralCNJRdBtn1.Name = "frmGerarRelatorioSemestralCNJRdBtn1";
            this.frmGerarRelatorioSemestralCNJRdBtn1.Size = new System.Drawing.Size(35, 17);
            this.frmGerarRelatorioSemestralCNJRdBtn1.TabIndex = 12;
            this.frmGerarRelatorioSemestralCNJRdBtn1.TabStop = true;
            this.frmGerarRelatorioSemestralCNJRdBtn1.Text = "1º";
            this.frmGerarRelatorioSemestralCNJRdBtn1.UseVisualStyleBackColor = true;
            // 
            // frmGerarRelatorioSemestralCNJRdBtn2
            // 
            this.frmGerarRelatorioSemestralCNJRdBtn2.AutoSize = true;
            this.frmGerarRelatorioSemestralCNJRdBtn2.Location = new System.Drawing.Point(135, 57);
            this.frmGerarRelatorioSemestralCNJRdBtn2.Name = "frmGerarRelatorioSemestralCNJRdBtn2";
            this.frmGerarRelatorioSemestralCNJRdBtn2.Size = new System.Drawing.Size(35, 17);
            this.frmGerarRelatorioSemestralCNJRdBtn2.TabIndex = 13;
            this.frmGerarRelatorioSemestralCNJRdBtn2.Text = "2º";
            this.frmGerarRelatorioSemestralCNJRdBtn2.UseVisualStyleBackColor = true;
            // 
            // frmGerarRelatorioSemestralCNJ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmGerarRelatorioSemestralCNJRdBtn2);
            this.Controls.Add(this.frmGerarRelatorioSemestralCNJRdBtn1);
            this.Controls.Add(this.gerarRelatorioContabilidadeDtg);
            this.Controls.Add(this.gerarRelatorioContabilidadeMaskAno);
            this.Controls.Add(this.labelGerarRelatorioContabilidadeMES);
            this.Controls.Add(this.labelGerarRelatorioContabilidadeANO);
            this.Controls.Add(this.buttonGerarRelatorioContabilidadeConsultar);
            this.Controls.Add(this.labelGerarRelatorioContabilidadeTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmGerarRelatorioSemestralCNJ";
            this.Size = new System.Drawing.Size(1324, 483);
            this.Load += new System.EventHandler(this.frmGerarRelatorioContabilidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gerarRelatorioContabilidadeDtg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGerarRelatorioContabilidadeTitulo;
        private System.Windows.Forms.Button buttonGerarRelatorioContabilidadeConsultar;
        private System.Windows.Forms.Label labelGerarRelatorioContabilidadeANO;
        private System.Windows.Forms.Label labelGerarRelatorioContabilidadeMES;
        private System.Windows.Forms.MaskedTextBox gerarRelatorioContabilidadeMaskAno;
        private System.Windows.Forms.DataGridView gerarRelatorioContabilidadeDtg;
        private System.Windows.Forms.RadioButton frmGerarRelatorioSemestralCNJRdBtn1;
        private System.Windows.Forms.RadioButton frmGerarRelatorioSemestralCNJRdBtn2;
    }
}
