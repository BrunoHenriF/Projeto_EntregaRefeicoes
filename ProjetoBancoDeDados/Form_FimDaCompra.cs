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
    public partial class Form_FimDaCompra : Form
    {
        public Form_FimDaCompra()
        {
            InitializeComponent();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
