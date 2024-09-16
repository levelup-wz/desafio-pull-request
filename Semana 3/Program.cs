using System;
using Comex.Entidades;

class Program
{
    static void Main()
    {
        // Criando as categorias
        Categoria informatica = new Categoria("INFORMÁTICA", "ATIVA");
        Categoria moveis = new Categoria("MÓVEIS", "INATIVA");
        Categoria livros = new Categoria("LIVROS", "ATIVA");

        // Criando os produtos
        Produto notebookSamsung = new Produto("Notebook Samsung", "Notebook bestseller!", 3523.00, 1, "Informática");
        Produto cleanArchitecture = new Produto("Clean Architecture", "Livro de Arquitetura limpa!", 102.90, 2, "Livros");
        Produto monitorDell = new Produto("Monitor Dell", "Top 1 em custo-benefício", 1889.00, 3, "Informática");

        // Criando clientes
        Cliente isabela = new Cliente("Isabela", "Queiroz", "01234567890", "34999999999", "Rua Misteriosa",
            "1000", "Rua abaixo do supermercado", "Cidade Jardim", "Uberlândia", "Minas Gerais");
        Cliente joao = new Cliente("Joao", "Grilo", "01212121212", "83988888888", "Avenida de Cidade",
            "1000", "Perto da igreja", "Bairro Nossa Senhora Aparecida", "Taperoá", "Paraíba");

        // Especificando os pedidos
        Pedido pedido1 = new Pedido("03/12/2022", isabela, notebookSamsung, 2);
        Pedido pedido2 = new Pedido("03/12/2022", joao, cleanArchitecture, 2);
        Pedido pedido3 = new Pedido("04/12/2022", isabela, monitorDell, 1);


        Console.WriteLine("Pedidos: \n");
        //Testando pedido e cliente
        Console.WriteLine("\n{0} - {1} Cliente: {2} \n{3} {4} unidades \nR${5} - Imposto: R${6}",
            pedido1.Id, pedido1.Data, pedido1.Cliente.NomeCompleto(), pedido1.Produto.Nome,
            pedido1.QuantidadeVendida, pedido1.CalculaValorTotal(), pedido1.CalculaTotalImposto());
        Console.WriteLine("\n{0} - {1} Cliente: {2} \n{3} {4} unidades \nR${5} - Imposto: R${6}",
            pedido2.Id, pedido2.Data, pedido2.Cliente.NomeCompleto(), pedido2.Produto.Nome,
            pedido2.QuantidadeVendida, pedido2.CalculaValorTotal(), pedido2.CalculaTotalImposto());
        Console.WriteLine("\n{0} - {1} Cliente: {2} \n{3} {4} unidades \nR${5} - Imposto: R${6}",
            pedido3.Id, pedido3.Data, pedido3.Cliente.NomeCompleto(), pedido3.Produto.Nome,
            pedido3.QuantidadeVendida, pedido3.CalculaValorTotal(), pedido3.CalculaTotalImposto());
    }
}