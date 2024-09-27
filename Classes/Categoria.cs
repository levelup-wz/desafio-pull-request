using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Categoria
    {
        private static int Estoque { get; set; }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public Categoria(string nome, string status)
        {
            Estoque++;
            Id = Estoque;
            Nome = nome;
            Status = status;
        }

    }
}
