namespace Calcula_Custas
{
    partial class frmRelatorioConsultaSelosBDInterno
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
            this.frmRelatorioConsultaSelosMskDataInicial = new System.Windows.Forms.MaskedTextBox();
            this.alteraSelosBDBtnConsultar = new System.Windows.Forms.Button();
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta = new System.Windows.Forms.DataGridView();
            this.frmRelatorioConsultaSelosCmbCodigoAto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.frmRelatorioConsultaSelosMskDataFinal = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio = new System.Windows.Forms.GroupBox();
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico = new System.Windows.Forms.RadioButton();
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta)).BeginInit();
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAlteraSelosBDTitulo
            // 
            this.lblAlteraSelosBDTitulo.AutoSize = true;
            this.lblAlteraSelosBDTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlteraSelosBDTitulo.Location = new System.Drawing.Point(20, 20);
            this.lblAlteraSelosBDTitulo.Name = "lblAlteraSelosBDTitulo";
            this.lblAlteraSelosBDTitulo.Size = new System.Drawing.Size(402, 23);
            this.lblAlteraSelosBDTitulo.TabIndex = 0;
            this.lblAlteraSelosBDTitulo.Text = "Relatório de Utilização de Selos - BD Interno";
            // 
            // frmRelatorioConsultaSelosMskDataInicial
            // 
            this.frmRelatorioConsultaSelosMskDataInicial.Location = new System.Drawing.Point(24, 88);
            this.frmRelatorioConsultaSelosMskDataInicial.Mask = "00/00/0000";
            this.frmRelatorioConsultaSelosMskDataInicial.Name = "frmRelatorioConsultaSelosMskDataInicial";
            this.frmRelatorioConsultaSelosMskDataInicial.Size = new System.Drawing.Size(95, 22);
            this.frmRelatorioConsultaSelosMskDataInicial.TabIndex = 1;
            this.frmRelatorioConsultaSelosMskDataInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frmRelatorioConsultaSelosMskDataInicial.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.alteraSelosBDMskSeloInicial_MaskInputRejected);
            this.frmRelatorioConsultaSelosMskDataInicial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.alteraSelosBDMskSeloInicial_MouseClick);
            this.frmRelatorioConsultaSelosMskDataInicial.Enter += new System.EventHandler(this.frmRelatorioConsultaSelosMskDataInicial_Enter);
            this.frmRelatorioConsultaSelosMskDataInicial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.alteraSelosBDMskSeloInicial_KeyDown);
            // 
            // alteraSelosBDBtnConsultar
            // 
            this.alteraSelosBDBtnConsultar.Location = new System.Drawing.Point(324, 87);
            this.alteraSelosBDBtnConsultar.Name = "alteraSelosBDBtnConsultar";
            this.alteraSelosBDBtnConsultar.Size = new System.Drawing.Size(125, 25);
            this.alteraSelosBDBtnConsultar.TabIndex = 4;
            this.alteraSelosBDBtnConsultar.Text = "CONSULTAR";
            this.alteraSelosBDBtnConsultar.UseVisualStyleBackColor = true;
            this.alteraSelosBDBtnConsultar.Click += new System.EventHandler(this.alteraSelosBDBtnConsultar_Click);
            // 
            // frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta
            // 
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.AllowUserToAddRows = false;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.AllowUserToDeleteRows = false;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.AllowUserToResizeColumns = false;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.AllowUserToResizeRows = false;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Location = new System.Drawing.Point(24, 118);
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Name = "frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta";
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.ReadOnly = true;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.RowHeadersWidth = 51;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.RowTemplate.Height = 24;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Size = new System.Drawing.Size(1176, 691);
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.TabIndex = 6;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.Visible = false;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.alteraSelosBDDtgConsulta_CellEndEdit);
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.alteraSelosBDDtgConsulta_KeyPress);
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.alteraSelosBDDtgConsulta_KeyUp);
            // 
            // frmRelatorioConsultaSelosCmbCodigoAto
            // 
            this.frmRelatorioConsultaSelosCmbCodigoAto.AutoCompleteCustomSource.AddRange(new string[] {
            "1301",
            "1302",
            "8501",
            "1501",
            "1502",
            "7101",
            "7110",
            "7120",
            "7130",
            "7140",
            "7150",
            "7201",
            "7402",
            "7601",
            "7701",
            "7802",
            "7803",
            "7901",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410",
            "1411",
            "1600",
            "1601",
            "1602",
            "1603",
            "1604",
            "1605",
            "1606",
            "1607",
            "1608",
            "1609",
            "1610",
            "1611",
            "1416",
            "1417",
            "1418",
            "1435",
            "1436",
            "1460",
            "1461",
            "1462",
            "1463",
            "1464",
            "1465",
            "1466",
            "1467",
            "1468",
            "1469",
            "1470",
            "1670",
            "1671",
            "1672",
            "1673",
            "1674",
            "1675",
            "1676",
            "1677",
            "1678",
            "1679",
            "1680",
            "1681",
            "1475",
            "1476",
            "1437",
            "1438",
            "1455",
            "1458",
            "1477",
            "8101",
            "8401",
            "8402",
            "1202",
            "1203",
            "1485",
            "7804",
            "7180",
            "1484",
            "8502",
            "1482",
            "TODOS"});
            this.frmRelatorioConsultaSelosCmbCodigoAto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.frmRelatorioConsultaSelosCmbCodigoAto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.frmRelatorioConsultaSelosCmbCodigoAto.FormattingEnabled = true;
            this.frmRelatorioConsultaSelosCmbCodigoAto.Items.AddRange(new object[] {
            "1301",
            "1302",
            "8501",
            "1501",
            "1502",
            "7101",
            "7110",
            "7120",
            "7130",
            "7140",
            "7150",
            "7201",
            "7402",
            "7601",
            "7701",
            "7802",
            "7803",
            "7901",
            "1401",
            "1402",
            "1403",
            "1404",
            "1405",
            "1406",
            "1407",
            "1408",
            "1409",
            "1410",
            "1411",
            "1600",
            "1601",
            "1602",
            "1603",
            "1604",
            "1605",
            "1606",
            "1607",
            "1608",
            "1609",
            "1610",
            "1611",
            "1416",
            "1417",
            "1418",
            "1435",
            "1436",
            "1460",
            "1461",
            "1462",
            "1463",
            "1464",
            "1465",
            "1466",
            "1467",
            "1468",
            "1469",
            "1470",
            "1670",
            "1671",
            "1672",
            "1673",
            "1674",
            "1675",
            "1676",
            "1677",
            "1678",
            "1679",
            "1680",
            "1681",
            "1475",
            "1476",
            "1437",
            "1438",
            "1455",
            "1458",
            "1477",
            "8101",
            "8401",
            "8402",
            "1202",
            "1203",
            "1485",
            "7804",
            "7180",
            "1484",
            "8502",
            "1482",
            "TODOS"});
            this.frmRelatorioConsultaSelosCmbCodigoAto.Location = new System.Drawing.Point(238, 88);
            this.frmRelatorioConsultaSelosCmbCodigoAto.Name = "frmRelatorioConsultaSelosCmbCodigoAto";
            this.frmRelatorioConsultaSelosCmbCodigoAto.Size = new System.Drawing.Size(80, 24);
            this.frmRelatorioConsultaSelosCmbCodigoAto.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data Final";
            // 
            // frmRelatorioConsultaSelosMskDataFinal
            // 
            this.frmRelatorioConsultaSelosMskDataFinal.Location = new System.Drawing.Point(126, 88);
            this.frmRelatorioConsultaSelosMskDataFinal.Mask = "00/00/0000";
            this.frmRelatorioConsultaSelosMskDataFinal.Name = "frmRelatorioConsultaSelosMskDataFinal";
            this.frmRelatorioConsultaSelosMskDataFinal.Size = new System.Drawing.Size(95, 22);
            this.frmRelatorioConsultaSelosMskDataFinal.TabIndex = 2;
            this.frmRelatorioConsultaSelosMskDataFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.frmRelatorioConsultaSelosMskDataFinal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmRelatorioConsultaSelosMskDataFinal_MouseClick);
            this.frmRelatorioConsultaSelosMskDataFinal.Enter += new System.EventHandler(this.frmRelatorioConsultaSelosMskDataFinal_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(234, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Código Ato";
            // 
            // frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio
            // 
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.Controls.Add(this.frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico);
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.Controls.Add(this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico);
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.Location = new System.Drawing.Point(455, 61);
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.Name = "frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio";
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.Size = new System.Drawing.Size(173, 51);
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.TabIndex = 13;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.TabStop = false;
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.Text = "Tipo de Relatório";
            // 
            // frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico
            // 
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.AutoSize = true;
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.Checked = true;
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.Location = new System.Drawing.Point(6, 21);
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.Name = "frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico";
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.Size = new System.Drawing.Size(79, 20);
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.TabIndex = 0;
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.TabStop = true;
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.Text = "Sintético";
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.UseVisualStyleBackColor = true;
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico.CheckedChanged += new System.EventHandler(this.frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico_CheckedChanged);
            // 
            // frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico
            // 
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico.AutoSize = true;
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico.Location = new System.Drawing.Point(88, 21);
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico.Name = "frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico";
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico.Size = new System.Drawing.Size(79, 20);
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico.TabIndex = 1;
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico.Text = "Analítico";
            this.frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico.UseVisualStyleBackColor = true;
            // 
            // frmRelatorioConsultaSelosBDInterno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.frmRelatorioConsultaSelosMskDataFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.frmRelatorioConsultaSelosCmbCodigoAto);
            this.Controls.Add(this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta);
            this.Controls.Add(this.alteraSelosBDBtnConsultar);
            this.Controls.Add(this.frmRelatorioConsultaSelosMskDataInicial);
            this.Controls.Add(this.lblAlteraSelosBDTitulo);
            this.Name = "frmRelatorioConsultaSelosBDInterno";
            this.Size = new System.Drawing.Size(1251, 826);
            ((System.ComponentModel.ISupportInitialize)(this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta)).EndInit();
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.ResumeLayout(false);
            this.frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAlteraSelosBDTitulo;
        private System.Windows.Forms.MaskedTextBox frmRelatorioConsultaSelosMskDataInicial;
        private System.Windows.Forms.Button alteraSelosBDBtnConsultar;
        private System.Windows.Forms.DataGridView frmRelatorioConsultaUtilizacaoDeSelosBDInternoDtgConsulta;
        private System.Windows.Forms.ComboBox frmRelatorioConsultaSelosCmbCodigoAto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox frmRelatorioConsultaSelosMskDataFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox frmRelatorioConsultaUtilizacaoDeSelosBDInternoGbxTipoRelatorio;
        private System.Windows.Forms.RadioButton frmRelatorioConsultaUtilizacaoDeSelosRdbAnalitico;
        private System.Windows.Forms.RadioButton frmRelatorioConsultaUtilizacaoDeSelosRdbSintetico;
    }
}
