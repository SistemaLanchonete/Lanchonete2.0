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

namespace Lanchonete_2._0.Telas
{
    public partial class TelaCadastro_cliente : Form
    {
        public TelaCadastro_cliente()
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
            string pasta = @"C:\Users\Family Torrente\Desktop\Noia.Text";

            // Verifica se a pasta existe ou a cria se não existir
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Obtém o caminho completo do arquivo de texto dentro da pasta
            string caminhoArquivo = Path.Combine(pasta, "ArquivoCliente.txt");

            try
            {
                // Cria um link para a pasta e escreve no arquivo de texto
                using (StreamWriter writer = new StreamWriter(caminhoArquivo, true)) // O segundo parâmetro "true" indica modo de adição
                {
                    writer.WriteLine();
                    // Escreve os dados da pessoa
                    writer.WriteLine($"Nome: {tx_nome.Text}");
                    writer.WriteLine($"CPF: {tx_cpf.Text}");
                    writer.WriteLine($"Senha: {tx_senha.Text}");
                    writer.WriteLine($"Email: {tx_Conf_email.Text}");

                    writer.WriteLine();
                }

                MessageBox.Show("Dados da pessoa adicionados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao adicionar dados da pessoa: {ex.Message}");
            }



            Pessoa pessoa = new Pessoa();
            string cpf = tx_cpf.Text;

            try
            {
                ValidaCpf validarCpf = new ValidaCpf();
                if (validarCpf.ValidaCPF(cpf))
                {
                    label6.Visible = false;
                    pessoa.Cpf = cpf;
                }
                else
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "CPF é inválido";
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
                label8.ForeColor = Color.Red;
                label8.Text = "As senha não são as mesmas!";
            }

            if (label1.Text == tx_Conf_email.Text)
            {

                MessageBox.Show(tx_nome.Text + " " + tx_cpf.Text + " " + label1.Text + " " + tx_senha.Text + " " + tx_Conf_senha.Text + " " + tx_Conf_email.Text);
            }
            else
            {
                label9.ForeColor = Color.Red;
                label9.Text = "0s Emails não são os mesmos!";
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
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TelaCadastro_cliente_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
