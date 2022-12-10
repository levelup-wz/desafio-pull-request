﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex

{
    public class Produto
    {
        private static int _id = 0;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double PrecoUnitario { get; set; }
        public int Quantidade { get; set; }
        public string Categoria { get; set; }
        public Produto produto { get; set; } //tipo produto

        public Produto( string nome, double precoUnitario, int quantidade, string categoria)
        {
            Id = ++_id;
            Nome = nome;
            PrecoUnitario= precoUnitario;
            Quantidade = quantidade;
            Categoria = categoria;

        }

        public virtual double ValorEstoque()
        {
            double total = PrecoUnitario * Quantidade;
            return total;
        }

        public virtual double Imposto()
        {
            double TotalImposto = PrecoUnitario * 0.40;
            return TotalImposto;
        }

        public string RetornaInfosProduto()
        {
            return $"ID produto número: {Id} \n " +
                $"Porduto: {Nome} \n" +
                $"Quantidade estoque: {Quantidade}\n" +
                $"Categoria: {Categoria}\n" +
                $"Valor unitário R$ {PrecoUnitario.ToString("N2")} \n" +
                $"Valor em estoque R$ {ValorEstoque().ToString("N2")}\n" +
                $"Valor imposto: {Imposto().ToString("N2")} \n";
        }

    }
}
