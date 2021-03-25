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
    public class EmailSistemaController
    {
        public EmailSistemaModel ObterConfiguracoesEmailSistema()
        {
            bool resultado;
            EmailSistemaModel config = new EmailSistemaModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from emailsistema where idemailsistema = 1;";
            comando.CommandType = CommandType.Text;
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("idemailsistema", typeof(int));
            dt.Columns.Add("emailprincipal", typeof(string));
            dt.Columns.Add("emailcopia1", typeof(string));
            dt.Columns.Add("emailcopia2", typeof(string));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            if (resultado)
            {
                config.idemailsistema = Convert.ToInt32(dt.Rows[0]["idemailsistema"]);
                config.emailprincipal = Convert.ToString(dt.Rows[0]["emailprincipal"]);
                config.emailcopia1 = Convert.ToString(dt.Rows[0]["emailcopia1"]);
                config.emailcopia2 = Convert.ToString(dt.Rows[0]["emailcopia2"]);
                return config;
            }
            else
            {
                return config;
            }

        }
        public void SalvarConfiguracao(EmailSistemaModel config)
        {

            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update emailsistema set emailprincipal = @emailprincipal,emailcopia1 = @emailcopia1,emailcopia2 = @emailcopia2 where idemailsistema = 1";
            comando.Parameters.Add(new MySqlParameter("@emailprincipal", config.emailprincipal));
            comando.Parameters.Add(new MySqlParameter("@emailcopia1", config.emailcopia1));
            comando.Parameters.Add(new MySqlParameter("@emailcopia2", config.emailcopia2));
            comando.ExecuteNonQuery();
        }
    }
}
