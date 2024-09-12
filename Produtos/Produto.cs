using System;

namespace Comex.Produtos
{
    public class Produto
    {
        public static int Quantidade { get; private set; }
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }
        public string Categoria { get; set; }

        public double ValorTotal()
        {
            return Preco * Estoque;
        }
        public double CalculaImposto()
        {
            return 0.4 * Preco;
        }

        public Produto(string nome, string descricao, double preco, int estoque, string categoria)
        {
            Quantidade++;
            Id = Quantidade;
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Estoque = estoque;
            Categoria = categoria;
        }
    }
}
