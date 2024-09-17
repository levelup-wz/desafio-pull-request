using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Semana 2 - Imprimir os números ÍMPARES de 1 a 100");

        for (int i = 1; i <= 100; i++)
        {
            int j = 1;
            while (j <= i)
            {
                if (i % 2 != 0)
                {
                    Console.Write(i + " ");
                }
                j++;
            }
            Console.WriteLine();
        }



        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}