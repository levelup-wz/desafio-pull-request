﻿using Comex.TestaModels;
using Comex.Models.Exceptions;
using Comex.Models;

try
{
    Console.WriteLine("Testa Produto Isento:");
    Console.WriteLine("-----------------------------------");
    TestaProdutoIsento.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Entrada De Produtos No Estoque:");
    Console.WriteLine("-----------------------------------");
    TestaEntradaDeProdutosNoEstoque.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Saída De Produtos No Estoque:");
    Console.WriteLine("-----------------------------------");
    TestaSaidaDeProdutoNoEstoque.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Validação de Categoria:");
    Console.WriteLine("-----------------------------------");
    TestaValidacaoDeCategoria.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Validação de Produtos:");
    Console.WriteLine("-----------------------------------");
    TestaValidacaoDeProdutos.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Saída da Nota Fiscal:");
    Console.WriteLine("-----------------------------------");
    TestaNotaFiscal.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Cálculo do Frete:");
    Console.WriteLine("-----------------------------------");
    TestaFrete.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Formatacao Cpf:");
    Console.WriteLine("-----------------------------------");
    TesteCPF.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Vestuário:");
    Console.WriteLine("-----------------------------------");
    TestaVestuario.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Items do Pedido:");
    Console.WriteLine("-----------------------------------");
    TestaItemsDoPedido.Main();
    Console.WriteLine(" ");
    Console.WriteLine("Testa Pedido:");
    Console.WriteLine("-----------------------------------");
    TestaPedido.Main();
    Console.WriteLine(" ");
}
catch (LimiteDeEstoqueExcedidoException ex)
{
    Console.WriteLine(ex.Message);
}
