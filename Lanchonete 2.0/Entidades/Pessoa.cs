using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete_2._0.Entidades
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }   
        public string Email { get; set; }
        public string Senha { get; set; }

        public Pessoa() { }

        public Pessoa(string nome, string cpf, string email, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Senha = senha;  
        }
    }
}
