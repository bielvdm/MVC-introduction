using System;
using System.Collections.Generic;
using System.IO;

namespace MVC_introduction.views
{
    public class Cliente
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int Telefone { get; set; }
        public string Endereco { get; set; }
        public string DataNascimento { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        private const string PATH = "Database/Cliente.csv";

        public Cliente (){
            string pasta = PATH.Split("/")[0];
            if(!Directory.Exists(pasta)){
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH)){
                File.Create(PATH);
            }
        }

        public List <Cliente> LerCliente (){
            List <Cliente> cliente = new List<Cliente> ();
            string[] linhas  = File.ReadAllLines(PATH);
            foreach (string item in linhas)
            {
                string [] atributosCliente = item.Split(";");
                Cliente clientes = new Cliente ();
                clientes.Codigo = int.Parse(atributosCliente[0]);
                clientes.Nome = atributosCliente[1];
                clientes.Email = atributosCliente[2];
                clientes.Telefone = int.Parse(atributosCliente[3]);
                clientes.Endereco = atributosCliente[4];
                clientes.DataNascimento = atributosCliente[5];
                clientes.Sexo = atributosCliente[6];
                clientes.CPF = int.Parse(atributosCliente[7]);   
            }
            return cliente;
        }
    }
}