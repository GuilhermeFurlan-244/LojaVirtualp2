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

        public PedidoFactory(IDescontoStrategy estrategiaDesconto)
        {
            _estrategiaDesconto = estrategiaDesconto;
        }

        public Pedido CriarPedido(int idpedido, Cliente cliente,List<(Produto produto,int quantidade)> itens)
        {
            var pedido = new Pedido(idpedido, cliente);

            foreach (var(produto,quantidade)in itens)
            {

                var itemPedido = new ItemPedido(produto, quantidade)
                {
                    DescontoStrategy = _estrategiaDesconto
                };
                pedido.AdicionarItem(itemPedido);
            }
            return pedido;
        }


     }
}
