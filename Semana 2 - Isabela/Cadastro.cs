using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com o seu nome");
        string nomeDoCliente = Console.ReadLine();
        Console.WriteLine("Entre com o seu email");
        string email = Console.ReadLine();
        Console.WriteLine($"Olá, {nomeDoCliente} !Usuário {email} cadastrado!");
    }
    Console.WriteLine("\n Aperte enter para encerrar.");
    Console.ReadLine();

}
