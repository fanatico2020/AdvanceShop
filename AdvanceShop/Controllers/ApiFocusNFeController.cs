using AdvanceShop.Data;
using AdvanceShop.JsonModels.FocusNFe.NFC_e;
using AdvanceShop.Models;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Controllers
{
    public class ApiFocusNFeController
    {
        public ApiFocusNfeModel ObterConfiguracoesApiFocusNfe()
        {
            bool resultado;
            ApiFocusNfeModel config = new ApiFocusNfeModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from apifocusnfe where idapifocusnfe = 1;";
            comando.CommandType = CommandType.Text;
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("idapifocusnfe", typeof(int));
            dt.Columns.Add("usarapi", typeof(int));
            dt.Columns.Add("tokenhomologacao", typeof(string));
            dt.Columns.Add("tokenproducao", typeof(string));
            dt.Columns.Add("ambiente", typeof(string));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            if (resultado)
            {
                config.idapifocusnfe = Convert.ToInt32(dt.Rows[0]["idapifocusnfe"]);
                config.usarapi = Convert.ToInt32(dt.Rows[0]["usarapi"]);
                config.tokenhomologacao = Convert.ToString(dt.Rows[0]["tokenhomologacao"]);
                config.tokenproducao = Convert.ToString(dt.Rows[0]["tokenproducao"]);
                config.ambiente = Convert.ToString(dt.Rows[0]["ambiente"]);
                return config;
            }
            else
            {
                return config;
            }

        }
        public void SalvarConfiguracao(ApiFocusNfeModel config)
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update apifocusnfe set usarapi = @usarapi,tokenhomologacao = @tokenhomologacao,tokenproducao = @tokenproducao,ambiente = @ambiente where idapifocusnfe = 1";
            comando.Parameters.Add(new MySqlParameter("@usarapi", config.usarapi));
            comando.Parameters.Add(new MySqlParameter("@tokenhomologacao", config.tokenhomologacao));
            comando.Parameters.Add(new MySqlParameter("@tokenproducao", config.tokenproducao));
            comando.Parameters.Add(new MySqlParameter("@ambiente", config.ambiente));
            comando.ExecuteNonQuery();
        }
        public async void EnviandoNFC_e(ApiFocusNfeModel config,FocusNFe focusNFe)
        {
            string ambienteFocus = "";
            string focusToken = "";
            if (config.ambiente == "homologacao")
            {
                ambienteFocus = "homologacao";
                focusToken = config.tokenhomologacao;
            }
            else
            {
                ambienteFocus = "producao";
                focusToken = config.tokenproducao;
            }
            //dados
            string json = JsonConvert.SerializeObject(focusNFe, Formatting.Indented);


            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"https://{ambienteFocus}.focusnfe.com.br/v2/nfce"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(focusToken));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");

                    request.Content = new ByteArrayContent(File.ReadAllBytes(json));

                    var response = await httpClient.SendAsync(request);
                }
            }
        }
    }
}
