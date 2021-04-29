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
    public partial class Form_Enderecoepagamento : Form
    {
        public Form_Enderecoepagamento()
        {
            InitializeComponent();
        }

        private void Chkbox_cartao_CheckedChanged(object sender, EventArgs e)
        {
            if (Chkbox_cartao.Checked)
            {
                txt_cvv.Enabled = false;
                txt_numetitular.Enabled = false;
                txt_validade.Enabled = false;
                msktxt_numcartao.Enabled = false;
            }
            else
            {
                txt_cvv.Enabled = true;
                txt_numetitular.Enabled = true;
                txt_validade.Enabled = true;
                msktxt_numcartao.Enabled = true;
            }

        }
    }
}
