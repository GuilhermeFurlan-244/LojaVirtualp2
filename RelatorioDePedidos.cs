using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
    public class RelatorioDePedidos
    {
        public void Gerar(List<Pedido> pedidos)
        {
            if (pedidos == null || !pedidos.Any())
            {
                Console.WriteLine("Nenhum pedido encontrado.");
                return;
            }
            foreach (var pedido in pedidos)
            {
                Console.WriteLine("=======================");
                Console.WriteLine($"Pedido ID: {pedido.Id}");
                Console.WriteLine($"Data: {pedido.Cliente.Nome}");
                Console.WriteLine($"Data: {pedido.Data}");
                Console.WriteLine("Itens");

                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"- {item.Produto.Nome} | Qtd: {item.Quantidade} | Subtotal: R$ {item.GetValorTotal():F2}");

                }
                Console.WriteLine($"Valor Total: R$ {pedido.ValorTotal:F2}");
                Console.WriteLine("========================");
            }
        } 
        }
    }

