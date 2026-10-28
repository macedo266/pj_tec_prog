using Microsoft.Data.Sqlite;
using Projeto_do_semestre.Data;
using Projeto_do_semestre.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Projeto_do_semestre.Dao
{
    public class CarroDao
    {
        public List<Carro> ListarCarros()
        {
            string sql = "select * from Carro";
            SqliteConnection conexao = Banco.obterConexao();
            SqliteCommand comando    = new SqliteCommand(sql, conexao);
            SqliteDataReader dados   = comando.ExecuteReader();            
            List<Carro> lista = new List<Carro>();            
            while (dados.Read()){
                Carro c = new Carro();              
                c.Id            = dados.GetInt32(0);
                c.Nome          = dados.GetString(1);
                c.Descricao     = dados.GetString(2);
                c.Ano           = dados.GetInt32(3);
                c.Quilometragem = dados.GetInt32(4);
                c.Cambio        = dados.GetString(5);
                c.Preco         = dados.GetDouble(6);
                lista.Add(c);
            }
            return lista;
        }



        //criar métodos
        /*
        Listar
        Buscar
        Inserir
        Alterar
        Excluir        
        */ 
    }
}
