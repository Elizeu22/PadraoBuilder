using LojaVirtual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Builders
{
    public class PedidoBuilder
    {
        private Pedido _pedido = new();

        public PedidoBuilder comNomeCliente(string nome) 
        {
            _pedido.NomeCliente = nome;
            return this;
        }

        public PedidoBuilder comProduto(string produto)
        {
            _pedido.Produto = produto;
            return this;
        }

        public PedidoBuilder comQuantidade(int quantidade)
        {
            _pedido.Quantidade = quantidade;
            return this;
        }

        public PedidoBuilder comValorUnitario(double valorUnitario)
        {
            _pedido.ValorUnitario = valorUnitario;
            return this;
        }

        public PedidoBuilder comTotal()
        {
            _pedido.Total = _pedido.ValorUnitario * _pedido.Quantidade;
            return this;
        }

        public Pedido build()
        {
            return _pedido;
        }
    }
}
