using System;

namespace ConsoleApp
{
    class Programa
    {
        static void Main(string[] args)
        {
            //Leitura dos valores de a, b e c
            int a = 12, b = 3, c = -9;

            //DICA - Converter uma string para int com Convert.ToInt32(VALOR_PARA_CONVERSÃO)
            
            //Console.WriteLine("Informe o valor de a:");
            //int a = Convert.ToInt32(Console.ReadLine());


            //Cálculo das raízes
            double delta = Math.Pow(b, 2) - 4 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            //Exibição dos resultados
            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");


            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}