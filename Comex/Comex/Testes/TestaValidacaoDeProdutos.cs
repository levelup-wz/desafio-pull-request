/*using Comex.Produtos;
using System;

namespace Comex.Testes
{
    public class TestaValidacaoDeProdutos
    {
        Console.WriteLine("Criando Produto válido:");
        try
        {
            Produto produto1 = new Produto("produto", "é um produto", 1.44, 20, moveis);
            Console.WriteLine("Produto válido!");
        }
        catch (ArgumentException ex)
        {
             Console.WriteLine($"Produto inválido! \nErro do tipo: {ex.Message}");
        }

        Console.WriteLine("\nCriando Produto com preço inválido:");
        try
        {
            Produto produto1 = new Produto("produto", "é um produto", 0, 20, moveis);
            Console.WriteLine("Produto válido!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Produto inválido! \nErro do tipo: {ex.Message}");
        }
        
        Console.WriteLine("\nCriando Produto Isento com estoque inválido:");
        try
        {
            Produto produto1 = new ProdutoIsento("produto", "é um produto", 1.44, -10, moveis);
            Console.WriteLine("Produto válido!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Produto inválido! \nErro do tipo: {ex.Message}");
        }

        Console.WriteLine("\nCriando Produto Isento com categoria nula:");
        try
        {
            Produto produto1 = new ProdutoIsento("produto", "é um produto", 1.44, 20, categoria: null);
            Console.WriteLine("Produto válido!");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Produto inválido! \nErro do tipo: {ex.Message}");
        }
    }
}
*/