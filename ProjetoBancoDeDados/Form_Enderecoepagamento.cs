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
    public partial class Form_Enderecoepagamento : Form
    {
        string cpf_user;
        public Form_Enderecoepagamento(string cpf)
        {
            InitializeComponent();
            cpf_user = cpf;
        }
        bool flag;
        private void Chkbox_cartao_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkbox_cartao.Checked)
            {
                txt_validade.Enabled = false;
                txt_numetitular.Enabled = false;
                txt_cvv.Enabled = false;
                msktxt_numcartao.Enabled = false;
                flag = false;
            }
            else
            {
                txt_validade.Enabled = true;
                txt_numetitular.Enabled = true;
                txt_cvv.Enabled = true;
                msktxt_numcartao.Enabled = true;
                flag = true;
            }
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                
                var cartao = new Cartao()
                {
                    Nome = txt_numetitular.Text,
                    Numero = msktxt_numcartao.Text,
                    Validade = txt_validade.Text,
                    CVV = txt_cvv.Text,
                    CPF = cpf_user
                };
                conexaoBD.Execute("INSERT INTO dbo.CARTAO(NOME, NUMERO, VALIDADE, CVV, CPF) VALUES (@Nome,@Numero,@Validade,@CVV,@CPF)", cartao);
                

                var endereco = new Endereco()
                {
                    Estado = cbbox_estado.Text,
                    Cidade = txt_cidade.Text,
                    CPF = cpf_user,
                    Rua = txt_rua.Text,
                    Numero = txt_numero.Text,
                    CEP = txt_cep.Text,
                    Complemento = txt_complemento.Text
                };

                conexaoBD.Execute("INSERT INTO  dbo.ENDERECO(ESTADO,CIDADE,CPF_USER,RUA,NUMERO,CEP,COMPLEMENTO) VALUES (@Estado, @Cidade, @CPF,@Rua,@Numero,@CEP,@Complemento)", endereco);
            }
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
