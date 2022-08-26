namespace WindowsFormsApp1
{
    partial class frm_Demonstracao_UC
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
            this.Lbl_Lower = new System.Windows.Forms.Label();
            this.Lbl_Upper = new System.Windows.Forms.Label();
            this.LbL_Maius = new System.Windows.Forms.Label();
            this.Lbl_Minus = new System.Windows.Forms.Label();
            this.Bts_Reset = new System.Windows.Forms.Button();
            this.Txt_Msg = new System.Windows.Forms.TextBox();
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_Lower
            // 
            this.Lbl_Lower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Lower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Lower.Location = new System.Drawing.Point(736, 110);
            this.Lbl_Lower.Name = "Lbl_Lower";
            this.Lbl_Lower.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Lower.TabIndex = 13;
            // 
            // Lbl_Upper
            // 
            this.Lbl_Upper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Upper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_Upper.Location = new System.Drawing.Point(736, 62);
            this.Lbl_Upper.Name = "Lbl_Upper";
            this.Lbl_Upper.Size = new System.Drawing.Size(32, 23);
            this.Lbl_Upper.TabIndex = 12;
            // 
            // LbL_Maius
            // 
            this.LbL_Maius.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LbL_Maius.Location = new System.Drawing.Point(689, 63);
            this.LbL_Maius.Name = "LbL_Maius";
            this.LbL_Maius.Size = new System.Drawing.Size(40, 16);
            this.LbL_Maius.TabIndex = 11;
            this.LbL_Maius.Text = "Maius.";
            // 
            // Lbl_Minus
            // 
            this.Lbl_Minus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Minus.Location = new System.Drawing.Point(689, 111);
            this.Lbl_Minus.Name = "Lbl_Minus";
            this.Lbl_Minus.Size = new System.Drawing.Size(40, 16);
            this.Lbl_Minus.TabIndex = 10;
            this.Lbl_Minus.Text = "Minus.";
            // 
            // Bts_Reset
            // 
            this.Bts_Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Bts_Reset.Location = new System.Drawing.Point(697, 15);
            this.Bts_Reset.Name = "Bts_Reset";
            this.Bts_Reset.Size = new System.Drawing.Size(75, 28);
            this.Bts_Reset.TabIndex = 9;
            this.Bts_Reset.Text = "Limpar";
            this.Bts_Reset.UseVisualStyleBackColor = true;
            this.Bts_Reset.Click += new System.EventHandler(this.Bts_Reset_Click);
            // 
            // Txt_Msg
            // 
            this.Txt_Msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_Msg.Location = new System.Drawing.Point(18, 50);
            this.Txt_Msg.Multiline = true;
            this.Txt_Msg.Name = "Txt_Msg";
            this.Txt_Msg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Msg.Size = new System.Drawing.Size(649, 232);
            this.Txt_Msg.TabIndex = 8;
            this.Txt_Msg.TabStop = false;
            // 
            // Txt_Input
            // 
            this.Txt_Input.Location = new System.Drawing.Point(16, 16);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(100, 20);
            this.Txt_Input.TabIndex = 7;
            this.Txt_Input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_Input_KeyDown);
            // 
            // frm_Demonstracao_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Lbl_Lower);
            this.Controls.Add(this.Lbl_Upper);
            this.Controls.Add(this.LbL_Maius);
            this.Controls.Add(this.Lbl_Minus);
            this.Controls.Add(this.Bts_Reset);
            this.Controls.Add(this.Txt_Msg);
            this.Controls.Add(this.Txt_Input);
            this.Name = "frm_Demonstracao_UC";
            this.Size = new System.Drawing.Size(775, 553);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Lower;
        private System.Windows.Forms.Label Lbl_Upper;
        private System.Windows.Forms.Label LbL_Maius;
        private System.Windows.Forms.Label Lbl_Minus;
        private System.Windows.Forms.Button Bts_Reset;
        private System.Windows.Forms.TextBox Txt_Msg;
        private System.Windows.Forms.TextBox Txt_Input;
    }
}
