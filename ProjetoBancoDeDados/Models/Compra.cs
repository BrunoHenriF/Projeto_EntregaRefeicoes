using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Models
{
    class Compra
    {
        public string Meio_pagamento { get; set; }
        public string Endereco_entrega { get; set; }
        public string Placa_entregador { get; set; }
        public string Cod_prato { get; set; }
        public string CNPJ_restaurante { get; set; }
    }
}
