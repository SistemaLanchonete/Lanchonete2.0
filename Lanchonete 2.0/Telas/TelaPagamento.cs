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
    public partial class TelaPagamento : Form
    {
        public TelaPagamento(double valorTotal)
        {
            InitializeComponent();
            lb_total_paga.Text = valorTotal.ToString("R$ 0.00");
        }
        private bool pagamentoRealizado = false;

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Enabled == true)
            {
                checkBox1.Enabled = false;
            }
        }

        private void lb_total_paga_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Enabled == true)
            {
                checkBox2.Enabled = false;
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2Button1.Enabled)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            if (!checkBox1.Enabled)
            {
                checkBox1.Enabled = true;
                checkBox1.Checked = false;
            }
            else
            {
                checkBox2.Enabled = true;
                checkBox2.Checked = false;
            }
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                MessageBox.Show("Pagamento realizado com Sucesso! Bom Apetite!");
                lb_total_paga.Text = "R$ 0,00";
                pagamentoRealizado = true;
                guna2Button1.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
            }

            else
            {
                MessageBox.Show("Selecione uma forma de Pagamento!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaCardapio a = new TelaCardapio();
            a.ShowDialog();
        }

        private void TelaPagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
