﻿

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex.Models
{
    public class Pedido
    {
       
        public Produto ProdutoPedido { get; set; } //tipo produto
        public int Id { get; set; }
        public static int ContId = 0;
        public DateTime Data { get; set; }
       // public string Cliente { get; set; }
        public int Quantidade { get; set; }

        public Cliente ClientePedido { get; set; }

        public Pedido( Cliente cliente, Produto produto, int quantidade)
        {
            Id = ++ContId;
            ClientePedido = cliente;
            Data = DateTime.Now; 
            ProdutoPedido = produto;
            Quantidade= quantidade;
        }

        public Pedido()
        {
        }

        public double ValorPedido() 
        {
            double valorTotal = ProdutoPedido.PrecoUnitario * Quantidade;
            return valorTotal;
        }
                
        public double ImpostoTotal()
        {
            double totalPagar = Quantidade * ProdutoPedido.Imposto();
            return totalPagar;
        }

        public string RetornaInfosPedido()
        {
            return $"ID pedido número: {Id} \n" +
                $"{ClientePedido.RetornaCliente()}" +
                $"Data do pedido: {Data.ToString("dd/MM/yyyy")}\n" +
                $"Produto: {ProdutoPedido.Nome}\n" +
                $"Quantidade do pedido: {Quantidade}\n" +
                $"Valor unitário: {ProdutoPedido.PrecoUnitario.ToString("N2")}\n" +
                $"O valor total do pedido R$ {ValorPedido().ToString("N2")}\n" +
                $"Impostos do pedido R$ {ImpostoTotal().ToString("N2")}\n ";
        }


    }
}

