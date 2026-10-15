🛒 Exercício C# — Design Pattern Builder

📌 Objetivo

Praticar o padrão de projeto Builder em C#, utilizando um cenário real de uma loja virtual para
construir objetos de pedidos de compra de forma organizada.

📝 Descrição do exercício

Você está desenvolvendo o backend de uma loja virtual. O sistema precisa criar pedidos contendo
informações do cliente, produto, quantidade e valor unitário.

Seu objetivo é implementar o padrão Builder para construir esses pedidos passo a passo,
mantendo cada classe com sua responsabilidade.

🧱 Estrutura do projeto

LojaVirtual/
├── Models/
│   └── Pedido.cs
├── Builders/
│   └── PedidoBuilder.cs
├── Services/
│   └── PedidoService.cs
└── Program.cs

✅ Requisitos

1. Pedido.cs

Criar a classe Pedido com as seguintes propriedades:

NomeCliente

Produto

Quantidade

ValorUnitario

2. PedidoBuilder.cs

Criar a classe responsável pela construção do pedido, contendo os métodos:

ComNomeCliente()

ComProduto()

ComQuantidade()

ComValorUnitario()

Build()

Regras:

Cada método Com...() deve configurar uma propriedade do pedido.

Os métodos Com...() devem retornar this, permitindo encadeamento.

O método Build() deve retornar o objeto `Pedido construído.

3. PedidoService.cs

Criar a classe PedidoService, responsável por utilizar o Builder para montar um pedido.

O método CriarPedido() deverá configurar os dados do pedido e retornar o objeto criado.

4. Program.cs

O arquivo Program.cs deverá chamar o serviço e exibir os dados do pedido no console.

Evite colocar toda a lógica de construção do pedido diretamente no Program.cs.

🎯 Resultado esperado

Ao executar o programa, o console deverá exibir:

Cliente: João
Produto: Teclado
Quantidade: 2
Valor unitário: R$ 150,00
Total: R$ 300,00

O total deve ser calculado multiplicando a quantidade pelo valor unitário.