using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualP2
{
   public class Cliente
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string CPF { get;private set; }

        public Cliente (int id, string nome, string email, string cpf)
        {

            if (id <= 0)
                throw new ArgumentException("Id deve ser maior que zero");

            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("Nome não pode ser Vazio.");

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))

                if (string.IsNullOrWhiteSpace(cpf) || cpf.Length != 11)
                    throw new ArgumentException("CPF Inválido. Deve conter 11 dígitos");

            Id = id;
            Nome = nome;
            Email = email;
            CPF = cpf;
        }
    }
}
