namespace Agenda
{
    partial class FrmAgenda
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CalCalendario = new System.Windows.Forms.MonthCalendar();
            this.GrpFormulario = new System.Windows.Forms.GroupBox();
            this.BtnAgendar = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.LblValor = new System.Windows.Forms.Label();
            this.CmbHorario = new System.Windows.Forms.ComboBox();
            this.LblHorario = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.DtpData = new System.Windows.Forms.DateTimePicker();
            this.ClbProcedimentos = new System.Windows.Forms.CheckedListBox();
            this.LblProcedimento = new System.Windows.Forms.Label();
            this.TxtCliente = new System.Windows.Forms.TextBox();
            this.LblCliente = new System.Windows.Forms.Label();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.FlpFiltros = new System.Windows.Forms.FlowLayoutPanel();
            this.LblFiltro = new System.Windows.Forms.Label();
            this.BtnTodos = new System.Windows.Forms.Button();
            this.BtnCorte = new System.Windows.Forms.Button();
            this.BtnMechas = new System.Windows.Forms.Button();
            this.BtnSelagem = new System.Windows.Forms.Button();
            this.BtnColoracao = new System.Windows.Forms.Button();
            this.BtnHidratacao = new System.Windows.Forms.Button();
            this.BtnSobrancelha = new System.Windows.Forms.Button();
            this.FlpAgendamento = new System.Windows.Forms.FlowLayoutPanel();
            this.PnlAgendamentos = new System.Windows.Forms.Panel();
            this.TxtHorarioAgendado = new System.Windows.Forms.TextBox();
            this.TxtValorAgendado = new System.Windows.Forms.TextBox();
            this.TxtProcedimentoAgendado = new System.Windows.Forms.TextBox();
            this.LblValorAgendado = new System.Windows.Forms.Label();
            this.TxtClienteAgendado = new System.Windows.Forms.TextBox();
            this.LblHorarioAgendado = new System.Windows.Forms.Label();
            this.LblProcedimentoAgendado = new System.Windows.Forms.Label();
            this.LblClienteAgendado = new System.Windows.Forms.Label();
            this.DgvAgendamentos = new System.Windows.Forms.DataGridView();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.Btn_Pagar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblAviso = new System.Windows.Forms.Label();
            this.GrpFormulario.SuspendLayout();
            this.FlpFiltros.SuspendLayout();
            this.FlpAgendamento.SuspendLayout();
            this.PnlAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgendamentos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalCalendario
            // 
            this.CalCalendario.Location = new System.Drawing.Point(18, 18);
            this.CalCalendario.MaxSelectionCount = 1;
            this.CalCalendario.Name = "CalCalendario";
            this.CalCalendario.TabIndex = 0;
            this.CalCalendario.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalCalendario_DateSelected);
            // 
            // GrpFormulario
            // 
            this.GrpFormulario.Controls.Add(this.BtnAgendar);
            this.GrpFormulario.Controls.Add(this.BtnLimpar);
            this.GrpFormulario.Controls.Add(this.TxtValor);
            this.GrpFormulario.Controls.Add(this.LblValor);
            this.GrpFormulario.Controls.Add(this.CmbHorario);
            this.GrpFormulario.Controls.Add(this.LblHorario);
            this.GrpFormulario.Controls.Add(this.LblData);
            this.GrpFormulario.Controls.Add(this.DtpData);
            this.GrpFormulario.Controls.Add(this.ClbProcedimentos);
            this.GrpFormulario.Controls.Add(this.LblProcedimento);
            this.GrpFormulario.Controls.Add(this.TxtCliente);
            this.GrpFormulario.Controls.Add(this.LblCliente);
            this.GrpFormulario.Location = new System.Drawing.Point(18, 193);
            this.GrpFormulario.Name = "GrpFormulario";
            this.GrpFormulario.Size = new System.Drawing.Size(227, 419);
            this.GrpFormulario.TabIndex = 1;
            this.GrpFormulario.TabStop = false;
            this.GrpFormulario.Text = "+ Novo Agendamento";
            // 
            // BtnAgendar
            // 
            this.BtnAgendar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAgendar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgendar.Location = new System.Drawing.Point(115, 383);
            this.BtnAgendar.Name = "BtnAgendar";
            this.BtnAgendar.Size = new System.Drawing.Size(75, 23);
            this.BtnAgendar.TabIndex = 11;
            this.BtnAgendar.Text = "Agendar";
            this.BtnAgendar.UseVisualStyleBackColor = false;
            this.BtnAgendar.Click += new System.EventHandler(this.BtnAgendar_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.BackColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(34, 383);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
            this.BtnLimpar.TabIndex = 10;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TxtValor
            // 
            this.TxtValor.BackColor = System.Drawing.Color.White;
            this.TxtValor.Location = new System.Drawing.Point(18, 325);
            this.TxtValor.Multiline = true;
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(191, 20);
            this.TxtValor.TabIndex = 9;
            // 
            // LblValor
            // 
            this.LblValor.AutoSize = true;
            this.LblValor.Location = new System.Drawing.Point(17, 308);
            this.LblValor.Name = "LblValor";
            this.LblValor.Size = new System.Drawing.Size(31, 13);
            this.LblValor.TabIndex = 8;
            this.LblValor.Text = "Valor";
            // 
            // CmbHorario
            // 
            this.CmbHorario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbHorario.FormattingEnabled = true;
            this.CmbHorario.Items.AddRange(new object[] {
            "8:00",
            "8:30",
            "9:00",
            "9:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00"});
            this.CmbHorario.Location = new System.Drawing.Point(18, 271);
            this.CmbHorario.Name = "CmbHorario";
            this.CmbHorario.Size = new System.Drawing.Size(189, 21);
            this.CmbHorario.TabIndex = 7;
            // 
            // LblHorario
            // 
            this.LblHorario.AutoSize = true;
            this.LblHorario.Location = new System.Drawing.Point(17, 255);
            this.LblHorario.Name = "LblHorario";
            this.LblHorario.Size = new System.Drawing.Size(46, 13);
            this.LblHorario.TabIndex = 6;
            this.LblHorario.Text = "Horários";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Location = new System.Drawing.Point(15, 203);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(30, 13);
            this.LblData.TabIndex = 5;
            this.LblData.Text = "Data";
            // 
            // DtpData
            // 
            this.DtpData.Checked = false;
            this.DtpData.Location = new System.Drawing.Point(18, 221);
            this.DtpData.Name = "DtpData";
            this.DtpData.ShowCheckBox = true;
            this.DtpData.Size = new System.Drawing.Size(191, 20);
            this.DtpData.TabIndex = 4;
            this.DtpData.ValueChanged += new System.EventHandler(this.DtpData_ValueChanged);
            // 
            // ClbProcedimentos
            // 
            this.ClbProcedimentos.CheckOnClick = true;
            this.ClbProcedimentos.FormattingEnabled = true;
            this.ClbProcedimentos.Items.AddRange(new object[] {
            "Todos",
            "Corte",
            "Mechas",
            "Selagem",
            "Coloração",
            "Hidratação",
            "Sobrancelha"});
            this.ClbProcedimentos.Location = new System.Drawing.Point(18, 92);
            this.ClbProcedimentos.Name = "ClbProcedimentos";
            this.ClbProcedimentos.Size = new System.Drawing.Size(191, 94);
            this.ClbProcedimentos.TabIndex = 3;
            this.ClbProcedimentos.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ClbProcedimentos_ItemCheck);
            // 
            // LblProcedimento
            // 
            this.LblProcedimento.AutoSize = true;
            this.LblProcedimento.Location = new System.Drawing.Point(15, 75);
            this.LblProcedimento.Name = "LblProcedimento";
            this.LblProcedimento.Size = new System.Drawing.Size(143, 13);
            this.LblProcedimento.TabIndex = 2;
            this.LblProcedimento.Text = "Procedimento a ser realizado";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Location = new System.Drawing.Point(18, 40);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(191, 20);
            this.TxtCliente.TabIndex = 1;
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Location = new System.Drawing.Point(15, 24);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(39, 13);
            this.LblCliente.TabIndex = 0;
            this.LblCliente.Text = "Cliente";
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.Location = new System.Drawing.Point(277, 68);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(169, 13);
            this.LblTitulo.TabIndex = 2;
            this.LblTitulo.Text = "Organização que Realça a Beleza";
            // 
            // FlpFiltros
            // 
            this.FlpFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FlpFiltros.Controls.Add(this.LblFiltro);
            this.FlpFiltros.Controls.Add(this.BtnTodos);
            this.FlpFiltros.Controls.Add(this.BtnCorte);
            this.FlpFiltros.Controls.Add(this.BtnMechas);
            this.FlpFiltros.Controls.Add(this.BtnSelagem);
            this.FlpFiltros.Controls.Add(this.BtnColoracao);
            this.FlpFiltros.Controls.Add(this.BtnHidratacao);
            this.FlpFiltros.Controls.Add(this.BtnSobrancelha);
            this.FlpFiltros.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpFiltros.Location = new System.Drawing.Point(956, 87);
            this.FlpFiltros.Name = "FlpFiltros";
            this.FlpFiltros.Size = new System.Drawing.Size(86, 321);
            this.FlpFiltros.TabIndex = 3;
            this.FlpFiltros.WrapContents = false;
            // 
            // LblFiltro
            // 
            this.LblFiltro.AutoSize = true;
            this.LblFiltro.Location = new System.Drawing.Point(3, 0);
            this.LblFiltro.Name = "LblFiltro";
            this.LblFiltro.Size = new System.Drawing.Size(77, 13);
            this.LblFiltro.TabIndex = 0;
            this.LblFiltro.Text = "Procedimentos";
            // 
            // BtnTodos
            // 
            this.BtnTodos.BackColor = System.Drawing.Color.White;
            this.BtnTodos.Location = new System.Drawing.Point(3, 23);
            this.BtnTodos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BtnTodos.Name = "BtnTodos";
            this.BtnTodos.Size = new System.Drawing.Size(75, 23);
            this.BtnTodos.TabIndex = 1;
            this.BtnTodos.Text = "Todos";
            this.BtnTodos.UseVisualStyleBackColor = false;
            this.BtnTodos.Click += new System.EventHandler(this.BtnTodos_Click);
            // 
            // BtnCorte
            // 
            this.BtnCorte.BackColor = System.Drawing.Color.White;
            this.BtnCorte.Location = new System.Drawing.Point(3, 66);
            this.BtnCorte.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BtnCorte.Name = "BtnCorte";
            this.BtnCorte.Size = new System.Drawing.Size(75, 23);
            this.BtnCorte.TabIndex = 2;
            this.BtnCorte.Text = "Corte";
            this.BtnCorte.UseVisualStyleBackColor = false;
            this.BtnCorte.Click += new System.EventHandler(this.BtnCorte_Click);
            // 
            // BtnMechas
            // 
            this.BtnMechas.BackColor = System.Drawing.Color.White;
            this.BtnMechas.Location = new System.Drawing.Point(3, 109);
            this.BtnMechas.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BtnMechas.Name = "BtnMechas";
            this.BtnMechas.Size = new System.Drawing.Size(75, 23);
            this.BtnMechas.TabIndex = 3;
            this.BtnMechas.Text = "Mechas";
            this.BtnMechas.UseVisualStyleBackColor = false;
            this.BtnMechas.Click += new System.EventHandler(this.BtnMechas_Click);
            // 
            // BtnSelagem
            // 
            this.BtnSelagem.BackColor = System.Drawing.Color.White;
            this.BtnSelagem.Location = new System.Drawing.Point(3, 152);
            this.BtnSelagem.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BtnSelagem.Name = "BtnSelagem";
            this.BtnSelagem.Size = new System.Drawing.Size(75, 23);
            this.BtnSelagem.TabIndex = 4;
            this.BtnSelagem.Text = "Selagem";
            this.BtnSelagem.UseVisualStyleBackColor = false;
            this.BtnSelagem.Click += new System.EventHandler(this.BtnSelagem_Click);
            // 
            // BtnColoracao
            // 
            this.BtnColoracao.BackColor = System.Drawing.Color.White;
            this.BtnColoracao.Location = new System.Drawing.Point(3, 195);
            this.BtnColoracao.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BtnColoracao.Name = "BtnColoracao";
            this.BtnColoracao.Size = new System.Drawing.Size(75, 23);
            this.BtnColoracao.TabIndex = 5;
            this.BtnColoracao.Text = "Coloração";
            this.BtnColoracao.UseVisualStyleBackColor = false;
            this.BtnColoracao.Click += new System.EventHandler(this.BtnColoracao_Click);
            // 
            // BtnHidratacao
            // 
            this.BtnHidratacao.BackColor = System.Drawing.Color.White;
            this.BtnHidratacao.Location = new System.Drawing.Point(3, 238);
            this.BtnHidratacao.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BtnHidratacao.Name = "BtnHidratacao";
            this.BtnHidratacao.Size = new System.Drawing.Size(75, 23);
            this.BtnHidratacao.TabIndex = 6;
            this.BtnHidratacao.Text = "Hidratação";
            this.BtnHidratacao.UseVisualStyleBackColor = false;
            this.BtnHidratacao.Click += new System.EventHandler(this.BtnHidratacao_Click);
            // 
            // BtnSobrancelha
            // 
            this.BtnSobrancelha.BackColor = System.Drawing.Color.White;
            this.BtnSobrancelha.Location = new System.Drawing.Point(3, 281);
            this.BtnSobrancelha.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.BtnSobrancelha.Name = "BtnSobrancelha";
            this.BtnSobrancelha.Size = new System.Drawing.Size(75, 23);
            this.BtnSobrancelha.TabIndex = 7;
            this.BtnSobrancelha.Text = "Sobrancelha";
            this.BtnSobrancelha.UseVisualStyleBackColor = false;
            this.BtnSobrancelha.Click += new System.EventHandler(this.BtnSobrancelha_Click);
            // 
            // FlpAgendamento
            // 
            this.FlpAgendamento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlpAgendamento.AutoScroll = true;
            this.FlpAgendamento.Controls.Add(this.PnlAgendamentos);
            this.FlpAgendamento.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlpAgendamento.Location = new System.Drawing.Point(277, 87);
            this.FlpAgendamento.Name = "FlpAgendamento";
            this.FlpAgendamento.Size = new System.Drawing.Size(657, 497);
            this.FlpAgendamento.TabIndex = 4;
            this.FlpAgendamento.Visible = false;
            this.FlpAgendamento.WrapContents = false;
            // 
            // PnlAgendamentos
            // 
            this.PnlAgendamentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.PnlAgendamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlAgendamentos.Controls.Add(this.TxtHorarioAgendado);
            this.PnlAgendamentos.Controls.Add(this.TxtValorAgendado);
            this.PnlAgendamentos.Controls.Add(this.TxtProcedimentoAgendado);
            this.PnlAgendamentos.Controls.Add(this.LblValorAgendado);
            this.PnlAgendamentos.Controls.Add(this.TxtClienteAgendado);
            this.PnlAgendamentos.Controls.Add(this.LblHorarioAgendado);
            this.PnlAgendamentos.Controls.Add(this.LblProcedimentoAgendado);
            this.PnlAgendamentos.Controls.Add(this.LblClienteAgendado);
            this.PnlAgendamentos.Location = new System.Drawing.Point(3, 3);
            this.PnlAgendamentos.Name = "PnlAgendamentos";
            this.PnlAgendamentos.Size = new System.Drawing.Size(654, 90);
            this.PnlAgendamentos.TabIndex = 0;
            // 
            // TxtHorarioAgendado
            // 
            this.TxtHorarioAgendado.Location = new System.Drawing.Point(218, 48);
            this.TxtHorarioAgendado.Name = "TxtHorarioAgendado";
            this.TxtHorarioAgendado.Size = new System.Drawing.Size(85, 20);
            this.TxtHorarioAgendado.TabIndex = 15;
            // 
            // TxtValorAgendado
            // 
            this.TxtValorAgendado.Location = new System.Drawing.Point(65, 45);
            this.TxtValorAgendado.Name = "TxtValorAgendado";
            this.TxtValorAgendado.Size = new System.Drawing.Size(100, 20);
            this.TxtValorAgendado.TabIndex = 14;
            // 
            // TxtProcedimentoAgendado
            // 
            this.TxtProcedimentoAgendado.Location = new System.Drawing.Point(402, 12);
            this.TxtProcedimentoAgendado.Multiline = true;
            this.TxtProcedimentoAgendado.Name = "TxtProcedimentoAgendado";
            this.TxtProcedimentoAgendado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtProcedimentoAgendado.Size = new System.Drawing.Size(191, 37);
            this.TxtProcedimentoAgendado.TabIndex = 13;
            // 
            // LblValorAgendado
            // 
            this.LblValorAgendado.AutoSize = true;
            this.LblValorAgendado.Location = new System.Drawing.Point(17, 48);
            this.LblValorAgendado.Name = "LblValorAgendado";
            this.LblValorAgendado.Size = new System.Drawing.Size(34, 13);
            this.LblValorAgendado.TabIndex = 3;
            this.LblValorAgendado.Text = "Valor:";
            // 
            // TxtClienteAgendado
            // 
            this.TxtClienteAgendado.Location = new System.Drawing.Point(65, 10);
            this.TxtClienteAgendado.Name = "TxtClienteAgendado";
            this.TxtClienteAgendado.Size = new System.Drawing.Size(191, 20);
            this.TxtClienteAgendado.TabIndex = 12;
            // 
            // LblHorarioAgendado
            // 
            this.LblHorarioAgendado.AutoSize = true;
            this.LblHorarioAgendado.Location = new System.Drawing.Point(172, 49);
            this.LblHorarioAgendado.Name = "LblHorarioAgendado";
            this.LblHorarioAgendado.Size = new System.Drawing.Size(44, 13);
            this.LblHorarioAgendado.TabIndex = 2;
            this.LblHorarioAgendado.Text = "Horário:";
            // 
            // LblProcedimentoAgendado
            // 
            this.LblProcedimentoAgendado.AutoSize = true;
            this.LblProcedimentoAgendado.Location = new System.Drawing.Point(321, 12);
            this.LblProcedimentoAgendado.Name = "LblProcedimentoAgendado";
            this.LblProcedimentoAgendado.Size = new System.Drawing.Size(75, 13);
            this.LblProcedimentoAgendado.TabIndex = 1;
            this.LblProcedimentoAgendado.Text = "Procedimento:";
            // 
            // LblClienteAgendado
            // 
            this.LblClienteAgendado.AutoSize = true;
            this.LblClienteAgendado.Location = new System.Drawing.Point(17, 12);
            this.LblClienteAgendado.Name = "LblClienteAgendado";
            this.LblClienteAgendado.Size = new System.Drawing.Size(42, 13);
            this.LblClienteAgendado.TabIndex = 0;
            this.LblClienteAgendado.Text = "Cliente:";
            // 
            // DgvAgendamentos
            // 
            this.DgvAgendamentos.AllowUserToAddRows = false;
            this.DgvAgendamentos.AllowUserToDeleteRows = false;
            this.DgvAgendamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAgendamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAgendamentos.BackgroundColor = System.Drawing.Color.White;
            this.DgvAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAgendamentos.Location = new System.Drawing.Point(277, 87);
            this.DgvAgendamentos.MultiSelect = false;
            this.DgvAgendamentos.Name = "DgvAgendamentos";
            this.DgvAgendamentos.ReadOnly = true;
            this.DgvAgendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAgendamentos.Size = new System.Drawing.Size(657, 407);
            this.DgvAgendamentos.TabIndex = 7;
            this.DgvAgendamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAgendamentos_CellClick);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnEditar.BackColor = System.Drawing.Color.White;
            this.BtnEditar.Location = new System.Drawing.Point(544, 590);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 18;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = false;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnExcluir.BackColor = System.Drawing.Color.White;
            this.BtnExcluir.Location = new System.Drawing.Point(447, 590);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 17;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = false;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // Btn_Pagar
            // 
            this.Btn_Pagar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Btn_Pagar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Pagar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pagar.Location = new System.Drawing.Point(647, 589);
            this.Btn_Pagar.Name = "Btn_Pagar";
            this.Btn_Pagar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Pagar.TabIndex = 19;
            this.Btn_Pagar.Text = "Pagar";
            this.Btn_Pagar.UseVisualStyleBackColor = false;
            this.Btn_Pagar.Click += new System.EventHandler(this.Btn_Pagar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.BtnClientes);
            this.panel1.Location = new System.Drawing.Point(277, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 59);
            this.panel1.TabIndex = 22;
            // 
            // BtnSair
            // 
            this.BtnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Location = new System.Drawing.Point(560, 9);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(51, 40);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.FlatAppearance.BorderSize = 0;
            this.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashboard.Location = new System.Drawing.Point(69, 9);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(70, 40);
            this.BtnDashboard.TabIndex = 4;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.UseVisualStyleBackColor = true;
            this.BtnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Location = new System.Drawing.Point(279, 9);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(70, 40);
            this.BtnClientes.TabIndex = 5;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = true;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LblAviso);
            this.panel2.Location = new System.Drawing.Point(739, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(167, 47);
            this.panel2.TabIndex = 23;
            // 
            // LblAviso
            // 
            this.LblAviso.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblAviso.AutoSize = true;
            this.LblAviso.Location = new System.Drawing.Point(5, 10);
            this.LblAviso.Name = "LblAviso";
            this.LblAviso.Size = new System.Drawing.Size(161, 26);
            this.LblAviso.TabIndex = 0;
            this.LblAviso.Text = "Para pagar, é neessário primeiro \r\nseleionar um agendamento.";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1054, 636);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_Pagar);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.DgvAgendamentos);
            this.Controls.Add(this.FlpFiltros);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.GrpFormulario);
            this.Controls.Add(this.CalCalendario);
            this.Controls.Add(this.FlpAgendamento);
            this.Name = "FrmAgenda";
            this.Text = "Agenda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAgenda_Load);
            this.GrpFormulario.ResumeLayout(false);
            this.GrpFormulario.PerformLayout();
            this.FlpFiltros.ResumeLayout(false);
            this.FlpFiltros.PerformLayout();
            this.FlpAgendamento.ResumeLayout(false);
            this.PnlAgendamentos.ResumeLayout(false);
            this.PnlAgendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAgendamentos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalCalendario;
        private System.Windows.Forms.GroupBox GrpFormulario;
        private System.Windows.Forms.Label LblCliente;
        private System.Windows.Forms.Label LblProcedimento;
        private System.Windows.Forms.TextBox TxtCliente;
        private System.Windows.Forms.DateTimePicker DtpData;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblHorario;
        private System.Windows.Forms.ComboBox CmbHorario;
        private System.Windows.Forms.Label LblValor;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Button BtnAgendar;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.FlowLayoutPanel FlpFiltros;
        private System.Windows.Forms.Label LblFiltro;
        private System.Windows.Forms.Button BtnTodos;
        private System.Windows.Forms.Button BtnCorte;
        private System.Windows.Forms.Button BtnMechas;
        private System.Windows.Forms.Button BtnSelagem;
        private System.Windows.Forms.Button BtnColoracao;
        private System.Windows.Forms.Button BtnHidratacao;
        private System.Windows.Forms.Button BtnSobrancelha;
        private System.Windows.Forms.FlowLayoutPanel FlpAgendamento;
        private System.Windows.Forms.Panel PnlAgendamentos;
        private System.Windows.Forms.Label LblValorAgendado;
        private System.Windows.Forms.Label LblHorarioAgendado;
        private System.Windows.Forms.Label LblClienteAgendado;
        public System.Windows.Forms.Label LblProcedimentoAgendado;
        private System.Windows.Forms.TextBox TxtHorarioAgendado;
        private System.Windows.Forms.TextBox TxtValorAgendado;
        private System.Windows.Forms.TextBox TxtProcedimentoAgendado;
        private System.Windows.Forms.TextBox TxtClienteAgendado;
        private System.Windows.Forms.DataGridView DgvAgendamentos;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.CheckedListBox ClbProcedimentos;
        private System.Windows.Forms.Button Btn_Pagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblAviso;
    }
}

