using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agenda;

namespace Dashboard
{
    public partial class FrmDashboard : Form
    {
        private FrmDashboardDAO dao = new FrmDashboardDAO();
        private List<Agendamento> atendimentos = new List<Agendamento>();
        private string periodo = "Diario";
        private DateTime dataInicial;
        private DateTime dataFinal;

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            AtualizarDashboard();
        }

        private void FrmDashboard_Activated(object sender, EventArgs e)
        {
            AtualizarDashboard();
        }

        private void BtnDiario_Click(object sender, EventArgs e)
        {
            periodo = "Diario";
            AtualizarDashboard();
        }

        private void BtnSemanal_Click(object sender, EventArgs e)
        {
            periodo = "Semanal";
            AtualizarDashboard();
        }

        private void BtnMensal_Click(object sender, EventArgs e)
        {
            periodo = "Mensal";
            AtualizarDashboard();
        }

        private void CalCalendarioD_DateChanged(object sender, DateRangeEventArgs e)
        {
            AtualizarDashboard();
        }

        private void AtualizarDashboard()
        {
            CalcularPeriodo();
            atendimentos = dao.ListarPeriodo(dataInicial, dataFinal);
            DgvAtendimentos.Rows.Clear();
            int quantidade = 0;
            decimal faturamento = 0;
            foreach (Agendamento agendamento in atendimentos)
            {
                quantidade++;
                faturamento = faturamento + agendamento.Valor;
                DgvAtendimentos.Rows.Add(agendamento.Data.ToShortDateString(), agendamento.Cliente, agendamento.Procedimentos, agendamento.Horario, $"R$ {agendamento.Valor.ToString("F2")}");
            }
            DgvAtendimentos.ClearSelection();
            TxtQntAtendimentos.Text = quantidade.ToString();
            TxtFaturamento.Text = $"R$ {faturamento.ToString("F2")}";
            MostrarPercentual(PgbHidratacao, TxtPercentualHidratacao, ContarProcedimento("Hidratação"), quantidade);
            MostrarPercentual(PgbSobrancelha, TxtPercentualSobrancelha, ContarProcedimento("Sobrancelha"), quantidade);
            MostrarPercentual(PgbCorte, TxtPercentualCorte, ContarProcedimento("Corte"), quantidade);
            MostrarPercentual(PgbSelagem, TxtPercentualSelagem, ContarProcedimento("Selagem"), quantidade);
            MostrarPercentual(PgbColoracao, TxtPercentualColoracao, ContarProcedimento("Coloração"), quantidade);
            MostrarPercentual(PgbMechas, TxtPercentualMechas, ContarProcedimento("Mechas"), quantidade);

        }

        private void CalcularPeriodo()
        {
            DateTime dataClicada = CalCalendarioD.SelectionStart;
            dataInicial = dataClicada;
            dataFinal = dataClicada;
            if (periodo == "Semanal")
            {
                dataInicial = dataClicada.AddDays(-(int)dataClicada.DayOfWeek);
                dataFinal = dataInicial.AddDays(6);
            }
            if (periodo == "Mensal")
            {
                dataInicial = new DateTime(dataClicada.Year, dataClicada.Month, 1);
                dataFinal = dataInicial.AddMonths(1).AddDays(-1);
            }
        }

        private int ContarProcedimento(string procedimento)
        {
            int contagem = 0;
            foreach (Agendamento agendamento in atendimentos)
            {
                if (agendamento.Procedimentos.Contains(procedimento))
                {
                    contagem++;
                }
            }
            return contagem;
        }

        private void MostrarPercentual(ProgressBar barra, TextBox caixa, int contagem, int total)
        {
            double percentual = 0;
            if (total > 0)
            {
                percentual = contagem * 100.0 / total;
            }
            barra.Value = (int)percentual;
            caixa.Text = percentual.ToString("F1");
        }

    }
}