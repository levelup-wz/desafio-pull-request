using System;
class Program
{
    static void Main(string[] args)
    {

        int soma = 0;
        int i = 0;
        for (i = 0; i <= 100; i++)
        {
            soma = soma + i;
        }

        Console.WriteLine($"A soma de 1 até 100 é: {soma}. ");

        Console.WriteLine("\n Aperte enter para encerrar.");
        Console.ReadLine();

    }
}
