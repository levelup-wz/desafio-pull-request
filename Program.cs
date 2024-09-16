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
        Categoria moveis = new Categoria("MÓVEIS", "ATIVA");
        Categoria livros = new Categoria("LIVROS", "ATIVA");

        // declaração dos produtos
        Produto notebook = new Produto("Notebook Samsung", "O melhor da marca!",
            3523.00, 1, "Informática");
        Produto cleanA = new Produto("Clean Architecture", "O melhor da marca!",
            102.90, 2, "Livros");
        Produto monitor = new Produto("Monitor Dell", "O melhor da marca!",
            1889.00, 3, "Informática");

        Produto vacina = new ProdutoIsento("Vacina", "Vacinas para todas as doenças",
            250.00, 500, "Saúde");
        Produto livroJava = new ProdutoIsento("Use a Cabeça: Java", "Descomplicando Java",
            112.90, 5, "Livros");
        Produto macbookPro = new ProdutoIsento("Macbook pro", "O melhor da marca!",
            20000.00, 15, "Informática");

        // declaração do cliente
        Cliente danilo = new Cliente("Danilo", "Siervi", "12345678913", "32998145012", "Rua Legal",
            "D13", "Perto da prefeitura", "Centro", "Ouro Branco", "Minas Gerais");

        // declaração dos pedidos
        Pedido pedido1 = new Pedido("02/12/2022", danilo, notebook, 2);
        Pedido pedido2 = new Pedido("03/12/2022", danilo, cleanA, 2);
        Pedido pedido3 = new Pedido("03/12/2022", danilo, monitor, 1);
        Pedido pedido4 = new Pedido("09/12/2022", danilo, vacina, 200);

        // estoque
        Estoque estoque = new Estoque();
        estoque.RegistraEntrada(notebook);
        estoque.RegistraEntrada(cleanA);
        estoque.RegistraEntrada(monitor);
        estoque.RegistraEntrada(vacina);
        estoque.RegistraEntrada(livroJava);
        estoque.RegistraEntrada(macbookPro);

        string op = "";

        while (op != "6")
        {
            Console.Clear();
            
            Console.WriteLine("[1] Ver categorias \n[2] Ver pedidos \n[3] Conferir estoque \n[4] Teste entrada \n[5] Teste saída \n[6] Encerrar");
            op = Console.ReadLine();

            switch(op) 
            {
                case "1":
                    Console.Clear();

                    Console.WriteLine($"{informatica.Nome} ({informatica.Id} - {informatica.Status}) \n" +
                        $"{moveis.Nome} ({moveis.Id} - {moveis.Status}) \n{livros.Nome} ({livros.Id} - {livros.Status})");
                    string c = Console.ReadLine();

                    switch (c)
                    {
                        case "1":
                            Console.WriteLine($"\nProdutos: \n\nCategoria: {notebook.Categoria} \nId: {notebook.Id} - {notebook.Nome}, {notebook.Descricao} " +
                                $"R${notebook.Preco} \nQuantidade em estoque: {notebook.Estoque} \nImposto R${notebook.CalculaImposto()}");

                            Console.WriteLine($"\nCategoria: {monitor.Categoria} \nId: {monitor.Id} - {monitor.Nome}, {monitor.Descricao} R${monitor.Preco}" +
                                $"\nQuantidade em estoque: {monitor.Estoque} \nImposto R${monitor.CalculaImposto()}");

                            Console.WriteLine($"\nCategoria: {macbookPro.Categoria} \nId: {macbookPro.Id} - {macbookPro.Nome}, {macbookPro.Descricao} " +
                               $"R${macbookPro.Preco} \nQuantidade em estoque: {macbookPro.Estoque} \nImposto R${macbookPro.CalculaImposto()}");
                            Console.Read();
                            break;

                        case "2":
                            Console.WriteLine($"\nProdutos: \n\nCategoria: {vacina.Categoria} \nId: {vacina.Id} - {vacina.Nome}, {vacina.Descricao} " +
                               $"R${vacina.Preco} \nQuantidade em estoque: {vacina.Estoque} \nImposto R${vacina.CalculaImposto()}");
                            Console.Read();
                            break;

                        case "3":
                            Console.WriteLine($"\nProdutos: \n\nCategoria: {cleanA.Categoria} \nId: {cleanA.Id} - {cleanA.Nome}, {cleanA.Descricao} R${cleanA.Preco}" +
                                $"\nQuantidade em estoque: {cleanA.Estoque} \nImposto R${cleanA.CalculaImposto()}");

                            Console.WriteLine($"\nCategoria: {livroJava.Categoria} \nId: {livroJava.Id} - {livroJava.Nome}, {livroJava.Descricao} " +
                               $"R${livroJava.Preco} \nQuantidade em estoque: {livroJava.Estoque} \nImposto R${livroJava.CalculaImposto()}");
                            Console.Read();
                            break;
                    }
                    break;

                case "2":
                    Console.WriteLine($"\n{pedido1.Id} - {pedido1.Data} Cliente: {pedido1.Cliente.NomeCompleto()} \n{pedido1.Produto.Nome} " +
                        $"{pedido1.QuantidadeVendida} unidades \nR${pedido1.CalculaValorTotal()} - Imposto: R${pedido1.CalculaTotalImposto()}");
                    Console.WriteLine($"\n{pedido2.Id} - {pedido2.Data} Cliente: {pedido2.Cliente.NomeCompleto()} \n{pedido2.Produto.Nome} " +
                        $"{pedido2.QuantidadeVendida} unidades \nR${pedido2.CalculaValorTotal()} - Imposto: R${pedido2.CalculaTotalImposto()}");
                    Console.WriteLine($"\n{pedido3.Id} - {pedido3.Data} Cliente: {pedido3.Cliente.NomeCompleto()} \n{pedido3.Produto.Nome} " +
                        $"{pedido3.QuantidadeVendida} unidades \nR${pedido3.CalculaValorTotal()} - Imposto: R${pedido3.CalculaTotalImposto()}");
                    Console.WriteLine($"\n{pedido4.Id} - {pedido4.Data} Cliente: {pedido4.Cliente.NomeCompleto()} \n{pedido4.Produto.Nome} " +
                        $"{pedido4.QuantidadeVendida} unidades \nR${pedido4.CalculaValorTotal()} - Imposto: R${pedido4.CalculaTotalImposto()}");
                    Console.Read();
                    break;

                case "3":
                    Console.WriteLine($"\nCapacidade: {estoque.Capacidade} \nOcupação: {estoque.Ocupacao} \nMontante: {estoque.Montante}");
                    Console.Read();
                    break;

                case "4":
                    Estoque testeEstoque1 = new Estoque();

                    testeEstoque1.RegistraEntrada(vacina);
                    testeEstoque1.RegistraEntrada(livroJava);
                    testeEstoque1.RegistraEntrada(macbookPro);

                    Console.WriteLine($"\nCapacidade: {testeEstoque1.Capacidade} \nOcupação: {testeEstoque1.Ocupacao} \nMontante: {testeEstoque1.Montante}");
                    Console.Read();
                    break;

                case "5":
                    Estoque testeEstoque2 = new Estoque();

                    testeEstoque2.RegistraEntrada(vacina);
                    Console.WriteLine($"\nEntrada: \nCapacidade: {testeEstoque2.Capacidade} \nOcupação: {testeEstoque2.Ocupacao} \nMontante: {testeEstoque2.Montante}");

                    testeEstoque2.RegistraSaida(vacina);
                    Console.WriteLine($"\nSaída: \nCapacidade: {testeEstoque2.Capacidade} \nOcupação: {testeEstoque2.Ocupacao} \nMontante: {testeEstoque2.Montante}");
                    Console.Read();
                    break;
            }
        }
    }
}
