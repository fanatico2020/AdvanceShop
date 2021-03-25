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
    public class UnidadesMedidasProdutosController
    {
        public DataTable ObterTodasUnidadesMedidas()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from unidadesmedidasprodutos where deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void Adicionar(UnidadesMedidasProdutosModel unidadeMedidaProduto)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into unidadesmedidasprodutos(descricaounidademedida,deletado) values(@descricaounidademedida,0);";
            comando.Parameters.Add(new MySqlParameter("@descricaounidademedida", unidadeMedidaProduto.DescricaoUnidadeMedida));
            comando.ExecuteNonQuery();
        }

        public void Deletar(UnidadesMedidasProdutosModel unidadeMedidaProduto)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update unidadesmedidasprodutos set deletado = 1 where idunidadesmedidasprodutos = @idunidadesmedidasprodutos;";
            comando.Parameters.Add(new MySqlParameter("@idunidadesmedidasprodutos", unidadeMedidaProduto.IdUnidadesMedidasProdutos));
            comando.ExecuteNonQuery();
        }

    }
}
