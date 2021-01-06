using MVC_introduction.models;
using MVC_introduction.views;

namespace MVC_introduction.controllers
{
    public class Produtocontroller
    {
        Produto produto = new Produto ();
        Produtoview produtoview = new Produtoview ();

        public void ListarProdutos(){
            produtoview.Listar (produto.Ler());
        }
        public void Cadastrar (){
            produto.Inserir(produtoview.CadastrarProduto());   
        }
    }
}