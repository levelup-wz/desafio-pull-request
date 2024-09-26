/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public static class TestaProdutoIsento
    {
        static ProdutoIsento vacina = new ProdutoIsento("Vacina","Vacinas variadas", 250.00, 1000, "Saúde");
        static ProdutoIsento livro = new ProdutoIsento(" Use a Cabeça: Java","Livro sobre Java", 112.90, 5, "Livros");
        static Produto notebook = new Produto("Macbook Pro", "Notebook Apple", 20000.00, 11, "Informática");

        public static void Main()
        {
            Console.WriteLine("-------Dados do produto-------");
            Console.WriteLine(
              $"Id: {vacina.Id}\n" +
              $"Nome: {vacina.Nome}\n" +
              $"Categoria: {vacina.Categoria}\n" +
              $"Preço unitário: {vacina.Preco:C}\n" +
              $"Imposto por unidade: {vacina.CalculaImposto():C}\n" +
              $"Quantidade em estoque: {vacina.QuantidadeEmEstoque}\n"
              );
            // :C currency -> Valores monetários com duas casas decimais 
            // Poderia fazer um método em Produto e ProdutoIsento para retornar as infos relevantes do produto

            Console.WriteLine("-------Dados do produto-------");
            Console.WriteLine(
              $"Id: {livro.Id}\n" +
              $"Nome: {livro.Nome}\n" +
              $"Categoria: {livro.Categoria}\n" +
              $"Preço unitário: {livro.Preco:C}\n" +
              $"Imposto por unidade: {livro.CalculaImposto():C}\n" +
              $"Quantidade em estoque: {livro.QuantidadeEmEstoque}\n"
              );

            Console.WriteLine("-------Dados do produto-------");
            Console.WriteLine(
              $"Id: {notebook.Id}\n" +
              $"Nome: {notebook.Nome}\n" +
              $"Categoria: {notebook.Categoria}\n" +
              $"Preço unitário: {notebook.Preco:C}\n" +
              $"Imposto por unidade: {notebook.CalculaImposto():C}\n" +
              $"Quantidade em estoque: {notebook.QuantidadeEmEstoque}\n"
              );
        }
    }
}*/
