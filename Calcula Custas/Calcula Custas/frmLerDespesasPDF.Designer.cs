namespace Calcula_Custas
{
    partial class frmLerDespesasPDF
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
            this.frmLerDespesasPDFBtnAbrir = new System.Windows.Forms.Button();
            this.frmLerDespesasPDFLblTitulo = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.frmLerDespesasPDFBtnInclusao = new System.Windows.Forms.Button();
            this.frmLerDespesasPDFGbxInclusao = new System.Windows.Forms.GroupBox();
            this.frmLerDespesasPDFDtg = new System.Windows.Forms.DataGridView();
            this.frmLerDespesasPDFGbxHabilitarInclusao = new System.Windows.Forms.GroupBox();
            this.frmLerDespesasPDFRbtSim = new System.Windows.Forms.RadioButton();
            this.frmLerDespesasPDFRbtNao = new System.Windows.Forms.RadioButton();
            this.frmLerDespesasPDFGbxInclusao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmLerDespesasPDFDtg)).BeginInit();
            this.frmLerDespesasPDFGbxHabilitarInclusao.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmLerDespesasPDFBtnAbrir
            // 
            this.frmLerDespesasPDFBtnAbrir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLerDespesasPDFBtnAbrir.Location = new System.Drawing.Point(26, 44);
            this.frmLerDespesasPDFBtnAbrir.Name = "frmLerDespesasPDFBtnAbrir";
            this.frmLerDespesasPDFBtnAbrir.Size = new System.Drawing.Size(80, 26);
            this.frmLerDespesasPDFBtnAbrir.TabIndex = 0;
            this.frmLerDespesasPDFBtnAbrir.Text = "Abrir";
            this.frmLerDespesasPDFBtnAbrir.UseVisualStyleBackColor = true;
            this.frmLerDespesasPDFBtnAbrir.Click += new System.EventHandler(this.frmLerDespesasPDFBtnAbrir_Click);
            // 
            // frmLerDespesasPDFLblTitulo
            // 
            this.frmLerDespesasPDFLblTitulo.AutoSize = true;
            this.frmLerDespesasPDFLblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLerDespesasPDFLblTitulo.Location = new System.Drawing.Point(22, 9);
            this.frmLerDespesasPDFLblTitulo.Name = "frmLerDespesasPDFLblTitulo";
            this.frmLerDespesasPDFLblTitulo.Size = new System.Drawing.Size(466, 23);
            this.frmLerDespesasPDFLblTitulo.TabIndex = 1;
            this.frmLerDespesasPDFLblTitulo.Text = "Escolha os arquivos de recibos a serem compilados";
            // 
            // frmLerDespesasPDFBtnInclusao
            // 
            this.frmLerDespesasPDFBtnInclusao.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frmLerDespesasPDFBtnInclusao.Location = new System.Drawing.Point(6, 116);
            this.frmLerDespesasPDFBtnInclusao.Name = "frmLerDespesasPDFBtnInclusao";
            this.frmLerDespesasPDFBtnInclusao.Size = new System.Drawing.Size(80, 26);
            this.frmLerDespesasPDFBtnInclusao.TabIndex = 2;
            this.frmLerDespesasPDFBtnInclusao.Text = "Incluir Despesa";
            this.frmLerDespesasPDFBtnInclusao.UseVisualStyleBackColor = true;
            this.frmLerDespesasPDFBtnInclusao.Click += new System.EventHandler(this.frmLerDespesasPDFBtnInclusao_Click);
            // 
            // frmLerDespesasPDFGbxInclusao
            // 
            this.frmLerDespesasPDFGbxInclusao.Controls.Add(this.frmLerDespesasPDFDtg);
            this.frmLerDespesasPDFGbxInclusao.Controls.Add(this.frmLerDespesasPDFBtnInclusao);
            this.frmLerDespesasPDFGbxInclusao.Location = new System.Drawing.Point(26, 154);
            this.frmLerDespesasPDFGbxInclusao.Name = "frmLerDespesasPDFGbxInclusao";
            this.frmLerDespesasPDFGbxInclusao.Size = new System.Drawing.Size(910, 148);
            this.frmLerDespesasPDFGbxInclusao.TabIndex = 3;
            this.frmLerDespesasPDFGbxInclusao.TabStop = false;
            this.frmLerDespesasPDFGbxInclusao.Text = "Inclusão Avulsa de Despesas";
            this.frmLerDespesasPDFGbxInclusao.Visible = false;
            // 
            // frmLerDespesasPDFDtg
            // 
            this.frmLerDespesasPDFDtg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmLerDespesasPDFDtg.Location = new System.Drawing.Point(6, 21);
            this.frmLerDespesasPDFDtg.Name = "frmLerDespesasPDFDtg";
            this.frmLerDespesasPDFDtg.RowHeadersWidth = 51;
            this.frmLerDespesasPDFDtg.RowTemplate.Height = 24;
            this.frmLerDespesasPDFDtg.Size = new System.Drawing.Size(898, 89);
            this.frmLerDespesasPDFDtg.TabIndex = 5;
            this.frmLerDespesasPDFDtg.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.frmLerDespesasPDFDtg_CellEndEdit);
            // 
            // frmLerDespesasPDFGbxHabilitarInclusao
            // 
            this.frmLerDespesasPDFGbxHabilitarInclusao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.frmLerDespesasPDFGbxHabilitarInclusao.Controls.Add(this.frmLerDespesasPDFRbtSim);
            this.frmLerDespesasPDFGbxHabilitarInclusao.Controls.Add(this.frmLerDespesasPDFRbtNao);
            this.frmLerDespesasPDFGbxHabilitarInclusao.Location = new System.Drawing.Point(26, 85);
            this.frmLerDespesasPDFGbxHabilitarInclusao.Name = "frmLerDespesasPDFGbxHabilitarInclusao";
            this.frmLerDespesasPDFGbxHabilitarInclusao.Size = new System.Drawing.Size(136, 63);
            this.frmLerDespesasPDFGbxHabilitarInclusao.TabIndex = 4;
            this.frmLerDespesasPDFGbxHabilitarInclusao.TabStop = false;
            this.frmLerDespesasPDFGbxHabilitarInclusao.Text = "Incluir despesas manualmente ?";
            // 
            // frmLerDespesasPDFRbtSim
            // 
            this.frmLerDespesasPDFRbtSim.AutoSize = true;
            this.frmLerDespesasPDFRbtSim.Location = new System.Drawing.Point(66, 37);
            this.frmLerDespesasPDFRbtSim.Name = "frmLerDespesasPDFRbtSim";
            this.frmLerDespesasPDFRbtSim.Size = new System.Drawing.Size(51, 20);
            this.frmLerDespesasPDFRbtSim.TabIndex = 1;
            this.frmLerDespesasPDFRbtSim.Text = "Sim";
            this.frmLerDespesasPDFRbtSim.UseVisualStyleBackColor = true;
            this.frmLerDespesasPDFRbtSim.CheckedChanged += new System.EventHandler(this.frmLerDespesasPDFRbtSim_CheckedChanged);
            // 
            // frmLerDespesasPDFRbtNao
            // 
            this.frmLerDespesasPDFRbtNao.AutoSize = true;
            this.frmLerDespesasPDFRbtNao.Checked = true;
            this.frmLerDespesasPDFRbtNao.Location = new System.Drawing.Point(6, 37);
            this.frmLerDespesasPDFRbtNao.Name = "frmLerDespesasPDFRbtNao";
            this.frmLerDespesasPDFRbtNao.Size = new System.Drawing.Size(54, 20);
            this.frmLerDespesasPDFRbtNao.TabIndex = 0;
            this.frmLerDespesasPDFRbtNao.TabStop = true;
            this.frmLerDespesasPDFRbtNao.Text = "Não";
            this.frmLerDespesasPDFRbtNao.UseVisualStyleBackColor = true;
            this.frmLerDespesasPDFRbtNao.CheckedChanged += new System.EventHandler(this.frmLerDespesasPDFRbtNao_CheckedChanged);
            // 
            // frmLerDespesasPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmLerDespesasPDFGbxHabilitarInclusao);
            this.Controls.Add(this.frmLerDespesasPDFGbxInclusao);
            this.Controls.Add(this.frmLerDespesasPDFLblTitulo);
            this.Controls.Add(this.frmLerDespesasPDFBtnAbrir);
            this.Name = "frmLerDespesasPDF";
            this.Size = new System.Drawing.Size(1052, 586);
            this.frmLerDespesasPDFGbxInclusao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.frmLerDespesasPDFDtg)).EndInit();
            this.frmLerDespesasPDFGbxHabilitarInclusao.ResumeLayout(false);
            this.frmLerDespesasPDFGbxHabilitarInclusao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmLerDespesasPDFBtnAbrir;
        private System.Windows.Forms.Label frmLerDespesasPDFLblTitulo;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button frmLerDespesasPDFBtnInclusao;
        private System.Windows.Forms.GroupBox frmLerDespesasPDFGbxInclusao;
        private System.Windows.Forms.DataGridView frmLerDespesasPDFDtg;
        private System.Windows.Forms.GroupBox frmLerDespesasPDFGbxHabilitarInclusao;
        private System.Windows.Forms.RadioButton frmLerDespesasPDFRbtSim;
        private System.Windows.Forms.RadioButton frmLerDespesasPDFRbtNao;
    }
}
