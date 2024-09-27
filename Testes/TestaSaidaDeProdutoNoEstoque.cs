using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comex
{
    public class TestaSaidaDeProdutoNoEstoque
    {
        public static void Main()
        {
            ProdutoIsento vacina = new ProdutoIsento("Vacina", "Vacinas variadas",250.00, 500,"Saúde");

            Estoque estoque = new Estoque();

            estoque.RegistraEntrada(vacina);

            Console.WriteLine("-------REGISTRO DE ENTRADA NO ESTOQUE-------");
            Console.WriteLine(
                $"Capacidade: {Estoque.Capacidade}\n" +
                $"Ocupação: {Estoque.Ocupacao}\n" +
                $"Montante: {Estoque.Montante:C}\n"
            );

            estoque.RegistraSaida(vacina);

            Console.WriteLine("-------REGISTRO DE SAÍDA DO ESTOQUE-------");
            Console.WriteLine(
                $"Capacidade: {Estoque.Capacidade}\n" +
                $"Ocupação: {Estoque.Ocupacao}\n" +
                $"Montante: {Estoque.Montante:C}\n"
            );
        }
    }
}
