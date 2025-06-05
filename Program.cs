using System;
using System.Collections.Generic;

namespace LojaVirtualP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var produto1 = new Produto(1, "Smartphone", 1500m, "Eletronica");
            var produto2 = new Produto(2, "Camiseta", 50m, "Roupas");


            var cliente = new Cliente(1, "Rodrygo", "rodrygo@gmail.com", "12345678900");

            IDescontoStrategy desconto = new DescontoPorCategoria();

            var pedidoFactory = new PedidoFactory(desconto);

            var itens = new List<(Produto produto, int quantidade)>
            {
            (produto1, 2),
            (produto2, 6)
        };

            var pedido = pedidoFactory.CriarPedido(1, cliente, itens);

            Console.WriteLine($"Pedido ID: {pedido.Id}");
            Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
            Console.WriteLine($"Data: {pedido.Data}");
            Console.WriteLine("itens:");

            foreach (var item in pedido.Itens)
            {
                Console.WriteLine($"- {item.Produto.Nome} x {item.Quantidade} | Valor Total: {item.GetValorTotal():C2}");
            }
            Console.WriteLine($"Valor Total do Pedido: {pedido.ValorTotal:C2}");
       }
    }
}
    