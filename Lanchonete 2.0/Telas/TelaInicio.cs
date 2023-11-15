using Lanchonete_2._0.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Lanchonete_2._0
{
    public partial class TelaInicio : Form
    {
        public TelaInicio()
        {
            InitializeComponent();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TipoPerfil a = new TipoPerfil();
            a.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            TelaLogin a = new TelaLogin();
            a.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
