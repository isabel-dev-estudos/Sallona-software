using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace Agenda
{
    internal class FrmAgendaDAo
    {
        private string conexao = "Server=localhost;Database=SALLONA_DB;Uid=root;Pwd=;root";

        private int BuscarCliente(string nome)
        {
            int numCliente = 0;
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT num_cliente FROM clientes WHERE nome = @nome", con);
            cmd.Parameters.AddWithValue("@nome", nome);
            object resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                numCliente = Convert.ToInt32(resultado);
            }
            con.Close();
            return numCliente;
        }

        private int InserirCliente(string nome)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO clientes (nome) VALUES (@nome)", con);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.ExecuteNonQuery();
            int numCliente = Convert.ToInt32(cmd.LastInsertedId);
            con.Close();
            return numCliente;
        }

        private int ObterNumCliente(string nome)
        {
            int numCliente = BuscarCliente(nome);
            if (numCliente == 0)
            {
                numCliente = InserirCliente(nome);
            }
            return numCliente;
        }

        private void InserirItens(Agendamento agendamento)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            foreach (int numProcedimento in agendamento.NumProcedimentos)
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO itens_agendamento (num_agendamento, num_procedimento) VALUES (@numAgendamento, @numProcedimento)", con);
                cmd.Parameters.AddWithValue("@numAgendamento", agendamento.NumAgendamento);
                cmd.Parameters.AddWithValue("@numProcedimento", numProcedimento);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void ExcluirItens(int numAgendamento)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM itens_agendamento WHERE num_agendamento = @numAgendamento", con);
            cmd.Parameters.AddWithValue("@numAgendamento", numAgendamento);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void Inserir(Agendamento agendamento)
        {
            agendamento.NumCliente = ObterNumCliente(agendamento.Cliente);
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO agendamentos (data_agendamento, horario, num_cliente) VALUES (@data, @horario, @numCliente)", con);
            cmd.Parameters.AddWithValue("@data", agendamento.Data.Date);
            cmd.Parameters.AddWithValue("@horario", agendamento.Horario);
            cmd.Parameters.AddWithValue("@numCliente", agendamento.NumCliente);
            cmd.ExecuteNonQuery();
            agendamento.NumAgendamento = Convert.ToInt32(cmd.LastInsertedId);
            con.Close();
            InserirItens(agendamento);
        }

        public void Atualizar(Agendamento agendamento)
        {
            agendamento.NumCliente = ObterNumCliente(agendamento.Cliente);
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE agendamentos SET data_agendamento = @data, horario = @horario, num_cliente = @numCliente WHERE num_agendamento = @numAgendamento", con);
            cmd.Parameters.AddWithValue("@data", agendamento.Data.Date);
            cmd.Parameters.AddWithValue("@horario", agendamento.Horario);
            cmd.Parameters.AddWithValue("@numCliente", agendamento.NumCliente);
            cmd.Parameters.AddWithValue("@numAgendamento", agendamento.NumAgendamento);
            cmd.ExecuteNonQuery();
            con.Close();
            ExcluirItens(agendamento.NumAgendamento);
            InserirItens(agendamento);
        }

        public void Excluir(int numAgendamento)
        {
            ExcluirItens(numAgendamento);
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM agendamentos WHERE num_agendamento = @numAgendamento", con);
            cmd.Parameters.AddWithValue("@numAgendamento", numAgendamento);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public bool HorarioOcupado(DateTime data, string horario, int numAgendamento)
        {
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM agendamentos WHERE data_agendamento = @data AND horario = @horario AND num_agendamento <> @numAgendamento", con);
            cmd.Parameters.AddWithValue("@data", data.Date);
            cmd.Parameters.AddWithValue("@horario", horario);
            cmd.Parameters.AddWithValue("@numAgendamento", numAgendamento);
            int quantidade = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return quantidade > 0;
        }

        public decimal ObterValor(string nome)
        {
            decimal valor = 0;
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT valor FROM procedimentos WHERE nome = @nome", con);
            cmd.Parameters.AddWithValue("@nome", nome);
            object resultado = cmd.ExecuteScalar();
            if (resultado != null)
            {
                valor = Convert.ToDecimal(resultado);
            }
            con.Close();
            return valor;
        }

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

        public List<Agendamento> ListarPorData(DateTime data)
        {
            List<Agendamento> lista = new List<Agendamento>();
            MySqlConnection con = new MySqlConnection(conexao);
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT a.num_agendamento, a.data_agendamento, a.horario, c.num_cliente, c.nome FROM agendamentos a INNER JOIN clientes c ON c.num_cliente = a.num_cliente WHERE a.data_agendamento = @data ORDER BY a.data_agendamento, a.num_agendamento", con);
            cmd.Parameters.AddWithValue("@data", data.Date);
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