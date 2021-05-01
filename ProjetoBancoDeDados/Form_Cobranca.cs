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
                //Form_TataDelivery.Dados[0];

    public partial class Form_Cobranca : Form
    {
        public Form_Cobranca(double total)
        {
            InitializeComponent();
            lbl_valor.Text = "R$ " + total.ToString();
        }

        
        private void rdbtn_dinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_dinheiro.Checked == true)
            {
                grp_troco.Visible = true;

            }
        }

        private void chkbox_troconao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_troconao.Checked == true)
            {
                txt_troco.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_num.ReadOnly = true;
                txt_complemento.ReadOnly = true;
                txt_rua.ReadOnly = true;
                txt_cidade.ReadOnly = true;
                txt_cep.ReadOnly = true;

                string cpf = Form_TataDelivery.Dados[0].CPF;
                string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
                using (var conexaoBD = new SqlConnection(conexao))
                {
                    IEnumerable enderecos = conexaoBD.Query<Endereco>("select estado,cidade,rua,numero,cep,complemento FROM ENDERECO as A inner JOIN LOGIN as b on A.CPF_user = B.CPF WHERE B.CPF = '" + cpf + "'");
                    foreach (Endereco endereco in enderecos)
                    {
                        txt_cep.Text = endereco.CEP;
                        txt_cidade.Text = endereco.Cidade;
                        txt_estado.Text = endereco.Estado;
                        txt_num.Text = endereco.Numero;
                        txt_rua.Text = endereco.Rua;
                        txt_complemento.Text = endereco.Complemento;
                    }
                }
                //query = select estado,cidade,rua,numero,cep,complemento FROM ENDERECO as A inner JOIN LOGIN as b on A.CPF_user = B.CPF WHERE B.CPF like '%%'
            }
            else
            {
                txt_num.ReadOnly = false;
                txt_complemento.ReadOnly = false;
                txt_rua.ReadOnly = false;
                txt_cidade.ReadOnly = false;
                txt_cep.ReadOnly = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txt_nometitular.ReadOnly = true;
                txt_numero.ReadOnly = true;
                txt_cvv.ReadOnly = true;
                txt_validade.ReadOnly = true;

                string cpf = Form_TataDelivery.Dados[0].CPF;
                string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
                using (var conexaoBD = new SqlConnection(conexao))
                {
                    IEnumerable cartoes = conexaoBD.Query<Cartao>("select NOME,NUMERO,VALIDADE,CVV FROM CARTAO as A inner JOIN LOGIN as b on A.CPF = B.CPF WHERE B.CPF = '" + cpf + "'");
                    foreach (Cartao cartao in cartoes)
                    {
                        txt_nometitular.Text = cartao.Nome;
                        txt_numero.Text = cartao.Numero;
                        txt_validade.Text = cartao.Validade;
                        txt_cvv.Text = cartao.CVV;
                    }
                }
            }
            else
            {
                txt_nometitular.ReadOnly = false;
                txt_numero.ReadOnly = false;
                txt_cvv.ReadOnly = false;
                txt_validade.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_FimDaCompra f = new Form_FimDaCompra();
            f.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radio_online_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_online.Checked == true)
            {
            }
        }

        private void radio_entrega_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_entrega.Checked == true)
            {
                txt_nometitular.ReadOnly = true;
                txt_numero.ReadOnly = true;
                txt_cvv.ReadOnly = true;
                txt_validade.ReadOnly = true;
            }
            else
            {
                txt_nometitular.ReadOnly = false;
                txt_numero.ReadOnly = false;
                txt_cvv.ReadOnly = false;
                txt_validade.ReadOnly = false;
            }
        }
    }
}
