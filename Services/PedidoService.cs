using LojaVirtual.Builders;
using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LojaVirtual.Services
{
    public class PedidoService
    {
        public Pedido CriarPedido()
        {
            return new PedidoBuilder()
                .comNomeCliente("Thiago Silva")
                .comProduto("PC")
                .comQuantidade(2)
                .comValorUnitario(15.45)
                .comTotal()
                .build();
            
            
        }
    }
}
