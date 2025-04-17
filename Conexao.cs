using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ConexaoBD
{

    class Conexao
    {
        string dadosConexao = "server=localhost;user=root;database=ti42_teste;port=3306;password=";

        public DataTable ExecutaSelect(string query)
        {
            // Cria e abre conexão com o banco
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();

            // Rodar a query dentro do banco
            MySqlCommand comando = new MySqlCommand(query, conexao);
            MySqlDataAdapter dados = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            dados.Fill(dt);
            conexao.Close();
            return dt;
        }

    }

}
