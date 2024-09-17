using System;

namespace ConsoleApp
{
    class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o e-mail do cliente:");
            string email = Console.ReadLine();

            Console.WriteLine($"Olá, {nome}! Usuário {email} cadastrado!");



            Console.WriteLine("Tecle enter para fechar ...");
            Console.ReadLine();
        }
    }
}