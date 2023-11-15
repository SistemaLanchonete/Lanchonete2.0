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
    public partial class Pag2 : Form
    {
        public Pag2()
        {
            InitializeComponent();
        }
        bool precoVisivel = false;
        private void bt_verpreco_torta_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_torta.Text = "R$ 4.00";
            }
            else
            {
                bt_verpreco_torta.Text = "Ver Preço";
            }
        }

        private void bt_verpreco_esfirra_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_esfirra.Text = "R$ 13.00";
            }
            else
            {
                bt_verpreco_esfirra.Text = "Ver Preço";
            }
        }

        private void bt_estoque_esfirra_Click(object sender, EventArgs e)
        {
            bt_estoque_esfirra.Text = "Disponível";
        }

        private void bt_estoque_torta_Click(object sender, EventArgs e)
        {
            bt_estoque_torta.Text = "Disponível";
        }

        private void bt_verpreco_salgadinhos_Click(object sender, EventArgs e)
        {
            precoVisivel = !precoVisivel;

            if (precoVisivel)
            {
                bt_verpreco_salgadinhos.Text = "R$ 6.00";
            }
            else
            {
                bt_verpreco_salgadinhos.Text = "Ver Preço";
            }
        }

        private void bt_estoque_salgadinhos_Click(object sender, EventArgs e)
        {
            bt_estoque_salgadinhos.Text = "Disponível";
        }
    }
}
