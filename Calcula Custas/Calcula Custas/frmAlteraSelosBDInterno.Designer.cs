namespace Calcula_Custas
{
    partial class frmAlteraSelosBDInterno
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
            this.lblAlteraSelosBDTitulo = new System.Windows.Forms.Label();
            this.alteraSelosBDMskSeloInicial = new System.Windows.Forms.MaskedTextBox();
            this.alteraSelosBDMskSeloFinal = new System.Windows.Forms.MaskedTextBox();
            this.alteraSelosBDRbtSeloUnico = new System.Windows.Forms.RadioButton();
            this.alteraSelosBDGbxSeloIntervalo = new System.Windows.Forms.GroupBox();
            this.alteraSelosBDRbtSeloIntervalo = new System.Windows.Forms.RadioButton();
            this.alteraSelosBDBtnConsultar = new System.Windows.Forms.Button();
            this.alteraSelosBDDtgConsulta = new System.Windows.Forms.DataGridView();
            this.alteraSelosBDBtnAlterar = new System.Windows.Forms.Button();
            this.alteraSelosBDGbxSeloIntervalo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alteraSelosBDDtgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlteraSelosBDTitulo
            // 
            this.lblAlteraSelosBDTitulo.AutoSize = true;
            this.lblAlteraSelosBDTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteraSelosBDTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblAlteraSelosBDTitulo.Name = "lblAlteraSelosBDTitulo";
            this.lblAlteraSelosBDTitulo.Size = new System.Drawing.Size(298, 23);
            this.lblAlteraSelosBDTitulo.TabIndex = 0;
            this.lblAlteraSelosBDTitulo.Text = "Selecione os selos para consulta";
            // 
            // alteraSelosBDMskSeloInicial
            // 
            this.alteraSelosBDMskSeloInicial.Location = new System.Drawing.Point(195, 65);
            this.alteraSelosBDMskSeloInicial.Name = "alteraSelosBDMskSeloInicial";
            this.alteraSelosBDMskSeloInicial.Size = new System.Drawing.Size(100, 22);
            this.alteraSelosBDMskSeloInicial.TabIndex = 1;
            this.alteraSelosBDMskSeloInicial.Text = "Selo Inicial";
            this.alteraSelosBDMskSeloInicial.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.alteraSelosBDMskSeloInicial_MaskInputRejected);
            this.alteraSelosBDMskSeloInicial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.alteraSelosBDMskSeloInicial_MouseClick);
            this.alteraSelosBDMskSeloInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.alteraSelosBDMskSeloInicial_KeyDown);
            // 
            // alteraSelosBDMskSeloFinal
            // 
            this.alteraSelosBDMskSeloFinal.Location = new System.Drawing.Point(195, 93);
            this.alteraSelosBDMskSeloFinal.Name = "alteraSelosBDMskSeloFinal";
            this.alteraSelosBDMskSeloFinal.Size = new System.Drawing.Size(100, 22);
            this.alteraSelosBDMskSeloFinal.TabIndex = 2;
            this.alteraSelosBDMskSeloFinal.Text = "Selo Final";
            this.alteraSelosBDMskSeloFinal.Visible = false;
            this.alteraSelosBDMskSeloFinal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.alteraSelosBDMskSeloFinal_MouseClick);
            // 
            // alteraSelosBDRbtSeloUnico
            // 
            this.alteraSelosBDRbtSeloUnico.AutoSize = true;
            this.alteraSelosBDRbtSeloUnico.Checked = true;
            this.alteraSelosBDRbtSeloUnico.Location = new System.Drawing.Point(6, 21);
            this.alteraSelosBDRbtSeloUnico.Name = "alteraSelosBDRbtSeloUnico";
            this.alteraSelosBDRbtSeloUnico.Size = new System.Drawing.Size(94, 20);
            this.alteraSelosBDRbtSeloUnico.TabIndex = 3;
            this.alteraSelosBDRbtSeloUnico.TabStop = true;
            this.alteraSelosBDRbtSeloUnico.Text = "Selo Único";
            this.alteraSelosBDRbtSeloUnico.UseVisualStyleBackColor = true;
            this.alteraSelosBDRbtSeloUnico.CheckedChanged += new System.EventHandler(this.alteraSelosBDRbtSeloUnico_CheckedChanged);
            // 
            // alteraSelosBDGbxSeloIntervalo
            // 
            this.alteraSelosBDGbxSeloIntervalo.Controls.Add(this.alteraSelosBDRbtSeloIntervalo);
            this.alteraSelosBDGbxSeloIntervalo.Controls.Add(this.alteraSelosBDRbtSeloUnico);
            this.alteraSelosBDGbxSeloIntervalo.Location = new System.Drawing.Point(24, 46);
            this.alteraSelosBDGbxSeloIntervalo.Name = "alteraSelosBDGbxSeloIntervalo";
            this.alteraSelosBDGbxSeloIntervalo.Size = new System.Drawing.Size(160, 79);
            this.alteraSelosBDGbxSeloIntervalo.TabIndex = 4;
            this.alteraSelosBDGbxSeloIntervalo.TabStop = false;
            // 
            // alteraSelosBDRbtSeloIntervalo
            // 
            this.alteraSelosBDRbtSeloIntervalo.AutoSize = true;
            this.alteraSelosBDRbtSeloIntervalo.Location = new System.Drawing.Point(6, 47);
            this.alteraSelosBDRbtSeloIntervalo.Name = "alteraSelosBDRbtSeloIntervalo";
            this.alteraSelosBDRbtSeloIntervalo.Size = new System.Drawing.Size(136, 20);
            this.alteraSelosBDRbtSeloIntervalo.TabIndex = 4;
            this.alteraSelosBDRbtSeloIntervalo.TabStop = true;
            this.alteraSelosBDRbtSeloIntervalo.Text = "Intervalo de Selos";
            this.alteraSelosBDRbtSeloIntervalo.UseVisualStyleBackColor = true;
            this.alteraSelosBDRbtSeloIntervalo.CheckedChanged += new System.EventHandler(this.alteraSelosBDRbtSeloIntervalo_CheckedChanged);
            // 
            // alteraSelosBDBtnConsultar
            // 
            this.alteraSelosBDBtnConsultar.Location = new System.Drawing.Point(301, 64);
            this.alteraSelosBDBtnConsultar.Name = "alteraSelosBDBtnConsultar";
            this.alteraSelosBDBtnConsultar.Size = new System.Drawing.Size(125, 25);
            this.alteraSelosBDBtnConsultar.TabIndex = 5;
            this.alteraSelosBDBtnConsultar.Text = "CONSULTAR";
            this.alteraSelosBDBtnConsultar.UseVisualStyleBackColor = true;
            this.alteraSelosBDBtnConsultar.Click += new System.EventHandler(this.alteraSelosBDBtnConsultar_Click);
            // 
            // alteraSelosBDDtgConsulta
            // 
            this.alteraSelosBDDtgConsulta.AllowUserToAddRows = false;
            this.alteraSelosBDDtgConsulta.AllowUserToDeleteRows = false;
            this.alteraSelosBDDtgConsulta.AllowUserToResizeColumns = false;
            this.alteraSelosBDDtgConsulta.AllowUserToResizeRows = false;
            this.alteraSelosBDDtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alteraSelosBDDtgConsulta.Location = new System.Drawing.Point(24, 131);
            this.alteraSelosBDDtgConsulta.Name = "alteraSelosBDDtgConsulta";
            this.alteraSelosBDDtgConsulta.RowHeadersWidth = 51;
            this.alteraSelosBDDtgConsulta.RowTemplate.Height = 24;
            this.alteraSelosBDDtgConsulta.Size = new System.Drawing.Size(1176, 420);
            this.alteraSelosBDDtgConsulta.TabIndex = 6;
            this.alteraSelosBDDtgConsulta.Visible = false;
            this.alteraSelosBDDtgConsulta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.alteraSelosBDDtgConsulta_CellEndEdit);
            this.alteraSelosBDDtgConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alteraSelosBDDtgConsulta_KeyPress);
            this.alteraSelosBDDtgConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.alteraSelosBDDtgConsulta_KeyUp);
            // 
            // alteraSelosBDBtnAlterar
            // 
            this.alteraSelosBDBtnAlterar.Location = new System.Drawing.Point(24, 557);
            this.alteraSelosBDBtnAlterar.Name = "alteraSelosBDBtnAlterar";
            this.alteraSelosBDBtnAlterar.Size = new System.Drawing.Size(125, 25);
            this.alteraSelosBDBtnAlterar.TabIndex = 7;
            this.alteraSelosBDBtnAlterar.Text = "ALTERAR";
            this.alteraSelosBDBtnAlterar.UseVisualStyleBackColor = true;
            this.alteraSelosBDBtnAlterar.Visible = false;
            this.alteraSelosBDBtnAlterar.Click += new System.EventHandler(this.alteraSelosBDBtnAlterar_Click);
            // 
            // frmAlteraSelosBDInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.alteraSelosBDBtnAlterar);
            this.Controls.Add(this.alteraSelosBDDtgConsulta);
            this.Controls.Add(this.alteraSelosBDBtnConsultar);
            this.Controls.Add(this.alteraSelosBDGbxSeloIntervalo);
            this.Controls.Add(this.alteraSelosBDMskSeloFinal);
            this.Controls.Add(this.alteraSelosBDMskSeloInicial);
            this.Controls.Add(this.lblAlteraSelosBDTitulo);
            this.Name = "frmAlteraSelosBDInterno";
            this.Size = new System.Drawing.Size(1251, 606);
            this.alteraSelosBDGbxSeloIntervalo.ResumeLayout(false);
            this.alteraSelosBDGbxSeloIntervalo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alteraSelosBDDtgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlteraSelosBDTitulo;
        private System.Windows.Forms.MaskedTextBox alteraSelosBDMskSeloInicial;
        private System.Windows.Forms.MaskedTextBox alteraSelosBDMskSeloFinal;
        private System.Windows.Forms.RadioButton alteraSelosBDRbtSeloUnico;
        private System.Windows.Forms.GroupBox alteraSelosBDGbxSeloIntervalo;
        private System.Windows.Forms.RadioButton alteraSelosBDRbtSeloIntervalo;
        private System.Windows.Forms.Button alteraSelosBDBtnConsultar;
        private System.Windows.Forms.DataGridView alteraSelosBDDtgConsulta;
        private System.Windows.Forms.Button alteraSelosBDBtnAlterar;
    }
}
