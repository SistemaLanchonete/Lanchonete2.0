using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace Lanchonete_2._0.Telas
{
    public partial class TelaLogin : Form
    {
        private const string pasta = @"C:\Users\tayna_97l6kwx\OneDrive\Imagens\Dados.TEXT";
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
                   
                    else if (arquivoClientes != tx_email.Text) // Aviso de EMAIL errado
                    {
                        
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
            { // Combina o caminho do arquivo usando o diretório 'pasta' e o nome do arquivo 'arquivo'
                string caminhoArquivo = Path.Combine(pasta, arquivo);

                // Verifica se o arquivo existe
                if (File.Exists(caminhoArquivo))
                {// Abre o arquivo para leitura
                    using (StreamReader reader = new StreamReader(caminhoArquivo))
                    {
                        string linha;
                        string emailSalvo = "";
                        string senhaSalva = "";

                        while ((linha = reader.ReadLine()) != null)
                        {
                            // Verifica se a linha contém "Email:"
                            if (linha.Contains("Email:"))
                            {
                                // Extrai o email da linha
                                emailSalvo = linha.Split(':')[1].Trim();
                            }
                            else if (linha.Contains("Senha:"))
                            {
                                // Extrai a senha da linha
                                senhaSalva = linha.Split(':')[1].Trim();
                            }

                            // Verifica se encontrou o usuário
                            if (!string.IsNullOrEmpty(emailSalvo) && !string.IsNullOrEmpty(senhaSalva))
                            {
                                if (emailSalvo == email && senhaSalva == senha)
                                {

                                    return true;
                                }

                                // Reinicia as variáveis para a próxima iteração
                                emailSalvo = "";
                                senhaSalva = "";
                            }
                        }
                    }                    
                    MessageBox.Show("Email ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    MessageBox.Show("Arquivo não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao verificar se o usuário já está cadastrado: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private bool IsValidEmail(string email)
        {//micro
            string pattern = @"([A-z0-9]+@[A-z]+\.[A-z\.]{2,5})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);

            // ([A-z0-9]+) =é uma parte de uma expressão regular que corresponde a uma sequência de um ou mais caracteres alfanuméricos(onjunto de caracteres alfabéticos e numéricos,). 
            // ([A-z]+) = Isso corresponde a um ou mais caracteres alfabéticos (letras de A a Z, maiúsculas ou minúsculas) após o "@".
            // ([A-z\.]{2,5}) = é a extensão do dominio com .com, .org
        }
        private void bt_cardapio_Click(object sender, EventArgs e)
        {
            TelaCardapio a = new TelaCardapio();
            a.ShowDialog();
        }
        private void TelaLogin_Load(object sender, EventArgs e)
        {
            tx_senha.UseSystemPasswordChar = true; // Cobri a visão da senha
        }
        private void guna2Button1_Click(object sender, EventArgs e) // botão do olho
        {
            tx_senha.UseSystemPasswordChar = !tx_senha.UseSystemPasswordChar; //se a senha for exposta, sera revelado
        } 
    }
}
