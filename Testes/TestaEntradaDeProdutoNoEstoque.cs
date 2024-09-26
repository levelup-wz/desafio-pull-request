/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaEntradaDeProdutosNoEstoque
    {
        static ProdutoIsento vacina = new ProdutoIsento("Vacina", "Vacinas variadas",250.00, 500, "Saúde");
        static ProdutoIsento livro = new ProdutoIsento(" Use a Cabeça: Java","Livro sobre Java", 112.90, 5, "Livros");
        static Produto notebook = new Produto("Macbook Pro","Notebook Apple", 20000.00, 15, "Informática");

        static Estoque estoque = new Estoque();

        public static void Main()
        {
            estoque.RegistraEntrada(vacina);
            estoque.RegistraEntrada(livro);
            estoque.RegistraEntrada(notebook);
            // Registrando as entradas no estoque.

            Console.WriteLine("-------Dados do Estoque-------");
            Console.WriteLine(
               $"capacidade: {Estoque.Capacidade}\n" +
               $"ocupação: {Estoque.Ocupacao}\n" +
               $"montante (r$) : {Estoque.Montante:c}\n");
            // OBS.: Se atentar ao retirar comentários, porque todas as letras maiúsculas passam para minúsculas. 

            Produto bala = new Produto("Bala 7 Belo", "Bala de Framboesa",0.1, 5000, "Alimentos");

            try
            {
                estoque.RegistraEntrada(bala);
            }
            catch (LimiteDeEstoqueExcedidoException e)
            {
                Console.WriteLine($"ERRO: {e.Message}");
                throw;
            }

        }
    }
}
*/
