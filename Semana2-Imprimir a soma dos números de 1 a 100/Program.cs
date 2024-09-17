using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Semana 2 - Imprimir a soma dos números de 1 a 100");

        int soma = 0;

        // Laço for
        for (int i = 1; i <= 100; i++)
        {
            soma += i;
        }

        // Laço while
        int j = 1;
        while (j <= 100)
        {
            soma += j;
            j++;
        }

        if (soma == 5050)
        {
            Console.WriteLine("A soma dos números de 1 a 100 é igual a 5050.");
        }
        else
        {
            Console.WriteLine("A soma dos números de 1 a 100 não é igual a 5050.");
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}