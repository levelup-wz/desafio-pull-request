using System;
class Programa
{
    static void Main(string[] args)
    {
        int a = 12, b = 3, c = -9;
        double x1, x2, delta;

        delta = Math.Pow(b, 2.0) - 4 * a * c;

        x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
        x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

        Console.WriteLine("As duas raízes são: x1= " + x1 + ", x2= " + x2);

        Console.WriteLine("\n Aperte enter para encerrar.");
        Console.ReadLine();
    }
}