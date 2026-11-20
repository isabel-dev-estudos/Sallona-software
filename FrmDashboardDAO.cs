using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Agenda
{
    internal class FrmDashboardDAO
    {
        private string conexao = "Server=localhost;Database=SALLONA_DB;Uid=root;Pwd=;";

        private void PreencherProcedimentos(Agendamento agendamento)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT p.num_procedimento, p.nome, p.valor FROM itens_agendamento i INNER JOIN procedimentos p ON p.num_procedimento = i.num_procedimento WHERE i.num_agendamento = @numAgendamento ORDER BY p.num_procedimento", con);
            cmd.Parameters.AddWithValue("@numAgendamento", agendamento.NumAgendamento);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                if (agendamento.Procedimentos != "")
                {
                    agendamento.Procedimentos = agendamento.Procedimentos + ", ";
                }
                agendamento.NumProcedimentos.Add(leitor.GetInt32(0));
                agendamento.Procedimentos = agendamento.Procedimentos + leitor.GetString(1);
                agendamento.Valor = agendamento.Valor + leitor.GetDecimal(2);
            }
            leitor.Close();
            con.Close();
        }

        public List<Agendamento> ListarPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            List<Agendamento> lista = new List<Agendamento>();
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT a.num_agendamento, a.data_agendamento, a.horario, c.num_cliente, c.nome FROM agendamentos a INNER JOIN clientes c ON c.num_cliente = a.num_cliente WHERE a.data_agendamento BETWEEN @dataInicial AND @dataFinal ORDER BY a.data_agendamento, a.num_agendamento", con);
            cmd.Parameters.AddWithValue("@dataInicial", dataInicial.Date);
            cmd.Parameters.AddWithValue("@dataFinal", dataFinal.Date);
            MySqlDataReader leitor = cmd.ExecuteReader();
            while (leitor.Read())
            {
                Agendamento agendamento = new Agendamento();
                agendamento.NumAgendamento = leitor.GetInt32(0);
                agendamento.Data = leitor.GetDateTime(1);
                agendamento.Horario = leitor.GetString(2);
                agendamento.NumCliente = leitor.GetInt32(3);
                agendamento.Cliente = leitor.GetString(4);
                lista.Add(agendamento);
            }
            leitor.Close();
            con.Close();
            foreach (Agendamento agendamento in lista)
            {
                PreencherProcedimentos(agendamento);
            }
            return lista;
        }
    }
}