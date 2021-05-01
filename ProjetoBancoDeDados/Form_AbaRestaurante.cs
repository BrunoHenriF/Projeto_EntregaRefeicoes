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
    public partial class Form_AbaRestaurante : Form
    {

        public Form_AbaRestaurante(string selecionado)
        {
            InitializeComponent();
            
            lbl_nomerest.Text = selecionado;


            listbox_pratos.Items.Clear();
            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                IEnumerable pratos = conexaoBD.Query<Pratos>("select distinct(NOME), PRECO FROM RESTAURANTE as A inner JOIN PRATOS as b on A.CNPJ = B.CNPJ where NOME_FANT like '%" + selecionado + "%' order by preco");
                foreach (Pratos prato in pratos)
                {
                    listbox_pratos.Items.Add(prato.Nome + "   R$" + prato.Preco);
                }
            }
        }
        
        private void btn_comprar_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Cobranca f = new Form_Cobranca();
            f.ShowDialog();
        }

        private void listbox_pratos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
