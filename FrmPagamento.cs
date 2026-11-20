using System;
using System.Windows.Forms;

namespace Agenda
{
    public partial class FrmPagamento : Form
    {
        private Agendamento agendamento;
        private FrmAgendaDAo agendaDao = new FrmAgendaDAo();
        private PagamentoDAO dao = new PagamentoDAO();

        internal FrmPagamento(Agendamento agendamento)
        {
            InitializeComponent();
            this.agendamento = agendamento;
            Load += FrmPagamento_Load;
            Btn_Salvar.Click += Btn_Salvar_Click;
            Btn_Limpar.Click += Btn_Limpar_Click;
        }

        private void FrmPagamento_Load(object sender, EventArgs e)
        {
            if (Dgv_Procedimentos.Columns.Count == 0)
            {
                Dgv_Procedimentos.Columns.Add("Procedimento", "Procedimento");
            }
            if (Dgv_Valores.Columns.Count == 0)
            {
                Dgv_Valores.Columns.Add("Valor", "Valor");
            }
            Dgv_Procedimentos.ReadOnly = true;
            Dgv_Procedimentos.AllowUserToAddRows = false;
            Dgv_Procedimentos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Dgv_Valores.ReadOnly = true;
            Dgv_Valores.AllowUserToAddRows = false;
            Dgv_Valores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Txb_Cliente.ReadOnly = true;
            Txb_Total.ReadOnly = true;
            CarregarPedido();
        }

        private void CarregarPedido()
        {
            Txb_Cliente.Text = agendamento.Cliente;
            Dgv_Procedimentos.Rows.Clear();
            Dgv_Valores.Rows.Clear();
            string[] nomes = agendamento.Procedimentos.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string nome in nomes)
            {
                decimal valor = agendaDao.ObterValor(nome);
                Dgv_Procedimentos.Rows.Add(nome);
                Dgv_Valores.Rows.Add("R$ " + valor.ToString("F2"));
            }
            Dgv_Procedimentos.ClearSelection();
            Dgv_Valores.ClearSelection();
            Txb_Total.Text = "R$ " + agendamento.Valor.ToString("F2");
        }

        private string ObterForma()
        {
            if (Rdb_Dinheiro.Checked)
            {
                return "Dinheiro";
            }
            if (Rdb_Pix.Checked)
            {
                return "Pix";
            }
            return "";
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {
            string forma = ObterForma();
            if (forma == "")
            {
                MessageBox.Show("Escolha a forma de pagamento.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (dao.JaPago(agendamento.NumAgendamento))
                {
                    MessageBox.Show("Este agendamento já foi pago.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Pagamento pagamento = new Pagamento();
                pagamento.NumAgendamento = agendamento.NumAgendamento;
                pagamento.FormaPagamento = forma;
                pagamento.Valor = agendamento.Valor;
                pagamento.DataPagamento = DateTime.Now;
                dao.Inserir(pagamento);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível salvar o pagamento: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string mensagem = "Cliente: " + agendamento.Cliente + Environment.NewLine
                + "Itens: " + agendamento.Procedimentos + Environment.NewLine
                + "Total: R$ " + agendamento.Valor.ToString("F2") + Environment.NewLine
                + "Forma de pagamento: " + forma + Environment.NewLine + Environment.NewLine
                + "Pagamento registrado com sucesso.";
            MessageBox.Show(mensagem, "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Rdb_Dinheiro.Checked = false;
            Rdb_Pix.Checked = false;
        }

    }
}