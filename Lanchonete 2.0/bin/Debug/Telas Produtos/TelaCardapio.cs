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
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);  // define o local onde ira abrir
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            TelaCarrinho a = new TelaCarrinho();
            a.ShowDialog();
        }
    }
}
