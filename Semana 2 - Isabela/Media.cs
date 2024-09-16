using System;
class Program
{
    static void Main(string[] args)
    {
        double[] notas = { 6.8, 7.9, 6.1, 10, 5.4 };

        double soma = 0;
        int i = 0;
        for (i = 0; i <= 4; i++)
        {
            soma += notas[i];
        }

        double VALOR_DA_MEDIA = soma / 5;

        Console.WriteLine($"A média da turma foi de: {VALOR_DA_MEDIA:0.00}. ");
        // Estabelecendo o resultado em duas casas decimais

        if (VALOR_DA_MEDIA > 7)
        {
            Console.WriteLine("Turma aprovada!");
        }

        Console.WriteLine("\n Aperte enter para encerrar.");
        Console.ReadLine();
    }
}
