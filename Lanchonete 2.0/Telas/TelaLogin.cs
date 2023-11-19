using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lanchonete_2._0.Telas
{
    public partial class TelaLogin : Form
    {
        private const string pasta = @"C:\Users\Family Torrente\Desktop\Noia.Text";
        private const string arquivoClientes = "ArquivoCliente.txt";
        bool emailEncontrado = true;
        public TelaLogin()
        {
            InitializeComponent();
        }
        
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string email = tx_email.Text.Trim();
            string senha = tx_senha.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha)) // aviso de campo em branco
            {
                MessageBox.Show("Por favor, insira um email e uma senha válidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsValidEmail(email))
            {
                try
                {
                    if (UsuarioJaCadastrado(arquivoClientes, email, senha))
                    {
                        MessageBox.Show("Usuário existente");
                        bt_cardapio.Enabled = true;
                    }
                   
                    else if (arquivoClientes != tx_email.Text) // Aviso de Senha errada
                    {
                        
                        MessageBox.Show("Senha Incorreta!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        bt_cardapio.Enabled = false;
                        return;
                    }
  
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                MessageBox.Show("O e-mail não é válido. Por favor, insira um e-mail válido.", "Validação de E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UsuarioJaCadastrado(string arquivo, string email, string senha)
        {
            try
            {
                if (File.Exists(Path.Combine(pasta, arquivo)))
                {
                    foreach (var linha in File.ReadLines(Path.Combine(pasta, arquivo)))
                    {
                        if (linha.Contains($"Email: {email}"))
                        {
                            emailEncontrado = true;
                        }
                        else if (linha.Contains($"Senha: {senha}"))
                        {
                          
                            if (arquivoClientes == senha)
                            {
                                MessageBox.Show("Email Incorreto");
                            }
                            else
                            {
                                MessageBox.Show("Login bem-sucedido!");
                                return true;
                            }
                        }
                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar se o usuário já está cadastrado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"([A-z]+@[A-z]+\.[A-z\.]{2,5})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void bt_cardapio_Click(object sender, EventArgs e)
        {
            TelaCardapio a = new TelaCardapio();
            a.ShowDialog();
        }

        private void TelaLogin_Load(object sender, EventArgs e)
        {
            tx_senha.UseSystemPasswordChar = true;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            tx_senha.UseSystemPasswordChar = !tx_senha.UseSystemPasswordChar;
        }

       
    }
}
