using AdvanceShop.Shared.CustomMessageBox;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Data
{
    public class ConexaoMySql
    {
        public static MySqlConnection GetConexao()
        {
            string Server = (ConfigurationManager.AppSettings["Server"]);
            string Database = (ConfigurationManager.AppSettings["DataBase"]);
            string Port = (ConfigurationManager.AppSettings["Port"]);

            MySqlConnection conexao = new MySqlConnection(
                     @"Server=" + Server + ";User ID=root;Password=masterkey;Database=" + Database + ";Persist Security Info= true;Charset=utf8;Port = " + Port + ";Uid=root;Pooling=False;Allow User Variables=True;convertzerodatetime=true;");
            try
            {
                conexao.Open();
            }

            catch (MySql.Data.MySqlClient.MySqlException exc)
            {

                MessageBoxError.Show($"Não foi possível conectar com o banco de dados {Database} no IP {Server} pela porta {Port} - detalhe do error " + exc.Message);

                Application.Exit();
            }
            /*
            finally
            {
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }*/
            return conexao;

        }
        public static MySqlCommand GetComando(MySqlConnection conexao)
        {
            using (MySqlCommand comando = conexao.CreateCommand())
            {
                return comando;
            }

        }
        public static MySqlDataReader GetDataReader(MySqlCommand comando)
        {
            return comando.ExecuteReader();
        }
    }
}
