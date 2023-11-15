using Lanchonete_2._0.Classes;
using Lanchonete_2._0.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lanchonete_2._0
{
    public partial class Tela_Cadastro_funcionario : Form
    {
        public Tela_Cadastro_funcionario()
        {
            InitializeComponent();
            lb_cpf.Text = "";
           lb_email_invalido.Text = "";
            lb_senha_invalido.Text = "";
        }
          
        private void bt_salvar_cadrastro_Click(object sender, EventArgs e)
        {
            string pasta = @"C:\Users\Family Torrente\Desktop\Noia.Text";

            // Verifica se a pasta existe ou a cria se não existir
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Obtém o caminho completo do arquivo de texto dentro da pasta
            string caminhoArquivo = Path.Combine(pasta, "ArquivoFuncionario.txt");

            try
            {
                // Cria um link para a pasta e escreve no arquivo de texto
                using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
                {
                    writer.WriteLine();// Escreve o link da pasta
                    writer.WriteLine(pasta);

                    // Escreve os dados da pessoa
                    writer.WriteLine($"Nome: {tx_nome.Text}");
                    writer.WriteLine($"CPF: {tx_cpf.Text}");
                    writer.WriteLine($"Senha: {tx_senha.Text}");
                    writer.WriteLine($"Email: {tx_Conf_email.Text}");
                    writer.WriteLine();
                }

                MessageBox.Show("Link da pasta e dados da pessoa salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o link da pasta e dados da pessoa: {ex.Message}");
            }


            Pessoa pessoa = new Pessoa();
            string cpf = tx_cpf.Text;

            try
            {
                ValidaCpf validarCpf = new ValidaCpf();
                if (validarCpf.ValidaCPF(cpf))
                {
                    lb_cpf.Visible = false;
                    pessoa.Cpf = cpf;
                }
                else
                {
                    lb_cpf.ForeColor = Color.Red;
                    lb_cpf.Text = "CPF é inválido";
                    tx_cpf.Clear();
                    Console.ResetColor();
                }
            }
            catch (Exception ex)
            {
                // Tratar a exceção, se necessário
                Console.WriteLine($"Erro ao validar CPF: {ex.Message}");
            }

            if (tx_senha.Text == tx_Conf_senha.Text)
            {

                MessageBox.Show(tx_nome.Text + " " + tx_cpf.Text + " " + label1.Text + " " + tx_senha.Text + " " + tx_Conf_senha.Text);


            }
            else
            {
                lb_senha_invalido.ForeColor = Color.Red;
                lb_senha_invalido.Text = "As senha não são as mesmas!";
            }

            if (label1.Text == tx_Conf_email.Text)
            {

                MessageBox.Show(tx_nome.Text + " " + tx_cpf.Text + " " + label1.Text + " " + tx_senha.Text + " " + tx_Conf_senha.Text + " " + tx_Conf_email.Text);
            }
            else
            {
                lb_email_invalido.ForeColor = Color.Red;
                lb_email_invalido.Text = "0s Emails não são os mesmos!";
            }
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
            cb_cargos.Items.Remove(cb_cargos.SelectedItem);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
