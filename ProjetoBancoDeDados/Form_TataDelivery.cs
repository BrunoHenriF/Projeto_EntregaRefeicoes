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
    public partial class Form_TataDelivery : Form
    {
        public static List<Cliente_logado> Dados = new List<Cliente_logado>();
        
        public Form_TataDelivery()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_CadastroUsuario f = new Form_CadastroUsuario();
            f.ShowDialog();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            f.ShowDialog();
        }

        private void btn_cadastroloja_Click(object sender, EventArgs e)
        {
            Form_CadastroLoja f = new Form_CadastroLoja();
            f.ShowDialog();
        }

        private void btn_cadastromotoboy_Click(object sender, EventArgs e)
        {
            Form_CadastroEntrega f = new Form_CadastroEntrega();
            f.ShowDialog();

        }
        
        string filtro, texto, query_busca, selecionado;

        private void txt_barradebusca_TextChanged(object sender, EventArgs e)
        {
            if (radbtn_preco.Checked == true)
            {
                texto = txt_barradebusca.Text;
                query_busca = "select distinct(NOME_FANT) FROM RESTAURANTE as A inner JOIN PRATOS as b on A.CNPJ = B.CNPJ where PRECO <=" + texto;
                lbl_teste.Text = query_busca;
            }
            else
            {
                texto = txt_barradebusca.Text;
                query_busca = filtro + "'%" + texto + "%'";
                lbl_teste.Text = query_busca;
            }
        }

        private void radbtn_prato_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_prato.Checked == true)
            {
                filtro = "select NOME_FANT FROM RESTAURANTE as A inner JOIN PRATOS as b on A.CNPJ = B.CNPJ where NOME like ";
            }
        }

        private void radbtn_nome_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_nome.Checked == true)
            {
                filtro = "select (NOME_FANT) from RESTAURANTE where NOME_FANT like";
            }
        }

        private void radbtn_culinaria_CheckedChanged(object sender, EventArgs e)
        {
            if (radbtn_culinaria.Checked == true)
            {
                filtro = "select (NOME_FANT) from RESTAURANTE where CULINARIA like";
            }
        }

        private void radbtn_preco_CheckedChanged(object sender, EventArgs e)
        {
            //if (radbtn_preco.Checked == true)
            //{

            //}
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login f = new Form_Login();
            f.ShowDialog();
        }

        private void cadastreseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroUsuario f = new Form_CadastroUsuario();
            f.ShowDialog();
        }

        private void cadastreSeuRestauranteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroLoja f = new Form_CadastroLoja();
            f.ShowDialog();
        }

        private void trabalheComoNossoEntregadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroEntrega f = new Form_CadastroEntrega();
            f.ShowDialog();

        }

        private void cadastroDePratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_CadastroPrato f = new Form_CadastroPrato();
            f.ShowDialog();
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            listbox_resultados.Items.Clear();
            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                IEnumerable restaurantes = conexaoBD.Query<Restaurante>(query_busca);
                foreach (Restaurante restaurante in restaurantes)
                {
                    listbox_resultados.Items.Add(restaurante.Nome_fant);
                }
            }

            //Form_ResultadoBusca f = new Form_ResultadoBusca();
            //f.ShowDialog();
        }

        private void listbox_resultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionado = listbox_resultados.SelectedItem.ToString();
        }

        private void btn_ir_para_restaurante_Click(object sender, EventArgs e)
        {
            Form_AbaRestaurante f = new Form_AbaRestaurante(selecionado);
            f.ShowDialog();
        }
    }
}
