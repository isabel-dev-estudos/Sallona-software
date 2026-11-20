namespace Clientes
{
    partial class Clientesforms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientesforms));
            this.btnSair = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnFinanceiro = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFiltros = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(749, 13);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(302, 40);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Location = new System.Drawing.Point(566, 13);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(100, 40);
            this.btnAgenda.TabIndex = 3;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnFinanceiro
            // 
            this.btnFinanceiro.FlatAppearance.BorderSize = 0;
            this.btnFinanceiro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinanceiro.Location = new System.Drawing.Point(395, 13);
            this.btnFinanceiro.Name = "btnFinanceiro";
            this.btnFinanceiro.Size = new System.Drawing.Size(100, 40);
            this.btnFinanceiro.TabIndex = 2;
            this.btnFinanceiro.Text = "Financeiro";
            this.btnFinanceiro.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Location = new System.Drawing.Point(209, 13);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 40);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Location = new System.Drawing.Point(22, 13);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(100, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.btnSair);
            this.pnlConteudo.Controls.Add(this.btnDashboard);
            this.pnlConteudo.Controls.Add(this.btnAgenda);
            this.pnlConteudo.Controls.Add(this.btnClientes);
            this.pnlConteudo.Controls.Add(this.btnFinanceiro);
            this.pnlConteudo.Location = new System.Drawing.Point(12, -1);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(1063, 60);
            this.pnlConteudo.TabIndex = 1;
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusca.Location = new System.Drawing.Point(49, 169);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(208, 35);
            this.txtBusca.TabIndex = 3;
            // 
            // dgvClientes
            // 
            this.dgvClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 234);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(1058, 362);
            this.dgvClientes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clientes";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(383, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cuidar dos detalhes é o primeiro passo para um atendimento memorável";
            // 
            // btnFiltros
            // 
            this.btnFiltros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFiltros.Location = new System.Drawing.Point(282, 172);
            this.btnFiltros.Name = "btnFiltros";
            this.btnFiltros.Size = new System.Drawing.Size(75, 32);
            this.btnFiltros.TabIndex = 10;
            this.btnFiltros.Text = "Filtros";
            this.btnFiltros.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Location = new System.Drawing.Point(504, 81);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(0, 43);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo cliente";
            this.btnNovo.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(684, 81);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(0, 43);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(867, 81);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(0, 43);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdenar.Location = new System.Drawing.Point(386, 169);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 32);
            this.btnOrdenar.TabIndex = 16;
            this.btnOrdenar.Text = "Nome: A–Z";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(890, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 43);
            this.button1.TabIndex = 19;
            this.button1.Text = "Excluir";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(723, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.PaleVioletRed;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(556, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 43);
            this.button3.TabIndex = 17;
            this.button3.Text = "Novo cliente";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Clientesforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1075, 636);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnFiltros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.pnlConteudo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clientesforms";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientesforms_Load_1);
            this.pnlConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnFinanceiro;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFiltros;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}