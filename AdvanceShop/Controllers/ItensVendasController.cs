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
    public class ItensVendasController
    {
        public DataTable ObterTodosItensDaVendas(ItensVendasModel itensVenda)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from itensvendas inner join produtos on itensvendas.produtos_idprodutos = produtos.idprodutos where vendas_idvendas = @vendas_idvendas;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@vendas_idvendas", itensVenda.vendas_idvendas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public DataTable ObterTodosItensDaTransacaoEstoque(ItensVendasModel itensVenda)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from itensvendas inner join produtos on itensvendas.produtos_idprodutos = produtos.idprodutos where transacoesestoque_idtransacoesestoque = @transacoesestoque_idtransacoesestoque;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@transacoesestoque_idtransacoesestoque", itensVenda.transacoesestoque_idtransacoesestoque));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
    }
}
