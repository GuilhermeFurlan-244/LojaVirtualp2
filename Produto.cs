using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
    public class Produto
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public string Categoria { get; private set; }

        public Produto(int id, string nome, decimal preco, string categoria)
        {
            if (id <= 0)
                throw new ArgumentException("Id deve ser Maior que zero");
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome não pode ser vazio");
            if (preco <= 0)
                throw new ArgumentException("Preço deve ser maior que zero");
            if (string.IsNullOrWhiteSpace(categoria))
                throw new ArgumentException("Categoria não pode ser vazia");

            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;


        }
    }
}
