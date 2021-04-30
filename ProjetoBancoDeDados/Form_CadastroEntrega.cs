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
    public partial class Form_CadastroEntrega : Form
    {
        public Form_CadastroEntrega()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;             
            using (var conexaoBD = new SqlConnection(conexao))
            {
                var entregador = new Entregador()
                {
                    CPF = msktxt_cpf.Text,
                    Nome = txt_nome.Text,
                    Placa = msktxt_placa.Text,
                    CNH = msktxt_cnh.Text 
                };

                conexaoBD.Execute("INSERT INTO dbo.ENTREGADOR(NOME, PLACA, CPF, NUM_CNH) VALUES (@Nome, @Placa, @CPF, @CNH)", entregador);
            }
        }
    }
}
