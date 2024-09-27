using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class Estoque
    {
        static public int Capacidade { get; set; } = 1000;
        static public int Ocupacao { get; set; }
        static public decimal Montante { get; set; }

        public void RegistraEntrada(Produto produto)
        {
            {
                Capacidade -= produto.Estoque;
                Ocupacao += produto.Estoque;
                Montante += Convert.ToDecimal(produto.MontanteEstoque());
                // Variável e método com nomes parecidos!!
            }
        }

        public void RegistraSaida(Produto produto)
        {
            Capacidade += produto.Estoque;
            Ocupacao -= produto.Estoque;
            Montante -= Convert.ToDecimal(produto.Estoque);
        }

        public string InformacoesDoEstoque()
        {
            return $" Capacidade: {Capacidade}\n Ocupação: {Ocupacao}\n Montante (R$) : {Montante:C}";
        }
    }
}
