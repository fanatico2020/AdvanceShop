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
    public class ClientesPessoasController
    {
        
        public DataTable ObterTodosClientesPessoas()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from clientespessoas inner join datahora on datahora.clientespessoas_idclientespessoas = clientespessoas.idclientespessoas where clientespessoas.deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void Adicionar(ClientesPessoasModel clientePessoa, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into clientespessoas(nome,cpf_cnpj,datanascimento,email,contato1,contato2,sexo,status,tipopessoa,rg_ie,observacao,cep,endereco,numero,bairro,complemento,cidade,uf,deletado) " +
                "values(@nome,@cpf_cnpj,@datanascimento,@email,@contato1,@contato2,@sexo,@status,@tipopessoa,@rg_ie,@observacao,@cep,@endereco,@numero,@bairro,@complemento,@cidade,@uf,0); " +
                "insert into datahora(datahoracadastro,usuariocadastro,clientespessoas_idclientespessoas) values(now(),@usuariocadastro,last_insert_id());";
            comando.Parameters.Add(new MySqlParameter("@nome", clientePessoa.NomeClientePessoa));
            comando.Parameters.Add(new MySqlParameter("@cpf_cnpj", clientePessoa.CPFCNPJ));
            comando.Parameters.Add(new MySqlParameter("@datanascimento", clientePessoa.DataNascimento));
            comando.Parameters.Add(new MySqlParameter("@email", clientePessoa.Email));
            comando.Parameters.Add(new MySqlParameter("@contato1", clientePessoa.Contato1));
            comando.Parameters.Add(new MySqlParameter("@contato2", clientePessoa.Contato2));
            comando.Parameters.Add(new MySqlParameter("@sexo", clientePessoa.Sexo));
            comando.Parameters.Add(new MySqlParameter("@status", clientePessoa.StatusClientePessoa));
            comando.Parameters.Add(new MySqlParameter("@tipopessoa", clientePessoa.TipoPessoa));
            comando.Parameters.Add(new MySqlParameter("@rg_ie", clientePessoa.RGIE));
            comando.Parameters.Add(new MySqlParameter("@observacao", clientePessoa.Observacao));
            comando.Parameters.Add(new MySqlParameter("@cep", clientePessoa.CEP));
            comando.Parameters.Add(new MySqlParameter("@endereco", clientePessoa.Endereco));
            comando.Parameters.Add(new MySqlParameter("@numero", clientePessoa.NumeroCasa));
            comando.Parameters.Add(new MySqlParameter("@bairro", clientePessoa.Bairro));
            comando.Parameters.Add(new MySqlParameter("@complemento", clientePessoa.Complemento));
            comando.Parameters.Add(new MySqlParameter("@cidade", clientePessoa.Cidade));
            comando.Parameters.Add(new MySqlParameter("@uf", clientePessoa.UF));
            comando.Parameters.Add(new MySqlParameter("@usuariocadastro", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }

        public void Editar(ClientesPessoasModel clientePessoa, UsuariosModel usuarioLogado)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update clientespessoas set nome = @nome, cpf_cnpj = @cpf_cnpj,datanascimento = @datanascimento, email = @email, contato1 = @contato1, contato2 = @contato2," +
                "sexo = @sexo,rg_ie = @rg_ie,observacao = @observacao,status = @status,endereco = @endereco,numero = @numero,bairro = @bairro,complemento = @complemento,cidade = @cidade,uf = @uf,cep = @cep where idclientespessoas = @idclientespessoas;" +
                "update datahora set datahoraedicao = now(),usuarioedicao = @usuarioedicao where clientespessoas_idclientespessoas = @idclientespessoas;";
            comando.Parameters.Add(new MySqlParameter("@idclientespessoas", clientePessoa.IdClientesPessoas));
            comando.Parameters.Add(new MySqlParameter("@nome", clientePessoa.NomeClientePessoa));
            comando.Parameters.Add(new MySqlParameter("@cpf_cnpj", clientePessoa.CPFCNPJ));
            comando.Parameters.Add(new MySqlParameter("@datanascimento", clientePessoa.DataNascimento));
            comando.Parameters.Add(new MySqlParameter("@email", clientePessoa.Email));
            comando.Parameters.Add(new MySqlParameter("@contato1", clientePessoa.Contato1));
            comando.Parameters.Add(new MySqlParameter("@contato2", clientePessoa.Contato2));
            comando.Parameters.Add(new MySqlParameter("@sexo", clientePessoa.Sexo));
            comando.Parameters.Add(new MySqlParameter("@status", clientePessoa.StatusClientePessoa));
            comando.Parameters.Add(new MySqlParameter("@tipopessoa", clientePessoa.TipoPessoa));
            comando.Parameters.Add(new MySqlParameter("@rg_ie", clientePessoa.RGIE));
            comando.Parameters.Add(new MySqlParameter("@observacao", clientePessoa.Observacao));
            comando.Parameters.Add(new MySqlParameter("@cep", clientePessoa.CEP));
            comando.Parameters.Add(new MySqlParameter("@endereco", clientePessoa.Endereco));
            comando.Parameters.Add(new MySqlParameter("@numero", clientePessoa.NumeroCasa));
            comando.Parameters.Add(new MySqlParameter("@bairro", clientePessoa.Bairro));
            comando.Parameters.Add(new MySqlParameter("@complemento", clientePessoa.Complemento));
            comando.Parameters.Add(new MySqlParameter("@cidade", clientePessoa.Cidade));
            comando.Parameters.Add(new MySqlParameter("@uf", clientePessoa.UF));
            comando.Parameters.Add(new MySqlParameter("@usuarioedicao", usuarioLogado.UsuarioAcesso));
            comando.ExecuteNonQuery();
        }

        public void Deletar(ClientesPessoasModel clientePessoa)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update clientespessoas set deletado = 1 where idclientespessoas = @idclientespessoas;";
            comando.Parameters.Add(new MySqlParameter("@idclientespessoas", clientePessoa.IdClientesPessoas));
            comando.ExecuteNonQuery();
        }
        public bool VerificarSer_CPF_CNPJ_JaCadastrado(ClientesPessoasModel ClientePessoa)
        {
            bool resultado;
            ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from clientespessoas where cpf_cnpj = @cpf_cnpj;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@cpf_cnpj", ClientePessoa.CPFCNPJ));
            
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
        //Cupom não fiscal
        public ClientesPessoasModel ObterDadosDoClientePessoaPorID(ClientesPessoasModel ClientePessoa)
        {
            bool resultado;
            ClientesPessoasModel clientePessoa = new ClientesPessoasModel();
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText =
                "select * from clientespessoas where idclientespessoas = @idclientespessoas;";
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(new MySqlParameter("@idclientespessoas", ClientePessoa.IdClientesPessoas));
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
    }
}
