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
    public partial class Form_CadastroLoja : Form
    {
        public Form_CadastroLoja()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                var restaurante = new Restaurante()
                {
                    Nome_ofi = txt_nomeoficial.Text,
                    Nome_fant = txt_nomefantasia.Text,
                    CNPJ = txt_cnpj.Text,
                    Tel = txt_telefone.Text,
                    Estado = txt_numero.Text,
                    Cidade = txt_cidade.Text,
                    Rua = txt_rua.Text,
                    Numero = txt_numero.Text,
                    Culinaria = txt_culinaria.Text
                };

                conexaoBD.Execute("INSERT INTO dbo.RESTAURANTE(NOME_OFI, NOME_FANT, CNPJ, TEL, ESTADO, " +
                    "CIDADE, RUA, NUMERO, CULINARIA) VALUES (@Nome_ofi, @Nome_fant, @CNPJ, @Tel, @Estado, @Cidade, @Rua, @Numero, @Culinaria)", restaurante);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
