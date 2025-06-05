using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
    public class PedidoFactory
    {
        private readonly IDescontoStrategy _estrategiaDesconto;
        private readonly ILogService _log;

        public PedidoFactory(IDescontoStrategy estrategiaDesconto, ILogService log  )
        {
            _estrategiaDesconto = estrategiaDesconto;
            _log = log;
        }

        public Pedido CriarPedido(int idpedido, Cliente cliente,List<(Produto produto,int quantidade)> itens)
        {
            _log.Registrar($"Iniciando criação do pedido #{idpedido}para o cliente {cliente.Nome}");
            var pedido = new Pedido(idpedido, cliente);

            foreach (var(produto,quantidade)in itens)
            {

                var itemPedido = new ItemPedido(produto, quantidade)
                {
                    DescontoStrategy = _estrategiaDesconto
                };
                pedido.AdicionarItem(itemPedido);
                _log.Registrar($"Pedido #{quantidade}x '{produto.Nome}' ao pedido # {idpedido}");
            }

            _log.Registrar($"Pedido #{idpedido} criado com sucesso com valor total de R$ {pedido.ValorTotal:F2}");
            return pedido;
        }


     }
}
