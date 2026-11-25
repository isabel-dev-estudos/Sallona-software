namespace Agenda
{
    partial class FrmPagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPagamento));
            this.Txb_Cliente = new System.Windows.Forms.TextBox();
            this.Dgv_Procedimentos = new System.Windows.Forms.DataGridView();
            this.Dgv_Valores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Txb_Total = new System.Windows.Forms.TextBox();
            this.Grb_Forma = new System.Windows.Forms.GroupBox();
            this.Rdb_Pix = new System.Windows.Forms.RadioButton();
            this.Rdb_Dinheiro = new System.Windows.Forms.RadioButton();
            this.Btn_Salvar = new System.Windows.Forms.Button();
            this.Btn_Limpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAgenda = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Procedimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Valores)).BeginInit();
            this.Grb_Forma.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txb_Cliente
            // 
            this.Txb_Cliente.BackColor = System.Drawing.SystemColors.Window;
            this.Txb_Cliente.Location = new System.Drawing.Point(151, 139);
            this.Txb_Cliente.Name = "Txb_Cliente";
            this.Txb_Cliente.ReadOnly = true;
            this.Txb_Cliente.Size = new System.Drawing.Size(132, 20);
            this.Txb_Cliente.TabIndex = 0;
            // 
            // Dgv_Procedimentos
            // 
            this.Dgv_Procedimentos.AllowUserToAddRows = false;
            this.Dgv_Procedimentos.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Procedimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Procedimentos.Location = new System.Drawing.Point(316, 139);
            this.Dgv_Procedimentos.Name = "Dgv_Procedimentos";
            this.Dgv_Procedimentos.ReadOnly = true;
            this.Dgv_Procedimentos.Size = new System.Drawing.Size(273, 215);
            this.Dgv_Procedimentos.TabIndex = 1;
            // 
            // Dgv_Valores
            // 
            this.Dgv_Valores.AllowUserToAddRows = false;
            this.Dgv_Valores.BackgroundColor = System.Drawing.Color.White;
            this.Dgv_Valores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Valores.Location = new System.Drawing.Point(717, 139);
            this.Dgv_Valores.Name = "Dgv_Valores";
            this.Dgv_Valores.ReadOnly = true;
            this.Dgv_Valores.Size = new System.Drawing.Size(273, 215);
            this.Dgv_Valores.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total do Pedido:";
            // 
            // Txb_Total
            // 
            this.Txb_Total.BackColor = System.Drawing.SystemColors.Window;
            this.Txb_Total.Location = new System.Drawing.Point(418, 387);
            this.Txb_Total.Name = "Txb_Total";
            this.Txb_Total.ReadOnly = true;
            this.Txb_Total.Size = new System.Drawing.Size(146, 20);
            this.Txb_Total.TabIndex = 4;
            // 
            // Grb_Forma
            // 
            this.Grb_Forma.Controls.Add(this.Rdb_Pix);
            this.Grb_Forma.Controls.Add(this.Rdb_Dinheiro);
            this.Grb_Forma.Location = new System.Drawing.Point(717, 410);
            this.Grb_Forma.Name = "Grb_Forma";
            this.Grb_Forma.Size = new System.Drawing.Size(272, 103);
            this.Grb_Forma.TabIndex = 5;
            this.Grb_Forma.TabStop = false;
            this.Grb_Forma.Text = "Forma de Pagamento";
            // 
            // Rdb_Pix
            // 
            this.Rdb_Pix.AutoSize = true;
            this.Rdb_Pix.Location = new System.Drawing.Point(7, 43);
            this.Rdb_Pix.Name = "Rdb_Pix";
            this.Rdb_Pix.Size = new System.Drawing.Size(39, 17);
            this.Rdb_Pix.TabIndex = 1;
            this.Rdb_Pix.TabStop = true;
            this.Rdb_Pix.Text = "Pix";
            this.Rdb_Pix.UseVisualStyleBackColor = true;
            // 
            // Rdb_Dinheiro
            // 
            this.Rdb_Dinheiro.AutoSize = true;
            this.Rdb_Dinheiro.Location = new System.Drawing.Point(7, 20);
            this.Rdb_Dinheiro.Name = "Rdb_Dinheiro";
            this.Rdb_Dinheiro.Size = new System.Drawing.Size(64, 17);
            this.Rdb_Dinheiro.TabIndex = 0;
            this.Rdb_Dinheiro.TabStop = true;
            this.Rdb_Dinheiro.Text = "Dinheiro";
            this.Rdb_Dinheiro.UseVisualStyleBackColor = true;
            // 
            // Btn_Salvar
            // 
            this.Btn_Salvar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_Salvar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salvar.Location = new System.Drawing.Point(452, 590);
            this.Btn_Salvar.Name = "Btn_Salvar";
            this.Btn_Salvar.Size = new System.Drawing.Size(173, 36);
            this.Btn_Salvar.TabIndex = 6;
            this.Btn_Salvar.Text = "Salvar pagamento";
            this.Btn_Salvar.UseVisualStyleBackColor = false;
            // 
            // Btn_Limpar
            // 
            this.Btn_Limpar.BackColor = System.Drawing.SystemColors.Window;
            this.Btn_Limpar.Location = new System.Drawing.Point(668, 588);
            this.Btn_Limpar.Name = "Btn_Limpar";
            this.Btn_Limpar.Size = new System.Drawing.Size(173, 36);
            this.Btn_Limpar.TabIndex = 7;
            this.Btn_Limpar.Text = "Limpar";
            this.Btn_Limpar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cliente:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.btnAgenda);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Location = new System.Drawing.Point(53, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 55);
            this.panel1.TabIndex = 9;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(832, 11);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(47, 40);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.Location = new System.Drawing.Point(27, 11);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(109, 40);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnAgenda
            // 
            this.btnAgenda.FlatAppearance.BorderSize = 0;
            this.btnAgenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnAgenda.Location = new System.Drawing.Point(365, 11);
            this.btnAgenda.Name = "btnAgenda";
            this.btnAgenda.Size = new System.Drawing.Size(100, 40);
            this.btnAgenda.TabIndex = 8;
            this.btnAgenda.Text = "Agenda";
            this.btnAgenda.UseVisualStyleBackColor = true;
            this.btnAgenda.Click += new System.EventHandler(this.btnAgenda_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Pink;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClientes.Location = new System.Drawing.Point(209, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(100, 40);
            this.btnClientes.TabIndex = 5;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.OldLace;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.PaleVioletRed;
            this.lblTitulo.Location = new System.Drawing.Point(312, 81);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(115, 24);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Pagamento";
            // 
            // FrmPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1054, 636);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Limpar);
            this.Controls.Add(this.Btn_Salvar);
            this.Controls.Add(this.Grb_Forma);
            this.Controls.Add(this.Txb_Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Dgv_Valores);
            this.Controls.Add(this.Dgv_Procedimentos);
            this.Controls.Add(this.Txb_Cliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPagamento";
            this.Text = "SALLONA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Procedimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Valores)).EndInit();
            this.Grb_Forma.ResumeLayout(false);
            this.Grb_Forma.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txb_Cliente;
        private System.Windows.Forms.DataGridView Dgv_Procedimentos;
        private System.Windows.Forms.DataGridView Dgv_Valores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txb_Total;
        private System.Windows.Forms.GroupBox Grb_Forma;
        private System.Windows.Forms.RadioButton Rdb_Dinheiro;
        private System.Windows.Forms.RadioButton Rdb_Pix;
        private System.Windows.Forms.Button Btn_Salvar;
        private System.Windows.Forms.Button Btn_Limpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnAgenda;
        private System.Windows.Forms.Button btnClientes;
    }
}