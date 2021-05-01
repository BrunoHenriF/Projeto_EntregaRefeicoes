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
    public partial class Form_CadastroPrato : Form
    {
        public Form_CadastroPrato()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                var prato = new Pratos()
                {
                    Nome = txt_nome.Text,
                    Descricao = txt_descricao.Text,
                    Cnpj = txt_CNPJ.Text,
                    Preco = txt_preco.Text,
                    Cod_prato = txt_codigo.Text,
                    Disponibilidade = txt_disponibilidade.Text
                };
                conexaoBD.Execute("INSERT INTO dbo.PRATOS(NOME,DESCRICAO,DISPONIBILIDADE,COD_PRATO,CNPJ,PRECO) VALUES (@Nome, @Descricao, @Disponibilidade,@Cod_prato, @Cnpj, @Preco )", prato);

                MessageBox.Show("Prato cadastrado com sucesso!");
                this.Close();
            }
        }
    }
}
