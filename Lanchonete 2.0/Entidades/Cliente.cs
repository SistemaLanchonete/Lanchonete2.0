using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lanchonete_2._0.Entidades
{
    internal class Cliente : Pessoa
    {
        public Cliente() { }
        public Cliente(string nome, string cpf, string email, string senha, DateTime DateNasci, string sexo):base(nome, cpf, email, senha, DateNasci, sexo)
        {

        }
    }
}
