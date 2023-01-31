﻿using System;
using System.Linq;
using Comex.Modelos.Clientes;

namespace Comex.Modelos.Pedidos;

public class Pedido
{
    public static int Quantidade { get; private set; }
    public int Id { get; private set; }
    public string Cep { get; private set; }
    public string Data { get; set; }
    public Cliente Cliente { get; set; }
    public List<ItensDoPedido> Itens { get; set; }
    public int QuantidadeVendida { get; set; }
    public NotaFiscal Nota { get; private set; }
    public decimal FretePedido { get; private set; }

    public Pedido(string data, Cliente cliente, string cep, params ItensDoPedido[] itens)
    {
        Quantidade++;
        Id = Quantidade;
        Itens = new List<ItensDoPedido>();
        Data = data;
        Cliente = cliente;
        QuantidadeVendida = 0;
        Nota = new NotaFiscal(this);
        Cep = cep;
        FretePedido = Frete.Calcular(cep);

        for (int i = 0; i < itens.Length; i++)
        {
            itens[i].Id = i + 1;
            QuantidadeVendida += itens[i].Quantidade;
            Itens.Add(itens[i]);
        }
    }

    public decimal CalculaValorTotal()
    {
        return Itens.Sum(pedido => pedido.Total);
    }

    public decimal CalculaTotalImposto()
    {
        return Itens.Sum(valor => valor.Item.CalculaImposto() * valor.Quantidade);
    }

    public decimal CalculaCustoTotal()
    {
        return CalculaValorTotal() + CalculaTotalImposto() + FretePedido;
    }

    public void RemoverItens(int id)
    {
        IEnumerable<ItensDoPedido> items = (
            from item in Itens
            where item.Id == id
            select item).ToList();

        foreach (ItensDoPedido item in items)
        {
            QuantidadeVendida -= item.Quantidade;
            Itens.Remove(item);
        }

        for (int i = 0; i < Itens.Count; i++)
        {
            Itens[i].Id = i + 1;
        }
    }

    public void AlterarQuantidade(int id, int quantidade)
    {
        IEnumerable<ItensDoPedido> items = (
            from item in Itens
            where item.Id == id
            select item).ToList();

        foreach (ItensDoPedido item in items)
        {
            var novoItem = item;
            novoItem.AlterarQuantidade(quantidade);

            Itens.Remove(item);
            Itens.Add(novoItem);

            QuantidadeVendida += novoItem.Quantidade - item.Quantidade;
        }

        for (int i = 0; i < Itens.Count; i++)
        {
            Itens[i].Id = i + 1;
        }
    }

    public override string ToString()
    {
        string pedido = "======================================\n";
        pedido += $"[{Id}] - {Data} \nCliente: {Cliente.NomeCompleto()} - {Cliente.CpfCliente.CPF} \n";
        pedido += "-------------------";

        foreach (ItensDoPedido item in Itens)
        {
            pedido += item.ToString();
        }

        pedido += "\n-------------------";
        pedido += $"\nQuantidade Total de Itens: {QuantidadeVendida} \nImposto: R${CalculaTotalImposto()}" +
            $"\nCEP: {Cep} - Frete: R${FretePedido}";
        pedido += "\n-------------------";
        pedido += "\n" + Nota;
        pedido += "\n======================================";
        return pedido;
    }
}
