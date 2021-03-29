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
            "insert into transacoesestoque(tipo,tipodescricao,descricaotransacao,clientespessoas_idclientespessoas,deletado) values (1,1,'Entrada de mercado no estoque',@clientespessoas_idclientespessoas,0); " +
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
        public void SaidaEstoque(TransacoesEstoqueModel transacaoEstoque, List<ProdutosModel> produtosEntrada, List<ItensVendasModel> itensVenda, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
            "insert into transacoesestoque(tipo,tipodescricao,,descricaotransacao,observacaotransacaoestoque,clientespessoas_idclientespessoas,deletado) values (@tipo,0,@descricaotransacao,@observacaotransacaoestoque,@clientespessoas_idclientespessoas,0); " +
            "select last_insert_id() into @id_transacaoestoque; " +
            "insert into datahora(datahoracadastro,usuariocadastro,transacoesestoque_idtransacoesestoque) values(now(),@usuariocadastro,last_insert_id()); ";
            comando.Parameters.Add(new MySqlParameter("@clientespessoas_idclientespessoas", transacaoEstoque.clientespessoas_idclientespessoas));
            comando.Parameters.Add(new MySqlParameter("@tipo", transacaoEstoque.Tipo));
            comando.Parameters.Add(new MySqlParameter("@descricaotransacao", transacaoEstoque.DescricaoTransacao));
            comando.Parameters.Add(new MySqlParameter("@observacaotransacaoestoque", transacaoEstoque.Observacao));
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
                "update produtos set estoqueatual = estoqueatual - @quantidade,precocusto = @precocusto,margemlucro = @margemlucro,precovenda = @precovenda," +
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
        public void Deletar(TransacoesEstoqueModel transacaoEstoque)
        {
            List<ItensVendasModel> itensEstoque = new List<ItensVendasModel>();
            string sinalOperacao = "";
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update transacoesestoque set deletado = 1 where idtransacoesestoque = @idtransacoesestoque;";
            comando.Parameters.Add(new MySqlParameter("@idtransacoesestoque", transacaoEstoque.IdTransacoesEstoque));
            comando.ExecuteNonQuery();

            comando.CommandText =
                    "select quantidade,produtos_idprodutos from itensvendas where transacoesestoque_idtransacoesestoque = @idtransacoesestoque";
            
            comando.ExecuteNonQuery();
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            while (reader.Read())//Ler o reader do select a acima
            {
                itensEstoque.Add(new ItensVendasModel()//adiciona a lista de itens os itens que foi retornado do select
                {
                    produtos_idprodutos = reader.GetInt32(1),
                    Quantidade = reader.GetInt32(0)
                });
                
            }
            reader.Close();//Fechar a leitura para a conexão fica livre para execulta o foreach logo abaixo..
            
            foreach (ItensVendasModel item in itensEstoque)
            {
                if (transacaoEstoque.TipoDescricao == 0)//0 saida
                {
                    sinalOperacao = "+";//investi
                }
                else if(transacaoEstoque.TipoDescricao == 1)//1 entrada
                {
                    sinalOperacao = "-";
                }
                //Apos a lista preenchida com os produtos da tabela itens da lista da venda que foi deletada e adicionado de volta a quantidade em estoque que tinha sido removida do produto
                comando.CommandText = $"update produtos set estoqueatual = estoqueatual {sinalOperacao} @quantidade where idprodutos = @produtos_idprodutos;";
                comando.Parameters.Add(new MySqlParameter("@quantidade", item.Quantidade));
                comando.Parameters.Add(new MySqlParameter("@produtos_idprodutos", item.produtos_idprodutos));
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }
    }
}
