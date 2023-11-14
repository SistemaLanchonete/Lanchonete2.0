using System.Collections.Generic;
using System.ComponentModel;

namespace Lanchonete_2._0.Classes
{
    internal class Produto
    {
        public string Nomep { get; set; }     
        public double Precop { get; set; }
        public bool Disponibilidadep { get; set; }

        public Produto() { }

        public Produto(string nomep, double precop, bool disponibilidadep)
        {
            Nomep = nomep;
            Precop = precop;
            Disponibilidadep = disponibilidadep;
        }

        List<Produto> listaProd = new List<Produto>();
        Produto p1 = new Produto("Pizza", 15.00, true);
        Produto p2 = new Produto("Hamburguer", 13.00, true);
        Produto p3 = new Produto("Tapioca", 5.00, true);
        Produto p4 = new Produto("Hamburguer", 13.00, true);
        Produto p5 = new Produto("Churros", 4.00, true);
        Produto p6 = new Produto("Salgados", 6.00, true);
        Produto p7 = new Produto("Coxinha", 3.00, true);
        Produto p8 = new Produto("Tapioca", 1.50, true);
        Produto p9 = new Produto("Esfirra", 3.00, true);
        Produto p10 = new Produto("Brownie", 4.00, true);
        Produto p11 = new Produto("Pastel", 15.00, true);
        Produto p12 = new Produto("Torta", 13.00, true);
        Produto p13 = new Produto("Milk-Shake", 5.00, true);
        Produto p14 = new Produto("Coca cola 220mL", 13.00, true);

        

    }
}
