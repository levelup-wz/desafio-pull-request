using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Produto
    {

        public static int Quantidade { get; set; } 
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }    
        public int QuantidadeEmEstoque { get; set; }
        public string Categoria { get; set; }
        protected string Atributos { get; set; }
        
        public double ValorEstoque()
        { 
            return  Preco * QuantidadeEmEstoque;
        }

        public virtual double CalculaImposto()
        {
            return (double)Preco * 0.4;
        }
        //calcula imposto: 40% do preço unitário.

        public Produto(string nome, string descricao, double preco, int quantidade_estoque, string categoria,string atributos)
        {
            Id = Quantidade;
            Nome = nome;
            Preco = preco;
            QuantidadeEmEstoque= quantidade_estoque;   
            Categoria = categoria;
            Descricao= descricao;
            Atributos = atributos;
            Quantidade++;

        }

    }
}
