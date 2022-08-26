namespace WindowsFormsApp1
{
    partial class frm_ValidaCPF_UC
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
            this.btn_Valida = new System.Windows.Forms.Button();
            this.btn_Limpa = new System.Windows.Forms.Button();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_Valida
            // 
            this.btn_Valida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Valida.Location = new System.Drawing.Point(901, 40);
            this.btn_Valida.Name = "btn_Valida";
            this.btn_Valida.Size = new System.Drawing.Size(111, 23);
            this.btn_Valida.TabIndex = 7;
            this.btn_Valida.Text = "Valida";
            this.btn_Valida.UseVisualStyleBackColor = true;
            this.btn_Valida.Click += new System.EventHandler(this.btn_Valida_Click);
            // 
            // btn_Limpa
            // 
            this.btn_Limpa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Limpa.Location = new System.Drawing.Point(901, 11);
            this.btn_Limpa.Name = "btn_Limpa";
            this.btn_Limpa.Size = new System.Drawing.Size(111, 23);
            this.btn_Limpa.TabIndex = 6;
            this.btn_Limpa.Text = "Limpa";
            this.btn_Limpa.UseVisualStyleBackColor = true;
            this.btn_Limpa.Click += new System.EventHandler(this.btn_Limpa_Click);
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(11, 56);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(0, 13);
            this.lbl_Resultado.TabIndex = 5;
            // 
            // msk_CPF
            // 
            this.msk_CPF.Location = new System.Drawing.Point(11, 11);
            this.msk_CPF.Mask = "000,000,000,-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(218, 20);
            this.msk_CPF.TabIndex = 4;
            // 
            // frm_ValidaCPF_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Valida);
            this.Controls.Add(this.btn_Limpa);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.msk_CPF);
            this.Name = "frm_ValidaCPF_UC";
            this.Size = new System.Drawing.Size(1027, 558);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Valida;
        private System.Windows.Forms.Button btn_Limpa;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.MaskedTextBox msk_CPF;
    }
}
