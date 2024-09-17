using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Semana 2 - Calcular média e aprovação da turma");



        List<double> notasAna = new List<double> { 6.8, 7.9, 6.1, 10, 5.4 };
        double mediaAna = notasAna.Average();

        List<double> notasBia = new List<double> { 6.8, 7.9, 6.1, 10, 5.4 };
        double mediaBia = notasBia.Average();

        List<double> notasCaio = new List<double> { 6.8, 7.9, 6.1, 10, 5.4 };
        double mediaCaio = notasCaio.Average();

        List<double> notasDani = new List<double> { 6.8, 7.9, 6.1, 10, 5.4 };
        double mediaDani = notasDani.Average();

        List<double> notasEli = new List<double> { 6.8, 7.9, 6.1, 10, 5.4 };
        double mediaEli = notasEli.Average();

        Console.WriteLine("A média de notas de Ana foi de " + mediaAna);
        Console.WriteLine("A média de notas de Bia foi de " + mediaBia);
        Console.WriteLine("A média de notas de Caio foi de " + mediaCaio);
        Console.WriteLine("A média de notas de Dani foi de " + mediaDani);
        Console.WriteLine("A média de notas de Eli foi de " + mediaEli);

        if (mediaAna > 7)
        {
            Console.WriteLine("Ana foi aprovada!");
        }

        if (mediaBia > 7)
        {
            Console.WriteLine("Bia foi aprovada!");
        }

        if (mediaCaio > 7)
        {
            Console.WriteLine("Caio foi aprovado!");
        }

        if (mediaDani > 7)
        {
            Console.WriteLine("Dani foi aprovado!");
        }

        if (mediaEli > 7)
        {
            Console.WriteLine("Eli foi aprovado!");
            {


                Console.WriteLine("Tecle enter para fechar ...");
                Console.ReadLine();
            }
        }
    }
}