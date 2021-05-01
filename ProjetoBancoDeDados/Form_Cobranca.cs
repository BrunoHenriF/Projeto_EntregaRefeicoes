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
    public partial class Form_Cobranca : Form
    {
        public Form_Cobranca()
        {
            InitializeComponent();
        }

        private void rdbtn_dinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtn_dinheiro.Checked == true)
            {
                grp_troco.Visible = true;
            }
        }

        private void chkbox_troconao_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbox_troconao.Checked == true)
            {
                txt_troco.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox6.ReadOnly = true;

                //query
            }
            else
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = false;
                textBox3.ReadOnly = false;
                textBox4.ReadOnly = false;
                textBox6.ReadOnly = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox5.ReadOnly = true;
                textBox8.ReadOnly = true;
                textBox9.ReadOnly = true;
                textBox7.ReadOnly = true;

                //query
            }
            else
            {
                textBox5.ReadOnly = false;
                textBox8.ReadOnly = false;
                textBox9.ReadOnly = false;
                textBox7.ReadOnly = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_FimDaCompra f = new Form_FimDaCompra();
            f.ShowDialog();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
