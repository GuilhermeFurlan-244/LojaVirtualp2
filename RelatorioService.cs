using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
    public class RelatorioService
    {
        private readonly List<Pedido> _pedidos;

        public RelatorioService(List<Pedido> pedidos)
        {
            _pedidos = pedidos ?? new List<Pedido>();
        }
        public void ExibirRelatorio()
        {
            Console.WriteLine("====== RELATÓRIO DE PEDIDOS =====");

            foreach (var pedido in _pedidos)
            {
                Console.WriteLine($"\nPedido ID: {pedido.Id}");
                Console.WriteLine($"Cliente: {pedido.Cliente.Nome} | CPF: {pedido.Cliente.CPF}");
                Console.WriteLine($"Data: {pedido.Data}");
                Console.WriteLine("Itens");

                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"- {item.Produto.Nome} | Categoria: {item.Produto.Categoria}| Qtd: {item.Quantidade} | Preço: R${item.Produto.Preco} | Total c/ desconto: R${item.GetValorTotal()}); ");
                }
                Console.WriteLine($"Valor Total do Pedido: R${pedido.ValorTotal}");
                Console.WriteLine("=======================");
            }
        }
    }
}
