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
    public partial class Form_FimDaCompra : Form
    {
        public Form_FimDaCompra()
        {
            InitializeComponent();

            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            using (var conexaoBD = new SqlConnection(conexao))
            {
                IEnumerable entregadores = conexaoBD.Query<Entregador>("SELECT TOP 1 NOME,PLACA FROM ENTREGADOR ORDER BY NEWID()");
                foreach (Entregador entregador in entregadores)
                {
                    txt_nomeentregador.Text = entregador.Nome;
                    txt_placa.Text = entregador.Placa;
                }
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
