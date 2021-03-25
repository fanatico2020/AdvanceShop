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
    public class ConfiguracoesGeraisController
    {
        public ConfiguracoesGeraisModel ObterConfiguracoesGerais()
        {
            bool resultado;
            ConfiguracoesGeraisModel config = new ConfiguracoesGeraisModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from configuracoesgerais where idconfiguracoesgerais = 1;";
            comando.CommandType = CommandType.Text;
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("idconfiguracoesgerais", typeof(int));
            dt.Columns.Add("trocomaximo", typeof(int));
            dt.Columns.Add("valortrocomaximo", typeof(decimal));
            dt.Columns.Add("imprimircpfcnpjnocupom", typeof(int));
            dt.Columns.Add("imprimircupomfinalizarvenda", typeof(int));
            dt.Columns.Add("imprimircupomfiscalnfcefinalizarvenda", typeof(int));
            dt.Columns.Add("imprimirnomevendedorfinalizarvenda", typeof(int));
            dt.Columns.Add("vendacartaopermitirdesconto", typeof(int));
            dt.Columns.Add("avisarclienteaniversariante", typeof(int));
            dt.Columns.Add("avisarprodutoestoquebaixo", typeof(int));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            if (resultado)
            {
                config.idconfiguracoesgerais = Convert.ToInt32(dt.Rows[0]["idconfiguracoesgerais"]);
                config.imprimircpfcnpjnocupom = Convert.ToInt32(dt.Rows[0]["imprimircpfcnpjnocupom"]);
                config.imprimircupomfinalizarvenda = Convert.ToInt32(dt.Rows[0]["imprimircupomfinalizarvenda"]);
                config.imprimircupomfiscalnfcefinalizarvenda = Convert.ToInt32(dt.Rows[0]["imprimircupomfiscalnfcefinalizarvenda"]);
                config.imprimirnomevendedorfinalizarvenda = Convert.ToInt32(dt.Rows[0]["imprimirnomevendedorfinalizarvenda"]);
                config.trocomaximo = Convert.ToInt32(dt.Rows[0]["trocomaximo"]);
                config.valortrocomaximo = Convert.ToDecimal(dt.Rows[0]["valortrocomaximo"]);
                config.vendacartaopermitirdesconto = Convert.ToInt32(dt.Rows[0]["vendacartaopermitirdesconto"]);
                config.avisarclienteaniversariante = Convert.ToInt32(dt.Rows[0]["avisarclienteaniversariante"]);
                config.avisarprodutoestoquebaixo = Convert.ToInt32(dt.Rows[0]["avisarprodutoestoquebaixo"]);
                return config;
            }
            else
            {
                return config;
            }

        }
        public void SalvarConfiguracao(ConfiguracoesGeraisModel config)
        {
            
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update configuracoesgerais set trocomaximo = @trocomaximo,valortrocomaximo = @valortrocomaximo,imprimircpfcnpjnocupom = @imprimircpfcnpjnocupom,imprimircupomfinalizarvenda = @imprimircupomfinalizarvenda,imprimircupomfiscalnfcefinalizarvenda = @imprimircupomfiscalnfcefinalizarvenda,imprimirnomevendedorfinalizarvenda = @imprimirnomevendedorfinalizarvenda,vendacartaopermitirdesconto = @vendacartaopermitirdesconto,avisarclienteaniversariante = @avisarclienteaniversariante,avisarprodutoestoquebaixo = @avisarprodutoestoquebaixo where idconfiguracoesgerais = 1";
            comando.Parameters.Add(new MySqlParameter("@trocomaximo", config.trocomaximo));
            comando.Parameters.Add(new MySqlParameter("@valortrocomaximo", config.valortrocomaximo));
            comando.Parameters.Add(new MySqlParameter("@imprimircpfcnpjnocupom", config.imprimircpfcnpjnocupom));
            comando.Parameters.Add(new MySqlParameter("@imprimircupomfinalizarvenda", config.imprimircupomfinalizarvenda));
            comando.Parameters.Add(new MySqlParameter("@imprimircupomfiscalnfcefinalizarvenda", config.imprimircupomfiscalnfcefinalizarvenda));
            comando.Parameters.Add(new MySqlParameter("@imprimirnomevendedorfinalizarvenda", config.imprimirnomevendedorfinalizarvenda));
            comando.Parameters.Add(new MySqlParameter("@vendacartaopermitirdesconto", config.vendacartaopermitirdesconto));
            comando.Parameters.Add(new MySqlParameter("@avisarclienteaniversariante", config.avisarclienteaniversariante));
            comando.Parameters.Add(new MySqlParameter("@avisarprodutoestoquebaixo", config.avisarprodutoestoquebaixo));
            comando.ExecuteNonQuery();
        }
    }
}
