using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Semana 2 - Imprimir a sequência de Fibonacci");


        //sequência de Fibonacci até o vigésimo elemento
        int a = 0, b = 1;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(a);
            int temp = a;
            a = b;
            b = temp + b;
        }


        //resolver o problema usando apenas duas variáveis
        int c = 1, d = 1;

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(c);
            d = c + d;
            c = d - c;
        }

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}