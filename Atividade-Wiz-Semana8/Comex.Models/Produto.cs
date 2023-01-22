﻿namespace Comex.Models
{
    public class Produto
    {
        private static int _id = 1;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descircao { get; set; }
        public decimal PrecoUnitario { get; set; }
        public int QuantidadeEmEstoque { get; set; }
        public string Categoria { get; set; }
        protected string Atributos { get; set; }

        public Produto (string nome, decimal precoUnitario, int quantidadeEmEstoque, string categoria, string atributos)
        {
            Id = _id++;
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEmEstoque = quantidadeEmEstoque;
            Categoria = categoria;
            Atributos = atributos;
        }

        public Produto (int id, string nome, decimal precoUnitario, int quantidadeEmEstoque, string categoria)
        {
            Id = id;
            Nome = nome;
            PrecoUnitario = precoUnitario;
            QuantidadeEmEstoque = quantidadeEmEstoque;
            Categoria = categoria;

            if (id <= 0)
            {
                throw new ArgumentException("ID deve ser maior que ZERO.", nameof(id));
            }
            if (nome.Length <= 5)
            {
                throw new ArgumentException("Nome deve ter mais que 5 caracteres", nameof(nome));
            }
            if (precoUnitario <= 0)
            {
                throw new ArgumentException("Preço unitário não pode ser ZERO.", nameof(precoUnitario));
            }
            if (quantidadeEmEstoque <= 0)
            {
                throw new ArgumentException("Não é possível inserir um produto com a quantidade ZERO no estoque.", nameof(quantidadeEmEstoque));
            }
            if (categoria.Length <= 0)
            {
                throw new ArgumentException("Obrigatorio definir a categoria do produto.", nameof(categoria));
            }
        }

        public int DefineId()
        {
            return Id;
        }

        public decimal CalculaValorTotalEmEstoque()
        {
            var resultado = QuantidadeEmEstoque * PrecoUnitario;
            return resultado;
        }

        public virtual decimal CalculaImposto()
        {
            var resultado = PrecoUnitario * 0.40M;
            return resultado;
        }
    }
}
