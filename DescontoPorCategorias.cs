using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
    public class DescontoPorCategorias : IDescontoStrategy 

    {
    public decimal CalcularDesconto(ItemPedido item)
    {
        if (item.Produto.Categoria == "Eletronicos")
            return item.Produto.Preco * item.Quantidade * 0.10m;
            if (item.Produto.Categoria.Equals("Roupas", StringComparison.OrdinalIgnoreCase))
                return item.Produto.Preco * item.Quantidade * 0.05m;   
        return 0;
    }
    }

}
