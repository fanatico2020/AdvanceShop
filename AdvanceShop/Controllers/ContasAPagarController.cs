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
    public class ContasAPagarController
    {
        public DataTable ObterTodasContasAPagar()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from contasapagar inner join datahora on datahora.contasapagar_idcontasapagar = contasapagar.idcontasapagar inner join categoriascontasapagar on contasapagar.categoriascontasapagar_idcategoriascontasapagar = categoriascontasapagar.idcategoriascontasapagar inner join clientespessoas on contasapagar.clientespessoas_idclientespessoas = clientespessoas.idclientespessoas where contasapagar.deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void Adicionar(ContasAPagarModel contaAPagar, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into contasapagar(referentea,observacao,status,valor,datavencimento,documento,categoriascontasapagar_idcategoriascontasapagar,clientespessoas_idclientespessoas,deletado) " +
                "values(@referentea,@observacao,0,@valor,@datavencimento,@documento,@categoriascontasapagar_idcategoriascontasapagar,@clientespessoas_idclientespessoas,0); " +
                "insert into datahora(datahoracadastro,usuariocadastro,contasapagar_idcontasapagar) values(now(),@usuariocadastro,last_insert_id());";
            comando.Parameters.Add(new MySqlParameter("@referentea", contaAPagar.Referentea));
            comando.Parameters.Add(new MySqlParameter("@observacao", contaAPagar.Observacao));
            comando.Parameters.Add(new MySqlParameter("@valor", contaAPagar.Valor));
            comando.Parameters.Add(new MySqlParameter("@datavencimento", contaAPagar.DataVencimento));
            comando.Parameters.Add(new MySqlParameter("@documento", contaAPagar.Documento));
            comando.Parameters.Add(new MySqlParameter("@categoriascontasapagar_idcategoriascontasapagar", contaAPagar.categoriascontasapagar_idcategoriascontasapagar));
            comando.Parameters.Add(new MySqlParameter("@clientespessoas_idclientespessoas", contaAPagar.clientespessoas_idclientespessoas));
            comando.Parameters.Add(new MySqlParameter("@usuariocadastro", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }

        public void Editar(ContasAPagarModel contaAPagar, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update contasapagar set referentea = @referentea, observacao = @observacao,valor = @valor,datavencimento = @datavencimento,documento = @documento,categoriascontasapagar_idcategoriascontasapagar = @categoriascontasapagar_idcategoriascontasapagar,clientespessoas_idclientespessoas = @clientespessoas_idclientespessoas where idcontasapagar = @idcontasapagar; " +
                "update datahora set datahoraedicao = now(),usuarioedicao = @usuarioedicao where contasapagar_idcontasapagar = @idcontasapagar;";
            comando.Parameters.Add(new MySqlParameter("@idcontasapagar", contaAPagar.IdContasApagar));
            comando.Parameters.Add(new MySqlParameter("@referentea", contaAPagar.Referentea));
            comando.Parameters.Add(new MySqlParameter("@observacao", contaAPagar.Observacao));
            comando.Parameters.Add(new MySqlParameter("@valor", contaAPagar.Valor));
            comando.Parameters.Add(new MySqlParameter("@datavencimento", contaAPagar.DataVencimento));
            comando.Parameters.Add(new MySqlParameter("@documento", contaAPagar.Documento));
            comando.Parameters.Add(new MySqlParameter("@categoriascontasapagar_idcategoriascontasapagar", contaAPagar.categoriascontasapagar_idcategoriascontasapagar));
            comando.Parameters.Add(new MySqlParameter("@clientespessoas_idclientespessoas", contaAPagar.clientespessoas_idclientespessoas));
            comando.Parameters.Add(new MySqlParameter("@usuarioedicao", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }
        public void EditarEfetuarPagamento(ContasAPagarModel contaAPagar, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update contasapagar set observacao = @observacao,status = @status,valorpago = @valorpago, datarecebimento = @datarecebimento where idcontasapagar = @idcontasapagar; " +
                "update datahora set datahoraedicao = now(),usuarioedicao = @usuarioedicao where contasapagar_idcontasapagar = @idcontasapagar;";
            comando.Parameters.Add(new MySqlParameter("@idcontasapagar", contaAPagar.IdContasApagar));
            comando.Parameters.Add(new MySqlParameter("@observacao", contaAPagar.Observacao));
            comando.Parameters.Add(new MySqlParameter("@status", contaAPagar.Status));
            comando.Parameters.Add(new MySqlParameter("@valorpago", contaAPagar.ValorPago));
            comando.Parameters.Add(new MySqlParameter("@datarecebimento", contaAPagar.DataRecebimento));
            comando.Parameters.Add(new MySqlParameter("@usuarioedicao", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }

        public void Deletar(ContasAPagarModel contaAPagar)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update contasapagar set deletado = 1 where idcontasapagar = @idcontasapagar;";
            comando.Parameters.Add(new MySqlParameter("@idcontasapagar", contaAPagar.IdContasApagar));
            comando.ExecuteNonQuery();
        }
    }
}
