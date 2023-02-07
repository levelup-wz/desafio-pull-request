﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EscritaPorExtenso.Moeda;
using NumericWordsConversion;

namespace Comex.Models
{
    public class NotaFiscal
    {
        internal Pedido Pedido { get; set; }
        public string ExtensiveValue { get; set; }
        public string ValorPorExtenso { get; set; }
        public NotaFiscal(Pedido pedido)
        {
            Pedido = pedido;
            NumericWordsConverter converter = new NumericWordsConverter();
            ExtensiveValue = converter.ToWords((decimal)Pedido.ValorTotal());
            ValorPorExtenso = Pedido.ValorTotal().PorExtensoDeReal();
        }

        public override string ToString()
        {
            return
                $"Nome: {Pedido.Cliente.NomeCompleto()}\n" +
                $"Data da compra: {Pedido.Data}\n" +
                $"Total do pedido: {Pedido.ValorTotal():C}\n"+
                $"Valor por extenso em Inglês: {ExtensiveValue}\n"+
                $"Valor por extenso em Português: {ValorPorExtenso}\n";
        }
    }
}


