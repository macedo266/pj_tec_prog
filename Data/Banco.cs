using Microsoft.Data.Sqlite;

namespace Projeto_do_semestre.Data
{
    public class Banco
    {
        private static string caminho = "Data Source = agencia.db";

        public static SqliteConnection obterConexao()
        {
            SqliteConnection conexao = new SqliteConnection(caminho);
            conexao.Open();
            return conexao;
        }

        public static void CriarBanco()
        {
            SqliteConnection conexao = obterConexao();
            String sql = """
            CREATE TABLE IF NOT EXISTS Carro(
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                nome TEXT NOT NULL,
                descricao TEXT NOT NULL,
                ano INTEGER NOT NULL,
                quilometragem INTEGER,
                cambio TEXT NOT NULL,
                preco REAL NOT NULL
            )
            """;
            SqliteCommand cmd = new SqliteCommand(sql,conexao);
            cmd.ExecuteNonQuery();
        }
    }
}
