﻿using System;
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
    public partial class Form_TataDelivery : Form
    {
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

        private void txt_barradebusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}