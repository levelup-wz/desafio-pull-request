using System;
class Programa
{
    static void Main(string[] args)
    {
        double imc;

        Console.Write(" Insira o seu peso atual: ");
        double peso = Convert.ToDouble(Console.ReadLine());
        Console.Write("Insira a sua altura: ");
        double altura = Convert.ToDouble(Console.ReadLine());

        imc = peso / Math.Pow(altura,2);

        Console.WriteLine("Seu IMC é : " + imc);

        if (imc < 17)
        {
            Console.WriteLine("Muito abaixo do peso.");
        }
        else if (imc >= 17 && imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso.");

        }
        else if (imc >= 18.5 && imc < 25)
        {
            Console.WriteLine("Peso ideal.");
        }
        else if (imc >= 25 && imc < 30)
        {
            Console.WriteLine("Sobrepeso.");
        }
        else if (imc >= 30 && imc < 35)
        {
            Console.WriteLine("Obesidade I.");
        }
        else if (imc >= 35 && imc < 40)
        {
            Console.WriteLine("Obesidade II.");
        }
        else
        {
            Console.WriteLine("Obesidade mórbida!");
        }
        Console.WriteLine("\n Aperte enter para encerrar.");
        Console.ReadLine();
    }
}