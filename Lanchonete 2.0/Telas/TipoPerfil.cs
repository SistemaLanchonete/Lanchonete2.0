using Lanchonete_2._0.Telas;
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
    public partial class TipoPerfil : Form
    {
        public TipoPerfil()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TelaCadastro_cliente a = new TelaCadastro_cliente();
            a.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Tela_Cadastro_funcionario a = new Tela_Cadastro_funcionario();
            a.ShowDialog();
        }
    }
}
