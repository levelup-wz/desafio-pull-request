using System;
using Comex.Categorias;
using Comex.Produtos;
using Comex.Pedidos;
using Comex.Clientes;

class Program
{
    static void Main()
    {
        // declaração das categorias
        Categoria informatica = new Categoria("INFORMÁTICA", "ATIVA");
        Categoria moveis = new Categoria("MÓVEIS", "INATIVA");
        Categoria livros = new Categoria("LIVROS", "ATIVA");

        // declaração dos produtos
        Produto notebookSamsung = new Produto("Notebook Samsung", "O melhor da marca!",
            3523.00, 1, "Informática");
        Produto cleanArchitecture = new Produto("Clean Architecture", "O melhor da marca!",
            102.90, 2, "Livros");
        Produto monitorDell = new Produto("Monitor Dell", "O melhor da marca!",
            1889.00, 3, "Informática");

        // declaração do cliente
        Cliente danilo = new Cliente("Danilo", "Siervi", "12345678913", "32998145012", "Rua Legal",
            "D13", "Perto da prefeitura", "Centro", "Ouro Branco", "Minas Gerais");

        // declaração dos pedidos
        Pedido pedido1 = new Pedido("02/12/2022", danilo, notebookSamsung, 2);
        Pedido pedido2 = new Pedido("03/12/2022", danilo, cleanArchitecture, 2);
        Pedido pedido3 = new Pedido("03/12/2022", danilo, monitorDell, 1);

        string op = "";

        while (op != "3")
        {
            Console.Clear();
            
            Console.WriteLine("[1] Ver categorias \n[2] Ver pedidos \n[3] Encerrar");
            op = Console.ReadLine();

            switch(op) 
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine("{0} ({1} - {2}) \n{3} ({4} - {5}) \n{6} ({7} - {8})",
                        informatica.Nome, informatica.Id, informatica.Status, moveis.Nome, moveis.Id,
                        moveis.Status, livros.Nome, livros.Id, livros.Status);
                    string c = Console.ReadLine();

                    switch (c)
                    {
                        case "1":
                            Console.WriteLine("\nProdutos: \n\nCategoria: {0} - {1}, {2} R${3} \nQuantidade em estoque: {4} \nImposto R${5}",
                                notebookSamsung.Categoria, notebookSamsung.Nome, notebookSamsung.Descricao,
                                notebookSamsung.Preco, notebookSamsung.Estoque, notebookSamsung.CalculaImposto());
                            Console.WriteLine("\nCategoria: {0} - {1}, {2} R${3} \nQuantidade em estoque: {4} \nImposto R${5}",
                                monitorDell.Categoria, monitorDell.Nome, monitorDell.Descricao,
                                monitorDell.Preco, monitorDell.Estoque, monitorDell.CalculaImposto());
                            Console.Read();
                            break;

                        case "2":
                            Console.WriteLine("\nINATIVA");
                            Console.Read();
                            break;

                        case "3":
                            Console.WriteLine("\nProdutos: \n\nCategoria: {0} - {1}, {2} R${3} \nQuantidade em estoque: {4} \nImposto R${5}",
                                cleanArchitecture.Categoria, cleanArchitecture.Nome, cleanArchitecture.Descricao,
                                cleanArchitecture.Preco, cleanArchitecture.Estoque, cleanArchitecture.CalculaImposto());
                            Console.Read();
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine("\n{0} - {1} Cliente: {2} \n{3} {4} unidades \nR${5} - Imposto: R${6}",
                        pedido1.Id, pedido1.Data, pedido1.Cliente.NomeCompleto(), pedido1.Produto.Nome,
                        pedido1.QuantidadeVendida, pedido1.CalculaValorTotal(), pedido1.CalculaTotalImposto());
                    Console.WriteLine("\n{0} - {1} Cliente: {2} \n{3} {4} unidades \nR${5} - Imposto: R${6}",
                        pedido2.Id, pedido2.Data, pedido2.Cliente.NomeCompleto(), pedido2.Produto.Nome,
                        pedido2.QuantidadeVendida, pedido2.CalculaValorTotal(), pedido2.CalculaTotalImposto());
                    Console.WriteLine("\n{0} - {1} Cliente: {2} \n{3} {4} unidades \nR${5} - Imposto: R${6}",
                        pedido3.Id, pedido3.Data, pedido3.Cliente.NomeCompleto(), pedido3.Produto.Nome,
                        pedido3.QuantidadeVendida, pedido3.CalculaValorTotal(), pedido3.CalculaTotalImposto());
                    Console.Read();
                    break;
            }
        }
    }
}
