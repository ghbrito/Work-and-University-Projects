namespace Calcula_Custas
{
    partial class frmImportaDadosBD
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
            this.lblFrmConfSelosSelecionePeriodo = new System.Windows.Forms.Label();
            this.lblFrmConfSelosDataInicial = new System.Windows.Forms.Label();
            this.mskFrmImportaAtosDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.btnFrmImportaAtosImportar = new System.Windows.Forms.Button();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbDataAdapter1 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mskFrmImportaAtosDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.lblFrmImportaAtosDataFinal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrmConfSelosSelecionePeriodo
            // 
            this.lblFrmConfSelosSelecionePeriodo.AutoSize = true;
            this.lblFrmConfSelosSelecionePeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmConfSelosSelecionePeriodo.Location = new System.Drawing.Point(13, 9);
            this.lblFrmConfSelosSelecionePeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrmConfSelosSelecionePeriodo.Name = "lblFrmConfSelosSelecionePeriodo";
            this.lblFrmConfSelosSelecionePeriodo.Size = new System.Drawing.Size(415, 20);
            this.lblFrmConfSelosSelecionePeriodo.TabIndex = 0;
            this.lblFrmConfSelosSelecionePeriodo.Text = "SELECIONE O PERÍODO PARA CONFERÊNCIA";
            // 
            // lblFrmConfSelosDataInicial
            // 
            this.lblFrmConfSelosDataInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFrmConfSelosDataInicial.AutoSize = true;
            this.lblFrmConfSelosDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmConfSelosDataInicial.Location = new System.Drawing.Point(17, 0);
            this.lblFrmConfSelosDataInicial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrmConfSelosDataInicial.Name = "lblFrmConfSelosDataInicial";
            this.lblFrmConfSelosDataInicial.Size = new System.Drawing.Size(89, 17);
            this.lblFrmConfSelosDataInicial.TabIndex = 2;
            this.lblFrmConfSelosDataInicial.Text = "Data Inicial";
            // 
            // mskFrmImportaAtosDataInicial
            // 
            this.mskFrmImportaAtosDataInicial.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskFrmImportaAtosDataInicial.Location = new System.Drawing.Point(14, 31);
            this.mskFrmImportaAtosDataInicial.Margin = new System.Windows.Forms.Padding(4);
            this.mskFrmImportaAtosDataInicial.Mask = "00/00/0000";
            this.mskFrmImportaAtosDataInicial.Name = "mskFrmImportaAtosDataInicial";
            this.mskFrmImportaAtosDataInicial.Size = new System.Drawing.Size(95, 22);
            this.mskFrmImportaAtosDataInicial.TabIndex = 1;
            this.mskFrmImportaAtosDataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFrmImportaAtosDataInicial.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mskFrmImportaAtosDataInicial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mskFrmConfSeloANO_MouseClick);
            // 
            // btnFrmImportaAtosImportar
            // 
            this.btnFrmImportaAtosImportar.Location = new System.Drawing.Point(300, 29);
            this.btnFrmImportaAtosImportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFrmImportaAtosImportar.Name = "btnFrmImportaAtosImportar";
            this.btnFrmImportaAtosImportar.Size = new System.Drawing.Size(120, 25);
            this.btnFrmImportaAtosImportar.TabIndex = 4;
            this.btnFrmImportaAtosImportar.Text = "IMPORTAR";
            this.btnFrmImportaAtosImportar.UseVisualStyleBackColor = true;
            this.btnFrmImportaAtosImportar.Click += new System.EventHandler(this.btnFrmImportaAtosImportar_Click);
            // 
            // fbCommandBuilder1
            // 
            this.fbCommandBuilder1.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.86851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.13149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 191F));
            this.tableLayoutPanel1.Controls.Add(this.mskFrmImportaAtosDataFinal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFrmImportaAtosDataFinal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFrmConfSelosDataInicial, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mskFrmImportaAtosDataInicial, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnFrmImportaAtosImportar, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(489, 70);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // mskFrmImportaAtosDataFinal
            // 
            this.mskFrmImportaAtosDataFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskFrmImportaAtosDataFinal.Location = new System.Drawing.Point(163, 31);
            this.mskFrmImportaAtosDataFinal.Margin = new System.Windows.Forms.Padding(4);
            this.mskFrmImportaAtosDataFinal.Mask = "00/00/0000";
            this.mskFrmImportaAtosDataFinal.Name = "mskFrmImportaAtosDataFinal";
            this.mskFrmImportaAtosDataFinal.Size = new System.Drawing.Size(95, 22);
            this.mskFrmImportaAtosDataFinal.TabIndex = 2;
            this.mskFrmImportaAtosDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFrmImportaAtosDataFinal
            // 
            this.lblFrmImportaAtosDataFinal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFrmImportaAtosDataFinal.AutoSize = true;
            this.lblFrmImportaAtosDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmImportaAtosDataFinal.Location = new System.Drawing.Point(169, 0);
            this.lblFrmImportaAtosDataFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrmImportaAtosDataFinal.Name = "lblFrmImportaAtosDataFinal";
            this.lblFrmImportaAtosDataFinal.Size = new System.Drawing.Size(82, 17);
            this.lblFrmImportaAtosDataFinal.TabIndex = 9;
            this.lblFrmImportaAtosDataFinal.Text = "Data Final";
            // 
            // frmImportaDadosBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblFrmConfSelosSelecionePeriodo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmImportaDadosBD";
            this.Size = new System.Drawing.Size(897, 626);
            this.Load += new System.EventHandler(this.frmConferenciaSelosUC_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrmConfSelosSelecionePeriodo;
        private System.Windows.Forms.Label lblFrmConfSelosDataInicial;
        private System.Windows.Forms.MaskedTextBox mskFrmImportaAtosDataInicial;
        private System.Windows.Forms.Button btnFrmImportaAtosImportar;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter fbDataAdapter1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MaskedTextBox mskFrmImportaAtosDataFinal;
        private System.Windows.Forms.Label lblFrmImportaAtosDataFinal;
    }
}
