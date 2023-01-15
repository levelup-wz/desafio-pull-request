﻿using Comex;
using Comex.Models;
using Comex.Testes;

Console.WriteLine("TestaCategoria:" + "\n");
Categoria categoria1 = new();
categoria1.DefineId();
categoria1.Nome = "INFORMÁTICA";
categoria1.Status = "ATIVA";

Categoria categoria2 = new();
categoria2.DefineId();
categoria2.Nome = "MÓVEIS";
categoria2.Status = "INATIVA";

Categoria categoria3 = new();
categoria3.DefineId();
categoria3.Nome = "LIVROS";
categoria3.Status = "ATIVA";

Console.WriteLine($"{categoria1.Nome} ({categoria1.DefineId()} - {categoria1.Status})");
Console.WriteLine($"{categoria2.Nome} ({categoria2.DefineId()} - {categoria2.Status})");
Console.WriteLine($"{categoria3.Nome} ({categoria3.DefineId()} - {categoria3.Status})" + "\n");

TestaValidacaoDeCategoria.RegistaEntradaParametro();
Console.WriteLine();

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("TestaProduto:" + "\n");
Produto produto1 = new("Notebook Samsung", 3523.00, 1, "Informática", "");

Produto produto2 = new("Clean Architecture", 102.90, 2, "Livros", "");

Produto produto3 = new("Monitor Dell 27", 1889.00, 3, "Informática", "");

Console.WriteLine($"{produto1.Categoria} ({produto1.DefineId()} - {produto1.Nome})");
Console.WriteLine($"Quantidade em estoque: {produto1.QuantidadeEmEstoque}");
Console.WriteLine($"Valor total em estoque: {produto1.CalculaValorTotalEmEstoque():N2}");
Console.WriteLine($"Preço unitário: {produto1.PrecoUnitario}");
Console.WriteLine($"Valor de Imposto: {produto1.CalculaImposto():N2}" + "\n");

Console.WriteLine($"{produto2.Categoria} ({produto2.DefineId()} - {produto2.Nome})");
Console.WriteLine($"Quantidade em estoque: {produto2.QuantidadeEmEstoque}");
Console.WriteLine($"Valor total em estoque: {produto2.CalculaValorTotalEmEstoque():N2}");
Console.WriteLine($"Preço unitário: {produto2.PrecoUnitario}");
Console.WriteLine($"Valor de Imposto: {produto2.CalculaImposto():N2}" + "\n");

Console.WriteLine($"{produto3.Categoria} ({produto3.DefineId()} - {produto3.Nome})");
Console.WriteLine($"Quantidade em estoque: {produto3.QuantidadeEmEstoque}");
Console.WriteLine($"Valor total em estoque: {produto3.CalculaValorTotalEmEstoque():N2}");
Console.WriteLine($"Preço unitário: {produto3.PrecoUnitario}");
Console.WriteLine($"Valor de Imposto: {produto3.CalculaImposto():N2}" + "\n");

TestaValidacaoDeProdutos.RegistaEntradaProdutos();
Console.WriteLine();

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("TestaPedido:" + "\n");
Pedido pedido1 = new(new Cliente("Hebert", "Belchior", new CPF("11133344455"), "(81)91234-5678","Rua: Vila Local,", "Numero: 801,", "Complemento: Bloco F, " +
                            "Apartamento 948,", "Bairro: Janga,", "Cidade: Paulista,", "Estado: PE"), new Produto("Notebook Samsung", 3523.00, 1, 
                            "Informática", ""), 1);
Console.WriteLine($"Id do pedido: {pedido1.DefineId()}");
Console.WriteLine($"Id do cliente: {pedido1.Cliente.DefineId()}");
Console.WriteLine($"Data do pedido: { pedido1.Data}");
Console.WriteLine($"Nome do cliente: {pedido1.Cliente.NomeCompleto()}");
Console.WriteLine($"CPF do cliente: {pedido1.Cliente.Cpf}");
Console.WriteLine($"Telefone do cliente: {pedido1.Cliente.Telefone}");
Console.WriteLine($"Endereço do cliente: {pedido1.Cliente.EnderecoCompleto()}");
Console.WriteLine($"Produto do pedido: {pedido1.Produto.Nome}");
Console.WriteLine($"Categoria do produto: {pedido1.Produto.Categoria}");
Console.WriteLine($"Quantidade vendida: {pedido1.QuantidadeVendida}");
Console.WriteLine($"Valor total vendido: {pedido1.CalculaValorTotal():N2}");
Console.WriteLine($"Total de impostos: { pedido1.CalculaTotalDeImpostos():N2}" + "\n");
Pedido pedido2 = new(new Cliente("Monalisa", "Mata", new CPF("22233344455"), "(81)92345-6789", "Rua: Vila Local,", "Numero: 801,", "Complemento: Bloco F, " +
                            "Apartamento 948,", "Bairro: Janga,", "Cidade: Paulista,", "Estado: PE"), new Produto("Clean Architecture", 102.90, 2,
                            "Livros", ""), 2);
