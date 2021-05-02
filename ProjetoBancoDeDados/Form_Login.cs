using Dapper;
using ProjetoBancoDeDados.Models;
using System;
using System.Collections;
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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        string senha_digitada, senha_banco, cpf;

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            cpf = txt_CPF_login.Text;
            senha_digitada = txt_senha_login.Text;

            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                IEnumerable logins = conexaoBD.Query<Login>("SELECT SENHA FROM LOGIN WHERE CPF = '" + cpf + "'");
                foreach (Login login in logins)
                {
                    senha_banco = login.Senha;
                }
            }

            if (senha_digitada == senha_banco)
            {
                Cliente_logado obj = new Cliente_logado();
                obj.CPF = txt_CPF_login.Text;
                Form_TataDelivery.Dados.Add(obj);

                MessageBox.Show("Login efetuado com sucesso!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
