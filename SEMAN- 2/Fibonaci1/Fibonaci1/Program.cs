﻿using System;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 1;
            int n2 = 0;
            int soma = 0;

            for (var i = 1; i <= 19; i++)
            {
                soma = n1 + n2;
                n2 = n1;
                n1 = soma;
                Console.WriteLine($"A sequência é: {soma}");
            }
            Console.ReadKey();
        }
    }
}