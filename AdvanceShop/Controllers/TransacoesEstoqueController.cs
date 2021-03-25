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
    public class TransacoesEstoqueController
    {
        public DataTable ObterTodasTransacoes()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from transacoesestoque inner join datahora on datahora.transacoesestoque_idtransacoesestoque = transacoesestoque.idtransacoesestoque left join clientespessoas on transacoesestoque.clientespessoas_idclientespessoas = clientespessoas.idclientespessoas where transacoesestoque.deletado = 0 order by datahora.datahoracadastro desc;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void EntradaEstoque(TransacoesEstoqueModel transacaoEstoque,List<ProdutosModel> produtosEntrada, List<ItensVendasModel> itensVenda, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
            "insert into transacoesestoque(tipo,descricaotransacao,clientespessoas_idclientespessoas,deletado) values (1,'Entrada de mercado no estoque',@clientespessoas_idclientespessoas,0); " +
            "select last_insert_id() into @id_transacaoestoque; " +
            "insert into datahora(datahoracadastro,usuariocadastro,transacoesestoque_idtransacoesestoque) values(now(),@usuariocadastro,last_insert_id()); ";
            comando.Parameters.Add(new MySqlParameter("@clientespessoas_idclientespessoas", transacaoEstoque.clientespessoas_idclientespessoas));
            comando.Parameters.Add(new MySqlParameter("@usuariocadastro", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();

            foreach (ItensVendasModel item in itensVenda)//inserir na tabela itensvendas os itens da venda conforme veio na lista
            {
                comando.CommandText =

                "insert into itensvendas(quantidade,valorunitario,subtotal,produtos_idprodutos,transacoesestoque_idtransacoesestoque) " +
                "values(@quantidade,@valorunitario,@subtotal,@produtos_idprodutos,@id_transacaoestoque);";
                comando.Parameters.Add(new MySqlParameter("@quantidade", item.Quantidade));
                comando.Parameters.Add(new MySqlParameter("@valorunitario", item.ValorUnitario));
                comando.Parameters.Add(new MySqlParameter("@subtotal", item.Subtotal));
                comando.Parameters.Add(new MySqlParameter("@item", item.Item));
                comando.Parameters.Add(new MySqlParameter("@produtos_idprodutos", item.produtos_idprodutos));
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            foreach (ProdutosModel item in produtosEntrada)
            {
                comando.CommandText =
                "update produtos set estoqueatual = estoqueatual + @quantidade,precocusto = @precocusto,margemlucro = @margemlucro,precovenda = @precovenda,"+
                "clientespessoas_idclientespessoas = @clientespessoas_idclientespessoas where idprodutos = @produtos_idprodutos;";
                comando.Parameters.Add(new MySqlParameter("@produtos_idprodutos", item.IdProdutos));
                comando.Parameters.Add(new MySqlParameter("@precocusto", item.PrecoCusto));
                comando.Parameters.Add(new MySqlParameter("@margemlucro", item.MargemLucro));
                comando.Parameters.Add(new MySqlParameter("@precovenda", item.PrecoVenda));
                comando.Parameters.Add(new MySqlParameter("@quantidade", item.EstoqueAtual));
                if (item.clientespessoas_idclientespessoas != 0) comando.Parameters.Add(new MySqlParameter("@clientespessoas_idclientespessoas", item.clientespessoas_idclientespessoas));
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }
    }
}
