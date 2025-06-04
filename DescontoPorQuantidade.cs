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
                return item.GetValorTotal() * 0.05m;
            return 0;
        }
    }
}
