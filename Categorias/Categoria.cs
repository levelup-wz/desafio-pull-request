using System;

namespace Comex.Categorias
{
    public class Categoria
    {
        public static int Quantidade { get; private set; }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Status { get; set; }

        public Categoria(string nome, string status)
        {
            Quantidade++;
            Id = Quantidade;
            Nome = nome;
            Status = status;
        }
    }
}
