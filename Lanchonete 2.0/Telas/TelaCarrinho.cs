using Lanchonete_2._0.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_2._0.Telas
{
    public partial class TelaCarrinho : Form
    {
        public TelaCarrinho()
        {
            InitializeComponent();
        }

        private void TelaCarrinho_Load(object sender, EventArgs e)
        {
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

            listaProd.Add(p1);
            listaProd.Add(p2);
            listaProd.Add(p3);
            listaProd.Add(p4);
            listaProd.Add(p5);
            listaProd.Add(p6);
            listaProd.Add(p7);
            listaProd.Add(p8);
            listaProd.Add(p9);
            listaProd.Add(p10);
            listaProd.Add(p11);
            listaProd.Add(p12);
            listaProd.Add(p13);
            listaProd.Add(p14);

            foreach (Produto p in listaProd)
            {
              
            }

        }



    }
}
