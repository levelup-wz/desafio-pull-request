using System;
class Program
{
    static void Main(string[] args)
    {
        int n1 = 0;
        int n2 = 1;

        for (int i = 0; i <= 20; i++)
        {
            Console.Write(n1 + ", ");

            n2 += n1;
            n1 = n2 - n1;
        }

        Console.WriteLine("\n Aperte enter para encerrar ...");
        Console.ReadLine();
    }
}