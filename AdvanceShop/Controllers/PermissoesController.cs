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
    public class PermissoesController

    {
        public DataTable ObterTodasPermissoesUsuario(UsuariosModel usuario)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select usuarios_idusuarios,permissoes_idpermissoes,status,descricaopermissao from usuario_tem_permissao inner join permissoes on idpermissoes = permissoes_idpermissoes where usuarios_idusuarios = @usuarios_idusuarios;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@usuarios_idusuarios", usuario.IdUsuarios));
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        
    }
}
