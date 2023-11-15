using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_2._0.Telas
{
    public partial class TelaLogin : Form
    {
        private const string pasta = @"C:\Users\Family Torrente\Desktop\Noia.Text";
        private const string arquivoClientes = "ArquivoCliente.txt";

        public TelaLogin()
        {
            InitializeComponent();
        }

        private bool VerificarCredenciais(string email, string senha)
        {
            string caminhoArquivo = Path.Combine(pasta, arquivoClientes);

            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    // Lê as linhas do arquivo uma por uma
                    foreach (var linha in File.ReadLines(caminhoArquivo))
                    {
                        // Verifica se a linha contém o email e a senha
                        if (linha.Contains($"Email: {email}") && linha.Contains($"Senha: {senha}"))
                        {
                            // Credenciais correspondem, login bem-sucedido
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar credenciais: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_salvar_Click(object sender, EventArgs e)
        {
            string email = tx_email.Text.Trim();
            string senha = tx_senha.Text;

            if (IsValidEmail(email))
            {
                try
                {
                    // Verifica se o usuário já existe no arquivo
                    if (UsuarioJaCadastrado(arquivoClientes, email))
                    {
                        MessageBox.Show("Usuário já cadastrado. Faça login.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        bt_cardapio.Enabled = true;
                    }
                    else
                    {
                        // Cria um link para a pasta e escreve no arquivo de texto
                        using (StreamWriter writer = new StreamWriter(Path.Combine(pasta, arquivoClientes), true))
                        {
                            // Escreve os dados do usuário
                            writer.WriteLine($"Email: {email}");
                            writer.WriteLine($"Senha: {senha}");
                            writer.WriteLine();
                        }

                        MessageBox.Show("Cadastro realizado com sucesso!");
                        bt_cardapio.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar dados do usuário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("O e-mail não é válido. Por favor, insira um e-mail válido.", "Validação de E-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool UsuarioJaCadastrado(string arquivo, string email)
        {
            try
            {
                // Verifica se o arquivo existe
                if (File.Exists(Path.Combine(pasta, arquivo)))
                {
                    // Lê as linhas do arquivo uma por uma
                    foreach (var linha in File.ReadLines(Path.Combine(pasta, arquivo)))
                    {
                        // Verifica se a linha contém o email
                        if (linha.Contains($"Email: {email}"))
                        {
                            // Usuário já cadastrado
                            return true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar se o usuário já está cadastrado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Usuário não cadastrado ou ocorreu um erro
            return false;
        }

        private bool IsValidEmail(string email)
        {
            // Esta expressão regular verifica se o formato do e-mail é válido
            string pattern = @"([A-z]+@[A-z]+\.[A-z\.]{2,5})$";
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
            TipoPerfil a = new TipoPerfil();
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

        private void tx_senha_TextChanged(object sender, EventArgs e)
        {
            // Se desejar fazer algo quando o texto da senha for alterado, adicione o código aqui
        }
    }
}
