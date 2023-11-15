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
    public partial class Pag3 : Form
    {
        public Pag3()
        {
            InitializeComponent();
        }
        bool precoVisivel = false;
        private void bt_verpreco_coxinha_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_coxinha.Text = "R$ 3.00";
            }
            else
            {
                bt_verpreco_coxinha.Text = "Ver Preço";
            }
            precoVisivel = !precoVisivel;

        
            
        }

        private void bt_estoque_coxinha_Click(object sender, EventArgs e)
        {
            bt_estoque_coxinha.Text = "Indisponível";
        }

        private void bt_verpreco_pastel_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_pastel.Text = "R$ 5.00";
            }
            else
            {
                bt_verpreco_coxinha.Text = "Ver Preço";
            }
        }

        private void bt_estoque_pastel_Click(object sender, EventArgs e)
        {
            bt_estoque_pastel.Text = "Disponível";
        }

        private void bt_verpreco_brownie_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_brownie.Text = "R$ 3.00";
            }
            else
            {
                bt_verpreco_coxinha.Text = "Ver Preço";
            }
        }

        private void bt_estoque_brownie_Click(object sender, EventArgs e)
        {
            bt_estoque_brownie.Text = "Indisponível";
        }
    }
}
