using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class ProdutoIsento : Produto
    {
        public static new int Quantidade { get; set; }
        public ProdutoIsento(string nome, string descricao, double preco, int estoque, string categoria) : base(nome, descricao, preco, estoque, categoria)
        {
        }

        public override double CalculaImposto()
        {
            return 0;
        }
    }
}
