using Lanchonete_2._0.Classes;
using Lanchonete_2._0.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.DesignerServices;
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
            string pasta = @"C:\Users\tayna_97l6kwx\OneDrive\Imagens\Dados.TEXT";

            // Verifica se a pasta existe ou a cria se não existir
            if (!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            // Obtém o caminho completo do arquivo de texto dentro da pasta
            string caminhoArquivo = Path.Combine(pasta, "ArquivoFuncionario.txt");
            Funcionario b = new Funcionario();
            b.Nome = tx_nome.Text;
            b.Cpf = tx_cpf.Text;
            b.Senha = tx_senha.Text;
            b.Email = tx_Email.Text;
            b.Sexo = (string)cb_sexo_fun.SelectedItem;

            try
            {             
                // Cria um link para a pasta e escreve no arquivo de texto
               using (StreamWriter writer = new StreamWriter(caminhoArquivo, true))
                {
      
                    // Escreve os dados da pessoa
                    writer.WriteLine($"\nNome: {b.Nome}");
                    writer.WriteLine($"CPF: {b.Cpf}");
                    writer.WriteLine($"Senha: {tx_senha.Text}");
                    writer.WriteLine($"Email: {tx_Email.Text}");
                    writer.WriteLine($"Data nascimento: {tx_data_fun.Text}"); 
                    writer.WriteLine($"Cargo: {cb_cargos_fun.SelectedItem}");
                    writer.WriteLine($"Sexo: {b.Sexo}");
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

            if (tx_Email.Text == tx_Conf_email.Text)
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
            cb_cargos_fun.Items.Remove(cb_cargos_fun.SelectedItem);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tx_data_fun_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tx_Conf_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cb_sexo_fun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tx_Conf_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void tx_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_email_invalido_Click(object sender, EventArgs e)
        {

        }

        private void lb_senha_invalido_Click(object sender, EventArgs e)
        {

        }

        private void lb_cpf_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tx_cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_cargos_fun_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Cadastro_funcionario_Load(object sender, EventArgs e)
        {

        }
    }
}
