using System.Collections.Generic;
using System.ComponentModel;

namespace Lanchonete_2._0.Classes
{
    internal class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public bool Disponibilidade { get; set; }

        // Adicione uma propriedade para armazenar a lista de produtos
        public List<Produto> ListaProdutos { get; set; }

        public Produto(string nome, double preco, bool disponibilidade)
        {
            Nome = nome;
            Preco = preco;
            Disponibilidade = disponibilidade;

            // Inicializa a lista de produtos na própria classe
            ListaProdutos = new List<Produto>()
            {
                new Produto("Pizza", 15.00, true),
                new Produto("Hamburguer", 13.00, true),
                new Produto("Tapioca", 5.00, true),
                new Produto("Churros", 4.00, true),
                new Produto("Salgados", 6.00, true),
                new Produto("Coxinha", 3.00, true),
                new Produto("Esfirra", 1.50, true),
                new Produto("Brownie", 3.00, true),
                new Produto("Pastel", 5.00, true),
                new Produto("Torta", 4.00, true),
                new Produto("Milk Shake", 7.00, true),
                new Produto("Coca Cola 220 ml", 4.50, true)
                
            };
           
        }
    }
}
