using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Vestuario : Produto
    {
        public string Tamanho { get; private set; }
        public string Cor { get; }

        public Vestuario(string nome, string descricao, double preco, int quantidade_estoque, string categoria, string atributos) : base(nome, descricao, preco, quantidade_estoque, categoria,atributos)
        {
            Atributos = atributos;
            Tamanho = ExtrairTamanho();
            Cor = ExtrairCor();
        }

        // Métodos Extratores do Tamanho e Cor considerando a grafia estabelecida. Demais casos: abordagem RegexOptions.IgnoreCase

        private string ExtrairTamanho()
        {
            int indice = Atributos.IndexOf("tamanho: ") + 9;
            return Atributos.Substring(indice, 1);
        }

        private string ExtrairCor()
        {
            int indice = Atributos.IndexOf("cor: ") + 5;
            return Atributos[indice..];
        }
    }
}