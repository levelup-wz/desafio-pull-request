using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumericWordsConversion;

namespace Comex.Models
{
    public class NotaFiscal
    {
        internal Pedido Pedido { get; set; }
        public string PorExtensoIngles { get; set; }
        public NotaFiscal(Pedido pedido)
        {
            Pedido = pedido;
            NumericWordsConverter converter = new NumericWordsConverter();
            PorExtensoIngles = converter.ToWords((decimal)Pedido.CalculaValorTotal());
        }

        public override string ToString()
        {
            return
                $"Nome: {Pedido.Cliente.NomeCompleto()}\n" +
                $"Data da compra: {Pedido.Data}\n" +
                $"Total do pedido: {Pedido.CalculaValorTotal():C}\n" +
                $"Valor por extenso em Inglês: {PorExtensoIngles}\n";
        }
    }
}