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
    public partial class TelaCadastro : Form
    {
        public TelaCadastro()
        {
            InitializeComponent();
            label8.Text = "";
            label9.Text = "";
            label6.Text = "";
        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_salvar_cadrastro_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            tx_nome.Clear();
            tx_Conf_email.Clear();
            tx_senha.Clear();
            tx_cpf.Clear();
            tx_Conf_senha.Clear();
            tx_Conf_email.Clear();
            tx_Email.Clear();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
