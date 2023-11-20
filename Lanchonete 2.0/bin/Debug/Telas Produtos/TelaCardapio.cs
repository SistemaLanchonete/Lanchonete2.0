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
    public partial class TelaCardapio : Form
    {
        public TelaCardapio()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForm(new Pag1()); // abre a janela na mesma janela
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForm(new Pag2());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildForm(new Pag3());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForm(new Pag4());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {//VIDEO
            // Fecha o formulário ativo atual
            if (activeForm != null)
                activeForm.Close();
            // Define o formulário filho como o formulário ativo
            activeForm = childForm;
            // Desabilita a criação automática de uma janela superior para o formulário filho
            childForm.TopLevel = false;
            // Remove a borda do formulário filho para ter um design sem bordas
            childForm.FormBorderStyle = FormBorderStyle.None;
            // Preenche o formulário filho para ocupar completamente o espaço disponível no painel
            childForm.Dock = DockStyle.Fill;


            // Adiciona o formulário filho ao painel
            panelChildForm.Controls.Add(childForm);
            // Define o formulário filho como uma referência no painel
            panelChildForm.Tag = childForm;
            // Move o formulário filho para a frente, tornando-o visível
            childForm.BringToFront();
            // Exibe o formulário filho
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TelaCarrinho a = new TelaCarrinho();
            a.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
