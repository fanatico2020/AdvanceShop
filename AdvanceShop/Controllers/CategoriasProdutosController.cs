﻿using AdvanceShop.Data;
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
    public class CategoriasProdutosController
    {
        public DataTable ObterTodasCategorias()
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandText = "select * from categoriasprodutos where deletado = 0;";
            comando.CommandType = CommandType.Text;
            MySqlDataReader reader = ConexaoMySql.GetDataReader(comando);
            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            return dataTable;
        }
        public void Adicionar(CategoriasProdutosModel categoriaProduto)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "insert into categoriasprodutos(descricaocategoria,deletado) values(@descricaocategoria,0);";
            comando.Parameters.Add(new MySqlParameter("@descricaocategoria", categoriaProduto.DescricaoCategoria));
            comando.ExecuteNonQuery();
        }

        public void Deletar(CategoriasProdutosModel categoriaProduto)
        {
            MySqlConnection conexao = ConexaoMySql.GetConexao();
            MySqlCommand comando = ConexaoMySql.GetComando(conexao);
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText =
                "update categoriasprodutos set deletado = 1 where idcategoriasprodutos = @idcategoriasprodutos;";
            comando.Parameters.Add(new MySqlParameter("@idcategoriasprodutos", categoriaProduto.IdCategoriasProdutos));
            comando.ExecuteNonQuery();
        }
    }
}
