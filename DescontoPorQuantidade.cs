using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
    public class DescontoPorQuantidade : IDescontoStrategy
    {
        public decimal CalcularDesconto(ItemPedido item)
        {
            if (item.Quantidade >= 5)
                return item.Produto.Preco *item.Quantidade  * 0.15m;
            return 0;
        }
    }
}
