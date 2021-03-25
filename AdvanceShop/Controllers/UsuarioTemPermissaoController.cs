using AdvanceShop.Data;
using AdvanceShop.Models;
using AdvanceShop.Shared.CustomMessageBox;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceShop.Controllers
{
    public static class UsuarioTemPermissaoController
    {
        public static bool AutenticarPermissao(UsuarioTemPermissaoModel usuarioTemPermissao)
        {
            bool resultado;
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from usuario_tem_permissao where status = 1 and usuarios_idusuarios = @usuarios_idusuarios and permissoes_idpermissoes = @permissoes_idpermissoes;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@usuarios_idusuarios", usuarioTemPermissao.usuarios_idusuarios));
            comando.Parameters.Add(new MySqlParameter("@permissoes_idpermissoes", usuarioTemPermissao.permissoes_idpermissoes));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            if (resultado)
            {
                return true;
            }
            else
            {
                MessageBoxWarning.Show($"Seu usuário não tem permissão para essa operação, entre em contato com o administrador do sistema é peça permissão no ID {usuarioTemPermissao.permissoes_idpermissoes}");
                return false;
            }

        }
        public static void EditarPermissaoSimNao(UsuarioTemPermissaoModel usuarioTemPermissaoModel)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update usuario_tem_permissao set status = @status where permissoes_idpermissoes = @permissoes_idpermissoes and usuarios_idusuarios = @usuarios_idusuarios;";
            comando.Parameters.Add(new MySqlParameter("@status", usuarioTemPermissaoModel.status));
            comando.Parameters.Add(new MySqlParameter("@permissoes_idpermissoes", usuarioTemPermissaoModel.permissoes_idpermissoes));
            comando.Parameters.Add(new MySqlParameter("@usuarios_idusuarios", usuarioTemPermissaoModel.usuarios_idusuarios));
            comando.ExecuteNonQuery();
        }

    }
}
