namespace Calcula_Custas
{
    partial class frmIncluirSeloAvulso
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
            this.lblIncluirSelosBDTitulo = new System.Windows.Forms.Label();
            this.incluirSelosQTD = new System.Windows.Forms.MaskedTextBox();
            this.alteraSelosBDBtnConsultar = new System.Windows.Forms.Button();
            this.incluirSelosBDDtgConsulta = new System.Windows.Forms.DataGridView();
            this.alteraSelosBDBtnIncluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.incluirSelosBDDtgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIncluirSelosBDTitulo
            // 
            this.lblIncluirSelosBDTitulo.AutoSize = true;
            this.lblIncluirSelosBDTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncluirSelosBDTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblIncluirSelosBDTitulo.Name = "lblIncluirSelosBDTitulo";
            this.lblIncluirSelosBDTitulo.Size = new System.Drawing.Size(395, 23);
            this.lblIncluirSelosBDTitulo.TabIndex = 0;
            this.lblIncluirSelosBDTitulo.Text = "Preencha o campo com os dados dos selos";
            // 
            // incluirSelosQTD
            // 
            this.incluirSelosQTD.Location = new System.Drawing.Point(223, 63);
            this.incluirSelosQTD.Mask = "000";
            this.incluirSelosQTD.Name = "incluirSelosQTD";
            this.incluirSelosQTD.Size = new System.Drawing.Size(38, 22);
            this.incluirSelosQTD.TabIndex = 1;
            this.incluirSelosQTD.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.alteraSelosBDMskSeloInicial_MaskInputRejected);
            this.incluirSelosQTD.MouseClick += new System.Windows.Forms.MouseEventHandler(this.alteraSelosBDMskSeloInicial_MouseClick);
            // 
            // alteraSelosBDBtnConsultar
            // 
            this.alteraSelosBDBtnConsultar.Location = new System.Drawing.Point(267, 62);
            this.alteraSelosBDBtnConsultar.Name = "alteraSelosBDBtnConsultar";
            this.alteraSelosBDBtnConsultar.Size = new System.Drawing.Size(125, 25);
            this.alteraSelosBDBtnConsultar.TabIndex = 5;
            this.alteraSelosBDBtnConsultar.Text = "Gerar Tabela";
            this.alteraSelosBDBtnConsultar.UseVisualStyleBackColor = true;
            this.alteraSelosBDBtnConsultar.Click += new System.EventHandler(this.alteraSelosBDBtnConsultar_Click);
            // 
            // incluirSelosBDDtgConsulta
            // 
            this.incluirSelosBDDtgConsulta.AllowUserToAddRows = false;
            this.incluirSelosBDDtgConsulta.AllowUserToDeleteRows = false;
            this.incluirSelosBDDtgConsulta.AllowUserToResizeColumns = false;
            this.incluirSelosBDDtgConsulta.AllowUserToResizeRows = false;
            this.incluirSelosBDDtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.incluirSelosBDDtgConsulta.Location = new System.Drawing.Point(24, 91);
            this.incluirSelosBDDtgConsulta.Name = "incluirSelosBDDtgConsulta";
            this.incluirSelosBDDtgConsulta.RowHeadersWidth = 51;
            this.incluirSelosBDDtgConsulta.RowTemplate.Height = 24;
            this.incluirSelosBDDtgConsulta.Size = new System.Drawing.Size(1176, 420);
            this.incluirSelosBDDtgConsulta.TabIndex = 6;
            this.incluirSelosBDDtgConsulta.Visible = false;
            this.incluirSelosBDDtgConsulta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.alteraSelosBDDtgConsulta_CellEndEdit);
            this.incluirSelosBDDtgConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alteraSelosBDDtgConsulta_KeyPress);
            this.incluirSelosBDDtgConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.alteraSelosBDDtgConsulta_KeyUp);
            // 
            // alteraSelosBDBtnIncluir
            // 
            this.alteraSelosBDBtnIncluir.Location = new System.Drawing.Point(24, 517);
            this.alteraSelosBDBtnIncluir.Name = "alteraSelosBDBtnIncluir";
            this.alteraSelosBDBtnIncluir.Size = new System.Drawing.Size(125, 25);
            this.alteraSelosBDBtnIncluir.TabIndex = 7;
            this.alteraSelosBDBtnIncluir.Text = "INCLUIR";
            this.alteraSelosBDBtnIncluir.UseVisualStyleBackColor = true;
            this.alteraSelosBDBtnIncluir.Visible = false;
            this.alteraSelosBDBtnIncluir.Click += new System.EventHandler(this.alteraSelosBDBtnAlterar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade de selos:";
            // 
            // frmIncluirSeloAvulso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alteraSelosBDBtnIncluir);
            this.Controls.Add(this.incluirSelosBDDtgConsulta);
            this.Controls.Add(this.alteraSelosBDBtnConsultar);
            this.Controls.Add(this.incluirSelosQTD);
            this.Controls.Add(this.lblIncluirSelosBDTitulo);
            this.Name = "frmIncluirSeloAvulso";
            this.Size = new System.Drawing.Size(1251, 606);
            ((System.ComponentModel.ISupportInitialize)(this.incluirSelosBDDtgConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncluirSelosBDTitulo;
        private System.Windows.Forms.MaskedTextBox incluirSelosQTD;
        private System.Windows.Forms.Button alteraSelosBDBtnConsultar;
        private System.Windows.Forms.DataGridView incluirSelosBDDtgConsulta;
        private System.Windows.Forms.Button alteraSelosBDBtnIncluir;
        private System.Windows.Forms.Label label1;
    }
}
