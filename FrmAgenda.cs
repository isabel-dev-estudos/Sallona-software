using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dashboard;
using Clientes;

namespace Agenda
{
    public partial class FrmAgenda : Form
    {
        private FrmAgendaDAo dao = new FrmAgendaDAo();
        private string filtroAtual = "Todos";
        private decimal valorTotal = 0;
        private Agendamento agendamentoEmEdicao;
        private bool atualizandoLista = false;
        private List<string> horarios = new List<string>();
        private string horarioSelecionado = "";

        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmAgenda_Load(object sender, EventArgs e)
        {
            foreach (object item in CmbHorario.Items)
            {
                horarios.Add(item.ToString());
            }
            CarregarHorarios();
            AtualizarAgenda();
        }

        private void DtpData_ValueChanged(object sender, EventArgs e)
        {
            if (DtpData.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MostrarAviso("O salão não funciona aos domingos.");
                DtpData.Value = DtpData.Value.AddDays(1);
                return;
            }
            CarregarHorarios();
        }

        private void CalCalendario_DateSelected(object sender, DateRangeEventArgs e)
        {
            if (e.Start.DayOfWeek == DayOfWeek.Sunday)
            {
                MostrarAviso("O salão não funciona aos domingos.");
                CalCalendario.SetDate(e.Start.AddDays(1));
            }
            AtualizarAgenda();
        }

        private void DgvAgendamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            horarioSelecionado = Convert.ToString(DgvAgendamentos.Rows[e.RowIndex].Cells["Horario"].Value);
        }

