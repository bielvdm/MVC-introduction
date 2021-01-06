using System;
using System.Collections.Generic;
using MVC_introduction.models;

namespace MVC_introduction.views
{
    public class Produtoview
    {
        public void Listar (List <Produto> produto){
            foreach (var item in produto)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco}");
                Console.WriteLine(); 
            }
        }
        public Produto CadastrarProduto (){
            Produto produto = new Produto ();
            Console.WriteLine($"Digite o código para cadastrar o produto:");
            produto.Codigo = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Digite o nome para cadastrar o produto:");
            produto.Nome = Console.ReadLine();
            
            Console.WriteLine($"Digite o preço para cadastrar o produto:");
            produto.Preco = float.Parse(Console.ReadLine());
            
            return produto;
        }
    }
}