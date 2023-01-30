﻿using Comex.Modelos.Produtos;
using System;

namespace Comex.Modelos.Pedidos
{
    public class ItensDoPedido
    {
        public Produto Item { get; }
        public int Quantidade { get; set; }
        public decimal Total { get; }

        public ItensDoPedido(Produto item, int quantidade)
        {
            Item = item;
            Quantidade = quantidade;
            Total = item.Preco * quantidade;
        }

        public void AlterarQuantidade(int id)
        {
        }
    }
}
