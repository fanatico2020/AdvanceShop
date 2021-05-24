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
    public class CaixasController
    {
        public DataTable ObterTodosCaixas()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from caixas inner join datahora on datahora.caixas_idcaixas = caixas.idcaixas where deletado = 0 order by caixas.status = 0 desc, idcaixas desc;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void Adicionar_AbrirCaixa(CaixasModel caixa, UsuariosModel usuarioLogado)
        {
            //Allow User Variables=True na string de conexão para aceitar variaveis no sql.
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
            "insert into caixas(maquina, saldoinicial, status,usuarios_idusuarios,deletado) values(@maquina, @saldoinicial,@status,@usuarios_idusuarios,0); " +
            "select last_insert_id() into @first_id; " +
            "insert into datahora(datahoracadastro, usuariocadastro, caixas_idcaixas) values(now(), @usuariocadastro, last_insert_id()); " +
            "insert into transacoescaixa(tipo, descricaotransacao, valor, status, caixas_idcaixas,deletado) values(1,'Abertura Caixa', @saldoinicial, 1, @first_id,0); " +
            "select last_insert_id() into @second_id;  " +
            "insert into datahora(datahoracadastro, usuariocadastro, transacoescaixa_idtransacoescaixa) values(now(), @usuariocadastro, last_insert_id()); " +
            "insert into formaspagamento(descricao,valor,transacoescaixa_idtransacoescaixa) values ('DINHEIRO',@saldoinicial,@second_id)";
            comando.Parameters.Add(new MySqlParameter("@maquina", caixa.Maquina));
            comando.Parameters.Add(new MySqlParameter("@saldoinicial", caixa.SaldoInicial));
            comando.Parameters.Add(new MySqlParameter("@status", caixa.status));
            comando.Parameters.Add(new MySqlParameter("@usuariocadastro", usuarioLogado.UsuarioAcesso));
            comando.Parameters.Add(new MySqlParameter("@usuarios_idusuarios", usuarioLogado.IdUsuarios));
            comando.ExecuteNonQuery();
        }

        public void Editar_SaldoInicial(CaixasModel caixa, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update caixas set saldoinicial = @saldoinicial where idcaixas = @idcaixas; " +
                "update datahora set datahoraedicao = now(),usuarioedicao = @usuarioedicao where caixas_idcaixas = @idcaixas; " +
                "select @id_transacao; " +
                "select idtransacoescaixa from transacoescaixa where descricaotransacao = 'Abertura Caixa' and caixas_idcaixas = @idcaixas into @id_transacao; " +
                "update transacoescaixa set valor = @saldoinicial  where idtransacoescaixa = @id_transacao;" +
                "update datahora set datahoraedicao = now(),usuarioedicao = @usuarioedicao where transacoescaixa_idtransacoescaixa = @id_transacao; " +
                "update formaspagamento set valor = @saldoinicial where transacoescaixa_idtransacoescaixa = @id_transacao;";
            comando.Parameters.Add(new MySqlParameter("@idcaixas", caixa.IdCaixas));
            comando.Parameters.Add(new MySqlParameter("@saldoinicial", caixa.SaldoInicial));
            comando.Parameters.Add(new MySqlParameter("@usuarioedicao", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }
        public void FecharCaixa(CaixasModel caixa)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update caixas set saldofinal = @saldofinal,status = @status,observacaocaixa = @observacaocaixa,valorinformado = @valorinformado,quebracaixa = @quebracaixa,usuariofechamento = @usuariofechamento,datahorafechamento = @datahorafechamento where idcaixas = @idcaixas; ";
            comando.Parameters.Add(new MySqlParameter("@idcaixas", caixa.IdCaixas));
            comando.Parameters.Add(new MySqlParameter("@saldofinal", caixa.SaldoFinal));
            comando.Parameters.Add(new MySqlParameter("@status", caixa.status));
            comando.Parameters.Add(new MySqlParameter("@observacaocaixa", caixa.ObservacaoCaixa));
            comando.Parameters.Add(new MySqlParameter("@valorinformado", caixa.ValorInformado));
            comando.Parameters.Add(new MySqlParameter("@quebracaixa", caixa.QuebraCaixa));
            comando.Parameters.Add(new MySqlParameter("@datahorafechamento", caixa.DataHoraFechamento));
            comando.Parameters.Add(new MySqlParameter("@usuariofechamento", caixa.UsuarioFechamento));
            comando.ExecuteNonQuery();
        }


        public void Deletar(CaixasModel caixa)
        {
            //Tem que verificar se o caixa já não possui venda, se sim não permitir deletar, caso contrario foi apenas aberto caixa e possivel deletar.
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update caixas set deletado = 1,status = 1 where idcaixas = @idcaixas;";
                /*
            "SET FOREIGN_KEY_CHECKS = 0; " +
            "select @iddocaixa; " +
            "select idcaixas from caixas where idcaixas = @idcaixas into @iddocaixa; " +
            "delete from datahora where caixas_idcaixas = @iddocaixa; " +
            "delete from caixas where idcaixas = @iddocaixa; " +
            "select @iddatransacaocaixa; " +
            "select idtransacoescaixa from transacoescaixa where caixas_idcaixas = @iddocaixa into @iddatransacaocaixa; " +
            "delete from transacoescaixa where caixas_idcaixas = @iddocaixa; " +
            "delete from formaspagamento where transacoescaixa_idtransacoescaixa = @iddatransacaocaixa; ";
                */
            comando.Parameters.Add(new MySqlParameter("@idcaixas", caixa.IdCaixas));
            comando.ExecuteNonQuery();
        }
        public bool VerificarCaixaAbertoOuNao(CaixasModel Caixa)
        {
            bool resultado;
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select idcaixas from caixas where usuarios_idusuarios = @usuarios_idusuarios and status = 0;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@usuarios_idusuarios", Caixa.usuarios_idusuarios));
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
        public CaixasModel AutenticarCaixaUsuario(CaixasModel Caixa)
        {
            bool resultado;
            CaixasModel caixa = new CaixasModel();
            caixa.caixaAberto = false;
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select idcaixas,maquina,status from caixas where usuarios_idusuarios = @usuarios_idusuarios and status = 0;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@usuarios_idusuarios", Caixa.usuarios_idusuarios));
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("idcaixas", typeof(int));
            dt.Columns.Add("maquina", typeof(string));
            dt.Columns.Add("status", typeof(int));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            if (resultado)
            {
                caixa.IdCaixas = Convert.ToInt32(dt.Rows[0]["idcaixas"]);
                caixa.Maquina = dt.Rows[0]["maquina"].ToString();
                caixa.status = Convert.ToInt32(dt.Rows[0]["status"]);
                caixa.caixaAberto = true;
                return caixa;
            }
            else
            {
                caixa.caixaAberto = false;
                return caixa;
            }

        }
        //Cupom não fiscal
        public CaixasModel ObterDadosDoCaixaPorID(CaixasModel Caixa)
        {
            
            bool resultado;
            CaixasModel caixa = new CaixasModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from caixas where idcaixas = @idcaixas;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idcaixas", Caixa.IdCaixas));
            //Montando dataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("idcaixas", typeof(int));
            dt.Columns.Add("maquina", typeof(string));
            dt.Columns.Add("saldoinicial", typeof(decimal));
            dt.Columns.Add("valorinformado", typeof(decimal));
            dt.Columns.Add("quebracaixa", typeof(decimal));
            dt.Columns.Add("saldofinal", typeof(decimal));
            dt.Columns.Add("observacaocaixa", typeof(string));
            dt.Columns.Add("status", typeof(int));
            dt.Columns.Add("usuariofechamento", typeof(string));
            dt.Columns.Add("datahorafechamento", typeof(DateTime));
            dt.Columns.Add("deletado", typeof(int));
            dt.Columns.Add("usuarios_idusuarios", typeof(int));
            //Lendo dt
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            resultado = reader.HasRows;
            dt.Load(reader);

            if (resultado)
            {
                try
                {
                    caixa.IdCaixas = Convert.ToInt32(dt.Rows[0]["idcaixas"]);
                    caixa.Maquina = dt.Rows[0]["maquina"].ToString();
                    caixa.SaldoInicial = Convert.ToDecimal(dt.Rows[0]["saldoinicial"]);
                    caixa.ValorInformado = Convert.ToDecimal(dt.Rows[0]["valorinformado"]);
                    caixa.QuebraCaixa = Convert.ToDecimal(dt.Rows[0]["quebracaixa"]);
                    caixa.SaldoFinal = Convert.ToDecimal(dt.Rows[0]["saldofinal"]);
                    caixa.ObservacaoCaixa = dt.Rows[0]["observacaocaixa"].ToString();
                    caixa.status = Convert.ToInt32(dt.Rows[0]["status"]);
                    caixa.UsuarioFechamento = dt.Rows[0]["usuariofechamento"].ToString();
                    caixa.DataHoraFechamento = Convert.ToDateTime(dt.Rows[0]["datahorafechamento"]);
                    caixa.Deletado = Convert.ToInt32(dt.Rows[0]["deletado"]);
                    caixa.usuarios_idusuarios = Convert.ToInt32(dt.Rows[0]["usuarios_idusuarios"]);
                }
                catch (InvalidCastException)
                {

                    
                }
                

                return caixa;
            }
            else
            {
                return caixa;
            }

        }

    }
}
