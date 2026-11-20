using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

public class ClienteDAO
{
    public List<Cliente> Listar()
    {
        var lista = new List<Cliente>();

        using (var con = Conexao.Obter())
        {
            con.Open();

            string sql = @"SELECT num_cliente, nome, telefone, email, ultima_visita
                           FROM clientes
                           WHERE ativo = 1
                           ORDER BY nome";

            using (var cmd = new MySqlCommand(sql, con))
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    lista.Add(new Cliente
                    {
                        Id = dr.GetInt32("num_cliente"),
                        Nome = dr.GetString("nome"),

                        Telefone = dr.IsDBNull(dr.GetOrdinal("telefone"))
                            ? ""
                            : dr.GetString("telefone"),

                        Email = dr.IsDBNull(dr.GetOrdinal("email"))
                            ? ""
                            : dr.GetString("email"),

                        UltimaVisita = dr.IsDBNull(dr.GetOrdinal("ultima_visita"))
                            ? (DateTime?)null
                            : dr.GetDateTime("ultima_visita")
                    });
                }
            }
        }

        return lista;
    }

    public void Inserir(Cliente c)
    {
        using (var con = Conexao.Obter())
        {
            con.Open();

            string sql = @"INSERT INTO clientes
                           (nome, telefone, email, ultima_visita)
                           VALUES (@nome, @telefone, @email, @visita)";

            using (var cmd = new MySqlCommand(sql, con))
            {
                PreencherParametros(cmd, c);
                cmd.ExecuteNonQuery();
                c.Id = (int)cmd.LastInsertedId;
            }
        }
    }

    public void Atualizar(Cliente c)
    {
        using (var con = Conexao.Obter())
        {
            con.Open();

            string sql = @"UPDATE clientes
                           SET nome = @nome,
                               telefone = @telefone,
                               email = @email,
                               ultima_visita = @visita
                           WHERE num_cliente = @id AND ativo = 1";

            using (var cmd = new MySqlCommand(sql, con))
            {
                PreencherParametros(cmd, c);
                cmd.Parameters.AddWithValue("@id", c.Id);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public void Excluir(int id)
    {
        using (var con = Conexao.Obter())
        {
            con.Open();

            string sql = @"UPDATE clientes
                           SET ativo = 0
                           WHERE num_cliente = @id AND ativo = 1";

            using (var cmd = new MySqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@id", id);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas == 0)
                    throw new Exception("Cliente não encontrado ou já está inativo.");
            }
        }
    }

    private void PreencherParametros(MySqlCommand cmd, Cliente c)
    {
        cmd.Parameters.AddWithValue("@nome", c.Nome);

        cmd.Parameters.AddWithValue("@telefone",
            string.IsNullOrWhiteSpace(c.Telefone)
                ? (object)DBNull.Value
                : c.Telefone);

        cmd.Parameters.AddWithValue("@email",
            string.IsNullOrWhiteSpace(c.Email)
                ? (object)DBNull.Value
                : c.Email);

        cmd.Parameters.AddWithValue("@visita",
            c.UltimaVisita.HasValue
                ? (object)c.UltimaVisita.Value
                : DBNull.Value);
    }
}