        private void ClbProcedimentos_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (atualizandoLista)
            {
                return;
            }
            atualizandoLista = true;
            if (e.Index == 0)
            {
                for (int i = 1; i < ClbProcedimentos.Items.Count; i++)
                {
                    ClbProcedimentos.SetItemChecked(i, e.NewValue == CheckState.Checked);
                }
            }
            else
            {
                if (e.NewValue == CheckState.Unchecked)
                {
                    ClbProcedimentos.SetItemChecked(0, false);
                }
            }
            atualizandoLista = false;
            CalcularValor(e);
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BtnAgendar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }
            Agendamento novo = new Agendamento();
            novo.Cliente = TxtCliente.Text.Trim();
            novo.Procedimentos = ObterProcedimentos();
            novo.NumProcedimentos = ObterNumProcedimentos();
            novo.Data = DtpData.Value.Date;
            novo.Horario = CmbHorario.Text;
            novo.Valor = valorTotal;
            if (agendamentoEmEdicao == null)
            {
                dao.Inserir(novo);
            }
            else
            {
                novo.NumAgendamento = agendamentoEmEdicao.NumAgendamento;
                dao.Atualizar(novo);
                agendamentoEmEdicao = null;
            }
            CalCalendario.SetDate(novo.Data);
            AtualizarAgenda();
            LimparCampos();
            MessageBox.Show("Agendamento realizado com sucesso.");
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = BuscarAgendamento();
            if (agendamento == null)
            {
                MostrarAviso("Selecione um agendamento na lista.");
                return;
            }
            DialogResult resposta = MessageBox.Show("Deseja excluir o agendamento de " + agendamento.Cliente + "?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.No)
            {
                return;
            }
            dao.Excluir(agendamento.NumAgendamento);
            if (agendamentoEmEdicao != null && agendamentoEmEdicao.NumAgendamento == agendamento.NumAgendamento)
            {
                agendamentoEmEdicao = null;
            }
            AtualizarAgenda();
            CarregarHorarios();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = BuscarAgendamento();
            if (agendamento == null)
            {
                MostrarAviso("Selecione um agendamento na lista.");
                return;
            }
            LimparCampos();
            agendamentoEmEdicao = agendamento;
            TxtCliente.Text = agendamento.Cliente;
            for (int i = 1; i < ClbProcedimentos.Items.Count; i++)
            {
                if (agendamento.Procedimentos.Contains(ClbProcedimentos.Items[i].ToString()))
                {
                    ClbProcedimentos.SetItemChecked(i, true);
                }
            }
            DtpData.Value = agendamento.Data;
            DtpData.Checked = true;
            CarregarHorarios();
            CmbHorario.SelectedItem = agendamento.Horario;
            MessageBox.Show("Altere os dados e clique em Agendar para salvar.");
        }

        private void BtnTodos_Click(object sender, EventArgs e)
        {
            AplicarFiltro("Todos");
        }

        private void BtnCorte_Click(object sender, EventArgs e)
        {
            AplicarFiltro("Corte");
        }

        private void BtnMechas_Click(object sender, EventArgs e)
        {
            AplicarFiltro("Mechas");
        }

        private void BtnSelagem_Click(object sender, EventArgs e)
        {
            AplicarFiltro("Selagem");
        }

        private void BtnColoracao_Click(object sender, EventArgs e)
        {
            AplicarFiltro("Coloração");
        }

        private void BtnHidratacao_Click(object sender, EventArgs e)
        {
            AplicarFiltro("Hidratação");
        }

        private void BtnSobrancelha_Click(object sender, EventArgs e)
        {
            AplicarFiltro("Sobrancelha");
        }

        private void AplicarFiltro(string procedimento)
        {
            filtroAtual = procedimento;
            AtualizarAgenda();
        }

        private void AtualizarAgenda()
        {
            List<Agendamento> lista = dao.ListarPorData(CalCalendario.SelectionStart.Date);
            List<Agendamento> resultado = new List<Agendamento>();
            foreach (Agendamento agendamento in lista)
            {
                if (ValidarFiltro(agendamento))
                {
                    resultado.Add(agendamento);
                }
            }
            horarioSelecionado = "";
            DgvAgendamentos.DataSource = null;
            DgvAgendamentos.DataSource = resultado;
            ConfigurarColunas();
            DgvAgendamentos.ClearSelection();
        }

        private void ConfigurarColunas()
        {
            DgvAgendamentos.Columns["Data"].Visible = false;
            DgvAgendamentos.Columns["NumAgendamento"].Visible = false;
            DgvAgendamentos.Columns["NumCliente"].Visible = false;
            DgvAgendamentos.Columns["Horario"].HeaderText = "Horário";
            DgvAgendamentos.Columns["Valor"].DefaultCellStyle.Format = "C2";
        }

        private bool ValidarFiltro(Agendamento agendamento)
        {
            if (filtroAtual == "Todos")
            {
                return true;
            }
            return agendamento.Procedimentos.Contains(filtroAtual);
        }

        private Agendamento BuscarAgendamento()
        {
            List<Agendamento> lista = dao.ListarPorData(CalCalendario.SelectionStart.Date);
            foreach (Agendamento agendamento in lista)
            {
                if (agendamento.Horario == horarioSelecionado)
                {
                    return agendamento;
                }
            }
            return null;
        }

        private void CarregarHorarios()
        {
            CmbHorario.Items.Clear();
            foreach (string horario in horarios)
            {
                if (!ValidarHorarioOcupado(horario) && !ValidarHorarioPassado(horario))
                {
                    CmbHorario.Items.Add(horario);
                }
            }
        }

        private bool ValidarHorarioOcupado(string horario)
        {
            int numEmEdicao = 0;
            if (agendamentoEmEdicao != null)
            {
                numEmEdicao = agendamentoEmEdicao.NumAgendamento;
            }
            return dao.HorarioOcupado(DtpData.Value.Date, horario, numEmEdicao);
        }

        private bool ValidarHorarioPassado(string horario)
        {
            DateTime dataHora = Convert.ToDateTime(DtpData.Value.ToShortDateString() + " " + horario);
            return dataHora <= DateTime.Now;
        }

        private void CalcularValor(ItemCheckEventArgs e)
        {
            valorTotal = 0;
            for (int i = 1; i < ClbProcedimentos.Items.Count; i++)
            {
                bool marcado;
                if (i == e.Index)
                {
                    marcado = e.NewValue == CheckState.Checked;
                }
                else
                {
                    marcado = ClbProcedimentos.GetItemChecked(i);
                }
                if (marcado)
                {
                    valorTotal = valorTotal + dao.ObterValor(ClbProcedimentos.Items[i].ToString());
                }
            }
            TxtValor.Text = "R$ " + valorTotal.ToString("F2");
        }

        private List<int> ObterNumProcedimentos()
        {
            List<int> numeros = new List<int>();
            for (int i = 1; i < ClbProcedimentos.Items.Count; i++)
            {
                if (ClbProcedimentos.GetItemChecked(i))
                {
                    numeros.Add(i);
                }
            }
            return numeros;
        }

        private string ObterProcedimentos()
        {
            string procedimentos = "";
            foreach (object item in ClbProcedimentos.CheckedItems)
            {
                if (item.ToString() == "Todos")
                {
                    continue;
                }
                if (procedimentos != "")
                {
                    procedimentos = procedimentos + ", ";
                }
                procedimentos = procedimentos + item.ToString();
            }
            return procedimentos;
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(TxtCliente.Text))
            {
                MostrarAviso("Informe o nome da cliente.");
                TxtCliente.Focus();
                return false;
            }
            if (double.TryParse(TxtCliente.Text.Trim(), out double numero))
            {
                MostrarAviso("O nome da cliente não pode ser um número.");
                TxtCliente.Focus();
                return false;
            }
            if (ObterProcedimentos() == "")
            {
                MostrarAviso("Escolha pelo menos um procedimento.");
                ClbProcedimentos.Focus();
                return false;
            }
            if (!DtpData.Checked)
            {
                MostrarAviso("Escolha a data do agendamento.");
                DtpData.Focus();
                return false;
            }
            if (DtpData.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                MostrarAviso("O salão não funciona aos domingos.");
                DtpData.Focus();
                return false;
            }
            if (CmbHorario.SelectedIndex == -1)
            {
                MostrarAviso("Escolha um horário.");
                CmbHorario.Focus();
                return false;
            }
            if (ValidarHorarioPassado(CmbHorario.Text))
            {
                MostrarAviso("Esse horário já passou. Escolha outro horário.");
                CarregarHorarios();
                CmbHorario.Focus();
                return false;
            }
            return true;
        }

        private void LimparCampos()
        {
            TxtCliente.Clear();
            for (int i = 0; i < ClbProcedimentos.Items.Count; i++)
            {
                ClbProcedimentos.SetItemChecked(i, false);
            }
            DtpData.Checked = false;
            CmbHorario.SelectedIndex = -1;
            valorTotal = 0;
            agendamentoEmEdicao = null;
            TxtValor.Clear();
            CarregarHorarios();
        }

        private static void MostrarAviso(string mensagem)
        {
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Todos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlpAgendamento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Pagar_Click(object sender, EventArgs e)
        {
            Agendamento agendamento = BuscarAgendamento();
            if (agendamento == null)
            {
                MostrarAviso("Selecione um agendamento na lista.");
                return;
            }
            FrmPagamento tela = new FrmPagamento(agendamento);
            tela.ShowDialog();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Paginas.Abrir(new FrmDashboard(), this);
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            Paginas.Abrir(new Clientesforms(), this);
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAgenda_Click(object sender, EventArgs e)
        {

        }
    }
}