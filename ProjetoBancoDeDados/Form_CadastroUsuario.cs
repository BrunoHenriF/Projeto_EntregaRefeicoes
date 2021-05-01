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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                var cliente = new Cliente()
                {
                    Nome = txt_nome.Text,
                    Tel = txt_telefone.Text,
                    CPF = masktxt_cpf.Text,
                    Email = txt_email.Text
                };

                conexaoBD.Execute("INSERT INTO dbo.CLIENTE(NOME, TEL, CPF, EMAIL) VALUES (@Nome, @Tel, @CPF, @Email)", cliente);
            }

            this.Close();

            Form_Enderecoepagamento f = new Form_Enderecoepagamento();
            f.ShowDialog();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
