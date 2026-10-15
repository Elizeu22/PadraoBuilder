using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LojaVirtual.Models
{
    public class Pedido
    {
        public string NomeCliente { get; set; }

        public string Produto { get; set; }

        public int Quantidade { get; set; } 

        public double ValorUnitario { get; set; }

        public double Total { get; set; }

    }
}
