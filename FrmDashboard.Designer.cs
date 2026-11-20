namespace Dashboard
{
    partial class FrmDashboard
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
            this.CalCalendarioD = new System.Windows.Forms.MonthCalendar();
            this.PnlFaturamento = new System.Windows.Forms.Panel();
            this.TxtFaturamento = new System.Windows.Forms.TextBox();
            this.LblFaturamento = new System.Windows.Forms.Label();
            this.PnlAtendimentos = new System.Windows.Forms.Panel();
            this.TxtQntAtendimentos = new System.Windows.Forms.TextBox();
            this.LblQntAtendimentos = new System.Windows.Forms.Label();
            this.PnlServicos = new System.Windows.Forms.Panel();
            this.TxtPercentualSobrancelha = new System.Windows.Forms.TextBox();
            this.TxtPercentualHidratacao = new System.Windows.Forms.TextBox();
            this.TxtPercentualColoracao = new System.Windows.Forms.TextBox();
            this.TxtPercentualSelagem = new System.Windows.Forms.TextBox();
            this.TxtPercentualMechas = new System.Windows.Forms.TextBox();
            this.TxtPercentualCorte = new System.Windows.Forms.TextBox();
            this.PgbSobrancelha = new System.Windows.Forms.ProgressBar();
            this.PgbHidratacao = new System.Windows.Forms.ProgressBar();
            this.PgbColoracao = new System.Windows.Forms.ProgressBar();
            this.PgbSelagem = new System.Windows.Forms.ProgressBar();
            this.PgbMechas = new System.Windows.Forms.ProgressBar();
            this.PgbCorte = new System.Windows.Forms.ProgressBar();
            this.LblSobrancelha = new System.Windows.Forms.Label();
            this.LblSelagem = new System.Windows.Forms.Label();
            this.LblHidratacao = new System.Windows.Forms.Label();
            this.LblColoracao = new System.Windows.Forms.Label();
            this.LblMechas = new System.Windows.Forms.Label();
            this.LblCorte = new System.Windows.Forms.Label();
            this.LblServicos = new System.Windows.Forms.Label();
            this.DgvAtendimentos = new System.Windows.Forms.DataGridView();
            this.ColData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColProcedimentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnMensal = new System.Windows.Forms.Button();
            this.BtnSemanal = new System.Windows.Forms.Button();
            this.BtnDiario = new System.Windows.Forms.Button();
            this.LblAgendamentos = new System.Windows.Forms.Label();
            this.PnlFaturamento.SuspendLayout();
            this.PnlAtendimentos.SuspendLayout();
            this.PnlServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtendimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // CalCalendarioD
            // 
            this.CalCalendarioD.Location = new System.Drawing.Point(18, 68);
            this.CalCalendarioD.MaxSelectionCount = 1;
            this.CalCalendarioD.Name = "CalCalendarioD";
            this.CalCalendarioD.TabIndex = 0;
            this.CalCalendarioD.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.CalCalendarioD_DateChanged);
            // 
            // PnlFaturamento
            // 
            this.PnlFaturamento.Controls.Add(this.TxtFaturamento);
            this.PnlFaturamento.Controls.Add(this.LblFaturamento);
            this.PnlFaturamento.Location = new System.Drawing.Point(638, 153);
            this.PnlFaturamento.Name = "PnlFaturamento";
            this.PnlFaturamento.Size = new System.Drawing.Size(200, 77);
            this.PnlFaturamento.TabIndex = 4;
            // 
            // TxtFaturamento
            // 
            this.TxtFaturamento.BackColor = System.Drawing.Color.White;
            this.TxtFaturamento.Location = new System.Drawing.Point(55, 35);
            this.TxtFaturamento.Name = "TxtFaturamento";
            this.TxtFaturamento.ReadOnly = true;
            this.TxtFaturamento.Size = new System.Drawing.Size(100, 20);
            this.TxtFaturamento.TabIndex = 14;
            // 
            // LblFaturamento
            // 
            this.LblFaturamento.AutoSize = true;
            this.LblFaturamento.Location = new System.Drawing.Point(69, 9);
            this.LblFaturamento.Name = "LblFaturamento";
            this.LblFaturamento.Size = new System.Drawing.Size(66, 13);
            this.LblFaturamento.TabIndex = 13;
            this.LblFaturamento.Text = "Faturamento";
            // 
            // PnlAtendimentos
            // 
            this.PnlAtendimentos.Controls.Add(this.TxtQntAtendimentos);
            this.PnlAtendimentos.Controls.Add(this.LblQntAtendimentos);
            this.PnlAtendimentos.Location = new System.Drawing.Point(638, 68);
            this.PnlAtendimentos.Name = "PnlAtendimentos";
            this.PnlAtendimentos.Size = new System.Drawing.Size(200, 77);
            this.PnlAtendimentos.TabIndex = 5;
            // 
            // TxtQntAtendimentos
            // 
            this.TxtQntAtendimentos.BackColor = System.Drawing.Color.White;
            this.TxtQntAtendimentos.Location = new System.Drawing.Point(55, 34);
            this.TxtQntAtendimentos.Name = "TxtQntAtendimentos";
            this.TxtQntAtendimentos.ReadOnly = true;
            this.TxtQntAtendimentos.Size = new System.Drawing.Size(100, 20);
            this.TxtQntAtendimentos.TabIndex = 13;
            // 
            // LblQntAtendimentos
            // 
            this.LblQntAtendimentos.AutoSize = true;
            this.LblQntAtendimentos.Location = new System.Drawing.Point(4, 6);
            this.LblQntAtendimentos.Name = "LblQntAtendimentos";
            this.LblQntAtendimentos.Size = new System.Drawing.Size(193, 13);
            this.LblQntAtendimentos.TabIndex = 12;
            this.LblQntAtendimentos.Text = "Quantidade de atendimentos realizados";
            // 
            // PnlServicos
            // 
            this.PnlServicos.Controls.Add(this.TxtPercentualSobrancelha);
            this.PnlServicos.Controls.Add(this.TxtPercentualHidratacao);
            this.PnlServicos.Controls.Add(this.TxtPercentualColoracao);
            this.PnlServicos.Controls.Add(this.TxtPercentualSelagem);
            this.PnlServicos.Controls.Add(this.TxtPercentualMechas);
            this.PnlServicos.Controls.Add(this.TxtPercentualCorte);
            this.PnlServicos.Controls.Add(this.PgbSobrancelha);
            this.PnlServicos.Controls.Add(this.PgbHidratacao);
            this.PnlServicos.Controls.Add(this.PgbColoracao);
            this.PnlServicos.Controls.Add(this.PgbSelagem);
            this.PnlServicos.Controls.Add(this.PgbMechas);
            this.PnlServicos.Controls.Add(this.PgbCorte);
            this.PnlServicos.Controls.Add(this.LblSobrancelha);
            this.PnlServicos.Controls.Add(this.LblSelagem);
            this.PnlServicos.Controls.Add(this.LblHidratacao);
            this.PnlServicos.Controls.Add(this.LblColoracao);
            this.PnlServicos.Controls.Add(this.LblMechas);
            this.PnlServicos.Controls.Add(this.LblCorte);
            this.PnlServicos.Controls.Add(this.LblServicos);
            this.PnlServicos.Location = new System.Drawing.Point(257, 68);
            this.PnlServicos.Name = "PnlServicos";
            this.PnlServicos.Size = new System.Drawing.Size(359, 162);
            this.PnlServicos.TabIndex = 5;
            // 
            // TxtPercentualSobrancelha
            // 
            this.TxtPercentualSobrancelha.BackColor = System.Drawing.Color.White;
            this.TxtPercentualSobrancelha.Location = new System.Drawing.Point(283, 131);
            this.TxtPercentualSobrancelha.Name = "TxtPercentualSobrancelha";
            this.TxtPercentualSobrancelha.ReadOnly = true;
            this.TxtPercentualSobrancelha.Size = new System.Drawing.Size(40, 20);
            this.TxtPercentualSobrancelha.TabIndex = 29;
            // 
            // TxtPercentualHidratacao
            // 
            this.TxtPercentualHidratacao.BackColor = System.Drawing.Color.White;
            this.TxtPercentualHidratacao.Location = new System.Drawing.Point(283, 110);
            this.TxtPercentualHidratacao.Name = "TxtPercentualHidratacao";
            this.TxtPercentualHidratacao.ReadOnly = true;
            this.TxtPercentualHidratacao.Size = new System.Drawing.Size(40, 20);
            this.TxtPercentualHidratacao.TabIndex = 28;
            // 
            // TxtPercentualColoracao
            // 
            this.TxtPercentualColoracao.BackColor = System.Drawing.Color.White;
            this.TxtPercentualColoracao.Location = new System.Drawing.Point(283, 88);
            this.TxtPercentualColoracao.Name = "TxtPercentualColoracao";
            this.TxtPercentualColoracao.ReadOnly = true;
            this.TxtPercentualColoracao.Size = new System.Drawing.Size(40, 20);
            this.TxtPercentualColoracao.TabIndex = 27;
            // 
            // TxtPercentualSelagem
            // 
            this.TxtPercentualSelagem.BackColor = System.Drawing.Color.White;
            this.TxtPercentualSelagem.Location = new System.Drawing.Point(283, 67);
            this.TxtPercentualSelagem.Name = "TxtPercentualSelagem";
            this.TxtPercentualSelagem.ReadOnly = true;
            this.TxtPercentualSelagem.Size = new System.Drawing.Size(40, 20);
            this.TxtPercentualSelagem.TabIndex = 26;
            // 
            // TxtPercentualMechas
            // 
            this.TxtPercentualMechas.BackColor = System.Drawing.Color.White;
            this.TxtPercentualMechas.Location = new System.Drawing.Point(283, 45);
            this.TxtPercentualMechas.Name = "TxtPercentualMechas";
            this.TxtPercentualMechas.ReadOnly = true;
            this.TxtPercentualMechas.Size = new System.Drawing.Size(40, 20);
            this.TxtPercentualMechas.TabIndex = 25;
            // 
            // TxtPercentualCorte
            // 
            this.TxtPercentualCorte.BackColor = System.Drawing.Color.White;
            this.TxtPercentualCorte.Location = new System.Drawing.Point(283, 23);
            this.TxtPercentualCorte.Name = "TxtPercentualCorte";
            this.TxtPercentualCorte.ReadOnly = true;
            this.TxtPercentualCorte.Size = new System.Drawing.Size(40, 20);
            this.TxtPercentualCorte.TabIndex = 24;
            // 
            // PgbSobrancelha
            // 
            this.PgbSobrancelha.Location = new System.Drawing.Point(90, 141);
            this.PgbSobrancelha.Name = "PgbSobrancelha";
            this.PgbSobrancelha.Size = new System.Drawing.Size(187, 8);
            this.PgbSobrancelha.TabIndex = 23;
            // 
            // PgbHidratacao
            // 
            this.PgbHidratacao.Location = new System.Drawing.Point(90, 118);
            this.PgbHidratacao.Name = "PgbHidratacao";
            this.PgbHidratacao.Size = new System.Drawing.Size(187, 8);
            this.PgbHidratacao.TabIndex = 22;
            // 
            // PgbColoracao
            // 
            this.PgbColoracao.Location = new System.Drawing.Point(90, 97);
            this.PgbColoracao.Name = "PgbColoracao";
            this.PgbColoracao.Size = new System.Drawing.Size(187, 8);
            this.PgbColoracao.TabIndex = 21;
            // 
            // PgbSelagem
            // 
            this.PgbSelagem.Location = new System.Drawing.Point(90, 77);
            this.PgbSelagem.Name = "PgbSelagem";
            this.PgbSelagem.Size = new System.Drawing.Size(187, 8);
            this.PgbSelagem.TabIndex = 20;
            // 
            // PgbMechas
            // 
            this.PgbMechas.Location = new System.Drawing.Point(90, 57);
            this.PgbMechas.Name = "PgbMechas";
            this.PgbMechas.Size = new System.Drawing.Size(187, 8);
            this.PgbMechas.TabIndex = 19;
            // 
            // PgbCorte
            // 
            this.PgbCorte.BackColor = System.Drawing.Color.White;
            this.PgbCorte.Location = new System.Drawing.Point(90, 30);
            this.PgbCorte.Name = "PgbCorte";
            this.PgbCorte.Size = new System.Drawing.Size(187, 8);
            this.PgbCorte.TabIndex = 18;
            // 
            // LblSobrancelha
            // 
            this.LblSobrancelha.AutoSize = true;
            this.LblSobrancelha.Location = new System.Drawing.Point(13, 136);
            this.LblSobrancelha.Name = "LblSobrancelha";
            this.LblSobrancelha.Size = new System.Drawing.Size(70, 13);
            this.LblSobrancelha.TabIndex = 17;
            this.LblSobrancelha.Text = "Sobrancelha:";
            // 
            // LblSelagem
            // 
            this.LblSelagem.AutoSize = true;
            this.LblSelagem.Location = new System.Drawing.Point(13, 72);
            this.LblSelagem.Name = "LblSelagem";
            this.LblSelagem.Size = new System.Drawing.Size(51, 13);
            this.LblSelagem.TabIndex = 16;
            this.LblSelagem.Text = "Selagem:";
            // 
            // LblHidratacao
            // 
            this.LblHidratacao.AutoSize = true;
            this.LblHidratacao.Location = new System.Drawing.Point(13, 113);
            this.LblHidratacao.Name = "LblHidratacao";
            this.LblHidratacao.Size = new System.Drawing.Size(62, 13);
            this.LblHidratacao.TabIndex = 15;
            this.LblHidratacao.Text = "Hidratação:";
            // 
            // LblColoracao
            // 
            this.LblColoracao.AutoSize = true;
            this.LblColoracao.Location = new System.Drawing.Point(13, 92);
            this.LblColoracao.Name = "LblColoracao";
            this.LblColoracao.Size = new System.Drawing.Size(58, 13);
            this.LblColoracao.TabIndex = 14;
            this.LblColoracao.Text = "Coloração:";
            // 
            // LblMechas
            // 
            this.LblMechas.AutoSize = true;
            this.LblMechas.Location = new System.Drawing.Point(13, 52);
            this.LblMechas.Name = "LblMechas";
            this.LblMechas.Size = new System.Drawing.Size(48, 13);
            this.LblMechas.TabIndex = 13;
            this.LblMechas.Text = "Mechas:";
            // 
            // LblCorte
            // 
            this.LblCorte.AutoSize = true;
            this.LblCorte.Location = new System.Drawing.Point(13, 30);
            this.LblCorte.Name = "LblCorte";
            this.LblCorte.Size = new System.Drawing.Size(35, 13);
            this.LblCorte.TabIndex = 12;
            this.LblCorte.Text = "Corte:";
            // 
            // LblServicos
            // 
            this.LblServicos.AutoSize = true;
            this.LblServicos.Location = new System.Drawing.Point(112, 6);
            this.LblServicos.Name = "LblServicos";
            this.LblServicos.Size = new System.Drawing.Size(139, 13);
            this.LblServicos.TabIndex = 11;
            this.LblServicos.Text = "Serviços mais realizados (%)";
            // 
            // DgvAtendimentos
            // 
            this.DgvAtendimentos.AllowUserToAddRows = false;
            this.DgvAtendimentos.AllowUserToDeleteRows = false;
            this.DgvAtendimentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAtendimentos.BackgroundColor = System.Drawing.Color.White;
            this.DgvAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColData,
            this.ColCliente,
            this.ColProcedimentos,
            this.ColHorario,
            this.ColValor});
            this.DgvAtendimentos.GridColor = System.Drawing.Color.White;
            this.DgvAtendimentos.Location = new System.Drawing.Point(18, 267);
            this.DgvAtendimentos.Name = "DgvAtendimentos";
            this.DgvAtendimentos.ReadOnly = true;
            this.DgvAtendimentos.RowHeadersVisible = false;
            this.DgvAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvAtendimentos.Size = new System.Drawing.Size(989, 334);
            this.DgvAtendimentos.TabIndex = 6;
            // 
            // ColData
            // 
            this.ColData.HeaderText = "Data";
            this.ColData.Name = "ColData";
            this.ColData.ReadOnly = true;
            // 
            // ColCliente
            // 
            this.ColCliente.HeaderText = "Cliente";
            this.ColCliente.Name = "ColCliente";
            this.ColCliente.ReadOnly = true;
            // 
            // ColProcedimentos
            // 
            this.ColProcedimentos.HeaderText = "Procedimentos";
            this.ColProcedimentos.Name = "ColProcedimentos";
            this.ColProcedimentos.ReadOnly = true;
            // 
            // ColHorario
            // 
            this.ColHorario.HeaderText = "Horário";
            this.ColHorario.Name = "ColHorario";
            this.ColHorario.ReadOnly = true;
            // 
            // ColValor
            // 
            this.ColValor.HeaderText = "Valor";
            this.ColValor.Name = "ColValor";
            this.ColValor.ReadOnly = true;
            // 
            // BtnMensal
            // 
            this.BtnMensal.Location = new System.Drawing.Point(181, 33);
            this.BtnMensal.Name = "BtnMensal";
            this.BtnMensal.Size = new System.Drawing.Size(65, 23);
            this.BtnMensal.TabIndex = 9;
            this.BtnMensal.Text = "Mensal";
            this.BtnMensal.UseVisualStyleBackColor = true;
            this.BtnMensal.Click += new System.EventHandler(this.BtnMensal_Click);
            // 
            // BtnSemanal
            // 
            this.BtnSemanal.Location = new System.Drawing.Point(97, 33);
            this.BtnSemanal.Name = "BtnSemanal";
            this.BtnSemanal.Size = new System.Drawing.Size(65, 23);
            this.BtnSemanal.TabIndex = 8;
            this.BtnSemanal.Text = "Semanal";
            this.BtnSemanal.UseVisualStyleBackColor = true;
            this.BtnSemanal.Click += new System.EventHandler(this.BtnSemanal_Click);
            // 
            // BtnDiario
            // 
            this.BtnDiario.Location = new System.Drawing.Point(19, 33);
            this.BtnDiario.Name = "BtnDiario";
            this.BtnDiario.Size = new System.Drawing.Size(62, 23);
            this.BtnDiario.TabIndex = 7;
            this.BtnDiario.Text = "Diário";
            this.BtnDiario.UseVisualStyleBackColor = true;
            this.BtnDiario.Click += new System.EventHandler(this.BtnDiario_Click);
            // 
            // LblAgendamentos
            // 
            this.LblAgendamentos.AutoSize = true;
            this.LblAgendamentos.Location = new System.Drawing.Point(19, 243);
            this.LblAgendamentos.Name = "LblAgendamentos";
            this.LblAgendamentos.Size = new System.Drawing.Size(114, 13);
            this.LblAgendamentos.TabIndex = 10;
            this.LblAgendamentos.Text = "Últimos agendamentos";
            // 
            // FrmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1054, 636);
            this.Controls.Add(this.LblAgendamentos);
            this.Controls.Add(this.PnlAtendimentos);
            this.Controls.Add(this.PnlFaturamento);
            this.Controls.Add(this.BtnMensal);
            this.Controls.Add(this.BtnSemanal);
            this.Controls.Add(this.BtnDiario);
            this.Controls.Add(this.DgvAtendimentos);
            this.Controls.Add(this.PnlServicos);
            this.Controls.Add(this.CalCalendarioD);
            this.Name = "FrmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.PnlFaturamento.ResumeLayout(false);
            this.PnlFaturamento.PerformLayout();
            this.PnlAtendimentos.ResumeLayout(false);
            this.PnlAtendimentos.PerformLayout();
            this.PnlServicos.ResumeLayout(false);
            this.PnlServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAtendimentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar CalCalendarioD;
        private System.Windows.Forms.Panel PnlFaturamento;
        private System.Windows.Forms.Panel PnlAtendimentos;
        private System.Windows.Forms.Panel PnlServicos;
        private System.Windows.Forms.DataGridView DgvAtendimentos;
        private System.Windows.Forms.Button BtnMensal;
        private System.Windows.Forms.Button BtnSemanal;
        private System.Windows.Forms.Button BtnDiario;
        private System.Windows.Forms.Label LblServicos;
        private System.Windows.Forms.Label LblAgendamentos;
        private System.Windows.Forms.Label LblFaturamento;
        private System.Windows.Forms.Label LblQntAtendimentos;
        private System.Windows.Forms.TextBox TxtFaturamento;
        private System.Windows.Forms.TextBox TxtQntAtendimentos;
        private System.Windows.Forms.Label LblHidratacao;
        private System.Windows.Forms.Label LblColoracao;
        private System.Windows.Forms.Label LblMechas;
        private System.Windows.Forms.Label LblCorte;
        private System.Windows.Forms.Label LblSelagem;
        private System.Windows.Forms.Label LblSobrancelha;
        private System.Windows.Forms.ProgressBar PgbColoracao;
        private System.Windows.Forms.ProgressBar PgbSelagem;
        private System.Windows.Forms.ProgressBar PgbMechas;
        private System.Windows.Forms.ProgressBar PgbCorte;
        private System.Windows.Forms.ProgressBar PgbSobrancelha;
        private System.Windows.Forms.ProgressBar PgbHidratacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColData;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColProcedimentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColValor;
        private System.Windows.Forms.TextBox TxtPercentualSelagem;
        private System.Windows.Forms.TextBox TxtPercentualMechas;
        private System.Windows.Forms.TextBox TxtPercentualCorte;
        private System.Windows.Forms.TextBox TxtPercentualSobrancelha;
        private System.Windows.Forms.TextBox TxtPercentualHidratacao;
        private System.Windows.Forms.TextBox TxtPercentualColoracao;
    }
}

