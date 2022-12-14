namespace Calcula_Custas
{
    partial class frmAtualizarValoresTabelas
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
            this.btnAtualizarValoresAbrirPDF = new System.Windows.Forms.Button();
            this.lblAtualizarValores = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAtualizarValoresAbrirPDF
            // 
            this.btnAtualizarValoresAbrirPDF.AutoSize = true;
            this.btnAtualizarValoresAbrirPDF.Location = new System.Drawing.Point(391, 3);
            this.btnAtualizarValoresAbrirPDF.Name = "btnAtualizarValoresAbrirPDF";
            this.btnAtualizarValoresAbrirPDF.Size = new System.Drawing.Size(75, 26);
            this.btnAtualizarValoresAbrirPDF.TabIndex = 0;
            this.btnAtualizarValoresAbrirPDF.Text = "Abrir";
            this.btnAtualizarValoresAbrirPDF.UseVisualStyleBackColor = true;
            this.btnAtualizarValoresAbrirPDF.Click += new System.EventHandler(this.btnAtualizarValoresAbrirPDF_Click);
            // 
            // lblAtualizarValores
            // 
            this.lblAtualizarValores.AutoSize = true;
            this.lblAtualizarValores.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtualizarValores.Location = new System.Drawing.Point(3, 0);
            this.lblAtualizarValores.Name = "lblAtualizarValores";
            this.lblAtualizarValores.Size = new System.Drawing.Size(338, 48);
            this.lblAtualizarValores.TabIndex = 1;
            this.lblAtualizarValores.Text = "Selecione o arquivo com os valores a serem atualizados na tabela de emolumentos: " +
    "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblAtualizarValores, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAtualizarValoresAbrirPDF, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(777, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // frmAtualizarValoresTabelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAtualizarValoresTabelas";
            this.Size = new System.Drawing.Size(998, 577);
            //this.Load += new System.EventHandler(this.frmAtualizarValoresTabelas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAtualizarValoresAbrirPDF;
        private System.Windows.Forms.Label lblAtualizarValores;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
