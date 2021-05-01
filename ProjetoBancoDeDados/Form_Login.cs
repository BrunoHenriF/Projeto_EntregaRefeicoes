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

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            //string conexao = ConfigurationManager.ConnectionStrings["conexao"].ConnectionString;
            //using (var conexaoBD = new SqlConnection(conexao))
            //{
            //    IEnumerable clientes = conexaoBD.Query<Cliente>("Select NOME, SENHA from Cliente");
            //    foreach (Cliente cliente in clientes)
            //    {
                    
            //    }
            //} 

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
