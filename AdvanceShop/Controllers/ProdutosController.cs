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
    public class ProdutosController
    {
        public DataTable ObterTodosProdutos()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from produtos inner join datahora on datahora.produtos_idprodutos = produtos.idprodutos inner join categoriasprodutos on produtos.categoriasprodutos_idcategoriasprodutos = categoriasprodutos.idcategoriasprodutos inner join clientespessoas on  produtos.clientespessoas_idclientespessoas = clientespessoas.idclientespessoas inner join marcasprodutos on produtos.marcasprodutos_idmarcasprodutos = marcasprodutos.idmarcasprodutos inner join unidadesmedidasprodutos on produtos.unidadesmedidasprodutos_idunidadesmedidasprodutos = unidadesmedidasprodutos.idunidadesmedidasprodutos where produtos.deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public DataTable ObterTodosProdutos_PDV()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select produtos.idprodutos,produtos.descricaoproduto,produtos.codigobarra,produtos.precocusto,produtos.margemlucro,produtos.precovenda,produtos.estoqueatual,categoriasprodutos.descricaocategoria,marcasprodutos.descricaomarca,unidadesmedidasprodutos.descricaounidademedida from produtos inner join categoriasprodutos on produtos.categoriasprodutos_idcategoriasprodutos = categoriasprodutos.idcategoriasprodutos inner join clientespessoas on  produtos.clientespessoas_idclientespessoas = clientespessoas.idclientespessoas inner join marcasprodutos on produtos.marcasprodutos_idmarcasprodutos = marcasprodutos.idmarcasprodutos inner join unidadesmedidasprodutos on produtos.unidadesmedidasprodutos_idunidadesmedidasprodutos = unidadesmedidasprodutos.idunidadesmedidasprodutos where produtos.statusproduto = 1 and produtos.deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public DataTable ObterTodosProdutosQueControlarEstoque()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select produtos.idprodutos,produtos.descricaoproduto,produtos.codigobarra,produtos.precocusto,produtos.margemlucro,produtos.precovenda,produtos.estoqueatual,categoriasprodutos.descricaocategoria,marcasprodutos.descricaomarca,unidadesmedidasprodutos.descricaounidademedida from produtos inner join categoriasprodutos on produtos.categoriasprodutos_idcategoriasprodutos = categoriasprodutos.idcategoriasprodutos inner join clientespessoas on  produtos.clientespessoas_idclientespessoas = clientespessoas.idclientespessoas inner join marcasprodutos on produtos.marcasprodutos_idmarcasprodutos = marcasprodutos.idmarcasprodutos inner join unidadesmedidasprodutos on produtos.unidadesmedidasprodutos_idunidadesmedidasprodutos = unidadesmedidasprodutos.idunidadesmedidasprodutos where produtos.statusproduto = 1 and produtos.controlarestoque = 1 and produtos.deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void Adicionar(ProdutosModel produto, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into produtos(descricaoproduto,codigobarra,precocusto,margemlucro,precovenda,calcularprecovendaauto,estoqueatual,estoqueminimo,estoquemaximo,controlarestoque,statusproduto,categoriasprodutos_idcategoriasprodutos,clientespessoas_idclientespessoas,marcasprodutos_idmarcasprodutos,unidadesmedidasprodutos_idunidadesmedidasprodutos,deletado) " +
                "values(@descricaoproduto,@codigobarra,@precocusto,@margemlucro,@precovenda,@calcularprecovendaauto,@estoqueatual,@estoqueminimo,@estoquemaximo,@controlarestoque,@statusproduto,@categoriasprodutos_idcategoriasprodutos,@clientespessoas_idclientespessoas,@marcasprodutos_idmarcasprodutos,@unidadesmedidasprodutos_idunidadesmedidasprodutos,0); " +
                "insert into datahora(datahoracadastro,usuariocadastro,produtos_idprodutos) values(now(),@usuariocadastro,last_insert_id());";
            comando.Parameters.Add(new MySqlParameter("@descricaoproduto", produto.DescricaoProduto));
            comando.Parameters.Add(new MySqlParameter("@codigobarra", produto.CodigoBarra));
            comando.Parameters.Add(new MySqlParameter("@precocusto", produto.PrecoCusto));
            comando.Parameters.Add(new MySqlParameter("@margemlucro", produto.MargemLucro));
            comando.Parameters.Add(new MySqlParameter("@precovenda", produto.PrecoVenda));
            comando.Parameters.Add(new MySqlParameter("@calcularprecovendaauto", produto.CalcularAutomatico));
            comando.Parameters.Add(new MySqlParameter("@estoqueatual", produto.EstoqueAtual));
            comando.Parameters.Add(new MySqlParameter("@estoqueminimo", produto.EstoqueMinimo));
            comando.Parameters.Add(new MySqlParameter("@estoquemaximo", produto.EstoqueMaximo));
            comando.Parameters.Add(new MySqlParameter("@controlarestoque", produto.ControlarEstoque));
            comando.Parameters.Add(new MySqlParameter("@statusproduto", produto.StatusProduto));
            comando.Parameters.Add(new MySqlParameter("@categoriasprodutos_idcategoriasprodutos", produto.categoriasprodutos_idcategoriasprodutos));
            comando.Parameters.Add(new MySqlParameter("@clientespessoas_idclientespessoas", produto.clientespessoas_idclientespessoas));
            comando.Parameters.Add(new MySqlParameter("@marcasprodutos_idmarcasprodutos", produto.marcasprodutos_idmarcasprodutos));
            comando.Parameters.Add(new MySqlParameter("@unidadesmedidasprodutos_idunidadesmedidasprodutos", produto.unidadesmedidasprodutos_idunidadesmedidasprodutos));
            comando.Parameters.Add(new MySqlParameter("@usuariocadastro", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }
        
        public void Editar(ProdutosModel produto, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update produtos set descricaoproduto = @descricaoproduto,codigobarra = @codigobarra,precocusto = @precocusto,margemlucro = @margemlucro,precovenda = @precovenda,calcularprecovendaauto = @calcularprecovendaauto,estoqueatual = @estoqueatual,estoqueminimo = @estoqueminimo,estoquemaximo = @estoquemaximo," +
                "controlarestoque = @controlarestoque,statusproduto = @statusproduto,categoriasprodutos_idcategoriasprodutos = @categoriasprodutos_idcategoriasprodutos,clientespessoas_idclientespessoas = @clientespessoas_idclientespessoas,marcasprodutos_idmarcasprodutos = @marcasprodutos_idmarcasprodutos,unidadesmedidasprodutos_idunidadesmedidasprodutos = @unidadesmedidasprodutos_idunidadesmedidasprodutos where idprodutos = @idprodutos; " +
                "update datahora set datahoraedicao = now(),usuarioedicao = @usuarioedicao where produtos_idprodutos = @idprodutos;";
            comando.Parameters.Add(new MySqlParameter("@idprodutos", produto.IdProdutos));
            comando.Parameters.Add(new MySqlParameter("@descricaoproduto", produto.DescricaoProduto));
            comando.Parameters.Add(new MySqlParameter("@codigobarra", produto.CodigoBarra));
            comando.Parameters.Add(new MySqlParameter("@precocusto", produto.PrecoCusto));
            comando.Parameters.Add(new MySqlParameter("@margemlucro", produto.MargemLucro));
            comando.Parameters.Add(new MySqlParameter("@precovenda", produto.PrecoVenda));
            comando.Parameters.Add(new MySqlParameter("@calcularprecovendaauto", produto.CalcularAutomatico));
            comando.Parameters.Add(new MySqlParameter("@estoqueatual", produto.EstoqueAtual));
            comando.Parameters.Add(new MySqlParameter("@estoqueminimo", produto.EstoqueMinimo));
            comando.Parameters.Add(new MySqlParameter("@estoquemaximo", produto.EstoqueMaximo));
            comando.Parameters.Add(new MySqlParameter("@controlarestoque", produto.ControlarEstoque));
            comando.Parameters.Add(new MySqlParameter("@statusproduto", produto.StatusProduto));
            comando.Parameters.Add(new MySqlParameter("@categoriasprodutos_idcategoriasprodutos", produto.categoriasprodutos_idcategoriasprodutos));
            comando.Parameters.Add(new MySqlParameter("@clientespessoas_idclientespessoas", produto.clientespessoas_idclientespessoas));
            comando.Parameters.Add(new MySqlParameter("@marcasprodutos_idmarcasprodutos", produto.marcasprodutos_idmarcasprodutos));
            comando.Parameters.Add(new MySqlParameter("@unidadesmedidasprodutos_idunidadesmedidasprodutos", produto.unidadesmedidasprodutos_idunidadesmedidasprodutos));
            comando.Parameters.Add(new MySqlParameter("@usuarioedicao", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }
        
        public void Deletar(ProdutosModel produto)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update produtos set deletado = 1 where idprodutos = @idprodutos;";
            comando.Parameters.Add(new MySqlParameter("@idprodutos", produto.IdProdutos));
            comando.ExecuteNonQuery();
        }

    }
}
