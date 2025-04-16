using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ConexaoBD{

    class Conexao
    {
        string dadosConexao = "server=localhost;user=root;database=ti42_teste;port=3306;password=";

        public List<Produto> BuscaProdutos()
        {
            // Abrir Conexão com banco
            MySqlConnection conexao = new MySqlConnection(dadosConexao);
            conexao.Open();
            Console.WriteLine("Conexão bem sucedida!");

            // Rodar o SQL dentro do banco
            string sql = "SELECT * FROM produto;";
            MySqlCommand comando = new MySqlCommand( sql, conexao );
            MySqlDataReader dados = comando.ExecuteReader();

            List<Produto> lista = new List<Produto>(); 

            while (dados.Read() )
            {
                // Console.WriteLine("ID:"+dados[0]+ " | Nome: "+dados[1]+" | Preço: "+dados[2]);

                Produto p = new Produto();
                p.id = dados.GetInt32("id");
                p.nome = dados.GetString("nome");
                p.preco = dados.GetFloat("preco");
                p.registro = dados.GetDateTime("registro");

                lista.Add(p);              
                           
            }

            conexao.Close();

            return lista;
        }

    }

}