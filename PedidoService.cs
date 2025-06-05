using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
   public class PedidoService
    {
        private readonly List<Pedido> _pedidos = new List<Pedido>();
        private readonly ILogService _log;

        public PedidoService(ILogService log)
        {
            _log = log ?? throw new ArgumentException(nameof(log));
        }

        public void AdicionarPedido(Pedido pedido)
        {
            if (pedido == null)
                throw new ArgumentException(nameof(pedido));

            _pedidos.Add(pedido);
            _log.Registrar($"Pedido {pedido.Id} adicionando para o cliente {pedido.Cliente.Nome} ");
        }
        public IEnumerable<Pedido> ListarPedido()
        {
            return _pedidos;
        }
        public void ImprimirRelatorio()
        {
            _log.Registrar("Relatorio de pedidos gerado");
            Console.WriteLine("Relatório de Pedidos");
            foreach (var pedido in _pedidos)
            {
                Console.WriteLine($"Pedido ID: {pedido.Id}");
                Console.WriteLine($"Cliente: {pedido.Cliente.Nome}");
                Console.WriteLine($"Data: {pedido.Data}");
                Console.WriteLine($"Itens");
                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"- {item.Produto.Nome}x{item.Quantidade}- Valor: {item.GetValorTotal():C}");
                }
                Console.WriteLine($"Valor Total: {pedido.ValorTotal:C}");
                Console.WriteLine("-------------------------------------");
            }
        }
    }
}
