using MySql.Data.MySqlClient;
using System.Data.SqlClient;

public class Conexao
{
    public static MySqlConnection Obter()
    {
        var sb = new MySqlConnectionStringBuilder
        {
            Server = "localhost",
            Port = 3306,
            Database = "sallona_db",
            UserID = "root",
            Password = "root"
        };

        return new MySqlConnection(sb.ConnectionString);
    }
}