using System;

namespace Comex.Modelos.Categorias
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

            if (nome.Length <= 3)
            {
                throw new ArgumentException("Nome deve conter mais do que 3 caracteres");
            }
            if (status != "ATIVA" && status != "INATIVA")
            {
                throw new ArgumentException("O status deve ser: ATIVA ou INATIVA");
            }

            Nome = nome;
            Status = status;
        }
    }
}