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
    public partial class Pag4 : Form
    {
        public Pag4()
        {
            InitializeComponent();
        }
        bool precoVisivel = false;
        private void bt_verpreco_tapioca_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_tapioca.Text = "R$ 5.00";
            }
            else
            {
                bt_verpreco_tapioca.Text = "Ver Preço";
            }
        }

        private void bt_estoque_tapioca_Click(object sender, EventArgs e)
        {
            bt_estoque_tapioca.Text = "Disponível";
        }

        private void bt_verpreco_cocacola_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_cocacola.Text = "R$ 4.50";
            }
            else
            {
                bt_verpreco_cocacola.Text = "Ver Preço";
            }
        }

        private void bt_estoque_cocacola_Click(object sender, EventArgs e)
        {
        
            bt_estoque_cocacola.Text = "Disponível";
        }

        private void bt_verpreco_hamburguer_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_hamburguer.Text = "R$ 13.00";
            }
            else
            {
                bt_verpreco_tapioca.Text = "Ver Preço";
            }
        }

        private void bt_estoque_hamburguer_Click(object sender, EventArgs e)
        {
            bt_estoque_hamburguer.Text = "Disponível";
        }
    }
}
