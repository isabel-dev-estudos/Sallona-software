using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class PagamentoDAO
    {
        public void Inserir(Pagamento pagamento)
        {
            MySqlConnection con = Conexao.Obter();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO pagamentos (num_agendamento, forma_pagamento, valor, data_pagamento) VALUES (@numAgendamento, @forma, @valor, @data)", con);
            cmd.Parameters.AddWithValue("@numAgendamento", pagamento.NumAgendamento);
            cmd.Parameters.AddWithValue("@forma", pagamento.FormaPagamento);
            cmd.Parameters.AddWithValue("@valor", pagamento.Valor);
            cmd.Parameters.AddWithValue("@data", pagamento.DataPagamento);
            cmd.ExecuteNonQuery();
            pagamento.NumPagamento = Convert.ToInt32(cmd.LastInsertedId);
            con.Close();
        }

        public bool JaPago(int numAgendamento)
        {
            MySqlConnection con = Conexao.Obter();
            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM pagamentos WHERE num_agendamento = @numAgendamento", con);
            cmd.Parameters.AddWithValue("@numAgendamento", numAgendamento);
            int quantidade = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return quantidade > 0;
        }
    }
}
