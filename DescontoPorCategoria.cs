using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
   public class DescontoPorCategoria : IDescontoStrategy
    {
        public decimal CalcularDesconto(ItemPedido item)
        {
            if (item.Produto.Categoria == "Eletronicos")
                return item.GetValorTotal() * 0.10m;
            return 0;
        }
    }
}
