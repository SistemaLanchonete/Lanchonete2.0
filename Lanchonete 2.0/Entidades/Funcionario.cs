using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete_2._0.Entidades
{
    internal class Funcionario : Pessoa
    {
        public string Cargo { get; set; }

        public Funcionario() { }

        public Funcionario(string cargo, string nome, string cpf, string email, string senha):base(nome, cpf, email, senha)
        {
            Cargo = cargo;
        }
    }
}
