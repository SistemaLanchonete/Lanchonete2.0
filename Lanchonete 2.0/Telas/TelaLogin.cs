using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_2._0.Telas
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }
        public string Pergunta { get; set; }
        public bool LembrarSenha { get; set; }
        List<LembraSenha> respostas = new List<LembraSenha>();

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string email = tx_email.Text.Trim();

            if (IsValidEmail(email))
            {
                MessageBox.Show("Salvo com Sucesso!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (bt_salvar.Enabled)
                {
                    bt_cardapio.Enabled = true;
                    bt_salvar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("O e-mail não é válido. Por favor, insira um e-mail válido.", "Validação de E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool IsValidEmail(string email)
        {
            // Esta expressão regular verifica se o formato do e-mail é válido
            string pattern = @"([A-z]+@[A-z]+\.[A-z\.]{2,5})$"; // esse é o Regex (uma regra de endereço eletronico)    
            Regex regex = new Regex(pattern);

            return regex.IsMatch(email);
        }
        private void bt_cardapio_Click(object sender, EventArgs e)
        {

            TelaCardapio a = new TelaCardapio();
            a.ShowDialog();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LembraSenha resposta = new LembraSenha();
            {

                if (checkBox1.Checked)
                {
                    respostas.Add(resposta);
                }
                foreach (var respostass in respostas)
                {
                    Console.WriteLine($"Resposta: {respostas.ToString()}");
                    tx_senha.Text = respostass.ToString();
                }

            }
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            tx_senha.UseSystemPasswordChar = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tx_senha.UseSystemPasswordChar = !tx_senha.UseSystemPasswordChar;

            // Permite alternar entre a exibição e ocultação da senha cada vez que é chamada
            // tx_senha é uma instância do controle TextBox onde o usuário insere a senha.
            // UseSystemPasswordChar verifica se é true ou false a vizualização
        }
    }
}
