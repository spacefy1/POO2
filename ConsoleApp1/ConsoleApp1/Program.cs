using Microsoft.Data.SqlClient;

namespace ConsoleApp1
{
    internal class TestClass
        {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);

            SqlConnection conexao;

            conexao = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyUnityDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");

            conexao.Open();

            Console.WriteLine("Conexao OK");

            Console.WriteLine("== Salvado dados no BD ==");

            var insertCmd = conexao.CreateCommand();
            insertCmd.CommandText = "INSERT INTO CURSOS (Nome, Periodo, Categoria) VALUES (@nome, @per, @cat)";

            
            insertCmd.Parameters.Add(new SqlParameter("nome", "POO3"));

            insertCmd.Parameters.Add(new SqlParameter("per", 30));

            insertCmd.Parameters.Add(new SqlParameter("cat", "Maneiro23"));

            insertCmd.ExecuteNonQuery();

            conexao.Close();

        }
    }

}

