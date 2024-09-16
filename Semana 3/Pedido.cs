using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Entidades
{
    public class Pedido
    {
        public static int Quantidade { get; private set; }
        public int Id { get; private set; }
        public string Data { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }
        public int QuantidadeVendida { get; set; }

        public Pedido(string data, Cliente cliente, Produto produto, int quantidadeVendida)
        {
            Quantidade++;
            Id = Quantidade;
            Data = data;
            Cliente = cliente;
            Produto = produto;
            QuantidadeVendida = quantidadeVendida;
        }

        public double CalculaValorTotal()
        {
            return Produto.Preco * QuantidadeVendida;
        }

        public double CalculaTotalImposto()
        {
            return Produto.CalculaImposto() * QuantidadeVendida;
        }
    }
}