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
    public class DataHoraController
    {
        //Cupom não fiscal
        public DataHoraModel ObterDadosDataHoraPorIDVenda(DataHoraModel DataHora)
        {
            bool resultado;
            DataHoraModel dataHora = new DataHoraModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from datahora where vendas_idvendas = @vendas_idvendas;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@vendas_idvendas", DataHora.vendas_idvendas));
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("iddatahora", typeof(int));
            dt.Columns.Add("datahoracadastro", typeof(DateTime));
            dt.Columns.Add("datahoraedicao", typeof(DateTime));
            dt.Columns.Add("usuariocadastro", typeof(string));
            dt.Columns.Add("usuarioedicao", typeof(string));
            dt.Columns.Add("usuarios_idusuarios", typeof(int));
            dt.Columns.Add("clientespessoas_idclientespessoas", typeof(int));
            dt.Columns.Add("caixas_idcaixas", typeof(int));
            dt.Columns.Add("produtos_idprodutos", typeof(int));
            dt.Columns.Add("transacoescaixa_idtransacoescaixa", typeof(int));
            dt.Columns.Add("transacoesestoque_idtransacoesestoque", typeof(int));
            dt.Columns.Add("contasapagar_idcontasapagar", typeof(int));
            dt.Columns.Add("vendas_idvendas", typeof(int));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            if (resultado)
            {
                try
                {
                    dataHora.iddatahora = Convert.ToInt32(dt.Rows[0]["iddatahora"]);
                    dataHora.datahoracadastro = Convert.ToDateTime(dt.Rows[0]["datahoracadastro"]);
                    dataHora.datahoraedicao = Convert.ToDateTime(dt.Rows[0]["datahoraedicao"]);
                    dataHora.usuariocadastro = dt.Rows[0]["usuariocadastro"].ToString();
                    dataHora.usuarioedicao = dt.Rows[0]["usuarioedicao"].ToString();
                    dataHora.usuarios_idusuarios = Convert.ToInt32(dt.Rows[0]["usuarios_idusuarios"]);
                    dataHora.clientespessoas_idclientespessoas = Convert.ToInt32(dt.Rows[0]["clientespessoas_idclientespessoas"]);
                    dataHora.caixas_idcaixas = Convert.ToInt32(dt.Rows[0]["caixas_idcaixas"]);
                    dataHora.produtos_idprodutos = Convert.ToInt32(dt.Rows[0]["produtos_idprodutos"]);
                    dataHora.transacoescaixa_idtransacoescaixa = Convert.ToInt32(dt.Rows[0]["transacoescaixa_idtransacoescaixa"]);
                    dataHora.transacoesestoque_idtransacoesestoque = Convert.ToInt32(dt.Rows[0]["transacoesestoque_idtransacoesestoque"]);
                    dataHora.contasapagar_idcontasapagar = Convert.ToInt32(dt.Rows[0]["contasapagar_idcontasapagar"]);
                    dataHora.vendas_idvendas = Convert.ToInt32(dt.Rows[0]["vendas_idvendas"]);
                }
                catch (InvalidCastException)
                {

                }
                

                return dataHora;
            }
            else
            {
                return dataHora;
            }

        }
        public DataHoraModel ObterDadosDataHoraPorIDCaixa(CaixasModel Caixa)
        {
            bool resultado;
            DataHoraModel dataHora = new DataHoraModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from datahora where caixas_idcaixas = @caixas_idcaixas;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@caixas_idcaixas", Caixa.IdCaixas));
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("iddatahora", typeof(int));
            dt.Columns.Add("datahoracadastro", typeof(DateTime));
            dt.Columns.Add("datahoraedicao", typeof(DateTime));
            dt.Columns.Add("usuariocadastro", typeof(string));
            dt.Columns.Add("usuarioedicao", typeof(string));
            dt.Columns.Add("usuarios_idusuarios", typeof(int));
            dt.Columns.Add("clientespessoas_idclientespessoas", typeof(int));
            dt.Columns.Add("caixas_idcaixas", typeof(int));
            dt.Columns.Add("produtos_idprodutos", typeof(int));
            dt.Columns.Add("transacoescaixa_idtransacoescaixa", typeof(int));
            dt.Columns.Add("transacoesestoque_idtransacoesestoque", typeof(int));
            dt.Columns.Add("contasapagar_idcontasapagar", typeof(int));
            dt.Columns.Add("vendas_idvendas", typeof(int));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            if (resultado)
            {
                try
                {
                    dataHora.iddatahora = Convert.ToInt32(dt.Rows[0]["iddatahora"]);
                    dataHora.datahoracadastro = Convert.ToDateTime(dt.Rows[0]["datahoracadastro"]);
                    dataHora.datahoraedicao = Convert.ToDateTime(dt.Rows[0]["datahoraedicao"]);
                    dataHora.usuariocadastro = dt.Rows[0]["usuariocadastro"].ToString();
                    dataHora.usuarioedicao = dt.Rows[0]["usuarioedicao"].ToString();
                    dataHora.usuarios_idusuarios = Convert.ToInt32(dt.Rows[0]["usuarios_idusuarios"]);
                    dataHora.clientespessoas_idclientespessoas = Convert.ToInt32(dt.Rows[0]["clientespessoas_idclientespessoas"]);
                    dataHora.caixas_idcaixas = Convert.ToInt32(dt.Rows[0]["caixas_idcaixas"]);
                    dataHora.produtos_idprodutos = Convert.ToInt32(dt.Rows[0]["produtos_idprodutos"]);
                    dataHora.transacoescaixa_idtransacoescaixa = Convert.ToInt32(dt.Rows[0]["transacoescaixa_idtransacoescaixa"]);
                    dataHora.transacoesestoque_idtransacoesestoque = Convert.ToInt32(dt.Rows[0]["transacoesestoque_idtransacoesestoque"]);
                    dataHora.contasapagar_idcontasapagar = Convert.ToInt32(dt.Rows[0]["contasapagar_idcontasapagar"]);
                    dataHora.vendas_idvendas = Convert.ToInt32(dt.Rows[0]["vendas_idvendas"]);
                }
                catch (InvalidCastException)
                {

                }


                return dataHora;
            }
            else
            {
                return dataHora;
            }

        }
    }
}
