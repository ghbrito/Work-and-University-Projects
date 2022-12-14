namespace Calcula_Custas
{
    partial class frmConferenciaSelosUC
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
            this.cbFrmConfSeloMES = new System.Windows.Forms.ComboBox();
            this.lblFrmConfSelosANO = new System.Windows.Forms.Label();
            this.lblFrmConfSelosMES = new System.Windows.Forms.Label();
            this.lblFrmConfSelosSEMANA = new System.Windows.Forms.Label();
            this.mskFrmConfSeloANO = new System.Windows.Forms.MaskedTextBox();
            this.cbConfSelosSemana = new System.Windows.Forms.ComboBox();
            this.btnConfSelosPesquisar = new System.Windows.Forms.Button();
            this.fbCommand1 = new FirebirdSql.Data.FirebirdClient.FbCommand();
            this.fbConnection1 = new FirebirdSql.Data.FirebirdClient.FbConnection();
            this.fbDataAdapter1 = new FirebirdSql.Data.FirebirdClient.FbDataAdapter();
            this.fbCommandBuilder1 = new FirebirdSql.Data.FirebirdClient.FbCommandBuilder();
            this.dtgConfSelosRegCiv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxConfSelosResultadoPesquisa = new System.Windows.Forms.GroupBox();
            this.btnConfSelosRecalcularValores = new System.Windows.Forms.Button();
            this.lblConfSelosTotalEmolNotasValor = new System.Windows.Forms.Label();
            this.lblConfSelosTotalEmolNotasTitulo = new System.Windows.Forms.Label();
            this.dtgConfSelosNotas = new System.Windows.Forms.DataGridView();
            this.lblConfSelosTotalEmolRegCivTitulo = new System.Windows.Forms.Label();
            this.lblConfSelosTotalEmolRegCivValor = new System.Windows.Forms.Label();
            this.lblConfSelosTotalGeralEmolumentosValor = new System.Windows.Forms.Label();
            this.lblConfSelosTotalGeralEmolumentos = new System.Windows.Forms.Label();
            this.lblConfSelosTotalGeralRecompeValor = new System.Windows.Forms.Label();
            this.lblConfSelosTotalGeralRecompe = new System.Windows.Forms.Label();
            this.lblConfSelosTotalGeralTFJValor = new System.Windows.Forms.Label();
            this.lblConfSelosTotalGeralTFJ = new System.Windows.Forms.Label();
            this.gbxConfSelosTotalConsultas = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfSelosRegCiv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbxConfSelosResultadoPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfSelosNotas)).BeginInit();
            this.gbxConfSelosTotalConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFrmConfSelosSelecionePeriodo
            // 
            this.lblFrmConfSelosSelecionePeriodo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFrmConfSelosSelecionePeriodo.AutoSize = true;
            this.lblFrmConfSelosSelecionePeriodo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmConfSelosSelecionePeriodo.Location = new System.Drawing.Point(6, 4);
            this.lblFrmConfSelosSelecionePeriodo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrmConfSelosSelecionePeriodo.Name = "lblFrmConfSelosSelecionePeriodo";
            this.lblFrmConfSelosSelecionePeriodo.Size = new System.Drawing.Size(446, 23);
            this.lblFrmConfSelosSelecionePeriodo.TabIndex = 0;
            this.lblFrmConfSelosSelecionePeriodo.Text = "SELECIONE O PERÍODO PARA CONFERÊNCIA";
            // 
            // cbFrmConfSeloMES
            // 
            this.cbFrmConfSeloMES.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbFrmConfSeloMES.FormattingEnabled = true;
            this.cbFrmConfSeloMES.Items.AddRange(new object[] {
            "1 - JANEIRO",
            "2 - FEVEREIRO",
            "3 - MARÇO",
            "4 - ABRIL",
            "5 - MAIO",
            "6 - JUNHO",
            "7 - JULHO",
            "8 - AGOSTO",
            "9 - SETEMBRO",
            "10 - OUTUBRO",
            "11 - NOVEMBRO",
            "12 - DEZEMBRO"});
            this.cbFrmConfSeloMES.Location = new System.Drawing.Point(220, 46);
            this.cbFrmConfSeloMES.Margin = new System.Windows.Forms.Padding(6);
            this.cbFrmConfSeloMES.Name = "cbFrmConfSeloMES";
            this.cbFrmConfSeloMES.Size = new System.Drawing.Size(238, 32);
            this.cbFrmConfSeloMES.TabIndex = 2;
            // 
            // lblFrmConfSelosANO
            // 
            this.lblFrmConfSelosANO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFrmConfSelosANO.AutoSize = true;
            this.lblFrmConfSelosANO.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmConfSelosANO.Location = new System.Drawing.Point(82, 0);
            this.lblFrmConfSelosANO.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrmConfSelosANO.Name = "lblFrmConfSelosANO";
            this.lblFrmConfSelosANO.Size = new System.Drawing.Size(35, 16);
            this.lblFrmConfSelosANO.TabIndex = 2;
            this.lblFrmConfSelosANO.Text = "ANO";
            // 
            // lblFrmConfSelosMES
            // 
            this.lblFrmConfSelosMES.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFrmConfSelosMES.AutoSize = true;
            this.lblFrmConfSelosMES.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmConfSelosMES.Location = new System.Drawing.Point(321, 0);
            this.lblFrmConfSelosMES.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrmConfSelosMES.Name = "lblFrmConfSelosMES";
            this.lblFrmConfSelosMES.Size = new System.Drawing.Size(36, 16);
            this.lblFrmConfSelosMES.TabIndex = 3;
            this.lblFrmConfSelosMES.Text = "MÊS";
            // 
            // lblFrmConfSelosSEMANA
            // 
            this.lblFrmConfSelosSEMANA.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFrmConfSelosSEMANA.AutoSize = true;
            this.lblFrmConfSelosSEMANA.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrmConfSelosSEMANA.Location = new System.Drawing.Point(554, 0);
            this.lblFrmConfSelosSEMANA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFrmConfSelosSEMANA.Name = "lblFrmConfSelosSEMANA";
            this.lblFrmConfSelosSEMANA.Size = new System.Drawing.Size(133, 16);
            this.lblFrmConfSelosSEMANA.TabIndex = 4;
            this.lblFrmConfSelosSEMANA.Text = "SEMANA / PERÍODO";
            // 
            // mskFrmConfSeloANO
            // 
            this.mskFrmConfSeloANO.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mskFrmConfSeloANO.Location = new System.Drawing.Point(30, 46);
            this.mskFrmConfSeloANO.Margin = new System.Windows.Forms.Padding(6);
            this.mskFrmConfSeloANO.Mask = "0000";
            this.mskFrmConfSeloANO.Name = "mskFrmConfSeloANO";
            this.mskFrmConfSeloANO.Size = new System.Drawing.Size(140, 30);
            this.mskFrmConfSeloANO.TabIndex = 1;
            this.mskFrmConfSeloANO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mskFrmConfSeloANO.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mskFrmConfSeloANO.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mskFrmConfSeloANO_MouseClick);
            // 
            // cbConfSelosSemana
            // 
            this.cbConfSelosSemana.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbConfSelosSemana.FormattingEnabled = true;
            this.cbConfSelosSemana.Items.AddRange(new object[] {
            "S1 - (01 a 07)",
            "S2 - (08 a 14)",
            "S3 - (15 a 21)",
            "S4 - (22 ao fim)",
            "Mês inteiro"});
            this.cbConfSelosSemana.Location = new System.Drawing.Point(501, 46);
            this.cbConfSelosSemana.Margin = new System.Windows.Forms.Padding(6);
            this.cbConfSelosSemana.Name = "cbConfSelosSemana";
            this.cbConfSelosSemana.Size = new System.Drawing.Size(238, 32);
            this.cbConfSelosSemana.TabIndex = 3;
            this.cbConfSelosSemana.SelectedIndexChanged += new System.EventHandler(this.cbConfSelosSemana_SelectedIndexChanged);
            // 
            // btnConfSelosPesquisar
            // 
            this.btnConfSelosPesquisar.Location = new System.Drawing.Point(767, 43);
            this.btnConfSelosPesquisar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfSelosPesquisar.Name = "btnConfSelosPesquisar";
            this.btnConfSelosPesquisar.Size = new System.Drawing.Size(180, 38);
            this.btnConfSelosPesquisar.TabIndex = 4;
            this.btnConfSelosPesquisar.Text = "PESQUISAR";
            this.btnConfSelosPesquisar.UseVisualStyleBackColor = true;
            this.btnConfSelosPesquisar.Click += new System.EventHandler(this.btnConfSelosPesquisar_Click);
            // 
            // fbConnection1
            // 
            this.fbConnection1.InfoMessage += new System.EventHandler<FirebirdSql.Data.FirebirdClient.FbInfoMessageEventArgs>(this.fbConnection1_InfoMessage_1);
            // 
            // fbCommandBuilder1
            // 
            this.fbCommandBuilder1.ConflictOption = System.Data.ConflictOption.OverwriteChanges;
            // 
            // dtgConfSelosRegCiv
            // 
            this.dtgConfSelosRegCiv.AllowUserToAddRows = false;
            this.dtgConfSelosRegCiv.AllowUserToDeleteRows = false;
            this.dtgConfSelosRegCiv.AllowUserToOrderColumns = true;
            this.dtgConfSelosRegCiv.AllowUserToResizeColumns = false;
            this.dtgConfSelosRegCiv.AllowUserToResizeRows = false;
            this.dtgConfSelosRegCiv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgConfSelosRegCiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConfSelosRegCiv.Location = new System.Drawing.Point(12, 68);
            this.dtgConfSelosRegCiv.Margin = new System.Windows.Forms.Padding(4);
            this.dtgConfSelosRegCiv.MultiSelect = false;
            this.dtgConfSelosRegCiv.Name = "dtgConfSelosRegCiv";
            this.dtgConfSelosRegCiv.ReadOnly = true;
            this.dtgConfSelosRegCiv.RowHeadersWidth = 51;
            this.dtgConfSelosRegCiv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgConfSelosRegCiv.RowTemplate.Height = 24;
            this.dtgConfSelosRegCiv.Size = new System.Drawing.Size(719, 373);
            this.dtgConfSelosRegCiv.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.86851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.13149F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 285F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 253F));
            this.tableLayoutPanel1.Controls.Add(this.lblFrmConfSelosANO, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mskFrmConfSeloANO, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfSelosPesquisar, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbFrmConfSeloMES, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFrmConfSelosSEMANA, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbConfSelosSemana, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFrmConfSelosMES, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1017, 104);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // gbxConfSelosResultadoPesquisa
            // 
            this.gbxConfSelosResultadoPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxConfSelosResultadoPesquisa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxConfSelosResultadoPesquisa.Controls.Add(this.btnConfSelosRecalcularValores);
            this.gbxConfSelosResultadoPesquisa.Controls.Add(this.lblConfSelosTotalEmolNotasValor);
            this.gbxConfSelosResultadoPesquisa.Controls.Add(this.lblConfSelosTotalEmolNotasTitulo);
            this.gbxConfSelosResultadoPesquisa.Controls.Add(this.dtgConfSelosNotas);
            this.gbxConfSelosResultadoPesquisa.Controls.Add(this.lblConfSelosTotalEmolRegCivTitulo);
            this.gbxConfSelosResultadoPesquisa.Controls.Add(this.lblConfSelosTotalEmolRegCivValor);
            this.gbxConfSelosResultadoPesquisa.Controls.Add(this.dtgConfSelosRegCiv);
            this.gbxConfSelosResultadoPesquisa.Location = new System.Drawing.Point(12, 152);
            this.gbxConfSelosResultadoPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.gbxConfSelosResultadoPesquisa.Name = "gbxConfSelosResultadoPesquisa";
            this.gbxConfSelosResultadoPesquisa.Padding = new System.Windows.Forms.Padding(4);
            this.gbxConfSelosResultadoPesquisa.Size = new System.Drawing.Size(1468, 522);
            this.gbxConfSelosResultadoPesquisa.TabIndex = 8;
            this.gbxConfSelosResultadoPesquisa.TabStop = false;
            this.gbxConfSelosResultadoPesquisa.Visible = false;
            this.gbxConfSelosResultadoPesquisa.Enter += new System.EventHandler(this.gbxConfSelosResultadoPesquisa_Enter);
            // 
            // btnConfSelosRecalcularValores
            // 
            this.btnConfSelosRecalcularValores.Location = new System.Drawing.Point(1278, 23);
            this.btnConfSelosRecalcularValores.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConfSelosRecalcularValores.Name = "btnConfSelosRecalcularValores";
            this.btnConfSelosRecalcularValores.Size = new System.Drawing.Size(180, 38);
            this.btnConfSelosRecalcularValores.TabIndex = 5;
            this.btnConfSelosRecalcularValores.Text = "RECALCULAR";
            this.btnConfSelosRecalcularValores.UseVisualStyleBackColor = true;
            this.btnConfSelosRecalcularValores.Click += new System.EventHandler(this.btnConfSelosRecalcularValores_Click);
            // 
            // lblConfSelosTotalEmolNotasValor
            // 
            this.lblConfSelosTotalEmolNotasValor.AutoSize = true;
            this.lblConfSelosTotalEmolNotasValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConfSelosTotalEmolNotasValor.Location = new System.Drawing.Point(805, 481);
            this.lblConfSelosTotalEmolNotasValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfSelosTotalEmolNotasValor.Name = "lblConfSelosTotalEmolNotasValor";
            this.lblConfSelosTotalEmolNotasValor.Size = new System.Drawing.Size(2, 26);
            this.lblConfSelosTotalEmolNotasValor.TabIndex = 13;
            // 
            // lblConfSelosTotalEmolNotasTitulo
            // 
            this.lblConfSelosTotalEmolNotasTitulo.AutoSize = true;
            this.lblConfSelosTotalEmolNotasTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSelosTotalEmolNotasTitulo.Location = new System.Drawing.Point(801, 445);
            this.lblConfSelosTotalEmolNotasTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfSelosTotalEmolNotasTitulo.Name = "lblConfSelosTotalEmolNotasTitulo";
            this.lblConfSelosTotalEmolNotasTitulo.Size = new System.Drawing.Size(259, 23);
            this.lblConfSelosTotalEmolNotasTitulo.TabIndex = 12;
            this.lblConfSelosTotalEmolNotasTitulo.Text = "Total de emolumentos Notas";
            // 
            // dtgConfSelosNotas
            // 
            this.dtgConfSelosNotas.AllowUserToAddRows = false;
            this.dtgConfSelosNotas.AllowUserToDeleteRows = false;
            this.dtgConfSelosNotas.AllowUserToOrderColumns = true;
            this.dtgConfSelosNotas.AllowUserToResizeColumns = false;
            this.dtgConfSelosNotas.AllowUserToResizeRows = false;
            this.dtgConfSelosNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dtgConfSelosNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConfSelosNotas.Location = new System.Drawing.Point(739, 68);
            this.dtgConfSelosNotas.Margin = new System.Windows.Forms.Padding(4);
            this.dtgConfSelosNotas.MultiSelect = false;
            this.dtgConfSelosNotas.Name = "dtgConfSelosNotas";
            this.dtgConfSelosNotas.ReadOnly = true;
            this.dtgConfSelosNotas.RowHeadersWidth = 51;
            this.dtgConfSelosNotas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgConfSelosNotas.RowTemplate.Height = 24;
            this.dtgConfSelosNotas.Size = new System.Drawing.Size(719, 373);
            this.dtgConfSelosNotas.TabIndex = 11;
            // 
            // lblConfSelosTotalEmolRegCivTitulo
            // 
            this.lblConfSelosTotalEmolRegCivTitulo.AutoSize = true;
            this.lblConfSelosTotalEmolRegCivTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfSelosTotalEmolRegCivTitulo.Location = new System.Drawing.Point(58, 445);
            this.lblConfSelosTotalEmolRegCivTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfSelosTotalEmolRegCivTitulo.Name = "lblConfSelosTotalEmolRegCivTitulo";
            this.lblConfSelosTotalEmolRegCivTitulo.Size = new System.Drawing.Size(291, 23);
            this.lblConfSelosTotalEmolRegCivTitulo.TabIndex = 9;
            this.lblConfSelosTotalEmolRegCivTitulo.Text = "Total de emolumentos Reg. Civil";
            // 
            // lblConfSelosTotalEmolRegCivValor
            // 
            this.lblConfSelosTotalEmolRegCivValor.AutoSize = true;
            this.lblConfSelosTotalEmolRegCivValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConfSelosTotalEmolRegCivValor.Location = new System.Drawing.Point(62, 481);
            this.lblConfSelosTotalEmolRegCivValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfSelosTotalEmolRegCivValor.Name = "lblConfSelosTotalEmolRegCivValor";
            this.lblConfSelosTotalEmolRegCivValor.Size = new System.Drawing.Size(2, 26);
            this.lblConfSelosTotalEmolRegCivValor.TabIndex = 10;
            this.lblConfSelosTotalEmolRegCivValor.Click += new System.EventHandler(this.lblConfSelosValorEmolValor_Click);
            // 
            // lblConfSelosTotalGeralEmolumentosValor
            // 
            this.lblConfSelosTotalGeralEmolumentosValor.AutoSize = true;
            this.lblConfSelosTotalGeralEmolumentosValor.Location = new System.Drawing.Point(309, 14);
            this.lblConfSelosTotalGeralEmolumentosValor.Name = "lblConfSelosTotalGeralEmolumentosValor";
            this.lblConfSelosTotalGeralEmolumentosValor.Size = new System.Drawing.Size(0, 24);
            this.lblConfSelosTotalGeralEmolumentosValor.TabIndex = 15;
            // 
            // lblConfSelosTotalGeralEmolumentos
            // 
            this.lblConfSelosTotalGeralEmolumentos.AutoSize = true;
            this.lblConfSelosTotalGeralEmolumentos.Location = new System.Drawing.Point(6, 14);
            this.lblConfSelosTotalGeralEmolumentos.Name = "lblConfSelosTotalGeralEmolumentos";
            this.lblConfSelosTotalGeralEmolumentos.Size = new System.Drawing.Size(297, 24);
            this.lblConfSelosTotalGeralEmolumentos.TabIndex = 14;
            this.lblConfSelosTotalGeralEmolumentos.Text = "Total Geral de Emolumentos : ";
            // 
            // lblConfSelosTotalGeralRecompeValor
            // 
            this.lblConfSelosTotalGeralRecompeValor.AutoSize = true;
            this.lblConfSelosTotalGeralRecompeValor.Location = new System.Drawing.Point(309, 46);
            this.lblConfSelosTotalGeralRecompeValor.Name = "lblConfSelosTotalGeralRecompeValor";
            this.lblConfSelosTotalGeralRecompeValor.Size = new System.Drawing.Size(0, 24);
            this.lblConfSelosTotalGeralRecompeValor.TabIndex = 17;
            // 
            // lblConfSelosTotalGeralRecompe
            // 
            this.lblConfSelosTotalGeralRecompe.AutoSize = true;
            this.lblConfSelosTotalGeralRecompe.Location = new System.Drawing.Point(6, 46);
            this.lblConfSelosTotalGeralRecompe.Name = "lblConfSelosTotalGeralRecompe";
            this.lblConfSelosTotalGeralRecompe.Size = new System.Drawing.Size(170, 24);
            this.lblConfSelosTotalGeralRecompe.TabIndex = 16;
            this.lblConfSelosTotalGeralRecompe.Text = "Total Recompe : ";
            // 
            // lblConfSelosTotalGeralTFJValor
            // 
            this.lblConfSelosTotalGeralTFJValor.AutoSize = true;
            this.lblConfSelosTotalGeralTFJValor.Location = new System.Drawing.Point(309, 79);
            this.lblConfSelosTotalGeralTFJValor.Name = "lblConfSelosTotalGeralTFJValor";
            this.lblConfSelosTotalGeralTFJValor.Size = new System.Drawing.Size(0, 24);
            this.lblConfSelosTotalGeralTFJValor.TabIndex = 19;
            // 
            // lblConfSelosTotalGeralTFJ
            // 
            this.lblConfSelosTotalGeralTFJ.AutoSize = true;
            this.lblConfSelosTotalGeralTFJ.Location = new System.Drawing.Point(6, 79);
            this.lblConfSelosTotalGeralTFJ.Name = "lblConfSelosTotalGeralTFJ";
            this.lblConfSelosTotalGeralTFJ.Size = new System.Drawing.Size(118, 24);
            this.lblConfSelosTotalGeralTFJ.TabIndex = 18;
            this.lblConfSelosTotalGeralTFJ.Text = "Total TFJ : ";
            // 
            // gbxConfSelosTotalConsultas
            // 
            this.gbxConfSelosTotalConsultas.Controls.Add(this.lblConfSelosTotalGeralRecompe);
            this.gbxConfSelosTotalConsultas.Controls.Add(this.lblConfSelosTotalGeralEmolumentosValor);
            this.gbxConfSelosTotalConsultas.Controls.Add(this.lblConfSelosTotalGeralRecompeValor);
            this.gbxConfSelosTotalConsultas.Controls.Add(this.lblConfSelosTotalGeralTFJValor);
            this.gbxConfSelosTotalConsultas.Controls.Add(this.lblConfSelosTotalGeralTFJ);
            this.gbxConfSelosTotalConsultas.Controls.Add(this.lblConfSelosTotalGeralEmolumentos);
            this.gbxConfSelosTotalConsultas.Location = new System.Drawing.Point(1036, 37);
            this.gbxConfSelosTotalConsultas.Name = "gbxConfSelosTotalConsultas";
            this.gbxConfSelosTotalConsultas.Size = new System.Drawing.Size(477, 117);
            this.gbxConfSelosTotalConsultas.TabIndex = 20;
            this.gbxConfSelosTotalConsultas.TabStop = false;
            this.gbxConfSelosTotalConsultas.Visible = false;
            this.gbxConfSelosTotalConsultas.Enter += new System.EventHandler(this.gbxConfSelosTotalConsultas_Enter);
            // 
            // frmConferenciaSelosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.gbxConfSelosTotalConsultas);
            this.Controls.Add(this.gbxConfSelosResultadoPesquisa);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblFrmConfSelosSelecionePeriodo);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmConferenciaSelosUC";
            this.Size = new System.Drawing.Size(1851, 949);
            this.Load += new System.EventHandler(this.frmConferenciaSelosUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfSelosRegCiv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gbxConfSelosResultadoPesquisa.ResumeLayout(false);
            this.gbxConfSelosResultadoPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConfSelosNotas)).EndInit();
            this.gbxConfSelosTotalConsultas.ResumeLayout(false);
            this.gbxConfSelosTotalConsultas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrmConfSelosSelecionePeriodo;
        private System.Windows.Forms.ComboBox cbFrmConfSeloMES;
        private System.Windows.Forms.Label lblFrmConfSelosANO;
        private System.Windows.Forms.Label lblFrmConfSelosMES;
        private System.Windows.Forms.Label lblFrmConfSelosSEMANA;
        private System.Windows.Forms.MaskedTextBox mskFrmConfSeloANO;
        private System.Windows.Forms.ComboBox cbConfSelosSemana;
        private System.Windows.Forms.Button btnConfSelosPesquisar;
        private FirebirdSql.Data.FirebirdClient.FbCommand fbCommand1;
        private FirebirdSql.Data.FirebirdClient.FbConnection fbConnection1;
        private FirebirdSql.Data.FirebirdClient.FbDataAdapter fbDataAdapter1;
        private FirebirdSql.Data.FirebirdClient.FbCommandBuilder fbCommandBuilder1;
        private System.Windows.Forms.DataGridView dtgConfSelosRegCiv;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbxConfSelosResultadoPesquisa;
        private System.Windows.Forms.Label lblConfSelosTotalEmolRegCivTitulo;
        private System.Windows.Forms.Label lblConfSelosTotalEmolRegCivValor;
        private System.Windows.Forms.Label lblConfSelosTotalEmolNotasValor;
        private System.Windows.Forms.Label lblConfSelosTotalEmolNotasTitulo;
        private System.Windows.Forms.DataGridView dtgConfSelosNotas;
        private System.Windows.Forms.Label lblConfSelosTotalGeralEmolumentosValor;
        private System.Windows.Forms.Label lblConfSelosTotalGeralEmolumentos;
        private System.Windows.Forms.Label lblConfSelosTotalGeralRecompeValor;
        private System.Windows.Forms.Label lblConfSelosTotalGeralRecompe;
        private System.Windows.Forms.Label lblConfSelosTotalGeralTFJValor;
        private System.Windows.Forms.Label lblConfSelosTotalGeralTFJ;
        private System.Windows.Forms.Button btnConfSelosRecalcularValores;
        private System.Windows.Forms.GroupBox gbxConfSelosTotalConsultas;
    }
}
