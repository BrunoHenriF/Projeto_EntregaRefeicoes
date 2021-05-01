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
        Dictionary<string, double> preco = new Dictionary<string, double>();
        Dictionary<string, string> descricao = new Dictionary<string, string>();
        //Dictionary<string, string> nomes = new Dictionary<string, string>();
        //Dictionary<string, bool> disponibilidade = new Dictionary<string, bool>();
        string nome_prato_selec, item_lista;

        double preco_prato, total = 0;

        public Form_AbaRestaurante(string selecionado)
        {
            InitializeComponent();
            
            lbl_nomerest.Text = selecionado;
            listbox_pratos.Items.Clear();

            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                IEnumerable pratos = conexaoBD.Query<Pratos>("select distinct(NOME),(PRECO), DESCRICAO FROM RESTAURANTE as A inner JOIN PRATOS as b on A.CNPJ = B.CNPJ where NOME_FANT like '%" + selecionado + "%' order by preco");
                foreach (Pratos prato in pratos)
                {
                    preco.Add(prato.Nome, Double.Parse(prato.Preco));
                    descricao.Add(prato.Nome, prato.Descricao);

                    listbox_pratos.Items.Add(prato.Nome + "   R$" + prato.Preco);
                }
            }
        }
        

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            item_lista = listbox_pratos.SelectedItem.ToString();

            nome_prato_selec = item_lista.Substring(0, item_lista.Length - 7);
            listBox_item.Items.Add(nome_prato_selec);
            listBox_preco.Items.Add(preco[nome_prato_selec]);

            preco_prato = preco[nome_prato_selec];

            total += preco_prato;
            txt_total.Text = total.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Cobranca f = new Form_Cobranca(total);
            f.ShowDialog();
        }

        private void listbox_pratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            item_lista = listbox_pratos.SelectedItem.ToString();

            nome_prato_selec = item_lista.Substring(0, item_lista.Length - 7);
            txt_descricao.Text = descricao[nome_prato_selec];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
