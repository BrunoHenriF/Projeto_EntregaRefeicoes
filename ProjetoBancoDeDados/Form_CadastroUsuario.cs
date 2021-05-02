using Dapper;
using ProjetoBancoDeDados.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBancoDeDados
{
    public partial class Form_CadastroUsuario : Form
    {
        public Form_CadastroUsuario()
        {
            InitializeComponent();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            string cpf;

            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                var cliente = new Cliente()
                {
                    Nome = txt_nome.Text,
                    Tel = txt_telefone.Text,
                    CPF = masktxt_cpf.Text,
                    Email = txt_email.Text,
                    RG = txt_rg.Text,
                    Sobrenome = txt_sobrenome.Text
                };

                conexaoBD.Execute("INSERT INTO dbo.CLIENTE(NOME, TEL, CPF, EMAIL, RG, SOBRENOME) VALUES (@Nome, @Tel, @CPF, @Email, @RG, @Sobrenome)", cliente);

                var login = new Login()
                {
                    Senha = txt_senha.Text,
                    CPF = masktxt_cpf.Text,
                };

                conexaoBD.Execute("INSERT INTO dbo.LOGIN(CPF, SENHA) VALUES (@CPF, @Senha)", login);
            }

            MessageBox.Show("Cadastro de cliente efetuado com sucesso!");
            this.Close();

            cpf = masktxt_cpf.Text;
            Form_Enderecoepagamento f = new Form_Enderecoepagamento(cpf);
            f.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
