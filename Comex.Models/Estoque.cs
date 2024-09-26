using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Estoque
    {
        static public int Capacidade { get; set; } = 1000;
        // Capacidade máxima = 1000.
        static public int Ocupacao { get; set; }
        static public decimal Montante { get; set; }

        public void RegistraEntrada(Produto produto)
        {
            if(produto.QuantidadeEmEstoque>Capacidade)
            {
                throw new LimiteDeEstoqueExcedidoException("A capacidade do estoque foi excedida. Capacidade máxima = 1000.");

            }

            {
                Capacidade -= produto.QuantidadeEmEstoque;
                Ocupacao += produto.QuantidadeEmEstoque;
                Montante += Convert.ToDecimal(produto.ValorEstoque());
            }
        }

        public void RegistraSaida(Produto produto)
        {
            if(Ocupacao==0)
            {
                throw new LimiteDeEstoqueExcedidoException("O estoque está vazio! Não é possível registrar saídas no estoque.");
            }
            Capacidade += produto.QuantidadeEmEstoque;
            Ocupacao -= produto.QuantidadeEmEstoque;
            Montante -= Convert.ToDecimal(produto.QuantidadeEmEstoque);
        }

        public string InformacoesDoEstoque()
        {
            return $" Capacidade: {Capacidade}\n Ocupação: {Ocupacao}\n Montante (R$) : {Montante:C}";
        }
    }
}
