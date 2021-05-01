using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBancoDeDados.Models
{
    class Cartao
    {
        public string Nome { get; set; }
        public string Numero { get; set; }
        public string Validade { get; set; }
        public string CVV { get; set; }
        public string CPF { get; set; }
    }
}
