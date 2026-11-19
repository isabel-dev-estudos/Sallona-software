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

        private void CalcularPeriodo()
        {
            DateTime dataClicada = CalCalendarioD.SelectionStart;
            switch (periodo)
            {
                case "Diario":
                    dataInicial = dataClicada;
                    dataFinal = dataClicada;
                    break;
                case "Semanal":
                    dataInicial = dataClicada.AddDays(-(int)dataClicada.DayOfWeek);
                    dataFinal = dataInicial.AddDays(6);
                    break;
                case "Mensal":
                    dataInicial = new DateTime(dataClicada.Year, dataClicada.Month, 1);
                    dataFinal = dataInicial.AddMonths(1).AddDays(-1);
                    break;
            }
        }

        private bool ValidarPeriodo(Agendamento agendamento)
        {
            if (agendamento.Data.Date < dataInicial.Date)
            {
                return false;
            }
            if (agendamento.Data.Date > dataFinal.Date)
            {
                return false;
            }
            return true;
        }

        private void AtualizarDashboard()
        {
            CalcularPeriodo();
            DgvAtendimentos.Rows.Clear();
            int quantidade = 0;
            double faturamento = 0;
            int corte = 0;
            int mechas = 0;
            int selagem = 0;
            int coloracao = 0;
            int hidratacao = 0;
            int sobrancelha = 0;
            foreach (Agendamento agendamento in FrmAgenda.agendamentos)
            {
                if (!ValidarPeriodo(agendamento))
                {
                    continue;
                }
                quantidade++;
                faturamento = faturamento + agendamento.Valor;
                if (agendamento.Procedimentos.Contains("Corte"))
                {
                    corte++;
                }
                if (agendamento.Procedimentos.Contains("Mechas"))
                {
                    mechas++;
                }
                if (agendamento.Procedimentos.Contains("Selagem"))
                {
                    selagem++;
                }
                if (agendamento.Procedimentos.Contains("Coloração"))
                {
                    coloracao++;
                }
                if (agendamento.Procedimentos.Contains("Hidratação"))
                {
                    hidratacao++;
                }
                if (agendamento.Procedimentos.Contains("Sobrancelha"))
                {
                    sobrancelha++;
                }
                DgvAtendimentos.Rows.Add(agendamento.Data.ToShortDateString(), agendamento.Cliente, agendamento.Procedimentos, agendamento.Horario, "R$ " + agendamento.Valor.ToString("F2"));
            }
            TxtQntAtendimentos.Text = quantidade.ToString();
            TxtFaturamento.Text = "R$ " + faturamento.ToString("F2");
            MostrarPercentual(PgbCorte, TxtPercentualCorte, corte, quantidade);
            MostrarPercentual(PgbMechas, TxtPercentualMechas, mechas, quantidade);
            MostrarPercentual(PgbSelagem, TxtPercentualSelagem, selagem, quantidade);
            MostrarPercentual(PgbColoracao, TxtPercentualColoracao, coloracao, quantidade);
            MostrarPercentual(PgbHidratacao, TxtPercentualHidratacao, hidratacao, quantidade);
            MostrarPercentual(PgbSobrancelha, TxtPercentualSobrancelha, sobrancelha, quantidade);
            DgvAtendimentos.ClearSelection();
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