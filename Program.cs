﻿using System;
using System.Collections.Generic;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)
        {

            Conexao conexao = new Conexao();
            List<Produto> lista = conexao.BuscaProdutos();

            foreach( Produto p in lista )
            {
                Console.WriteLine("ID:  "+p.id+"Nome: "+p.nome);
            }

            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Olá, digite o seu nome: ");
            // string nome = Console.ReadLine();
            // Console.WriteLine("Welcome "+nome);
        
            // Produto produto = new Produto();
            // produto.nome = "Berta";
            // produto.preco = 79.90f;

            // Console.WriteLine("O produto é: "+produto.nome+" e o preço é "+produto.preco);
        
        }
    }
}
