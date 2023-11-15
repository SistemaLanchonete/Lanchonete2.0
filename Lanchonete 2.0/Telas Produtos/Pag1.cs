using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_2._0
{
    public partial class Pag1 : Form
    {
        public Pag1()
        {
            InitializeComponent();
        }
        bool precoVisivel = false;
        private void bt_verpreco_pizza_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_pizza.Text = "R$ 15.00";
            }
            else
            {
                bt_verpreco_pizza.Text = "Ver Preço";
            }
        }

        private void bt_estoque_Click(object sender, EventArgs e)
        {
            bt_estoque_pizza.Text = "Disponível";
        }

        private void bt_verpreco_churros_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_churros.Text = "R$ 4.00";
            }
            else
            {
                bt_verpreco_churros.Text = "Ver Preço";
            }
        }

        private void bt_verpreco_milksheik_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_milksheik.Text = "R$ 7.00";
            }
            else
            {
                bt_verpreco_milksheik.Text = "Ver Preço";
            }
        }

        private void bt_estoque_churros_Click(object sender, EventArgs e)
        {
            bt_estoque_churros.Text = "Indisponível";
        }

        private void bt_estoque_milksheik_Click(object sender, EventArgs e)
        {
            bt_estoque_milksheik.Text = "Disponível";
        }
    }
}
