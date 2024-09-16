using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Produto
    {

        public static int Quantidade { get; set; } 
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }    
        public int Estoque { get; set; }    
        //public string Categoria.nome;
        public string Categoria { get; set; }
        
        public double MontanteEstoque()
        { 
            return  Preco * Estoque;
        }

        public double CalculaImposto()
        {
            return Preco * 0.4;
        }
        //calcula imposto: 40% do preço unitário.

        public Produto(string nome, string descricao, double preco, int estoque, string categoria)
        {
            Id = Quantidade;
            Nome = nome;
            Preco = preco;
            Estoque= estoque;   
            Categoria = categoria;
            Descricao= descricao;   
            Quantidade++;

        }

    }
}