Console.WriteLine($"Id do pedido: {pedido2.DefineId()}");
Console.WriteLine($"Id do cliente: {pedido2.Cliente.DefineId()}");
Console.WriteLine($"Data do pedido: {pedido2.Data}");
Console.WriteLine($"Nome do cliente: {pedido2.Cliente.NomeCompleto()}");
Console.WriteLine($"CPF do cliente: {pedido2.Cliente.Cpf}");
Console.WriteLine($"Telefone do cliente: {pedido2.Cliente.Telefone}");
Console.WriteLine($"Endereço do cliente: {pedido2.Cliente.EnderecoCompleto()}");
Console.WriteLine($"Produto do pedido: {pedido2.Produto.Nome}");
Console.WriteLine($"Categoria do produto: {pedido2.Produto.Categoria}");
Console.WriteLine($"Quantidade vendida: {pedido2.QuantidadeVendida}");
Console.WriteLine($"Valor total vendido: {pedido2.CalculaValorTotal():N2}");
Console.WriteLine($"Total de impostos: {pedido2.CalculaTotalDeImpostos():N2}" + "\n");

Pedido pedido3 = new(new Cliente("Angélica", "Maria", new CPF("33344455566"), "(81)93456-7891", "Rua: 197,", "Numero: 55,", "Complemento: Bloco O, Apartamento 777,",
                            "Bairro: Ouro Preto,", "Cidade: Olinda,", "Estado: PE"), new Produto("Monitor Dell 27", 1889.00, 3, "Informática", ""), 3);
Console.WriteLine($"Id do pedido: {pedido3.DefineId()}");
Console.WriteLine($"Id do cliente: {pedido3.Cliente.DefineId()}");
Console.WriteLine($"Data do pedido: {pedido3.Data}");
Console.WriteLine($"Nome do cliente: {pedido3.Cliente.NomeCompleto()}");
Console.WriteLine($"CPF do cliente: {pedido3.Cliente.Cpf}");
Console.WriteLine($"Telefone do cliente: {pedido2.Cliente.Telefone}");
Console.WriteLine($"Endereço do cliente: {pedido3.Cliente.EnderecoCompleto()}");
Console.WriteLine($"Produto do pedido: {pedido3.Produto.Nome}");
Console.WriteLine($"Categoria do produto: {pedido3.Produto.Categoria}");
Console.WriteLine($"Quantidade vendida: {pedido3.QuantidadeVendida}");
Console.WriteLine($"Valor total vendido: {pedido3.CalculaValorTotal():N2}");
Console.WriteLine($"Total de impostos: {pedido3.CalculaTotalDeImpostos():N2}" + "\n");

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("TestaProdutoIsento:" + "\n");
TestaProdutoIsento.MostraProdutoIsento();
Console.WriteLine("\n");

TestaValidacaoDeProdutos.RegistaEntradaProdutosIsentos();
Console.WriteLine();

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("Exibir entrada no estoque:" + "\n");
TestaEntradaDeProdutoNoEstoque.RegistraEntradoEstoque();
Console.WriteLine("\n");

Console.WriteLine("Exibir saída do estoque:" + "\n");
TestaSaidaDeProdutoNoEstoque.RegistraSaidoEstoque();
TestaSaidaDeProdutoNoEstoque.RegistraSaidoEstoque();
Console.WriteLine();

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("Nota fiscal:" + "\n");
NotaFiscal notaFiscal = new(new Pedido(new Cliente("Hebert", "Belchior", new CPF("11133344455"), "(81)91234-5678", "Rua: Vila Local,", "Numero: 801,",
                           "Complemento: Bloco F, " + "Apartamento 948,", "Bairro: Janga,", "Cidade: Paulista,", "Estado: PE"),
                           new Produto("Notebook Samsung", 3523.00, 1, "Informática", ""), 1));
notaFiscal.RegistraPedido();
Console.WriteLine();

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("Valor do frete por região:" + "\n");
TestaFrete.MostraFrete();
Console.WriteLine();

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("Formata CPF:" + "\n");
TesteCPF.RetornaCpf();
Console.WriteLine();

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("Vestuário: " + "\n");
TestaVestuario.RetornaVestuario();
Console.WriteLine();

Console.WriteLine(".--------------------..--------------------..--------------------..--------------------..--------------------." + "\n");

Console.WriteLine("Tecle enter para fechar o programa...");

Console.ReadKey();