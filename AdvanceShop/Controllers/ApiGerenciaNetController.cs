using AdvanceShop.Data;
using AdvanceShop.Models;
using Gerencianet.SDK;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Controllers
{
    public class ApiGerenciaNetController
    {

        public ApiGerenciaNetModel ObterConfiguracoesApiGerenciaNet()
        {
            bool resultado;
            ApiGerenciaNetModel config = new ApiGerenciaNetModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from apigerencianet where idapigerencianet = 1;";
            comando.CommandType = CommandType.Text;
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("idapigerencianet", typeof(int));
            dt.Columns.Add("usarapi", typeof(int));
            dt.Columns.Add("clientidhomologacao", typeof(string));
            dt.Columns.Add("clientsecrethomologacao", typeof(string));
            dt.Columns.Add("clientidproducao", typeof(string));
            dt.Columns.Add("clientsecretproducao", typeof(string));
            dt.Columns.Add("ambiente", typeof(string));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            try
            {
                if (resultado)
                {

                    config.idapigerencianet = Convert.ToInt32(dt.Rows[0]["idapigerencianet"]);
                    config.usarapi = Convert.ToInt32(dt.Rows[0]["usarapi"]);
                    config.clientidhomologacao = Convert.ToString(dt.Rows[0]["clientidhomologacao"]);
                    config.clientsecrethomologacao = Convert.ToString(dt.Rows[0]["clientsecrethomologacao"]);
                    config.clientidproducao = Convert.ToString(dt.Rows[0]["clientidproducao"]);
                    config.clientsecretproducao = Convert.ToString(dt.Rows[0]["clientsecretproducao"]);
                    config.ambiente = Convert.ToString(dt.Rows[0]["ambiente"]);
                    return config;
                }
                else
                {
                    return config;
                }
            }
            catch (InvalidCastException)
            {
                return config;
            }


        }
        public void SalvarConfiguracao(ApiGerenciaNetModel config)
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update apigerencianet set usarapi = @usarapi,clientidhomologacao = @clientidhomologacao,clientsecrethomologacao = @clientsecrethomologacao,clientidproducao = @clientidproducao,clientsecretproducao = @clientsecretproducao,ambiente = @ambiente where idapigerencianet = 1";
            comando.Parameters.Add(new MySqlParameter("@usarapi", config.usarapi));
            comando.Parameters.Add(new MySqlParameter("@clientidhomologacao", config.clientidhomologacao));
            comando.Parameters.Add(new MySqlParameter("@clientsecrethomologacao", config.clientsecrethomologacao));
            comando.Parameters.Add(new MySqlParameter("@clientidproducao", config.clientidproducao));
            comando.Parameters.Add(new MySqlParameter("@clientsecretproducao", config.clientsecretproducao));
            comando.Parameters.Add(new MySqlParameter("@ambiente", config.ambiente));
            comando.ExecuteNonQuery();
        }
        public void CriarTransacao(ApiGerenciaNetModel config,string CustomID)
        {
            bool ambienteGerencianet = false;
            string client_id = "";
            string client_secret = "";
            if (config.ambiente == "homologacao")
            {
                ambienteGerencianet = true;
                client_id = config.clientidhomologacao;
                client_secret = config.clientsecrethomologacao;
            }
            else if(config.ambiente == "producao")
            {
                ambienteGerencianet = false;
                client_id = config.clientidproducao;
                client_secret = config.clientsecretproducao;
            }
            dynamic endpoints = new Endpoints(client_id, client_secret, ambienteGerencianet);

            var body = new
            {
                items = new[] {
                new {
                    name = "Product 1",// Nome do item, produto ou serviço.Mínimo de 1 caractere e máximo de 255 caracteres(String).
                    value = 1000,// Valor, em centavos. Ex: R$ 10,00 = 1000. Integer.
                    amount = 1
                }
            },
                        
                metadata = new
                {
                    custom_id = CustomID
                }
            };

            var responseTransacao = endpoints.CreateCharge(null, body);

            //dados do response transacao criada
            string jsonResponseTransacao = JsonConvert.SerializeObject(responseTransacao);
            //Remover " " do inicio e do final
            //int tamanhoString = jsonResponseTransacao.Length;
            //jsonResponseTransacao.Remove(0, 1);
            //jsonResponseTransacao.Remove(tamanhoString - 1, 1);
            //string json = 
            JsonModels.GerenciaNet.GerenciaNet deserializeDataTransacao = JsonConvert.DeserializeObject<JsonModels.GerenciaNet.GerenciaNet>(jsonResponseTransacao);

            //Link Pagamento

            var param = new
            {
                id = deserializeDataTransacao.data.charge_id
            };

            var bodyLinkPagamento = new
            {
                billet_discount = 1,
                card_discount = 1,
                message = "Isso e um teste de link de pagamento",
                expire_at = DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"),
                request_delivery_address = false,
                payment_method = "all"
            };

            var responseLinkPagemnto = endpoints.ChargeLink(param, bodyLinkPagamento);

            int a = 1;

        }
    }
}
