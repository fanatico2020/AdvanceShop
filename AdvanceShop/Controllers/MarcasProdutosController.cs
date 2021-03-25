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
    public class MarcasProdutosController
    {
        public DataTable ObterTodasMarcas()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from marcasprodutos where deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void Adicionar(MarcasProdutosModel marcaProduto)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into marcasprodutos(descricaomarca,deletado) values(@descricaomarca,0);";
            comando.Parameters.Add(new MySqlParameter("@descricaomarca", marcaProduto.DescricaoMarca));
            comando.ExecuteNonQuery();
        }

        public void Deletar(MarcasProdutosModel marcaProduto)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update marcasprodutos set deletado = 1 where idmarcasprodutos = @idmarcasprodutos;";
            comando.Parameters.Add(new MySqlParameter("@idmarcasprodutos", marcaProduto.IdMarcasProdutos));
            comando.ExecuteNonQuery();
        }
    }
}
