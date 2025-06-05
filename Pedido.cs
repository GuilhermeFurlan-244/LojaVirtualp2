using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
    public class Pedido
    {
        public int Id { get; private set; }
        public Cliente Cliente { get; private set; }
        public List<ItemPedido> Itens { get; private set; } = new List<ItemPedido>();
        public DateTime Data { get; private set; }
        public Pedido(int id, Cliente cliente)
        {
            if (id <= 0)
                throw new ArgumentException("Id do pedido deve ser maior que zero.");
            if (cliente == null)
                throw new ArgumentNullException(nameof(cliente), "Cliente não pode ser nulo");

            Id = id;
            Cliente = cliente;
            Data = DateTime.Now;
        }
        public void AdicionarItem(ItemPedido item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item), "Item do pedido não pode ser nulo ");

            Itens.Add(item);
        }
        public decimal ValorTotal => CalcularValorTotal();

        private decimal CalcularValorTotal()
        {
            return Itens.Sum(item => item.GetValorTotal());
        }
    }
}
