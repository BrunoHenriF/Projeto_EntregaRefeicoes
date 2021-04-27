using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBancoDeDados
{
    public partial class Form_CadastroUsuario : Form
    {
        public Form_CadastroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            Form_Enderecoepagamento f = new Form_Enderecoepagamento();
            f.ShowDialog();
        }
    }
}
