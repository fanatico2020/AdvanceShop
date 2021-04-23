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
    public class TransacoesCaixaController
    {
        public DataTable ObterTodosTransacoes(TransacoesCaixaModel transacaoCaixa)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from transacoescaixa inner join datahora on datahora.transacoescaixa_idtransacoescaixa = transacoescaixa.idtransacoescaixa where transacoescaixa.caixas_idcaixas = @caixas_idcaixas and transacoescaixa.deletado = 0 order by datahora.datahoracadastro desc;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", transacaoCaixa.caixas_idcaixas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public void Adicionar_SuplementoSangria(TransacoesCaixaModel transacaoCaixa, UsuariosModel usuarioLogado)
        {
            
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
            "insert into transacoescaixa(tipo,descricaotransacao,valor,observacaotransacao,status,caixas_idcaixas,deletado) values(@tipo,@descricaotransacao,@valor,@observacaotransacao,@status,@caixas_idcaixas,0); " +
            "select last_insert_id() into @first_id; " +
            "insert into datahora(datahoracadastro, usuariocadastro, transacoescaixa_idtransacoescaixa) values(now(), @usuariocadastro, last_insert_id()); " +
            "insert into formaspagamento(descricao,valor,transacoescaixa_idtransacoescaixa) values('DINHEIRO',@valor,@first_id);";

            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", transacaoCaixa.caixas_idcaixas));
            comando.Parameters.Add(new MySqlParameter("@tipo", transacaoCaixa.Tipo));
            comando.Parameters.Add(new MySqlParameter("@descricaotransacao", transacaoCaixa.DescricaoTransacao));
            comando.Parameters.Add(new MySqlParameter("@observacaotransacao", transacaoCaixa.ObservacaoTransacao));
            comando.Parameters.Add(new MySqlParameter("@valor", transacaoCaixa.Valor));
            comando.Parameters.Add(new MySqlParameter("@status", transacaoCaixa.Status));
            comando.Parameters.Add(new MySqlParameter("@usuariocadastro", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }

        public void Deletar(TransacoesCaixaModel transacaoCaixa)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update transacoescaixa set deletado = 1 where idtransacoescaixa = @idtransacoescaixa;";
            comando.Parameters.Add(new MySqlParameter("@idtransacoescaixa", transacaoCaixa.IdTransacoesCaixa));
            comando.ExecuteNonQuery();
        }
        public decimal ObterValorDescontoVenda(TransacoesCaixaModel transacaoCaixa)//Desconto para edição de formas de pagamento
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select desconto from vendas where idvendas = @vendas_idvendas;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@vendas_idvendas", transacaoCaixa.vendas_idvendas));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            reader.Read();
            return reader.GetDecimal(0);
        }
        public void EditarStatusGerenciaNet(TransacoesCaixaModel transacaoCaixa)
        {
            if(transacaoCaixa.charge_id != 0)
            {
                MySqlConnection conexao = ConexaoMySql.GetConexao();
                MySqlCommand comando = ConexaoMySql.GetComando(conexao);
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText =
                    "update transacoescaixa set status = @status where charge_id = @charge_id;";
                comando.Parameters.Add(new MySqlParameter("@status", transacaoCaixa.Status));
                comando.Parameters.Add(new MySqlParameter("@charge_id", transacaoCaixa.charge_id));
                comando.ExecuteNonQuery();
            }
            
        }

    }
}
