
using LojaVirtual;
using LojaVirtual.Models;
using LojaVirtual.Services;

PedidoService pedidoService = new PedidoService();

Pedido pedido = pedidoService.CriarPedido();

Console.WriteLine(pedido.NomeCliente);
Console.WriteLine(pedido.Produto);
Console.WriteLine(pedido.Quantidade);
Console.WriteLine(pedido.ValorUnitario);
Console.WriteLine(pedido.Total);
