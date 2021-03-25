using AdvanceShop.Data;
using AdvanceShop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Controllers
{
    public class CategoriasContasAPagarController
    {
        public DataTable ObterTodasCategorias()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from categoriascontasapagar where deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void Adicionar(CategoriasContasAPagarModel categoriaContaAPagar)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into categoriascontasapagar(descricaocategoria,deletado) values(@descricaocategoria,0);";
            comando.Parameters.Add(new MySqlParameter("@descricaocategoria", categoriaContaAPagar.DescricaoCategoria));
            comando.ExecuteNonQuery();
        }

        public void Deletar(CategoriasContasAPagarModel categoriaContaAPagar)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update categoriascontasapagar set deletado = 1 where idcategoriascontasapagar = @idcategoriascontasapagar;";
            comando.Parameters.Add(new MySqlParameter("@idcategoriascontasapagar", categoriaContaAPagar.IdCategoriascontasapagar));
            comando.ExecuteNonQuery();
        }
    }
}
