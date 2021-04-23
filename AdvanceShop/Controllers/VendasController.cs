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
    public class VendasController
    {
        public DataTable ObterTodasVendas()
        {
            //Lista todas as vendas para o form vendas;
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from vendas inner join datahora on datahora.vendas_idvendas = vendas.idvendas left join clientespessoas on vendas.clientespessoas_idclientespessoas = clientespessoas.idclientespessoas where vendas.deletado = 0 order by datahora.datahoracadastro desc;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public int ObterUltimoIDVendaInserido()
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "SELECT idvendas from vendas ORDER BY idvendas DESC LIMIT 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            reader.Read();
            return reader.GetInt32(0);
        }
        public void Adicionar(VendasModel venda,List<FormasPagamentoModel> formasPagamento,List<ItensVendasModel> itensVenda,TransacoesCaixaModel transacaoCaixa, UsuariosModel usuarioLogado)
        {

            //Venda Pelo PDV
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
            "insert into vendas(valor,desconto,totalfinal,valorpago,troco,clientespessoas_idclientespessoas,caixas_idcaixas,deletado) " +
            "values(@valor,@desconto,@totalfinal,@valorpago,@troco,@clientespessoas_idclientespessoas,@caixas_idcaixas,0); " +
            "select last_insert_id() into @first_id ; " +
            "insert into datahora(datahoracadastro, usuariocadastro, vendas_idvendas) values(now(), @usuariocadastro, last_insert_id()); " +
            "insert into transacoescaixa(tipo, descricaotransacao,observacaotransacao,valor,status,caixas_idcaixas,vendas_idvendas,charge_id,payment_url,deletado) values(1,CONCAT('VENDA PDV Código ',@first_id),@observacaotransacao,@totalfinal,@status, @caixas_idcaixas,@first_id,@charge_id,@payment_url,0); " +
            "select last_insert_id() into @second_id ;" +
            "insert into datahora(datahoracadastro, usuariocadastro, transacoescaixa_idtransacoescaixa) values(now(), @usuariocadastro, last_insert_id()); " +
            "insert into transacoesestoque(tipo,tipodescricao,descricaotransacao,observacaotransacaoestoque,clientespessoas_idclientespessoas,vendas_idvendas,deletado) values (5,0,CONCAT('VENDA PDV Código ',@first_id),@observacaotransacao,@clientespessoas_idclientespessoas,@first_id,0); " +
            "select last_insert_id() into @id_transacaoestoque; " +
            "insert into datahora(datahoracadastro,usuariocadastro,transacoesestoque_idtransacoesestoque) values(now(),@usuariocadastro,last_insert_id()); ";

            comando.Parameters.Add(new MySqlParameter("@valor", venda.Valor));
            comando.Parameters.Add(new MySqlParameter("@desconto", venda.Desconto));
            comando.Parameters.Add(new MySqlParameter("@valorpago", venda.ValorPago));
            comando.Parameters.Add(new MySqlParameter("@totalfinal", venda.TotalFinal));
            comando.Parameters.Add(new MySqlParameter("@troco", venda.Troco));
            comando.Parameters.Add(new MySqlParameter("@observacaotransacao", transacaoCaixa.ObservacaoTransacao));
            comando.Parameters.Add(new MySqlParameter("@status", transacaoCaixa.Status));
            if (transacaoCaixa.charge_id != 0) comando.Parameters.Add(new MySqlParameter("@charge_id", transacaoCaixa.charge_id));
            comando.Parameters.Add(new MySqlParameter("@payment_url", transacaoCaixa.payment_url));
            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", venda.caixas_idcaixas));
            if(venda.clientespessoas_idclientespessoas != 0) comando.Parameters.Add(new MySqlParameter("@clientespessoas_idclientespessoas", venda.clientespessoas_idclientespessoas));
            comando.Parameters.Add(new MySqlParameter("@usuariocadastro", usuarioLogado.UsuarioAcesso));
            comando.Parameters.Add(new MySqlParameter("@usuarios_idusuarios", usuarioLogado.IdUsuarios));
            comando.ExecuteNonQuery();


            foreach (FormasPagamentoModel item in formasPagamento)//inserir na tabela formas de pagamento os tipos de pagamento da venda conforme veio na lista 
            {
                comando.CommandText =
                "insert into formaspagamento(descricao,valor,transacoescaixa_idtransacoescaixa) values(@descricao,@valorpagamento,@second_id);";
                comando.Parameters.Add(new MySqlParameter("@descricao", item.Descricao));
                comando.Parameters.Add(new MySqlParameter("@valorpagamento", item.Valor));
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            foreach (ItensVendasModel item in itensVenda)//inserir na tabela itensvendas os itens da venda conforme veio na lista
            {
                comando.CommandText =

                "insert into itensvendas(quantidade,valorunitario,subtotal,item,vendas_idvendas,produtos_idprodutos,transacoesestoque_idtransacoesestoque) " +
                "values(@quantidade,@valorunitario,@subtotal,@item,@first_id,@produtos_idprodutos,@id_transacaoestoque); " +
                //verifica se produto estar marcado pra controlar estoque, caso contrario não da baixa no estoque do produto
                "select @controlarestoqueproduto; " +
                "select controlarestoque from produtos where idprodutos = @produtos_idprodutos into @controlarestoqueproduto; " +
                "update produtos set estoqueatual = If(@controlarestoqueproduto = 1,estoqueatual - @quantidade,estoqueatual) where idprodutos = @produtos_idprodutos; ";
                comando.Parameters.Add(new MySqlParameter("@quantidade", item.Quantidade));
                comando.Parameters.Add(new MySqlParameter("@valorunitario", item.ValorUnitario));
                comando.Parameters.Add(new MySqlParameter("@subtotal", item.Subtotal));
                comando.Parameters.Add(new MySqlParameter("@item", item.Item));
                comando.Parameters.Add(new MySqlParameter("@produtos_idprodutos", item.produtos_idprodutos));
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            
        }
        public void Deletar(VendasModel venda)
        {
            List<ItensVendasModel> itensVenda = new List<ItensVendasModel>();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update vendas set deletado = 1 where idvendas = @idvendas;" +
                "update transacoescaixa set deletado = 1 where vendas_idvendas = @idvendas;" +
                "update transacoesestoque set deletado = 1 where vendas_idvendas = @idvendas;";
            comando.Parameters.Add(new MySqlParameter("@idvendas", venda.IdVendas));
            comando.ExecuteNonQuery();

            comando.CommandText =
                    "select quantidade,produtos_idprodutos from itensvendas where vendas_idvendas = @idvendas";
            comando.ExecuteNonQuery();
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            while (reader.Read())//Ler o reader do select a acima
            {
                itensVenda.Add(new ItensVendasModel()//adiciona a lista de itens os itens que foi retornado do select
                {
                    produtos_idprodutos = reader.GetInt32(1),
                    Quantidade = reader.GetInt32(0)
                });
            }
            reader.Close();//Fechar a leitura para a conexão fica livre para execulta o foreach logo abaixo..
            
            foreach (ItensVendasModel item in itensVenda)
            {
                //Apos a lista preenchida com os produtos da tabela itens da lista da venda que foi deletada e adicionado de volta a quantidade em estoque que tinha sido removida do produto
                comando.CommandText = "update produtos set estoqueatual = estoqueatual + @quantidade where idprodutos = @produtos_idprodutos;";
                comando.Parameters.Add(new MySqlParameter("@quantidade", item.Quantidade));
                comando.Parameters.Add(new MySqlParameter("@produtos_idprodutos", item.produtos_idprodutos));
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
        }
        //Cupom não fiscal
        public VendasModel ObterDadosDaVendaPorID(VendasModel Venda)
        {
            bool resultado;
            VendasModel venda = new VendasModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from vendas where idvendas = @idvendas;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idvendas", Venda.IdVendas));
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("idvendas", typeof(int));
            dt.Columns.Add("valor", typeof(decimal));
            dt.Columns.Add("desconto", typeof(decimal));
            dt.Columns.Add("totalfinal", typeof(decimal));
            dt.Columns.Add("valorpago", typeof(decimal));
            dt.Columns.Add("troco", typeof(decimal));
            dt.Columns.Add("clientespessoas_idclientespessoas", typeof(int));
            dt.Columns.Add("deletado", typeof(int));
            dt.Columns.Add("caixas_idcaixas", typeof(int));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            if (resultado)
            {
                try
                {
                    venda.IdVendas = Convert.ToInt32(dt.Rows[0]["idvendas"]);
                    venda.Valor = Convert.ToDecimal(dt.Rows[0]["valor"]);
                    venda.Desconto = Convert.ToDecimal(dt.Rows[0]["desconto"]);
                    venda.TotalFinal = Convert.ToDecimal(dt.Rows[0]["totalfinal"]);
                    venda.ValorPago = Convert.ToDecimal(dt.Rows[0]["valorpago"]);
                    venda.Troco = Convert.ToDecimal(dt.Rows[0]["troco"]);
                    venda.clientespessoas_idclientespessoas = Convert.ToInt32(dt.Rows[0]["clientespessoas_idclientespessoas"]);
                    venda.deletado = Convert.ToInt32(dt.Rows[0]["deletado"]);
                    venda.caixas_idcaixas = Convert.ToInt32(dt.Rows[0]["caixas_idcaixas"]);
                }
                catch (InvalidCastException)
                {

                }
                return venda;
            }
            else
            {
                return venda;
            }

        }

    }
}
