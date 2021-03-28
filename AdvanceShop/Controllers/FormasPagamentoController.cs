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
    public class FormasPagamentoController
    {

        public DataTable ObterFormasPagamentos(FormasPagamentoModel formaPagamento)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from formaspagamento where transacoescaixa_idtransacoescaixa = @transacoescaixa_idtransacoescaixa;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@transacoescaixa_idtransacoescaixa", formaPagamento.transacoescaixa_idtransacoescaixa));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public DataTable ObterFormasPagamentosPorIDVenda(VendasModel venda)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from formaspagamento left join transacoescaixa on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa where vendas_idvendas = @vendas_idvendas;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@vendas_idvendas", venda.IdVendas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        //somar formas de pagamento

        //Entradas
        public decimal SomarTotalDinheiroAberturaCaixa(TransacoesCaixaModel transacaoCaixa)
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa " +
                "on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa " +
                "where transacoescaixa.tipo = 1 and transacoescaixa.descricaotransacao = 'Abertura Caixa' " +
                "and transacoescaixa.caixas_idcaixas = @caixas_idcaixas and formaspagamento.descricao = 'DINHEIRO' and transacoescaixa.deletado = 0;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", transacaoCaixa.caixas_idcaixas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            reader.Read();
            return reader.GetDecimal(0);
        }
        public decimal SomarTotalDinheiroSuplementoCaixa(TransacoesCaixaModel transacaoCaixa)
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa " +
                "on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa " +
                "where transacoescaixa.tipo = 1 and transacoescaixa.descricaotransacao = 'Suplemento, Dinheiro adicionado ao caixa' " +
                "and transacoescaixa.caixas_idcaixas = @caixas_idcaixas and formaspagamento.descricao = 'DINHEIRO' and transacoescaixa.deletado = 0;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", transacaoCaixa.caixas_idcaixas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            reader.Read();
            return reader.GetDecimal(0);
        }
        public decimal SomarTotalDinheiroCaixa(TransacoesCaixaModel transacaoCaixa)
        {
            
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa "+
                "on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa "+
                "where transacoescaixa.tipo = 1 and transacoescaixa.descricaotransacao != 'Suplemento, Dinheiro adicionado ao caixa' and " +
                "transacoescaixa.descricaotransacao != 'Abertura Caixa' and transacoescaixa.caixas_idcaixas = @caixas_idcaixas and formaspagamento.descricao = 'DINHEIRO' and transacoescaixa.deletado = 0;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", transacaoCaixa.caixas_idcaixas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            reader.Read();
            return reader.GetDecimal(0);
        }
        public decimal SomarTotalCartaoCreditoCaixa(TransacoesCaixaModel transacaoCaixa)
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa " +
                "on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa " +
                "where transacoescaixa.tipo = 1 and transacoescaixa.caixas_idcaixas = @caixas_idcaixas and formaspagamento.descricao = 'CARTÃO CRÉDITO' and transacoescaixa.deletado = 0;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", transacaoCaixa.caixas_idcaixas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            reader.Read();
            return reader.GetDecimal(0);
        }
        public decimal SomarTotalCartaoDebitoCaixa(TransacoesCaixaModel transacaoCaixa)
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa " +
                "on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa " +
                "where transacoescaixa.tipo = 1 and transacoescaixa.caixas_idcaixas = @caixas_idcaixas and formaspagamento.descricao = 'CARTÃO DÉBITO' and transacoescaixa.deletado = 0;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", transacaoCaixa.caixas_idcaixas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            reader.Read();
            return reader.GetDecimal(0);
        }
        //Saidas
        public decimal SomarTotalDinheiroSangriaCaixa(TransacoesCaixaModel transacaoCaixa)
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select ifnull(sum(formaspagamento.valor),0) from formaspagamento left join transacoescaixa " +
                "on formaspagamento.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa " +
                "where transacoescaixa.tipo = 0 and transacoescaixa.descricaotransacao = 'Sangria, Dinheiro retirado do caixa' " +
                "and transacoescaixa.caixas_idcaixas = @caixas_idcaixas and formaspagamento.descricao = 'DINHEIRO' and transacoescaixa.deletado = 0;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", transacaoCaixa.caixas_idcaixas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            reader.Read();
            return reader.GetDecimal(0);
        }
    }
}
