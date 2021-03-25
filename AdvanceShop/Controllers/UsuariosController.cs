
using AdvanceShop.Data;
using AdvanceShop.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvanceShop.Controllers
{
    
    public class UsuariosController
    {
        public DataTable ObterTodosUsuariosAcesso_Nome()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select idusuarios,usuarioacesso from usuarios where status = 1 and deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }

        public DataTable ObterTodosUsuarios()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from usuarios inner join datahora on datahora.usuarios_idusuarios = usuarios.idusuarios where usuarios.deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        /*
        public UsuariosModels ObterUsuarioPorId(UsuariosModels usuario)
        {
            int resultado = 0;
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@usuario", UsuariosModels.usuario));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            while (reader.Read())
            {
                resultado = reader.GetInt32(2);
            }
            return resultado;
        }
        */
        public void Adicionar(UsuariosModel usuario,UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into usuarios(usuarioacesso,senhaacesso,nomecompleto,email,contato,usadescontomaximo,descontomaximo,status,deletado) " +
                "values(@usuarioacesso,md5(@senhaacesso),@nomecompleto,@email,@contato,@usadescontomaximo,@descontomaximo,@status,0); " +
                "insert into datahora(datahoracadastro,usuariocadastro,usuarios_idusuarios) values(now(),@usuariocadastro,last_insert_id());";
            comando.Parameters.Add(new MySqlParameter("@usuarioacesso", usuario.UsuarioAcesso));
            comando.Parameters.Add(new MySqlParameter("@senhaacesso", usuario.SenhaAcesso));
            comando.Parameters.Add(new MySqlParameter("@nomecompleto", usuario.NomeCompleto));
            comando.Parameters.Add(new MySqlParameter("@email", usuario.Email));
            comando.Parameters.Add(new MySqlParameter("@contato", usuario.Contato));
            comando.Parameters.Add(new MySqlParameter("@usadescontomaximo", usuario.UsaDescontoMaximo));
            comando.Parameters.Add(new MySqlParameter("@descontomaximo", usuario.DescontoMaximo));
            comando.Parameters.Add(new MySqlParameter("@status", usuario.Status));
            comando.Parameters.Add(new MySqlParameter("@usuariocadastro", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }
        
        public void Editar(UsuariosModel usuario, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = 
                "update usuarios set usuarioacesso = @usuarioacesso, senhaacesso = @senhaacesso,nomecompleto = @nomecompleto, "+
                "email = @email,contato = @contato,usadescontomaximo = @usadescontomaximo,descontomaximo = @descontomaximo,status = @status where idusuarios = @idusuarios;" +
                "update datahora set datahoraedicao = now(),usuarioedicao = @usuarioedicao where usuarios_idusuarios = @idusuarios;";
            comando.Parameters.Add(new MySqlParameter("@idusuarios", usuario.IdUsuarios));
            comando.Parameters.Add(new MySqlParameter("@usuarioacesso", usuario.UsuarioAcesso));
            comando.Parameters.Add(new MySqlParameter("@senhaacesso", usuario.SenhaAcesso));
            comando.Parameters.Add(new MySqlParameter("@nomecompleto", usuario.NomeCompleto));
            comando.Parameters.Add(new MySqlParameter("@email", usuario.Email));
            comando.Parameters.Add(new MySqlParameter("@contato", usuario.Contato));
            comando.Parameters.Add(new MySqlParameter("@usadescontomaximo", usuario.UsaDescontoMaximo));
            comando.Parameters.Add(new MySqlParameter("@descontomaximo", usuario.DescontoMaximo));
            comando.Parameters.Add(new MySqlParameter("@status", usuario.Status));
            comando.Parameters.Add(new MySqlParameter("@usuarioedicao", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }
        public void EditarStatus(UsuariosModel usuario, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update usuarios set status = @status where idusuarios = @idusuarios;" +
                "update datahora set datahoraedicao = now(),usuarioedicao = @usuarioedicao where usuarios_idusuarios = @idusuarios;";
            comando.Parameters.Add(new MySqlParameter("@idusuarios", usuario.IdUsuarios));
            comando.Parameters.Add(new MySqlParameter("@status", usuario.Status));
            comando.Parameters.Add(new MySqlParameter("@usuarioedicao", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }
        public void EditarSenha(UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update usuarios set senhaacesso = MD5(@senhaacesso) where idusuarios = @idusuarios;" +
                "update datahora set datahoraedicao = now(),usuarioedicao = @usuarioedicao where usuarios_idusuarios = @idusuarios;";
            comando.Parameters.Add(new MySqlParameter("@idusuarios", usuarioLogado.IdUsuarios));
            comando.Parameters.Add(new MySqlParameter("@senhaacesso", usuarioLogado.SenhaAcesso));
            comando.Parameters.Add(new MySqlParameter("@usuarioedicao", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }

        public void Deletar(UsuariosModel usuario)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update usuarios set deletado = 1 where idusuarios = @idusuarios;";
            comando.Parameters.Add(new MySqlParameter("@idusuarios", usuario.IdUsuarios));
            comando.ExecuteNonQuery();
        }
        public bool AutenticarSenha(UsuariosModel usuario)
        {
            bool resultado;
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from usuarios where usuarioacesso  = '" + usuario.UsuarioAcesso + "'and senhaacesso = MD5('" + usuario.SenhaAcesso + "') and status = 1;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            if (resultado)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public UsuariosModel AutenticarUsuario(UsuariosModel usuario)
        {
            bool resultado;
            UsuariosModel usuarioLogin = new UsuariosModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from usuarios where usuarioacesso  = '" + usuario.UsuarioAcesso + "'and senhaacesso = MD5('" + usuario.SenhaAcesso + "') and status = 1;";
            comando.CommandType = CommandType.Text;
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("idusuarios", typeof(int));
            dt.Columns.Add("usuarioacesso", typeof(string));
            dt.Columns.Add("senhaacesso", typeof(string));
            dt.Columns.Add("nomecompleto", typeof(string));
            dt.Columns.Add("email", typeof(string));
            dt.Columns.Add("contato", typeof(string));
            dt.Columns.Add("usadescontomaximo", typeof(int));
            dt.Columns.Add("descontomaximo", typeof(decimal));
            dt.Columns.Add("status", typeof(int));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);
            
            if (resultado)
            {
                usuarioLogin.IdUsuarios = Convert.ToInt32(dt.Rows[0]["idusuarios"]);
                usuarioLogin.UsuarioAcesso = dt.Rows[0]["usuarioacesso"].ToString();
                usuarioLogin.SenhaAcesso = dt.Rows[0]["senhaacesso"].ToString();
                usuarioLogin.NomeCompleto = dt.Rows[0]["nomecompleto"].ToString();
                usuarioLogin.Email = dt.Rows[0]["email"].ToString();
                usuarioLogin.Contato = dt.Rows[0]["contato"].ToString();
                usuarioLogin.UsaDescontoMaximo = Convert.ToInt32(dt.Rows[0]["usadescontomaximo"]);
                usuarioLogin.DescontoMaximo = Convert.ToDecimal(dt.Rows[0]["descontomaximo"]);
                usuarioLogin.Status = Convert.ToInt32(dt.Rows[0]["status"]);
                usuarioLogin.logado = 1;

                return usuarioLogin;
            }
            else
            {
                usuarioLogin.logado = 0;
                return usuarioLogin;
            }
            
        }
        public void EditarUsuarioComoLogadoOnOff(UsuariosModel usuarioLogado)//Falta implementar
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update usuarios set logado = @logado where idusuarios = @idusuarios;";
            comando.Parameters.Add(new MySqlParameter("@idusuarios", usuarioLogado.IdUsuarios));
            comando.Parameters.Add(new MySqlParameter("@logado", usuarioLogado.logado));
            comando.ExecuteNonQuery();
        }

    }
}
