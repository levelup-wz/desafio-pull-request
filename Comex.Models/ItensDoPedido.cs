using Comex.Models;
using Comex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Comex.Models
{
    public class ItensDoPedido
    {
        public readonly Produto Produto;
        public int Quantidade { get; set; }

        public readonly decimal Total;

        public ItensDoPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
            Total = (decimal)Produto.Preco * Quantidade;
            // Ambiguidade em Produto.Preco.
        }
    }
}
