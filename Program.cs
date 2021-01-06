using System;
using MVC_introduction.controllers;
using MVC_introduction.models;
using MVC_introduction.views;

namespace MVC_introduction
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Produtocontroller controle = new Produtocontroller();
            controle.Cadastrar();
            controle.ListarProdutos();
        }
    }
}
