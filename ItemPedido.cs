using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
    public class ItemPedido
    {
     public Produto Produto { get; private set; }
     public int Quantidade { get; private set; }
     public IDescontoStrategy DescontoStrategy { get; set; }

    public ItemPedido(Produto produto, int quantidade)
        {
            if (produto == null)
                throw new ArgumentException(nameof(produto), "Produto não pode ser nulo ");
            if (quantidade <= 0)
                throw new ArgumentException("Quantidade deve ser maior que zero");

            Produto = produto;
            Quantidade = quantidade;
        }
        public decimal GetValorTotal()
        {
            var valorBruto = Produto.Preco * Quantidade;
            var desconto = DescontoStrategy?.CalcularDesconto(this) ?? 0;
            return valorBruto - desconto;
        }
    }
}
