namespace Calcula_Custas
{
    partial class frmInputDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.frmInputDialogOK = new System.Windows.Forms.Button();
            this.frmInputBoxLblRecBruto = new System.Windows.Forms.Label();
            this.frmInputBoxLblDescIR = new System.Windows.Forms.Label();
            this.frmInputBoxLblTxRec = new System.Windows.Forms.Label();
            this.frmInputBoxLblRecDepositado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.frmInputDialogNumberBoxValorBruto = new Calcula_Custas.Classes.NumberBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.frmInputDialogNumberBoxDescontoIR = new Calcula_Custas.Classes.NumberBox();
            this.frmInputDialogNumberBoxTaxaRecivil = new Calcula_Custas.Classes.NumberBox();
            this.frmInputDialogNumberBoxValorLiquidoDepositado = new Calcula_Custas.Classes.NumberBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // frmInputDialogOK
            // 
            this.frmInputDialogOK.Location = new System.Drawing.Point(318, 126);
            this.frmInputDialogOK.Name = "frmInputDialogOK";
            this.frmInputDialogOK.Size = new System.Drawing.Size(75, 23);
            this.frmInputDialogOK.TabIndex = 0;
            this.frmInputDialogOK.Text = "Salvar";
            this.frmInputDialogOK.UseVisualStyleBackColor = true;
            this.frmInputDialogOK.Click += new System.EventHandler(this.frmInputDialogOK_Click);
            // 
            // frmInputBoxLblRecBruto
            // 
            this.frmInputBoxLblRecBruto.AutoSize = true;
            this.frmInputBoxLblRecBruto.Location = new System.Drawing.Point(97, 57);
            this.frmInputBoxLblRecBruto.Name = "frmInputBoxLblRecBruto";
            this.frmInputBoxLblRecBruto.Size = new System.Drawing.Size(73, 16);
            this.frmInputBoxLblRecBruto.TabIndex = 5;
            this.frmInputBoxLblRecBruto.Text = "Valor Bruto";
            // 
            // frmInputBoxLblDescIR
            // 
            this.frmInputBoxLblDescIR.AutoSize = true;
            this.frmInputBoxLblDescIR.Location = new System.Drawing.Point(89, 82);
            this.frmInputBoxLblDescIR.Name = "frmInputBoxLblDescIR";
            this.frmInputBoxLblDescIR.Size = new System.Drawing.Size(81, 16);
            this.frmInputBoxLblDescIR.TabIndex = 6;
            this.frmInputBoxLblDescIR.Text = "Desconto IR";
            // 
            // frmInputBoxLblTxRec
            // 
            this.frmInputBoxLblTxRec.AutoSize = true;
            this.frmInputBoxLblTxRec.Location = new System.Drawing.Point(88, 110);
            this.frmInputBoxLblTxRec.Name = "frmInputBoxLblTxRec";
            this.frmInputBoxLblTxRec.Size = new System.Drawing.Size(82, 16);
            this.frmInputBoxLblTxRec.TabIndex = 7;
            this.frmInputBoxLblTxRec.Text = "Taxa Recivil";
            // 
            // frmInputBoxLblRecDepositado
            // 
            this.frmInputBoxLblRecDepositado.AutoSize = true;
            this.frmInputBoxLblRecDepositado.Location = new System.Drawing.Point(10, 133);
            this.frmInputBoxLblRecDepositado.Name = "frmInputBoxLblRecDepositado";
            this.frmInputBoxLblRecDepositado.Size = new System.Drawing.Size(160, 16);
            this.frmInputBoxLblRecDepositado.TabIndex = 8;
            this.frmInputBoxLblRecDepositado.Text = "Valor Líquido Depositado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Preencha os valores relativos ao repasse do mês (RECOMPE)";
            // 
            // frmInputDialogNumberBoxValorBruto
            // 
            this.frmInputDialogNumberBoxValorBruto.ErrorProvider = this.errorProvider1;
            this.frmInputDialogNumberBoxValorBruto.Location = new System.Drawing.Point(176, 51);
            this.frmInputDialogNumberBoxValorBruto.Name = "frmInputDialogNumberBoxValorBruto";
            this.frmInputDialogNumberBoxValorBruto.Size = new System.Drawing.Size(100, 22);
            this.frmInputDialogNumberBoxValorBruto.TabIndex = 10;
            this.frmInputDialogNumberBoxValorBruto.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmInputDialogNumberBoxDescontoIR
            // 
            this.frmInputDialogNumberBoxDescontoIR.ErrorProvider = this.errorProvider1;
            this.frmInputDialogNumberBoxDescontoIR.Location = new System.Drawing.Point(176, 76);
            this.frmInputDialogNumberBoxDescontoIR.Name = "frmInputDialogNumberBoxDescontoIR";
            this.frmInputDialogNumberBoxDescontoIR.Size = new System.Drawing.Size(100, 22);
            this.frmInputDialogNumberBoxDescontoIR.TabIndex = 11;
            this.frmInputDialogNumberBoxDescontoIR.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // frmInputDialogNumberBoxTaxaRecivil
            // 
            this.frmInputDialogNumberBoxTaxaRecivil.ErrorProvider = this.errorProvider1;
            this.frmInputDialogNumberBoxTaxaRecivil.Location = new System.Drawing.Point(176, 101);
            this.frmInputDialogNumberBoxTaxaRecivil.Name = "frmInputDialogNumberBoxTaxaRecivil";
            this.frmInputDialogNumberBoxTaxaRecivil.Size = new System.Drawing.Size(100, 22);
            this.frmInputDialogNumberBoxTaxaRecivil.TabIndex = 12;
            this.frmInputDialogNumberBoxTaxaRecivil.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // frmInputDialogNumberBoxValorLiquidoDepositado
            // 
            this.frmInputDialogNumberBoxValorLiquidoDepositado.ErrorProvider = this.errorProvider1;
            this.frmInputDialogNumberBoxValorLiquidoDepositado.Location = new System.Drawing.Point(176, 127);
            this.frmInputDialogNumberBoxValorLiquidoDepositado.Name = "frmInputDialogNumberBoxValorLiquidoDepositado";
            this.frmInputDialogNumberBoxValorLiquidoDepositado.Size = new System.Drawing.Size(100, 22);
            this.frmInputDialogNumberBoxValorLiquidoDepositado.TabIndex = 13;
            this.frmInputDialogNumberBoxValorLiquidoDepositado.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // frmInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 175);
            this.Controls.Add(this.frmInputDialogNumberBoxValorLiquidoDepositado);
            this.Controls.Add(this.frmInputDialogNumberBoxTaxaRecivil);
            this.Controls.Add(this.frmInputDialogNumberBoxDescontoIR);
            this.Controls.Add(this.frmInputDialogNumberBoxValorBruto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmInputBoxLblRecDepositado);
            this.Controls.Add(this.frmInputBoxLblTxRec);
            this.Controls.Add(this.frmInputBoxLblDescIR);
            this.Controls.Add(this.frmInputBoxLblRecBruto);
            this.Controls.Add(this.frmInputDialogOK);
            this.Name = "frmInputDialog";
            this.Text = "Repasses RECOMPE";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmInputDialogOK;
        private System.Windows.Forms.Label frmInputBoxLblRecBruto;
        private System.Windows.Forms.Label frmInputBoxLblDescIR;
        private System.Windows.Forms.Label frmInputBoxLblTxRec;
        private System.Windows.Forms.Label frmInputBoxLblRecDepositado;
        private System.Windows.Forms.Label label1;
        private Classes.NumberBox frmInputDialogNumberBoxValorBruto;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Classes.NumberBox frmInputDialogNumberBoxValorLiquidoDepositado;
        private Classes.NumberBox frmInputDialogNumberBoxTaxaRecivil;
        private Classes.NumberBox frmInputDialogNumberBoxDescontoIR;
    }
}