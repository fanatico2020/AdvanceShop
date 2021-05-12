using AdvanceShop.Data;
using AdvanceShop.JsonModels.FocusNFe.NFC_e;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
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
            dt.Columns.Add("indicadoriedestinatario", typeof(string));
            dt.Columns.Add("clientespessoas_idclientespessoas", typeof(int));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            try
            {
                if (resultado)
                {

                    config.idapifocusnfe = Convert.ToInt32(dt.Rows[0]["idapifocusnfe"]);
                    config.usarapi = Convert.ToInt32(dt.Rows[0]["usarapi"]);
                    config.tokenhomologacao = Convert.ToString(dt.Rows[0]["tokenhomologacao"]);
                    config.tokenproducao = Convert.ToString(dt.Rows[0]["tokenproducao"]);
                    config.ambiente = Convert.ToString(dt.Rows[0]["ambiente"]);
                    config.indicadoriedestinatario = Convert.ToString(dt.Rows[0]["indicadoriedestinatario"]);
                    config.clientespessoas_idclientespessoas = Convert.ToInt32(dt.Rows[0]["clientespessoas_idclientespessoas"]);
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
        public ClientesPessoasModel ObterEmpresaEmitenteApiFocusNfe(ApiFocusNfeModel config)
        {
            bool resultado;
            ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from clientespessoas where idclientespessoas = @idclientespessoas;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idclientespessoas", config.clientespessoas_idclientespessoas));
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("idclientespessoas", typeof(int));
            dt.Columns.Add("nome", typeof(string));
            dt.Columns.Add("datanascimento", typeof(DateTime));
            dt.Columns.Add("sexo", typeof(string));
            dt.Columns.Add("contato1", typeof(string));
            dt.Columns.Add("contato2", typeof(string));
            dt.Columns.Add("rg_ie", typeof(string));
            dt.Columns.Add("cpf_cnpj", typeof(string));
            dt.Columns.Add("email", typeof(string));
            dt.Columns.Add("observacao", typeof(string));
            dt.Columns.Add("cep", typeof(string));
            dt.Columns.Add("endereco", typeof(string));
            dt.Columns.Add("numero", typeof(string));
            dt.Columns.Add("bairro", typeof(string));
            dt.Columns.Add("cidade", typeof(string));
            dt.Columns.Add("uf", typeof(string));
            dt.Columns.Add("status", typeof(int));
            dt.Columns.Add("tipopessoa", typeof(int));
            dt.Columns.Add("deletado", typeof(int));

            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            if (resultado)
            {
                clientePessoa.IdClientesPessoas = Convert.ToInt32(dt.Rows[0]["idclientespessoas"]);
                clientePessoa.NomeClientePessoa = dt.Rows[0]["nome"].ToString();
                clientePessoa.DataNascimento = Convert.ToDateTime(dt.Rows[0]["datanascimento"]);
                clientePessoa.Sexo = dt.Rows[0]["sexo"].ToString();
                clientePessoa.Contato1 = dt.Rows[0]["contato1"].ToString();
                clientePessoa.Contato2 = dt.Rows[0]["contato2"].ToString();
                clientePessoa.RGIE = dt.Rows[0]["rg_ie"].ToString();
                clientePessoa.CPFCNPJ = dt.Rows[0]["cpf_cnpj"].ToString();
                clientePessoa.Email = dt.Rows[0]["email"].ToString();
                clientePessoa.Observacao = dt.Rows[0]["observacao"].ToString();
                clientePessoa.CEP = dt.Rows[0]["cep"].ToString();
                clientePessoa.Endereco = dt.Rows[0]["endereco"].ToString();
                clientePessoa.NumeroCasa = dt.Rows[0]["numero"].ToString();
                clientePessoa.Bairro = dt.Rows[0]["bairro"].ToString();
                clientePessoa.Cidade = dt.Rows[0]["cidade"].ToString();
                clientePessoa.UF = dt.Rows[0]["uf"].ToString();
                clientePessoa.StatusClientePessoa = Convert.ToInt32(dt.Rows[0]["status"]);
                clientePessoa.TipoPessoa = Convert.ToInt32(dt.Rows[0]["tipopessoa"]);
                clientePessoa.Deletado = Convert.ToInt32(dt.Rows[0]["deletado"]);

                return clientePessoa;
            }
            else
            {
                return clientePessoa;
            }


        }
        public void SalvarConfiguracao(ApiFocusNfeModel config)
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update apifocusnfe set usarapi = @usarapi,tokenhomologacao = @tokenhomologacao,tokenproducao = @tokenproducao,ambiente = @ambiente,indicadoriedestinatario = @indicadoriedestinatario,clientespessoas_idclientespessoas = @clientespessoas_idclientespessoas where idapifocusnfe = 1";
            comando.Parameters.Add(new MySqlParameter("@usarapi", config.usarapi));
            comando.Parameters.Add(new MySqlParameter("@tokenhomologacao", config.tokenhomologacao));
            comando.Parameters.Add(new MySqlParameter("@tokenproducao", config.tokenproducao));
            comando.Parameters.Add(new MySqlParameter("@ambiente", config.ambiente));
            comando.Parameters.Add(new MySqlParameter("@indicadoriedestinatario", config.indicadoriedestinatario));
            comando.Parameters.Add(new MySqlParameter("@clientespessoas_idclientespessoas", config.clientespessoas_idclientespessoas));
            comando.ExecuteNonQuery();
        }
        public async void EnviandoNFC_e(ApiFocusNfeModel config,FocusNFe focusNFe,string REFERENCIA)
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
                httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), $"https://{ambienteFocus}.focusnfe.com.br/v2/nfce?ref={REFERENCIA}"))
                {
                    var base64authorization = Convert.ToBase64String(Encoding.ASCII.GetBytes(focusToken));
                    request.Headers.TryAddWithoutValidation("Authorization", $"Basic {base64authorization}");
                    request.Content = new StringContent(json,Encoding.UTF8, "application/json");
                    var response = await httpClient.SendAsync(request);
                    
                    
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBoxError.Show($"Algo deu errado ao tenta enviar NFC-e {response.StatusCode}");
                    }
                    
                }
            }
           
        }
    }
}
